using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace orial_bank
{
    public partial class Home : KryptonForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPIX_Click(object sender, EventArgs e)
        {
            PixForm formPix = new PixForm();
            formPix.Show();
        }

        private void checkBoxSeeOrHidden_Click(object sender, EventArgs e)
        {

        }

        private void accountValue_Click(object sender, EventArgs e)
        {

        }

       
        private string originalAccountValue;

        private void checkBoxSeeOrHidden_CheckedChanged(object sender, EventArgs e)
        {
            
            if (originalAccountValue == null)
            {
                originalAccountValue = accountValue.Text;
            }

           
            if (checkBoxSeeOrHidden.Checked)
            {
                
                accountValue.Text = new string('*', originalAccountValue.Length);
            }
            else
            {
               
                accountValue.Text = originalAccountValue;
            }
        }

    }
}
