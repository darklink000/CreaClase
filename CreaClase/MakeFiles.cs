using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreaClase
{
    class MakeFiles
    {

      public  string MakeInsertStatement(string tableName)
        {

            DataTable dt = getDataTableSqlServer(tableName);
            string result = "using System;"+Environment.NewLine;

            result += "using System.Collections.Generic;" + Environment.NewLine;
            result += "using System.Linq;" + Environment.NewLine;
            result += "using System.Data;" + Environment.NewLine;
            result += "using System.Data.SqlClient;" + Environment.NewLine;                    
            result += "using System.Net;" + Environment.NewLine;
            result += "using System.Web.Http;" + Environment.NewLine;
            result += Environment.NewLine;
            result += Environment.NewLine;


            result += "namespace *Replace With project name*.Controllers."+ tableName + Environment.NewLine;
            result += "{" + Environment.NewLine;            
            result += " public class "+ tableName + "Controller : ApiController " + Environment.NewLine;
            result += " {" + Environment.NewLine;
            result += "string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[\"*Webconfig or appconfigConnectionName*ConnectionString\"].ConnectionString;" + Environment.NewLine;
            result += " // GET: api/"+ tableName + Environment.NewLine;
            result += "public List<C"+tableName+"> Get()"  + Environment.NewLine;
            result += "{" + Environment.NewLine;

            result += "SqlConnection Conexion = new SqlConnection(connectionString);"+ Environment.NewLine;
            result += "List<C"+tableName+"> Resultado = new List<C"+ tableName + ">();" + Environment.NewLine;
            result += "SqlCommand cmd = new SqlCommand(\""+ tableName + "Select\", Conexion);" + Environment.NewLine;
            result += "cmd.CommandType = CommandType.StoredProcedure;" + Environment.NewLine;
            result += "//cmd.Parameters.AddWithValue(\"@idProd\", idProd);" + Environment.NewLine;
            result += "Conexion.Close();" + Environment.NewLine;
            result += "Conexion.Open();" + Environment.NewLine;
            result += "SqlDataReader reader = cmd.ExecuteReader();"+ Environment.NewLine;
            result += "C"+ tableName + " Aux;"+ Environment.NewLine;
            result += "while (reader.Read())"+ Environment.NewLine;
            result += "{"+ Environment.NewLine;
            result += "Aux = new C"+tableName+"();" + Environment.NewLine;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string dataType = getType(dt.Columns[i].DataType.ToString().Substring(7, dt.Columns[i].DataType.ToString().Count() - 7));
                string columnName = dt.Columns[i].ColumnName.ToString();

                if (dataType == "string")
                {
                    result += "Aux." + columnName + " = (reader[\"" + columnName + "\"].ToString());" + Environment.NewLine;
                }
                else
                {
                    result += "Aux." + columnName + " = " + dataType + ".Parse(reader[\"" + columnName + "\"].ToString());" + Environment.NewLine;
                   
                }
               
            }
            result += "Resultado.Add(Aux);" + Environment.NewLine;
            result += "}" + Environment.NewLine;

            result += Environment.NewLine;
            result += Environment.NewLine;

            result += "Conexion.Close();" + Environment.NewLine;
            result += "Conexion.Open();" + Environment.NewLine;
            result += "return Resultado;" + Environment.NewLine;
            result += "}" + Environment.NewLine;


            result += makeClassFromDataTable("C" + tableName, tableName);


            result += "       }" + Environment.NewLine;




            result += "}" + Environment.NewLine;
            return result;
        }



        string getType(string type)
        {
            string result = "";


            switch (type)
            {
                case "Int32":
                case "Int16":
                case "Numeric":
                case "Byte":
                    result = "int";
                    break;
                case "String":
                    {
                        result = "string";
                    }
                    break;
                case "DateTime":
                    {
                        result = "date";
                    }
                    break;
                case "Decimal":
                case "Double":
                case "Float":
                    {
                        result = "decimal";
                    }
                    break;
                default:
                    result = "string";
                    break;
            }



            return result;
        }

        string makeClassFromDataTable(string className, string tableName)
        {

            DataTable dt = getDataTableSqlServer(tableName);
            string Clase = "public class " + className + Environment.NewLine;

            Clase += "{" + Environment.NewLine;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                DataColumn column = dt.Columns[i];
                Clase += "public " + getType(column.DataType.ToString().Substring(7, column.DataType.ToString().Count() - 7)) + " " + column.ColumnName + " {get;set;}" + Environment.NewLine; ;
            }

            Clase += "}" + Environment.NewLine;


            return Clase;
        }

        public DataTable getDataTableSqlServer(string tableName)
        {
            DataTable DT = new DataTable();

            SqlConnection sqlconnection = new SqlConnection("Server=" + Properties.Settings.Default.ServerBD + ";User Id=" + Properties.Settings.Default.UserBD + ";Password = " + Properties.Settings.Default.PassBD + "; Database= TravelAndLive");

            sqlconnection.Close();

            if (sqlconnection.State == ConnectionState.Closed)
            {
                try
                {
                    sqlconnection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar" + ex.Message, "Error al conectar a la BD sql server ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;
                }

            }

            if (sqlconnection.State == ConnectionState.Open)
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 * FROM " + tableName, sqlconnection);
                adapter.Fill(ds);
                DT = ds.Tables[0];

                sqlconnection.Close();
            }


            return DT;
        }
    }


}
