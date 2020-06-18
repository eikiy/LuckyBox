using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
/// <summary>
/// Form 的摘要描述
/// </summary>
public class Form
{
    #region Form
    public Form()
    {
        //
        // TODO: 在此加入建構函式的程式碼
        //
    }
    #endregion

    #region 表單物件;sValue:傳入值
    /// <summary>
    /// 
    /// </summary>
    /// <param name="oControl">表單物件;sValue:傳入值</param>
    /// <param name="sValue"></param>
    public void SetValue(object oControl, string sValue)
    {
        //object oObject;
        Label oLabel;
        TextBox oTextBox;
        DropDownList oDropDownList;
        RadioButtonList oRadioButtonList;
        switch (oControl.ToString())
        {
            case "System.Web.UI.WebControls.Label":
                oLabel = (System.Web.UI.WebControls.Label)oControl;
                oLabel.Text = sValue;
                break;
            case "System.Web.UI.WebControls.TextBox":
                oTextBox = (System.Web.UI.WebControls.TextBox)oControl;
                oTextBox.Text = sValue;
                break;
            case "System.Web.UI.WebControls.DropDownList":
                oDropDownList = (System.Web.UI.WebControls.DropDownList)oControl;
                for (int i = 0; i < oDropDownList.Items.Count; i++)
                {
                    if (oDropDownList.Items[i].Value.Trim() == sValue.Trim())
                    {
                        oDropDownList.SelectedIndex = i;
                        break;
                    }
                }
                break;
            case "System.Web.UI.WebControls.RadioButtonList":
                oRadioButtonList = (System.Web.UI.WebControls.RadioButtonList)oControl;
                for (int i = 0; i < oRadioButtonList.Items.Count; i++)
                {
                    if (oRadioButtonList.Items[i].Value.Trim() == sValue.Trim())
                    {
                        oRadioButtonList.SelectedIndex = i;
                        break;
                    }
                }
                break;
        }
    }
    #endregion

    #region 表單物件;sValue:傳入值;sCut:單一字元的分隔符號
    /// <summary>
    /// 
    /// </summary>
    /// <param name="oControl">表單物件;sValue:傳入值;sCut:單一字元的分隔符號</param>
    /// <param name="sValue"></param>
    /// <param name="sCut"></param>
    public void SetValue(object oControl, string sValue, string sCut)
    {
        ListBox oListBox;
        CheckBoxList oCheckBoxList;
        string[] asValue;
        switch (oControl.ToString())
        {
            case "System.Web.UI.WebControls.ListBox":
                oListBox = (System.Web.UI.WebControls.ListBox)oControl;
                asValue = sValue.Split(Convert.ToChar(sCut));
                for (int i = 0; i < oListBox.Items.Count; i++)
                {
                    for (int j = 0; j < asValue.Length; j++)
                    {
                        if (oListBox.Items[i].Value.Trim() == asValue[j].Trim())
                            oListBox.Items[i].Selected = true;
                    }
                }
                break;
            case "System.Web.UI.WebControls.CheckBoxList":
                oCheckBoxList = (System.Web.UI.WebControls.CheckBoxList)oControl;
                asValue = sValue.Split(Convert.ToChar(sCut));
                for (int i = 0; i < oCheckBoxList.Items.Count; i++)
                {
                    for (int j = 0; j < asValue.Length; j++)
                    {
                        if (oCheckBoxList.Items[i].Value.Trim() == asValue[j].Trim())
                            oCheckBoxList.Items[i].Selected = true;
                    }
                }
                break;
        }
    }
    #endregion

    public bool ErrorEmptyMsg(System.Web.UI.Page webForm, object oControl, string sMessage)
    {
        //object oObject;
        TextBox oTextBox;
        DropDownList oDropDownList;
        RadioButtonList oRadioButtonList;
        ListBox oListBox;
        bool bError = false;
        switch (oControl.ToString())
        {
            case "System.Web.UI.WebControls.TextBox":
                oTextBox = (System.Web.UI.WebControls.TextBox)oControl;
                if (oTextBox.Text == "")
                    bError = true;
                break;
            case "System.Web.UI.WebControls.DropDownList":
                oDropDownList = (System.Web.UI.WebControls.DropDownList)oControl;
                if (oDropDownList.SelectedIndex < 0)
                    bError = true;
                break;
            case "System.Web.UI.WebControls.RadioButtonList":
                oRadioButtonList = (System.Web.UI.WebControls.RadioButtonList)oControl;
                if (oRadioButtonList.SelectedIndex < 0)
                    bError = true;
                break;
            case "System.Web.UI.WebControls.ListBox":
                oListBox = (System.Web.UI.WebControls.ListBox)oControl;
                if (oListBox.SelectedIndex < 0)
                    bError = true;
                break;

        }

        if (bError)
            webForm.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sMessage + "');</script>");
        return bError;
    }

    public void MsgBox(System.Web.UI.Page webForm, string sMessage)
    {
        webForm.ClientScript.RegisterStartupScript(webForm.GetType(), "Error", "alert('" + sMessage + "');", true);

        //try
        //{
        //    //webForm.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sMessage + "');</script>");
        //}
        //catch
        //{
        //    webForm.ClientScript.RegisterClientScriptBlock(this.GetType(), Guid.NewGuid().ToString(), "<script>alert('" + sMessage + "');</script>");
        //}

    }

    //public void AjaxMsgBox(Control page, string msg)
    //{
    //    ScriptManager.RegisterStartupScript(page, page.GetType(), "", "alert('" + msg + "')", true);
    //}

}