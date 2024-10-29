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
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            inputPassword.Text = "digite sua senha";
            inputPassword.ForeColor = Color.Gray;
        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPassword_Enter(object sender, EventArgs e)
        {
            if (inputPassword.Text == "digite sua senha")
            {
                inputPassword.Text = "";
                inputPassword.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void inputPassword_Leave(object sender, EventArgs e)
        {
            if (inputPassword.Text == "")
            {
                inputPassword.Text = "digite sua senha";
                inputPassword.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void inputCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBoxSeeOrHidden_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxSeeOrHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeeOrHidden.Checked == true)
            {
                inputPassword.PasswordChar = '*';
                inputPassword.StateCommon.Content.Color1 = Color.Black;
                
            }
            else { 
            inputPassword.PasswordChar = '\0';
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            RegisterWindow nextForm = new RegisterWindow();
            this.Hide();
            nextForm.Show();
        }
    }
}
