using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Resolver()
        {
            if (TxtIngresa.Text!="")
            {
                double dato = Convert.ToDouble(TxtIngresa.Text);
                int list = ListIngresa.SelectedIndex;
                switch (list)
                {
                    case 0:
                        TxtSalida1.Text = dato.ToString();
                        TxtSalida2.Text = (dato * 1.1628).ToString();
                        TxtSalida3.Text = (dato * 3.97).ToString();
                        TxtSalida4.Text = (dato / 3000).ToString();
                        break;
                    case 1:
                        TxtSalida1.Text = (dato * 0.86).ToString();
                        TxtSalida2.Text = dato.ToString();
                        TxtSalida3.Text = (dato * 3.412141633).ToString();
                        TxtSalida4.Text = (dato * 0.000284345).ToString();
                        break;
                    case 2:
                        TxtSalida1.Text = (dato*0.25).ToString();
                        TxtSalida2.Text = (dato*0.29307107).ToString();
                        TxtSalida3.Text = dato.ToString();
                        TxtSalida4.Text = (dato * 0.00008335).ToString();
                        break;
                    case 3:
                        TxtSalida1.Text = (dato * 3000).ToString();
                        TxtSalida2.Text = (dato * 3516.85).ToString();
                        TxtSalida3.Text = (dato * 12000).ToString();
                        TxtSalida4.Text = dato.ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NUMERO");
            }
        }
        private void BtnResultado_Click(object sender, EventArgs e)
        {
            Resolver();
        }
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtIngresa.Clear();
            ListIngresa.ClearSelected();
            TxtSalida1.Clear();
            TxtSalida2.Clear();
            TxtSalida3.Clear();
            TxtSalida4.Clear();
        }
    }
}
