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

        private void dUpDResisatnce_SelectedItemChanged(object sender, EventArgs e)
        {
            DataCalculator.KmodClass =  importClassData.Collection.KmodClass[dUpDResisatnce.Text];
            DataCalculator.CumulateChargClass = dUpDResisatnce.Text;
            dUpDKmod.Enabled = true;
        }
        public void UpdateCalc()
        {
            txt_Aire.Text = DataCalculator.CalAire.ToString();
            txt_oc0d.Text = DataCalculator.ContrainteAxialCal.ToString();
            txt_Verif.Text = DataCalculator.VerifResAxialCompress.ToString();
            txt_fc0d.Text = DataCalculator.ResitanceAxeCompress.ToString();
            txt_ly.Text = DataCalculator.CalInercyMomentY.ToString();
            txt_lz.Text = DataCalculator.CalInercyMomentZ.ToString();
            txt_ky.Text = DataCalculator.CoefficentKy.ToString();
            txt_Yy.Text = DataCalculator.CalMecanicElancementY.ToString();
            txt_Yz.Text = DataCalculator.CalMecanicElancementZ.ToString();
            txt_kz.Text = DataCalculator.CoefficentKz.ToString();
            txt_Arely.Text = DataCalculator.CalRelatifElancementY.ToString();
            txt_Arelz.Text = DataCalculator.CalRelatifElancementZ.ToString();
            txt_kcy.Text = DataCalculator.CoefficentFlambY.ToString();
            txt_kcz.Text = DataCalculator.CoefficentFlambZ.ToString();
            txt_kc.Text = DataCalculator.CoefficentFlamb.ToString();
            txt_Rup_Force.Text = DataCalculator.CalcMaxRuputureForce.ToString();
            txt_AireMax.Text = DataCalculator.CalcMinAire.ToString();
            txt_Aire_Rup.Text = DataCalculator.CalcSiseH_B.ToString();
        }
        private void txt_Validate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Validate_Click(object sender, EventArgs e)
        {
            UpdateCalc();          
        }

        private void txtLfz_Validating(object sender, CancelEventArgs e)
        {
            NumercValidation(txtLfz.Text);
        }
        private void NumercValidation(string toValidate)
        {
            int numberEntered;

            if (int.TryParse(toValidate, out numberEntered))
            {
                if (numberEntered < 1)
                {
                    MessageBox.Show("Les valeurs peuvent pas être négatives ");
                    toValidate = 5.ToString();
                }
            }
            else
            {
                MessageBox.Show("You need to enter an integer");
                toValidate = 5.ToString();
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtB.Text.Length != 0)
                DataCalculator.Stransb = Convert.ToDouble(txtB.Text);
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {
            if(txtH.Text.Length !=0)
                DataCalculator.Stransh = Convert.ToDouble(txtH.Text);
        }

        private void txtCoef_TextChanged(object sender, EventArgs e)
        {
            if (txtCoef.Text.Length != 0)
                DataCalculator.CoefYM = Convert.ToDouble(txtCoef.Text);
        }

        private void txtNed_TextChanged(object sender, EventArgs e)
        {
            if (txtNed.Text.Length != 0)
                DataCalculator.NedValcal = Convert.ToDouble(txtNed.Text);
        }

        private void txtLfy_TextChanged(object sender, EventArgs e)
        {
            if (txtLfy.Text.Length != 0)
                DataCalculator.Flamby = Convert.ToDouble(txtLfy.Text);
        }

        private void txtLfz_TextChanged(object sender, EventArgs e)
        {
            if (txtLfz.Text.Length != 0)
                DataCalculator.Flambz = Convert.ToDouble(txtLfz.Text);
        }

        private void dUpDKmod_SelectedItemChanged(object sender, EventArgs e)
        {
            DataCalculator.KmodClass = importClassData.Collection.KmodClass[dUpDResisatnce.Text];
            DataCalculator.CumulateChargClass = dUpDResisatnce.Text;
        }
    }
}
