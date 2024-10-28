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
    public partial class PixForm : KryptonForm
    {
        public PixForm()
        {
            InitializeComponent();
        }

        private void PixForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PixType_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (PixType.Text)
            {
                case "email":
                    inputKey.Text = "digite o email";
                    break;

                case "telefone":
                    inputKey.Text = "digite o telefone";
                    break;

                case "chave aleatória":
                    inputKey.Text = "digite a chave pix aleatória";
                    break;

                default:
                    inputKey.Text = "digite o número de CPF";
                    break;
            }
        }

        private void inputKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
