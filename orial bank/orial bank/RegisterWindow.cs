using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace orial_bank
{
    public partial class RegisterWindow : KryptonForm
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonMaskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputCreateCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputCreateCPF_Enter(object sender, EventArgs e)
        {
            if (inputCreateCPF.Text == "digite o seu CPF ou CNPJ" )
            {
                inputCreateCPF.Text = "";
                inputCreateCPF.ForeColor = Color.White;
            }
        }

        private void inputCreateCPF_Leave(object sender, EventArgs e)
        {
            if (inputCreateCPF.Text == "")
            {
                inputCreateCPF.Text = "digite o seu CPF ou CNPJ";
                inputCreateCPF.ForeColor = Color.White;
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();

            this.Close();

            firstForm.Show();
        }

        private void inputName_Enter(object sender, EventArgs e)
        {
            if (inputName.Text == "digite o seu nome")
            {
                inputName.Text = "";
                inputName.ForeColor = Color.White;
            }
        }

        private void inputName_Leave(object sender, EventArgs e)
        {
            if (inputName.Text == "")
            {
                inputName.Text = "digite o seu nome";
                inputName.ForeColor = Color.White;
            }
        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputEmail_Enter(object sender, EventArgs e)
        {
            if (inputEmail.Text == "digite o seu email")
            {
                inputEmail.Text = "";
                inputEmail.ForeColor = Color.White;
            }
        }

        private void inputEmail_Leave(object sender, EventArgs e)
        {
            if (inputEmail.Text == "")
            {
                inputEmail.Text = "digite o seu email";
                inputEmail.ForeColor = Color.White;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            RegisterWindowStep_2 NextForm = new RegisterWindowStep_2();
            this.Hide();
             NextForm.Show();
        }
    }
}
