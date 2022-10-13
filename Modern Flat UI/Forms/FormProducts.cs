using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Flat_UI.Forms
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.secondaryColor;
            label5.ForeColor = ThemeColor.primaryColor;
        }
  
    }
}
