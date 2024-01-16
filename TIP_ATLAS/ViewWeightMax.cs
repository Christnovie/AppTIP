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
    public partial class ViewWeightMax : Form
    {
        private CanevasMain canevas;
        public ViewWeightMax(CanevasMain canevas)
        {
            InitializeComponent();
            this.canevas = canevas;
        }

        private void ViewWeightMax_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.LightCyan;
            btnBack.Focus();
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.WhiteSmoke;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            canevas.showAccueil();
        }
    }
}
