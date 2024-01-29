namespace TIP_ATLAS
{
    partial class ViewWeightMax
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.importCassDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTest = new System.Windows.Forms.TextBox();
            this.dUpDResitanceClass = new System.Windows.Forms.DomainUpDown();
            this.dUpDKmod = new System.Windows.Forms.DomainUpDown();
            this.dUpDResisatnce = new System.Windows.Forms.DomainUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbl_Base = new System.Windows.Forms.Label();
            this.lbl_baseh = new System.Windows.Forms.Label();
            this.lbl_Lfy = new System.Windows.Forms.Label();
            this.lbl_Lfz = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.importCassDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(445, 377);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(201, 20);
            this.txtTest.TabIndex = 2;
            this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // dUpDResitanceClass
            // 
            this.dUpDResitanceClass.Location = new System.Drawing.Point(142, 107);
            this.dUpDResitanceClass.Name = "dUpDResitanceClass";
            this.dUpDResitanceClass.Size = new System.Drawing.Size(157, 20);
            this.dUpDResitanceClass.TabIndex = 3;
            this.dUpDResitanceClass.Text = "Classe de Resistance";
            this.dUpDResitanceClass.SelectedItemChanged += new System.EventHandler(this.dUpDClassResistance_SelectedItemChanged);
            // 
            // dUpDKmod
            // 
            this.dUpDKmod.Items.Add("Action permanent");
            this.dUpDKmod.Items.Add("Action long terme");
            this.dUpDKmod.Items.Add("Action moyen terme");
            this.dUpDKmod.Items.Add("Action court terme");
            this.dUpDKmod.Items.Add("Action instantanée");
            this.dUpDKmod.Location = new System.Drawing.Point(142, 147);
            this.dUpDKmod.Name = "dUpDKmod";
            this.dUpDKmod.Size = new System.Drawing.Size(120, 20);
            this.dUpDKmod.TabIndex = 4;
            this.dUpDKmod.Text = "Action d\'utilisation";
            // 
            // dUpDResisatnce
            // 
            this.dUpDResisatnce.Location = new System.Drawing.Point(142, 190);
            this.dUpDResisatnce.Name = "dUpDResisatnce";
            this.dUpDResisatnce.Size = new System.Drawing.Size(120, 20);
            this.dUpDResisatnce.TabIndex = 5;
            this.dUpDResisatnce.Text = "Resistance";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(680, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(495, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(680, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(495, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(680, 147);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(495, 106);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 12;
            // 
            // lbl_Base
            // 
            this.lbl_Base.AutoSize = true;
            this.lbl_Base.Location = new System.Drawing.Point(476, 109);
            this.lbl_Base.Name = "lbl_Base";
            this.lbl_Base.Size = new System.Drawing.Size(13, 13);
            this.lbl_Base.TabIndex = 13;
            this.lbl_Base.Text = "b";
            this.lbl_Base.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_baseh
            // 
            this.lbl_baseh.AutoSize = true;
            this.lbl_baseh.Location = new System.Drawing.Point(639, 113);
            this.lbl_baseh.Name = "lbl_baseh";
            this.lbl_baseh.Size = new System.Drawing.Size(13, 13);
            this.lbl_baseh.TabIndex = 14;
            this.lbl_baseh.Text = "h";
            // 
            // lbl_Lfy
            // 
            this.lbl_Lfy.AutoSize = true;
            this.lbl_Lfy.Location = new System.Drawing.Point(465, 154);
            this.lbl_Lfy.Name = "lbl_Lfy";
            this.lbl_Lfy.Size = new System.Drawing.Size(24, 13);
            this.lbl_Lfy.TabIndex = 15;
            this.lbl_Lfy.Text = "Lf,y";
            this.lbl_Lfy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Lfz
            // 
            this.lbl_Lfz.AutoSize = true;
            this.lbl_Lfz.Location = new System.Drawing.Point(638, 154);
            this.lbl_Lfz.Name = "lbl_Lfz";
            this.lbl_Lfz.Size = new System.Drawing.Size(24, 13);
            this.lbl_Lfz.TabIndex = 16;
            this.lbl_Lfz.Text = "Lf,y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Coefficient Ym";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ViewWeightMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(882, 511);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Lfz);
            this.Controls.Add(this.lbl_Lfy);
            this.Controls.Add(this.lbl_baseh);
            this.Controls.Add(this.lbl_Base);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dUpDResisatnce);
            this.Controls.Add(this.dUpDKmod);
            this.Controls.Add(this.dUpDResitanceClass);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewWeightMax";
            this.Text = "ViewWeightMax";
            this.Load += new System.EventHandler(this.ViewWeightMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importCassDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource importCassDataBindingSource;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.DomainUpDown dUpDResitanceClass;
        private System.Windows.Forms.DomainUpDown dUpDKmod;
        private System.Windows.Forms.DomainUpDown dUpDResisatnce;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbl_Base;
        private System.Windows.Forms.Label lbl_baseh;
        private System.Windows.Forms.Label lbl_Lfy;
        private System.Windows.Forms.Label lbl_Lfz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}