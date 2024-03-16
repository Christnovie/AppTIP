using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATLAS_Models;

namespace TIP_ATLAS
{
    public partial class ViewHome : Form
    {
        private CanevasMain canevas;
        public ViewHome(CanevasMain canevas)
        {
            InitializeComponent();
            this.canevas = canevas;
           
        }

        private void dimMax_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            canevas.ShowMaxWeightView();
        }

        private void btnForce_form_Click(object sender, EventArgs e)
        {
            this.Close();
            canevas.ShowMaxForce();
        }

        private void btn_VerifForm_Click(object sender, EventArgs e)
        {
            this.Close();
            canevas.ShowVerification();
        }

        private void btn_lexique_Click(object sender, EventArgs e)
        {
            ImportClassData.OpenPDF("Lexique.pdf");
        }
        private void btn_tableau_Click(object sender, EventArgs e)
        {
            ImportClassData.OpenPDF("TABLEAUX_DE_DONNEES.pdf");

        }
        private void btn_modeEmp_Click(object sender, EventArgs e)
        {
            ImportClassData.OpenPDF("Mode_d'emploi.pdf");

        }

        private void ViewHome_Load(object sender, EventArgs e)
        {

        }

    }
}
