using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDasnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nestorButtons1_Click(object sender, EventArgs e)
        {

        }

        private bool AlgoritmoContraseñaSegura(string password)
        {
            mayuscula.Checked = false; minuscula.Checked = false; numero.Checked = false; carespecial.Checked = false; minimo.Checked = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length >= 8)
                {
                    minimo.Checked = true;
                }
                if (Char.IsUpper(password, i))
                {
                    mayuscula.Checked = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula.Checked = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero.Checked = true;
                }
                else
                {
                    carespecial.Checked = true;
                }
            }
            if (mayuscula.Checked && minuscula.Checked && numero.Checked && carespecial.Checked && password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        private void nestorTxtBx2__TextChanged(object sender, EventArgs e)
        {
            if (AlgoritmoContraseñaSegura(nestorTxtBx2.Texts))
                nestorButtons1.Enabled = true;
            else nestorButtons1.Enabled = false;
        }
    }
}
