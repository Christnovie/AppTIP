using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using ATLAS_Models;
namespace TIP_ATLAS
{
    public partial class Verifications : Form
    {
        private CanevasMain canevas;
        private ImportClassData importClassData;
        private CompressionAxiale DataCalculator;
        public Verifications(CanevasMain canevas)
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            canevas.showAccueil();
        }

       

        private void btn_Validate_Click(object sender, EventArgs e)
        {
            UpdateCalc();          
        }

        //When input of user data part changed
        private void txt_Validate_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtB.Text.Length != 0)
                txtB_Validating(sender, new CancelEventArgs());
            dUpDKmod_Validating(sender, new CancelEventArgs());
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {
            if(txtH.Text.Length !=0)
                txtH_Validating(sender, new CancelEventArgs());
            dUpDKmod_Validating(sender, new CancelEventArgs());
        }

        private void txtCoef_TextChanged(object sender, EventArgs e)
        {
            if (txtCoef.Text.Length != 0)
                txtCoef_Validating(sender, new CancelEventArgs());
            dUpDKmod_Validating(sender, new CancelEventArgs());
        }

        private void txtNed_TextChanged(object sender, EventArgs e)
        {
            if (txtNed.Text.Length != 0)
               txtNed_Validating(sender, new CancelEventArgs());
            dUpDKmod_Validating(sender, new CancelEventArgs());
        }

        private void txtLfy_TextChanged(object sender, EventArgs e)
        {
            if (txtLfy.Text.Length != 0)
                txtLfy_Validating(sender, new CancelEventArgs());
            dUpDKmod_Validating(sender, new CancelEventArgs());
        }

        private void txtLfz_TextChanged(object sender, EventArgs e)
        {
            if (txtLfz.Text.Length != 0)
                txtLfz_Validating(sender, new CancelEventArgs());
            dUpDKmod_Validating(sender, new CancelEventArgs());
        }

        // Selected item Changed in up-down
        private void dUpDKmod_SelectedItemChanged(object sender, EventArgs e)
        {
            DataCalculator.KmodClass = importClassData.Collection.KmodClass[dUpDResisatnce.Text];
            DataCalculator.CumulateChargClass = dUpDResisatnce.Text;
            DataCalculator.ServiceClass = dUpDKmod.Text;
            dUpDKmod_Validating(sender, new CancelEventArgs());
        }
        private void dUpDClassResistance_SelectedItemChanged(object sender, EventArgs e)
        {
            WoodClass result;
            result = ImportClassData.GetSoftwoodDataValueTarget(importClassData.Collection, dUpDResitanceClass.Text);
            DataCalculator.CurrentWood = result;
        }

        private void dUpDResisatnce_SelectedItemChanged(object sender, EventArgs e)
        {
            DataCalculator.KmodClass = importClassData.Collection.KmodClass[dUpDResisatnce.Text];
            DataCalculator.CumulateChargClass = dUpDResisatnce.Text;
            DataCalculator.ServiceClass = dUpDKmod.Text;
            dUpDKmod.Enabled = true;
        }



        //Round number in the superior integer number
        public string RoundNumeberView(double number)
        {
            string result;
            if (number % 1 > 0)
            {
                return result = (Math.Truncate(number) + 1).ToString();
            }
            else { return result = number.ToString(); }
        }
        //Display and update Calc of Result
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
            txt_kmod.Text = DataCalculator.Kmod.ToString();
            txt_fcok.Text = DataCalculator.CurrentWood.fc0k.ToString();
            txt_E005.Text = DataCalculator.CurrentWood.E005.ToString();
            txt_constMassiv.Text = DataCalculator.ConstBetaRextitude.ToString();
        }
        //Update Result recommanded


        //Take data of Class and Co on Database
        private void DownloadItem()
        {
            foreach (string wood in importClassData.Collection.CollectionWood.Keys)
            {
                dUpDResitanceClass.Items.Add(wood);
            }
            foreach (string wood in importClassData.Collection.KmodClass.Keys)
            {
                dUpDResisatnce.Items.Add(wood);
            }

        }

        //Validating Data and send error
        bool ValidateData(TextBox text, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[+-]?\d*[\.,]\d+$|^[+-]?\d+([\.,]\d*)?$");
             
            if (!regex.IsMatch(text.Text)&&text.Text!="")
            {
                e.Cancel = true;
                text.Focus();
                errorInput.SetError(text, "Entrez un nombre svp!");
                return false;
            }
            else
            {
                if (text.Text == "")
                {
                    errorInput.Clear();
                    text.Text = "0";
                    return false;
                }
                else
                {
                    if (Convert.ToDouble(text.Text.Replace(".", ",")) < 5)
                    {
                        e.Cancel = true;
                        errorInput.SetError(text, "le nombre doit etre supérieur 5");
                        return false;
                    }
                    else
                    {
                        errorInput.Clear();
                        return true;
                    }
                }
            }
        }
        private void txtB_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateData(txtB, e))
            {
                DataCalculator.Stransb = Convert.ToDouble(txtB.Text.Replace(".", ","));
            }
        }
        private void txtH_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateData(txtH, e))
            {
                DataCalculator.Stransh = Convert.ToDouble(txtH.Text.Replace(".",","));
            }
        }

        private void txtNed_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateData(txtNed, e))
            {
                DataCalculator.NedValcal = Convert.ToDouble(txtNed.Text.Replace(".", ","));
            }
        }

        private void txtLfy_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateData(txtLfy, e))
            {
                DataCalculator.Flamby = Convert.ToDouble(txtLfy.Text.Replace(".", ","));
            }
        }

        private void txtCoef_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateData(txtCoef, e))
            {
                DataCalculator.CoefYM = Convert.ToDouble(txtCoef.Text.Replace(".", ","));
            }
        }
        private void txtLfz_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateData(txtLfz, e))
            {
                DataCalculator.Flambz = Convert.ToDouble(txtLfz.Text.Replace(".", ","));
            }
        }
        private void dUpDKmod_Validating(object sender, CancelEventArgs e)
        {
            dUpDKmod_Validated(sender, e);
        }

        private void dUpDKmod_Validated(object sender, EventArgs e)
        {
            btn_Validate.Enabled = dUpDKmod.Enabled;
            btn_Validate.Visible = dUpDKmod.Visible;
        }
        private void btn_Validate_MouseMove(object sender, MouseEventArgs e)
        {
            if (((txtB.Text != "" && txtH.Text != "") || txtNed.Text != "") && dUpDKmod.Visible)
            {
                btn_Validate.Visible = true;
            }
            else
            {
                btn_Validate.Visible = false;
            }
        }

        //Open help files 
        private void btn_lexique_Click(object sender, EventArgs e)
        {
            ImportClassData.OpenPDF("Lexique.pdf");
        }

        private void btn_tableau_Click(object sender, EventArgs e)
        {
            ImportClassData.OpenPDF("TABLEAUX_DE_DONNEES.pdf");

        }

        private void btn_modeEmploi_Click(object sender, EventArgs e)
        {
            ImportClassData.OpenPDF("Mode_d'emploi.pdf");

        }

        private void txt_Verif_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt_Verif.Text.Replace(".", ","))<=0.85)
                txt_Verif.BackColor = Color.LightGreen;
            else if(Convert.ToDouble(txt_Verif.Text.Replace(".", ",")) < 1 && Convert.ToDouble(txt_Verif.Text.Replace(".", ",")) > 0.85)
                txt_Verif.BackColor = Color.Orange;
            else if(Convert.ToDouble(txt_Verif.Text.Replace(".", ",")) >= 1)
                txt_Verif.BackColor= Color.LightCoral;
            else
                txt_Verif.BackColor = Color.White;
        }
    }

}
