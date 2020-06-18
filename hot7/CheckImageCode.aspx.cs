using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Web.Security;


 
    /// <summary>
    /// CheckImageCode 的摘要描述。
    /// </summary>
    public  partial class CheckImageCode : System.Web.UI.Page
    {
        private void Page_Load(object sender, System.EventArgs e)
        {
            // 在這裡放置使用者程式碼以初始化網頁
            //			this.CreateCheckCodeImage(GenerateCheckCode());
            this.CreateImage(GenerateCheckCode());
        }

        #region Web Form 設計工具產生的程式碼
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 此為 ASP.NET Web Form 設計工具所需的呼叫。
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// 此為設計工具支援所必須的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.Page_Load);
        }
        #endregion

        private string GenerateCheckCode()
        {
            int number;
            char code;
            string checkCode = String.Empty;

            System.Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                number = random.Next();

                if (number % 2 == 0)
                    code = (char)('0' + (char)(number % 10));
                else
                    code = (char)('A' + (char)(number % 26));

                checkCode += code.ToString();
            }

            //Response.Cookies.Add(new HttpCookie("CheckCode", checkCode));
            Session["CheckImageCode"] = checkCode;

            return checkCode;
        }


        private void CreateImage(string checkCode)
        {
            int iHeight = 100;
            int iWidth = 220;
            Random oRandom = new Random();

            int[] aBackgroundNoiseColor = new int[] { 150, 150, 150 };
            int[] aTextColor = new int[] { 0, 0, 0 };
            int[] aFontEmSizes = new int[] { 20, 25, 30, 35, 40 };

            string[] aFontNames = new string[]
			{
				"Comic Sans MS",
				"Arial",
				"Times New Roman",
				"Georgia",
				"Verdana",
				"Geneva"
			};
            FontStyle[] aFontStyles = new FontStyle[]
			{  
				FontStyle.Bold,
				FontStyle.Italic,
				FontStyle.Regular,
				FontStyle.Strikeout,
				FontStyle.Underline
			};
            HatchStyle[] aHatchStyles = new HatchStyle[]
			{
				HatchStyle.BackwardDiagonal, HatchStyle.Cross, 
				HatchStyle.DashedDownwardDiagonal, HatchStyle.DashedHorizontal,
				HatchStyle.DashedUpwardDiagonal, HatchStyle.DashedVertical, 
				HatchStyle.DiagonalBrick, HatchStyle.DiagonalCross,
				HatchStyle.Divot, HatchStyle.DottedDiamond, HatchStyle.DottedGrid, 
				HatchStyle.ForwardDiagonal, HatchStyle.Horizontal,
				HatchStyle.HorizontalBrick, HatchStyle.LargeCheckerBoard, 
				HatchStyle.LargeConfetti, HatchStyle.LargeGrid,
				HatchStyle.LightDownwardDiagonal, HatchStyle.LightHorizontal, 
				HatchStyle.LightUpwardDiagonal, HatchStyle.LightVertical,
				HatchStyle.Max, HatchStyle.Min, HatchStyle.NarrowHorizontal, 
				HatchStyle.NarrowVertical, HatchStyle.OutlinedDiamond,
				HatchStyle.Plaid, HatchStyle.Shingle, HatchStyle.SmallCheckerBoard, 
				HatchStyle.SmallConfetti, HatchStyle.SmallGrid,
				HatchStyle.SolidDiamond, HatchStyle.Sphere, HatchStyle.Trellis, 
				HatchStyle.Vertical, HatchStyle.Wave, HatchStyle.Weave,
				HatchStyle.WideDownwardDiagonal, HatchStyle.WideUpwardDiagonal, HatchStyle.ZigZag
			};

            //Get Captcha in Session
            string sCaptchaText = checkCode;

            //Creates an output Bitmap
            Bitmap oOutputBitmap = new Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb);
            Graphics oGraphics = Graphics.FromImage(oOutputBitmap);
            oGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            //Create a Drawing area
            RectangleF oRectangleF = new RectangleF(0, 0, iWidth, iHeight);


            System.Drawing.Brush oBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            //System.Drawing.Drawing2D.LinearGradientBrush oBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, iWidth, iHeight), Color.Blue, Color.DarkRed, 1.2f, true);

            //Draw background (Lighter colors RGB 100 to 255)
            oBrush = new HatchBrush(aHatchStyles[oRandom.Next
                (aHatchStyles.Length - 1)], Color.FromArgb((oRandom.Next(100, 255)),
                (oRandom.Next(100, 255)), (oRandom.Next(100, 255))), Color.White);
            oGraphics.FillRectangle(oBrush, oRectangleF);

            System.Drawing.Drawing2D.Matrix oMatrix = new System.Drawing.Drawing2D.Matrix();
            int i = 0;
            for (i = 0; i <= sCaptchaText.Length - 1; i++)
            {
                oMatrix.Reset();
                int iChars = sCaptchaText.Length;
                int x = iWidth / (iChars + 1) * i;
                int y = iHeight / 2;

                //Rotate text Random
                oMatrix.RotateAt(oRandom.Next(-40, 40), new PointF(x, y));
                oGraphics.Transform = oMatrix;

                //Draw the letters with Random Font Type, Size and Color
                oGraphics.DrawString
                    (
                    //Text
                    sCaptchaText.Substring(i, 1),
                    //Random Font Name and Style
                    new Font(aFontNames[oRandom.Next(aFontNames.Length - 1)],
                    aFontEmSizes[oRandom.Next(aFontEmSizes.Length - 1)],
                    aFontStyles[oRandom.Next(aFontStyles.Length - 1)]),
                    //Random Color (Darker colors RGB 0 to 100)
                    new SolidBrush(Color.FromArgb(oRandom.Next(0, 100),
                    oRandom.Next(0, 100), oRandom.Next(0, 100))),
                    x,
                    oRandom.Next(10, 40)
                    );
                oGraphics.ResetTransform();
            }

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            oOutputBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            Response.ClearContent();
            Response.ContentType = "image/Gif";
            Response.BinaryWrite(ms.ToArray());

            //			MemoryStream oMemoryStream = new MemoryStream();
            //			oOutputBitmap.Save(oMemoryStream, System.Drawing.Imaging.ImageFormat.Png);
            //			byte[] oBytes = oMemoryStream.GetBuffer();
            //
            //			oOutputBitmap.Dispose();
            //			oMemoryStream.Close();
            //
            //			context.Response.BinaryWrite(oBytes);
            //			context.Response.End();
        }
        //		public bool IsReusable
        //		{
        //			get
        //			{
        //				return false;
        //			}
        //		}



        private void CreateCheckCodeImage(string checkCode)
        {
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;

            //System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 12.5)), 22);
            //System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 20)), 40);
            System.Drawing.Bitmap image = new System.Drawing.Bitmap(140, 30);

            Graphics g = Graphics.FromImage(image);

            try
            {
                //生成隨機生成器
                Random random = new Random();

                //清空圖片背景色
                g.Clear(Color.White);

                //畫圖片的背景噪音線
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);

                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }

                Font font = new System.Drawing.Font("Arial", 22, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic));
                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);
                //g.DrawString(checkCode, font, brush, 2, 2);
                g.DrawString(checkCode, font, brush, 2, 2);

                //畫圖片的前景噪音點
                for (int i = 0; i < 500; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);

                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                //畫圖片的邊框線
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                Response.ClearContent();
                Response.ContentType = "image/Gif";
                Response.BinaryWrite(ms.ToArray());
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }





        }
    }
 