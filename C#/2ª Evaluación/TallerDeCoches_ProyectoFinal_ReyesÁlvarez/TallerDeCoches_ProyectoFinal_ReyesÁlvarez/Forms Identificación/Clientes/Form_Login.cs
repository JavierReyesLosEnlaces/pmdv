﻿

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_crear_cuenta_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD:C#/2ª Evaluación/TallerDeCoches_ProyectoFinal_ReyesÁlvarez/TallerDeCoches_ProyectoFinal_ReyesÁlvarez/Forms Identificación/Clientes/Form_Login.cs
            Form_SignupCliente fs = new Form_SignupCliente();
=======
            Form_SignUpCliente fs = new Form_SignUpCliente();
>>>>>>> fbe046c99b1650432a6ea5cad4cc497aa8e8681d:C#/2ª Evaluación/TallerDeCoches_ProyectoFinal_ReyesÁlvarez/TallerDeCoches_ProyectoFinal_ReyesÁlvarez/Form_Login.cs
            fs.Show();
            this.Hide();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (tb_usuario.Text.Length < 3 || tb_contraseña.Text.Length < 5)
            {
                MessageBox.Show("Username or password no válido, muy corto");

            }
            else
            {
                // Creacion del directorio que contendrá el fichero con las claves cifradas
                string dir = tb_usuario.Text;
                if (!Directory.Exists("data\\" + dir))
                {
                    MessageBox.Show("Usuario no registrado");
                }
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpss = sr.ReadLine();
                    sr.Close();

                    string decusr = AesCryp.Decrypt(encusr);
                    string decpss = AesCryp.Decrypt(encpss);

                    if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                    {
                        MessageBox.Show("Bienvenido");
                    }
                    else
                    {
                        MessageBox.Show("Error en el password");
                    }
                }

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
