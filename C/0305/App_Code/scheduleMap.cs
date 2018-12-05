using System.IO;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Data.SqlClient;
using System.Collections;
using System.Text;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class scheduleMap : System.Web.Services.WebService {

  [WebMethod]
  public ArrayList GetLocations(string _input)
  {

      string sql_schedule_map = "SELECT a.*, b.site_name, b.site_tel, b.site_address, b.b_hour, b.latitude, b.longitude FROM iutw_schedule_site a LEFT JOIN iutw_site b ON a.site_id = b.site_id WHERE a.schedule_date_id='" + _input + "' ORDER BY a.sorting";

      SqlDataReader sdr_map = ExecuteReader(sql_schedule_map);

      //string str_script = "<script>var locations = [";
      //string str_script = string.Empty;
      string str_script = string.Empty;
      ArrayList columns = new ArrayList(); 
      ArrayList rows = new ArrayList();
      

      while (sdr_map.Read())
      {
          columns.Clear();
          columns.Add(sdr_map["site_name"].ToString());
          columns.Add(sdr_map["latitude"].ToString());
          columns.Add(sdr_map["longitude"].ToString());
          rows.Add(columns.ToArray());

      }
      sdr_map.Close();

      return rows;
  }

  public SqlDataReader ExecuteReader(string strSQL)
  {
      string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStr_E_Root"].ConnectionString;
      SqlConnection rd_conn = new SqlConnection(connectionString);

      SqlDataReader myReader;

      using (SqlCommand cmd = new SqlCommand(strSQL, rd_conn))
      {

        
              rd_conn.Open();
              myReader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
              //SqlDataReader myReader = cmd.ExecuteReader();
              return myReader;

          

         


      }

      myReader.Dispose();
      myReader.Close();
      rd_conn.Close();


  }


  



}