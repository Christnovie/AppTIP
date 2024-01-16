using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIP_ATLAS
{
    public partial class ViewHome : Form
    {
        private Color btnDefaultcolor;
        private CanevasMain canevas;
        public ViewHome(CanevasMain canevas)
        {
            InitializeComponent();
            this.canevas = canevas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_Verifmode_MouseEnter(object sender, EventArgs e)
        {
            btnDefaultcolor = btn_Verifmode.BackColor;
            btn_Verifmode.BackColor = Color.LightCyan;
            btn_Verifmode.Focus();
        }

        private void btn_Verifmode_MouseLeave(object sender, EventArgs e)
        {
            btn_Verifmode.BackColor = Color.WhiteSmoke;
        }

        private void dimMax_btn_MouseEnter(object sender, EventArgs e)
        { 
            dimMax_btn.BackColor = Color.LightCyan;
            dimMax_btn.Focus();
        }

        private void dimMax_btn_MouseLeave(object sender, EventArgs e)
        {
            dimMax_btn.BackColor = Color.WhiteSmoke;
        }

        private void dimMax_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            canevas.ShowMaxWeightView();
        }
    }
}
