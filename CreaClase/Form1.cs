using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CreaClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }

        private void btn_getbds_Click(object sender, EventArgs e)
        {
            bindComboDB();

        }



        void bindComboDB()
        {
            cb_dbs.DataSource = getBDsSQLServer();
            
        }
        List<string> getBDsSQLServer()
        {
            List<string> result = new List<string>();

            SqlConnection sqlconnection = new SqlConnection("Server="+Properties.Settings.Default.ServerBD+";User Id="+Properties.Settings.Default.UserBD+";Password = "+Properties.Settings.Default.PassBD+"; ");

            sqlconnection.Close();

            if (sqlconnection.State == ConnectionState.Closed)
            {
                try
                {
                    sqlconnection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al conectar", "Error al conectar a la BD sql server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                
            }

            SqlCommand command = new SqlCommand("SELECT name FROM master.sys.databases ORDER BY name ASC", sqlconnection);

            SqlDataReader reader= command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(reader["name"].ToString());
            }


            sqlconnection.Close();


            if (result.Count == 0)
            {
                MessageBox.Show("Sin registros", "No se obtuvo ningun registro de BD´s", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void cb_dbs_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> tablas = getTablesSQLServer();
            if (tablas != null)
            {
                tablas.Insert(0, "TODAS");
                cb_tablas.DataSource = tablas;

            }
           
           
            
        }

        List<string> getTablesSQLServer()
        {
            List<string> result = new List<string>();

            SqlConnection sqlconnection = new SqlConnection("Server=" + Properties.Settings.Default.ServerBD + ";User Id=" + Properties.Settings.Default.UserBD + ";Password = " + Properties.Settings.Default.PassBD + "; Database= "+cb_dbs.Text);

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
                SqlCommand command = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME ASC", sqlconnection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(reader["TABLE_NAME"].ToString());
                }
                sqlconnection.Close();
            }
       
            if (result.Count == 0)
            {
                MessageBox.Show("Sin registros", "No se obtuvo ningun registro de BD´s", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void btn_generaClase_Click(object sender, EventArgs e)
        {

            string strClass = "";

            if (cb_tablas.Text == "TODAS")
            {

                List<string> tablas = getTablesSQLServer();
                for (int i = 0; i < tablas.Count; i++)
                {
                    strClass += makeClassFromDataTable("C" + tablas[i], tablas[i].ToString()) + Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                strClass += makeClassFromDataTable("C" + cb_tablas.Text, cb_tablas.Text) + Environment.NewLine + Environment.NewLine;
            }

            Clipboard.SetText(strClass);

            MessageBox.Show("Copiado al portapapeles", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    public    DataTable getDataTableSqlServer(string tableName)
        {
            DataTable DT = new DataTable();

            SqlConnection sqlconnection = new SqlConnection("Server=" + Properties.Settings.Default.ServerBD + ";User Id=" + Properties.Settings.Default.UserBD + ";Password = " + Properties.Settings.Default.PassBD + "; Database= " + cb_dbs.Text);

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

        

        string makeClassFromDataTable(string className,string tableName)
        {

            DataTable dt = getDataTableSqlServer(tableName);
            string Clase="public class "+ className + Environment.NewLine;

            Clase += "{" + Environment.NewLine;
            for (int i=0; i < dt.Columns.Count; i++)
            {
                DataColumn column = dt.Columns[i];
                Clase +="public "+ getType(column.DataType.ToString().Substring(7, column.DataType.ToString().Count() - 7)) + " "+ column.ColumnName + " {get;set;}" + Environment.NewLine; ;
            }

            Clase += "}" + Environment.NewLine;


            return Clase;
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

        private void btn_webApi_Click(object sender, EventArgs e)
        {
            MakeFiles make = new MakeFiles();


            Clipboard.SetText(make.MakeInsertStatement("Areas"));
        }
    }
}
