using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orial_bank
{
    public partial class RegisterWindowStep_2 : KryptonForm
    {
        public RegisterWindowStep_2()
        {
            InitializeComponent();
        }

        private void RegisterWindowStep_2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputPassWord_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {   
            Form1 firstForm = new Form1();

            this.Close();

            firstForm.Show();
        }

        private void inputPassWord_Enter(object sender, EventArgs e)
        {
            if(inputPassWord.Text == "digite a sua senha")
            {
                inputPassWord.Text = string.Empty;
                inputPassWord.ForeColor = Color.White;
            }
        }

        private void inputPassWord_Leave(object sender, EventArgs e)
        {
            if (inputPassWord.Text == "")
            {
                inputPassWord.Text = "digite a sua senha";
                inputPassWord.ForeColor = Color.White;
            }
        }

        private void inputConfirmPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputConfirmPassWord_Enter(object sender, EventArgs e)
        {
            if (inputConfirmPassWord.Text == "digite novamente a sua senha")
            {
                inputConfirmPassWord.Text = "";
                inputConfirmPassWord.ForeColor = Color.White;
            }
        }

        private void inputConfirmPassWord_Leave(object sender, EventArgs e)
        {
            if (inputConfirmPassWord.Text == "")
            {
                inputConfirmPassWord.Text = "digite novamente a sua senha";
                inputConfirmPassWord.ForeColor = Color.White;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            RegisterWindow previousForm = new RegisterWindow();
            this.Hide();
            previousForm.Show();

        }
    }
}
