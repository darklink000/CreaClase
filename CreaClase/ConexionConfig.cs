using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CreaClase
{
    public partial class ConexionConfig : UserControl
    {
        public ConexionConfig()
        {
            InitializeComponent();
        }

        private void ConexionConfig_Load(object sender, EventArgs e)
        {
            tb_host.Text = ConfigurationManager.AppSettings["ServerBD"].ToString();
            tb_usuario.Text = ConfigurationManager.AppSettings["UserBD"].ToString();
            tb_contraseña.Text = ConfigurationManager.AppSettings["PassBD"].ToString();
            
            selectMotor();

        }
        void selectMotor()
        {
            switch (ConfigurationManager.AppSettings["EngineBD"].ToString())
            {
                case "mysql":
                    rb_mysql.Checked = true;
                    break;
                case "sqlserver":
                    rb_sqlServer.Checked = true;
                    break;
                default:
                    break;
            }


        }

        void setMotor()
        {

            if (rb_mysql.Checked)
            {
                ConfigurationManager.AppSettings["EngineBD"]="mysql";
                return;
            }

            if (rb_sqlServer.Checked)
            {
                ConfigurationManager.AppSettings["EngineBD"]="sqlserver";
                return;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["ServerBD"] = tb_host.Text;
            ConfigurationManager.AppSettings["UserBD"]= tb_usuario.Text;
            ConfigurationManager.AppSettings["PassBD"]=tb_contraseña.Text;

            setMotor();

            MessageBox.Show("Datos guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
