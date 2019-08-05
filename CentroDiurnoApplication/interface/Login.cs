using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDiurnoApplication
{
    public partial class LoginInterface : Form
    {
        MainInterface mainInterface;


        public LoginInterface()
        {
            mainInterface = new MainInterface();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!InternetConnection.CheckForInternetConnection())
            {
                MessageBox.Show("Verifique su conexión a internet, e inténtelo de nuevo.", "Problema de red", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String username = this.textBox_userName.Text;
            String password = this.textBox_password.Text;

            if(username.Equals("admin") && password.Equals("admin"))
            {
                Console.WriteLine("Login correcto");
                this.Hide();
                var mainInterface = new MainInterface();
                mainInterface.Closed += (s, args) => this.Close();
                mainInterface.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados no corresponden a un usuario válido", "Información incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine("Login incorrecto");
            }

        }


    }
}
