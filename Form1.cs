using System;
using System.Windows.Forms;

namespace TrabalhoProgVisual
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = usuarioBox.Text;
            string senha = senhaBox.Text;

            if (usuario != "Mateus")
            {
                MessageBox.Show("Usuário Inválido", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (senha != "12345")
            {
                MessageBox.Show("Senha Inválida", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Se ambos usuário e senha estiverem corretos
                MessageBox.Show("Login Bem-Sucedido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (senhaBox.UseSystemPasswordChar)
            {
                senhaBox.UseSystemPasswordChar = false;
            }
            else
            {
                senhaBox.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toggleSenha_Click(object sender, EventArgs e)
        {
            if (senhaBox.UseSystemPasswordChar)
            {
                senhaBox.UseSystemPasswordChar = false;
                mostrarSenhaButton.Text = "Ocultar";
            }
            else
            {
                senhaBox.UseSystemPasswordChar = true;
                mostrarSenhaButton.Text = "Mostrar";

            }
        }
    }
}
