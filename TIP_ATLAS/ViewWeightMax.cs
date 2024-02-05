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
    public partial class ViewWeightMax : Form
    {
        private CanevasMain canevas;
        private ImportClassData importClassData;
        private CompressionAxiale DataCalculator;
        public ViewWeightMax(CanevasMain canevas)
        {
            InitializeComponent();
            this.canevas = canevas;
            importClassData = new ImportClassData();
            DataCalculator = new CompressionAxiale();
            DownloadItem();
        }

        private void ViewWeightMax_Load(object sender, EventArgs e)
        {
            
        }

        //Back button event
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

        private void lsbTypebois_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void dUpDClassResistance_SelectedItemChanged(object sender, EventArgs e)
        {
            WoodClass result;
            result = ImportClassData.GetSoftwoodDataValueTarget(importClassData.Collection, dUpDResitanceClass.Text);
            DataCalculator.CurrentWood = result;
        }
        private void DownloadItem()
        {
            foreach(string wood in importClassData.Collection.CollectionWood.Keys)
            {
                dUpDResitanceClass.Items.Add(wood);
            }
            foreach (string wood in importClassData.Collection.KmodClass.Keys)
            {
                dUpDResisatnce.Items.Add(wood);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dUpDResisatnce_SelectedItemChanged(object sender, EventArgs e)
        {
            DataCalculator.KmodClass =  importClassData.Collection.KmodClass[dUpDResisatnce.Text];
            DataCalculator.CumulateChargClass = dUpDResisatnce.Text;
        }
        public void UpdateCalc()
        {

        }

        private void txt_Validate_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txt_Validate.Text)>=1.000000|| Convert.ToDouble(txt_Validate.Text) <= 0)
            {
                txt_Validation.Text = "Non";
            }else
            {
                txt_Validation.Text = "OK";
            }
        }
    }
}
