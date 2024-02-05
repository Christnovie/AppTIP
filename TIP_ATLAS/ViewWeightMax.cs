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
        
       
        public ViewWeightMax(CanevasMain canevas)
        {
            InitializeComponent();
            this.canevas = canevas;
            importClassData = new ImportClassData();
            // no smaller than design time size
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            List<string> keyList = new List<string>(importClassData.Collection.CollectionWood.Keys);
            TypeResistanceKmod typeKmod = new TypeResistanceKmod();

            Dictionary<string, string> data = new Dictionary<string, string>();
           
         //   data.Add("abc", );
         //   data.Add("def", 456);

      



            foreach (var oneKeyList in keyList)
                lsbTypebois.Items.Add((oneKeyList));
            lsbTypebois.Height = lsbTypebois.ItemHeight * (lsbTypebois.Items.Count + 1);
            lsbTypebois.Width = 70;
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
            WoodClass result;
            result = ImportClassData.GetSoftwoodDataValueTarget(importClassData.Collection,lsbTypebois.Text);
            txtTypebois.Text = lsbTypebois.Text;
          //  txtTypebois.Text = result.ToString();
        }

        private void txtTypeBois_TextChanged(object sender, EventArgs e)
        {

            List<string> keyList = new List<string>(importClassData.Collection.CollectionWood.Keys);
            var itemList = lsbTypebois.Items.Cast<string>().ToList();
            if (keyList.Count > 0)
            {
                //clear the items from the list
                lsbTypebois.Items.Clear();

                //filter the items and add them to the list
                lsbTypebois.Items.AddRange(
                    keyList.Where(i => i.Contains(txtTypebois.Text)).ToArray());
               var lsbZy = lsbTypebois.Items.Cast<string>().ToList();
                lsbTypebois.Height = lsbTypebois.ItemHeight * (lsbTypebois.Items.Count + 1);
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTypebois_Click(object sender, EventArgs e)
        {
            lsbTypebois.Height = lsbTypebois.ItemHeight * (lsbTypebois.Items.Count + 1);
        }
    }
}
