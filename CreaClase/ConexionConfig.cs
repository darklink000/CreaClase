using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tb_host.Text = ConfigurationManager.AppSettings["MySetting"].ToString();
            tb_usuario.Text = ConfigurationSettings.AppSettings["UserBD"].ToString();
            tb_contraseña.Text = ConfigurationSettings.AppSettings["PassBD"].ToString();
            
            selectMotor();

        }
        void selectMotor()
        {
            switch (ConfigurationSettings.AppSettings["EngineBD"].ToString())
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
                ConfigurationSettings.AppSettings["EngineBD"] = "mysql";
                return;
            }

            if (rb_sqlServer.Checked)
            {
                ConfigurationSettings.AppSettings["EngineBD"] = "sqlserver";
                return;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ConfigurationSettings.AppSettings["ServerBD"] = tb_host.Text;
            ConfigurationSettings.AppSettings["UserBD"] = tb_usuario.Text;
            ConfigurationSettings.AppSettings["PassBD"] = tb_contraseña.Text;

            setMotor();

            MessageBox.Show("Datos guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
