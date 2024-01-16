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
    public partial class CanevasMain : Form
    {
        private ViewHome homePage;
        public CanevasMain()
        {
            InitializeComponent();
            showAccueil();
        }
        public void showAccueil()
        {
            homePage = new ViewHome(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(homePage);
            homePage.Show();
        }
        
        public void ShowMaxWeightView()
        {
            ViewWeightMax screen = new ViewWeightMax(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(screen);
            screen.Show();
        }
        
    }
}
