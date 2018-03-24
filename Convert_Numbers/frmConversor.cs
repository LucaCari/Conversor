using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_Numbers
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }
        Convert_Numbers c = new Convert_Numbers();
		//Tela do Conversor

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cboType.Text.Trim() == "")
            {
                MessageBox.Show("Selecione o tipo de entrada no combo de opções: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cboType.Text == "Binário")
                {
                    c.binaryNumber = txtNumber.Text;
                    setValues();
                }
                else if (cboType.Text == "Decimal")
                {
                    c.setdecimalToBinary(Convert.ToInt32(txtNumber.Text));
                    setValues();
                }
                else if (cboType.Text == "Octal")
                {
                    c.setoctalToBinary(txtNumber.Text);
                    setValues();
                }
                else if (cboType.Text == "Hexadecimal")
                {
                    c.sethexToBinary(txtNumber.Text);
                    setValues();
                }
            }
        }
        private void setValues()
        {
            txtBin.Text = c.binaryNumber;
            txtDec.Text = c.binaryToDecimal();
            txtHex.Text = c.binaryToHex();
            txtOct.Text = c.binaryToOctal();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboType.Text != "Hexadecimal")
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
