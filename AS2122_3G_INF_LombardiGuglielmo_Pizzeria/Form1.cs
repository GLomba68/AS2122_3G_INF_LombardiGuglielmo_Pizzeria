using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_3G_INF_LombardiGuglielmo_Pizzeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTipo_OnClick(object sender, EventArgs e)
        {
            int margherita = 0;
            int verdure = 0;
            int quattrostagioni = 0;

            switch (cmbTipo.Text)
            {
                case "Margherita":
                    margherita = margherita + Convert.ToInt32(txtQuantità.Text);
                    break;

                case "Verdure":
                    verdure = verdure + Convert.ToInt32(txtQuantità.Text);
                    break;

                default:
                    quattrostagioni = quattrostagioni + Convert.ToInt32(txtQuantità.Text);
                    break;
            }
        }
    }
}
