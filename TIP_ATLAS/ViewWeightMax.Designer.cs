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
            this.txt_F_Recommander = new System.Windows.Forms.TextBox();
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
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.txtDimRecomandé = new System.Windows.Forms.RichTextBox();
            this.txt_Aire_Rup = new System.Windows.Forms.RichTextBox();
            this.Txt_Air_Recomander = new System.Windows.Forms.RichTextBox();
            this.txtDim_rup = new System.Windows.Forms.RichTextBox();
            this.txt_Validate = new System.Windows.Forms.TextBox();
            this.txt_Rup_Force = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.btn_Validate = new System.Windows.Forms.Button();
            this.txt_Validation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.importCassDataBindingSource)).BeginInit();
            this.grpResult.SuspendLayout();
            this.grpUsers.SuspendLayout();
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
            // txt_F_Recommander
            // 
            this.txt_F_Recommander.Enabled = false;
            this.txt_F_Recommander.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_F_Recommander.Location = new System.Drawing.Point(123, 72);
            this.txt_F_Recommander.Name = "txt_F_Recommander";
            this.txt_F_Recommander.Size = new System.Drawing.Size(117, 26);
            this.txt_F_Recommander.TabIndex = 2;
            this.txt_F_Recommander.Text = "0";
            this.txt_F_Recommander.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
            // 
            // dUpDResitanceClass
            // 
            this.dUpDResitanceClass.CausesValidation = false;
            this.dUpDResitanceClass.Location = new System.Drawing.Point(142, 107);
            this.dUpDResitanceClass.Name = "dUpDResitanceClass";
            this.dUpDResitanceClass.ReadOnly = true;
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
            this.dUpDKmod.ReadOnly = true;
            this.dUpDKmod.Size = new System.Drawing.Size(120, 20);
            this.dUpDKmod.TabIndex = 4;
            this.dUpDKmod.Text = "Action d\'utilisation";
            // 
            // dUpDResisatnce
            // 
            this.dUpDResisatnce.Location = new System.Drawing.Point(142, 190);
            this.dUpDResisatnce.Name = "dUpDResisatnce";
            this.dUpDResisatnce.ReadOnly = true;
            this.dUpDResisatnce.Size = new System.Drawing.Size(120, 20);
            this.dUpDResisatnce.TabIndex = 5;
            this.dUpDResisatnce.Text = "Resistance";
            this.dUpDResisatnce.Wrap = true;
            this.dUpDResisatnce.SelectedItemChanged += new System.EventHandler(this.dUpDResisatnce_SelectedItemChanged);
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
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(495, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "50";
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
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(680, 147);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "50";
            // 
            // textBox7
            // 
            this.textBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox7.Location = new System.Drawing.Point(495, 106);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 12;
            // 
            // lbl_Base
            // 
            this.lbl_Base.AutoSize = true;
            this.lbl_Base.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Base.Location = new System.Drawing.Point(454, 109);
            this.lbl_Base.Name = "lbl_Base";
            this.lbl_Base.Size = new System.Drawing.Size(35, 13);
            this.lbl_Base.TabIndex = 13;
            this.lbl_Base.Text = "b[mm]";
            this.lbl_Base.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_baseh
            // 
            this.lbl_baseh.AutoSize = true;
            this.lbl_baseh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_baseh.Location = new System.Drawing.Point(631, 109);
            this.lbl_baseh.Name = "lbl_baseh";
            this.lbl_baseh.Size = new System.Drawing.Size(35, 13);
            this.lbl_baseh.TabIndex = 14;
            this.lbl_baseh.Text = "h[mm]";
            // 
            // lbl_Lfy
            // 
            this.lbl_Lfy.AutoSize = true;
            this.lbl_Lfy.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.lbl_Lfz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Lfz.Location = new System.Drawing.Point(642, 154);
            this.lbl_Lfz.Name = "lbl_Lfz";
            this.lbl_Lfz.Size = new System.Drawing.Size(24, 13);
            this.lbl_Lfz.TabIndex = 16;
            this.lbl_Lfz.Text = "Lf,z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(414, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Coefficient Ym";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(639, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ned";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // grpResult
            // 
            this.grpResult.BackColor = System.Drawing.Color.Tan;
            this.grpResult.Controls.Add(this.txt_Validation);
            this.grpResult.Controls.Add(this.label17);
            this.grpResult.Controls.Add(this.label16);
            this.grpResult.Controls.Add(this.label1);
            this.grpResult.Controls.Add(this.label2);
            this.grpResult.Controls.Add(this.label15);
            this.grpResult.Controls.Add(this.label14);
            this.grpResult.Controls.Add(this.label13);
            this.grpResult.Controls.Add(this.label3);
            this.grpResult.Controls.Add(this.label4);
            this.grpResult.Controls.Add(this.label9);
            this.grpResult.Controls.Add(this.label10);
            this.grpResult.Controls.Add(this.label8);
            this.grpResult.Controls.Add(this.label11);
            this.grpResult.Controls.Add(this.label7);
            this.grpResult.Controls.Add(this.label12);
            this.grpResult.Controls.Add(this.txt_Rup_Force);
            this.grpResult.Controls.Add(this.txt_Validate);
            this.grpResult.Controls.Add(this.txtDimRecomandé);
            this.grpResult.Controls.Add(this.txt_Aire_Rup);
            this.grpResult.Controls.Add(this.Txt_Air_Recomander);
            this.grpResult.Controls.Add(this.txtDim_rup);
            this.grpResult.Controls.Add(this.richTextBox8);
            this.grpResult.Controls.Add(this.richTextBox7);
            this.grpResult.Controls.Add(this.richTextBox6);
            this.grpResult.Controls.Add(this.richTextBox5);
            this.grpResult.Controls.Add(this.richTextBox4);
            this.grpResult.Controls.Add(this.richTextBox3);
            this.grpResult.Controls.Add(this.richTextBox2);
            this.grpResult.Controls.Add(this.richTextBox1);
            this.grpResult.Controls.Add(this.txt_F_Recommander);
            this.grpResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResult.Location = new System.Drawing.Point(37, 309);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(813, 170);
            this.grpResult.TabIndex = 19;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Resultat pour potos carrés";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(702, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(105, 23);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "0";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(702, 55);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(105, 23);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "0";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(702, 91);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(105, 23);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "0";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Enabled = false;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(514, 91);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(111, 23);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "0";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Enabled = false;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(514, 55);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(111, 23);
            this.richTextBox5.TabIndex = 7;
            this.richTextBox5.Text = "0";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Enabled = false;
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.Location = new System.Drawing.Point(514, 19);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(111, 23);
            this.richTextBox6.TabIndex = 8;
            this.richTextBox6.Text = "0";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Enabled = false;
            this.richTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.Location = new System.Drawing.Point(514, 126);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(111, 23);
            this.richTextBox7.TabIndex = 9;
            this.richTextBox7.Text = "0";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Enabled = false;
            this.richTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.Location = new System.Drawing.Point(702, 126);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(105, 23);
            this.richTextBox8.TabIndex = 10;
            this.richTextBox8.Text = "0";
            // 
            // txtDimRecomandé
            // 
            this.txtDimRecomandé.Enabled = false;
            this.txtDimRecomandé.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimRecomandé.Location = new System.Drawing.Point(323, 127);
            this.txtDimRecomandé.Name = "txtDimRecomandé";
            this.txtDimRecomandé.Size = new System.Drawing.Size(111, 23);
            this.txtDimRecomandé.TabIndex = 14;
            this.txtDimRecomandé.Text = "0";
            // 
            // txt_Aire_Rup
            // 
            this.txt_Aire_Rup.Enabled = false;
            this.txt_Aire_Rup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Aire_Rup.Location = new System.Drawing.Point(323, 19);
            this.txt_Aire_Rup.Name = "txt_Aire_Rup";
            this.txt_Aire_Rup.Size = new System.Drawing.Size(111, 23);
            this.txt_Aire_Rup.TabIndex = 13;
            this.txt_Aire_Rup.Text = "0";
            // 
            // Txt_Air_Recomander
            // 
            this.Txt_Air_Recomander.Enabled = false;
            this.Txt_Air_Recomander.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Air_Recomander.Location = new System.Drawing.Point(323, 55);
            this.Txt_Air_Recomander.Name = "Txt_Air_Recomander";
            this.Txt_Air_Recomander.Size = new System.Drawing.Size(111, 23);
            this.Txt_Air_Recomander.TabIndex = 12;
            this.Txt_Air_Recomander.Text = "0";
            // 
            // txtDim_rup
            // 
            this.txtDim_rup.Enabled = false;
            this.txtDim_rup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDim_rup.Location = new System.Drawing.Point(323, 91);
            this.txtDim_rup.Name = "txtDim_rup";
            this.txtDim_rup.Size = new System.Drawing.Size(111, 23);
            this.txtDim_rup.TabIndex = 11;
            this.txtDim_rup.Text = "0";
            // 
            // txt_Validate
            // 
            this.txt_Validate.Enabled = false;
            this.txt_Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Validate.Location = new System.Drawing.Point(123, 119);
            this.txt_Validate.Name = "txt_Validate";
            this.txt_Validate.Size = new System.Drawing.Size(78, 26);
            this.txt_Validate.TabIndex = 15;
            this.txt_Validate.Text = "0";
            this.txt_Validate.TextChanged += new System.EventHandler(this.txt_Validate_TextChanged);
            // 
            // txt_Rup_Force
            // 
            this.txt_Rup_Force.Enabled = false;
            this.txt_Rup_Force.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rup_Force.Location = new System.Drawing.Point(123, 28);
            this.txt_Rup_Force.Name = "txt_Rup_Force";
            this.txt_Rup_Force.Size = new System.Drawing.Size(117, 26);
            this.txt_Rup_Force.TabIndex = 16;
            this.txt_Rup_Force.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Force de Rupture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "h-b Rec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ned";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Kc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ned";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(459, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ned";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(647, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ned";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(647, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ned";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(647, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ned";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(258, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Aire max";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(268, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "A. Rec";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(247, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "h-b rupture";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "F. Recommander";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(44, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "Vérification";
            // 
            // grpUsers
            // 
            this.grpUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpUsers.Controls.Add(this.btn_Validate);
            this.grpUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsers.Location = new System.Drawing.Point(37, 73);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(813, 204);
            this.grpUsers.TabIndex = 20;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Données utilisateur";
            // 
            // btn_Validate
            // 
            this.btn_Validate.BackColor = System.Drawing.Color.Green;
            this.btn_Validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Validate.Location = new System.Drawing.Point(540, 171);
            this.btn_Validate.Name = "btn_Validate";
            this.btn_Validate.Size = new System.Drawing.Size(129, 27);
            this.btn_Validate.TabIndex = 0;
            this.btn_Validate.Text = "Valider";
            this.btn_Validate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Validate.UseVisualStyleBackColor = false;
            // 
            // txt_Validation
            // 
            this.txt_Validation.Enabled = false;
            this.txt_Validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Validation.Location = new System.Drawing.Point(207, 119);
            this.txt_Validation.Name = "txt_Validation";
            this.txt_Validation.Size = new System.Drawing.Size(33, 26);
            this.txt_Validation.TabIndex = 35;
            this.txt_Validation.Text = "0";
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
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewWeightMax";
            this.Text = "ViewWeightMax";
            this.Load += new System.EventHandler(this.ViewWeightMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importCassDataBindingSource)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource importCassDataBindingSource;
        private System.Windows.Forms.TextBox txt_F_Recommander;
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
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Rup_Force;
        private System.Windows.Forms.TextBox txt_Validate;
        private System.Windows.Forms.RichTextBox txtDimRecomandé;
        private System.Windows.Forms.RichTextBox txt_Aire_Rup;
        private System.Windows.Forms.RichTextBox Txt_Air_Recomander;
        private System.Windows.Forms.RichTextBox txtDim_rup;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.Button btn_Validate;
        private System.Windows.Forms.TextBox txt_Validation;
    }
}