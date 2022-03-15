using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_3G_INF_BacciocchiMichele_Pizzeria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void lstRiepilogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            int quantita = Convert.ToInt32(txtQuantita.Text);
            string tipoP = cmbPizza.Text;

            switch (tipoP)
            {
                case "Pizza margherita":
                    lstRiepilogo.Items.Add($"{tipoP} {quantita}");
                    lblnum1.Text = Convert.ToString(Convert.ToInt32(lblnum1.Text) + quantita);
                    break;

                case "Pizza con verdure":
                    lstRiepilogo.Items.Add($"{tipoP} {quantita}");
                    lblnum2.Text = Convert.ToString(Convert.ToInt32(lblnum2.Text) + quantita);
                    break;

                case "Pizza quattro stagioni":
                    lstRiepilogo.Items.Add($"{tipoP} {quantita}");
                    lblnum3.Text = Convert.ToString(Convert.ToInt32(lblnum3.Text) + quantita);
                    break;
                default:
                    MessageBox.Show("Scegliere una pizza dal menù");
                    break;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
