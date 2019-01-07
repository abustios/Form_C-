using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX_PROV_CONSULTACLASIF.Class
{
    class Consulta
    {
        //GetterSetter Properties
        //Acts as data carrier
        public string tipdocumento { get; set; }
        public string documento {get; set;}
        public string clasificacion { get; set;}

        static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        //Selecciona Data
        public DataSet Select()
            {
            SqlConnection con = new SqlConnection(conn);
            DataSet dt = new DataSet();
            try
            {
                string sql = "select * from bd_reg.dbo.PROY_CALIF WHERE COD_IBS=" + documento + " or documento="+ documento;
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();


            }
            return dt;
            
            }

        public int clasif(string cl)
        {
            if (cl == "0 - Normal")
                {
                return 0;
                }
            else if (cl == "1 - CPP")
                {
                return 1;
                }
            else if (cl == "2 - Deficiente")
                {
                return 2;
                }
            else if (cl == "3 - Dudoso")
                {
                return 3;
                }
            else if (cl == "4 - Perdida")
                {
                return 4;
                }
            else
                {
                return 5;
                } 


        }
    }
}
