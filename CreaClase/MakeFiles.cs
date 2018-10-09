using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaClase
{
    class MakeFiles
    {

      public  string MakeInsertStatement(string tableName)
        {
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
            result += " // GET: api/"+ tableName + Environment.NewLine;
            result += "public List<C"+tableName+"> Get()" + tableName + Environment.NewLine;
            result += "{" + Environment.NewLine;

            result += "SqlConnection Conexion = new SqlConnection(connectionString);"+ Environment.NewLine;
            result += "List<C"+tableName+"> Resultado = new List<C"+ tableName + ">();" + Environment.NewLine;
            result += "SqlCommand cmd = new SqlCommand(\""+ tableName + "Select\", Conexion);" + Environment.NewLine;
            result += "cmd.CommandType = CommandType.StoredProcedure;" + Environment.NewLine;
            result += "//cmd.Parameters.AddWithValue(\"@idProd\", idProd);" + Environment.NewLine;
            result += "Conexion.Close();" + Environment.NewLine;
            result += "Conexion.Open();" + Environment.NewLine;
            result += "SqlDataReader reader = cmd.ExecuteReader();"+ Environment.NewLine;
            result += "C"+ tableName + "Detalles Aux;"+ Environment.NewLine;
            result += "while (reader.Read())"+ Environment.NewLine;
            result += "{"+ Environment.NewLine;

            result += Environment.NewLine;
            result += Environment.NewLine;

            result += "Conexion.Close();";
            result += "Conexion.Open();";

            result += "}" + Environment.NewLine;


            //SqlConnection Conexion = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand("Inserta_Movimiento", Conexion);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Pid_producto", movimiento.id_producto);
            //cmd.Parameters.AddWithValue("@Pid_proveedor", movimiento.id_proveedor);
            //cmd.Parameters.AddWithValue("@Pid_usuario", movimiento.id_usuario);
            //cmd.Parameters.AddWithValue("@PMonto", movimiento.Monto);
            //cmd.Parameters.AddWithValue("@Pcantidad", movimiento.cantidad);
            //cmd.Parameters.AddWithValue("@Pid_vehiculo", movimiento.id_vehiculo);
            //cmd.Parameters.AddWithValue("@Pid_estatusMovimiento", movimiento.id_estatusMovimiento);
            //cmd.Parameters.AddWithValue("@Pid_tipoMovimiento", movimiento.id_tipoMovimiento);
            //cmd.Parameters.AddWithValue("@Pid_categoriaMovimiento", movimiento.id_categoriaMovimiento);

            ////  @Pconcepto varchar(150),@Pid_inventario int
            //cmd.Parameters.AddWithValue("@Pconcepto", movimiento.concepto);
            //cmd.Parameters.AddWithValue("@Pid_inventario", movimiento.id_inventario);

            //Conexion.Close();
            //try
            //{
            //    Conexion.Open();
            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        Conexion.Close();
            //        return true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Conexion.Close();
            //    return false;
            //}

            //Conexion.Close();
            //return false;



            result += " }" + Environment.NewLine;

            result += "}" + Environment.NewLine;
            return result;
        }



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

        //namespace ERP_Travel_WebForms.Controllers.Inventarios
        //    {
        //        public class DefaultController : ApiController
        //        {
        //            // GET: api/Default
        //            public IEnumerable<string> Get()
        //            {
        //                return new string[] { "value1", "value2" };
        //            }

        //            // GET: api/Default/5
        //            public string Get(int id)
        //            {
        //                return "value";
        //            }

        //            // POST: api/Default
        //            public void Post([FromBody]string value)
        //            {
        //            }

        //            // PUT: api/Default/5
        //            public void Put(int id, [FromBody]string value)
        //            {
        //            }

        //            // DELETE: api/Default/5
        //            public void Delete(int id)
        //            {
        //            }
        //        }
        //    }
    }
}
