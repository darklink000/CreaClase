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
            tb_host.Text = Properties.Settings.Default.ServerBD;
            tb_usuario.Text = Properties.Settings.Default.UserBD;
            tb_contraseña.Text = Properties.Settings.Default.PassBD;
            

            


            selectMotor();

        }
        void selectMotor()
        {
            switch (Properties.Settings.Default.EngineBD)
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
                Properties.Settings.Default.EngineBD = "mysql";
                return;
            }

            if (rb_sqlServer.Checked)
            {
                Properties.Settings.Default.EngineBD = "sqlserver";
                return;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerBD = tb_host.Text;
            Properties.Settings.Default.UserBD= tb_usuario.Text;
            Properties.Settings.Default.PassBD= tb_contraseña.Text;

            setMotor();

            MessageBox.Show("Datos guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
