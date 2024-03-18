namespace TIP_ATLAS
{
    partial class Verifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verifications));
            this.btnBack = new System.Windows.Forms.Button();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtLfy = new System.Windows.Forms.TextBox();
            this.txtNed = new System.Windows.Forms.TextBox();
            this.txtCoef = new System.Windows.Forms.TextBox();
            this.txtLfz = new System.Windows.Forms.TextBox();
            this.btn_Validate = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txt_Aire = new System.Windows.Forms.TextBox();
            this.txt_Verif = new System.Windows.Forms.TextBox();
            this.txt_ky = new System.Windows.Forms.TextBox();
            this.txt_fc0d = new System.Windows.Forms.TextBox();
            this.txt_ly = new System.Windows.Forms.TextBox();
            this.txt_lz = new System.Windows.Forms.TextBox();
            this.txt_kc = new System.Windows.Forms.TextBox();
            this.txt_Arelz = new System.Windows.Forms.TextBox();
            this.txt_Yy = new System.Windows.Forms.TextBox();
            this.txt_Yz = new System.Windows.Forms.TextBox();
            this.txt_Arely = new System.Windows.Forms.TextBox();
            this.txt_kcz = new System.Windows.Forms.TextBox();
            this.txt_kcy = new System.Windows.Forms.TextBox();
            this.txt_oc0d = new System.Windows.Forms.TextBox();
            this.errorInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_kz = new System.Windows.Forms.TextBox();
            this.txt_E005 = new System.Windows.Forms.TextBox();
            this.txt_constMassiv = new System.Windows.Forms.TextBox();
            this.txt_fcok = new System.Windows.Forms.TextBox();
            this.txt_kmod = new System.Windows.Forms.TextBox();
            this.btn_lexique = new System.Windows.Forms.Button();
            this.btn_tableau = new System.Windows.Forms.Button();
            this.btn_modeEmploi = new System.Windows.Forms.Button();
            this.combUpDKmod = new System.Windows.Forms.ComboBox();
            this.comboUpDResisatnce = new System.Windows.Forms.ComboBox();
            this.combUpDResitanceClass = new System.Windows.Forms.ComboBox();
            this.lblresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(25, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtH
            // 
            this.txtH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.Location = new System.Drawing.Point(543, 57);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(65, 20);
            this.txtH.TabIndex = 6;
            this.txtH.TextChanged += new System.EventHandler(this.txtH_TextChanged);
            this.txtH.Validating += new System.ComponentModel.CancelEventHandler(this.txtH_Validating);
            // 
            // txtLfy
            // 
            this.txtLfy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLfy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLfy.Location = new System.Drawing.Point(543, 122);
            this.txtLfy.Multiline = true;
            this.txtLfy.Name = "txtLfy";
            this.txtLfy.Size = new System.Drawing.Size(65, 23);
            this.txtLfy.TabIndex = 7;
            this.txtLfy.TextChanged += new System.EventHandler(this.txtLfy_TextChanged);
            this.txtLfy.Validating += new System.ComponentModel.CancelEventHandler(this.txtLfy_Validating);
            // 
            // txtNed
            // 
            this.txtNed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNed.Location = new System.Drawing.Point(543, 318);
            this.txtNed.Name = "txtNed";
            this.txtNed.Size = new System.Drawing.Size(65, 20);
            this.txtNed.TabIndex = 8;
            this.txtNed.TextChanged += new System.EventHandler(this.txtNed_TextChanged);
            this.txtNed.Validating += new System.ComponentModel.CancelEventHandler(this.txtNed_Validating);
            // 
            // txtCoef
            // 
            this.txtCoef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoef.Location = new System.Drawing.Point(543, 285);
            this.txtCoef.Name = "txtCoef";
            this.txtCoef.Size = new System.Drawing.Size(65, 20);
            this.txtCoef.TabIndex = 9;
            this.txtCoef.Text = "1,3";
            this.txtCoef.TextChanged += new System.EventHandler(this.txtCoef_TextChanged);
            this.txtCoef.Validating += new System.ComponentModel.CancelEventHandler(this.txtCoef_Validating);
            // 
            // txtLfz
            // 
            this.txtLfz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLfz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLfz.Location = new System.Drawing.Point(543, 151);
            this.txtLfz.Multiline = true;
            this.txtLfz.Name = "txtLfz";
            this.txtLfz.Size = new System.Drawing.Size(65, 23);
            this.txtLfz.TabIndex = 10;
            this.txtLfz.TextChanged += new System.EventHandler(this.txtLfz_TextChanged);
            this.txtLfz.Validating += new System.ComponentModel.CancelEventHandler(this.txtLfz_Validating);
            // 
            // btn_Validate
            // 
            this.btn_Validate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Validate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Validate.Enabled = false;
            this.btn_Validate.FlatAppearance.BorderSize = 0;
            this.btn_Validate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Validate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Validate.Location = new System.Drawing.Point(118, 344);
            this.btn_Validate.Name = "btn_Validate";
            this.btn_Validate.Size = new System.Drawing.Size(432, 57);
            this.btn_Validate.TabIndex = 0;
            this.btn_Validate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Validate.UseVisualStyleBackColor = false;
            this.btn_Validate.Visible = false;
            this.btn_Validate.Click += new System.EventHandler(this.btn_Validate_Click);
            this.btn_Validate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Validate_MouseMove);
            // 
            // txtB
            // 
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtB.Location = new System.Drawing.Point(543, 89);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(65, 20);
            this.txtB.TabIndex = 12;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            this.txtB.Validating += new System.ComponentModel.CancelEventHandler(this.txtB_Validating);
            // 
            // txt_Aire
            // 
            this.txt_Aire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Aire.Enabled = false;
            this.txt_Aire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Aire.Location = new System.Drawing.Point(173, 434);
            this.txt_Aire.Name = "txt_Aire";
            this.txt_Aire.Size = new System.Drawing.Size(62, 21);
            this.txt_Aire.TabIndex = 16;
            this.txt_Aire.Text = "0";
            // 
            // txt_Verif
            // 
            this.txt_Verif.BackColor = System.Drawing.Color.White;
            this.txt_Verif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Verif.Enabled = false;
            this.txt_Verif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Verif.Location = new System.Drawing.Point(950, 187);
            this.txt_Verif.Multiline = true;
            this.txt_Verif.Name = "txt_Verif";
            this.txt_Verif.Size = new System.Drawing.Size(65, 25);
            this.txt_Verif.TabIndex = 15;
            this.txt_Verif.Text = "0";
            this.txt_Verif.TextChanged += new System.EventHandler(this.txt_Verif_TextChanged);
            // 
            // txt_ky
            // 
            this.txt_ky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ky.Enabled = false;
            this.txt_ky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ky.Location = new System.Drawing.Point(826, 530);
            this.txt_ky.Name = "txt_ky";
            this.txt_ky.Size = new System.Drawing.Size(63, 21);
            this.txt_ky.TabIndex = 14;
            this.txt_ky.Text = "0";
            // 
            // txt_fc0d
            // 
            this.txt_fc0d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fc0d.Enabled = false;
            this.txt_fc0d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fc0d.Location = new System.Drawing.Point(173, 564);
            this.txt_fc0d.Name = "txt_fc0d";
            this.txt_fc0d.Size = new System.Drawing.Size(62, 21);
            this.txt_fc0d.TabIndex = 13;
            this.txt_fc0d.Text = "0";
            // 
            // txt_ly
            // 
            this.txt_ly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ly.Enabled = false;
            this.txt_ly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ly.Location = new System.Drawing.Point(446, 467);
            this.txt_ly.Name = "txt_ly";
            this.txt_ly.Size = new System.Drawing.Size(65, 21);
            this.txt_ly.TabIndex = 12;
            this.txt_ly.Text = "0";
            // 
            // txt_lz
            // 
            this.txt_lz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lz.Enabled = false;
            this.txt_lz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lz.Location = new System.Drawing.Point(446, 498);
            this.txt_lz.Name = "txt_lz";
            this.txt_lz.Size = new System.Drawing.Size(65, 21);
            this.txt_lz.TabIndex = 11;
            this.txt_lz.Text = "0";
            // 
            // txt_kc
            // 
            this.txt_kc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kc.Enabled = false;
            this.txt_kc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kc.Location = new System.Drawing.Point(1217, 520);
            this.txt_kc.Name = "txt_kc";
            this.txt_kc.Size = new System.Drawing.Size(65, 21);
            this.txt_kc.TabIndex = 10;
            this.txt_kc.Text = "0";
            // 
            // txt_Arelz
            // 
            this.txt_Arelz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Arelz.Enabled = false;
            this.txt_Arelz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Arelz.Location = new System.Drawing.Point(826, 467);
            this.txt_Arelz.Name = "txt_Arelz";
            this.txt_Arelz.Size = new System.Drawing.Size(63, 21);
            this.txt_Arelz.TabIndex = 9;
            this.txt_Arelz.Text = "0";
            // 
            // txt_Yy
            // 
            this.txt_Yy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Yy.Enabled = false;
            this.txt_Yy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Yy.Location = new System.Drawing.Point(446, 530);
            this.txt_Yy.Name = "txt_Yy";
            this.txt_Yy.Size = new System.Drawing.Size(65, 21);
            this.txt_Yy.TabIndex = 8;
            this.txt_Yy.Text = "0";
            // 
            // txt_Yz
            // 
            this.txt_Yz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Yz.Enabled = false;
            this.txt_Yz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Yz.Location = new System.Drawing.Point(446, 564);
            this.txt_Yz.Name = "txt_Yz";
            this.txt_Yz.Size = new System.Drawing.Size(65, 21);
            this.txt_Yz.TabIndex = 7;
            this.txt_Yz.Text = "0";
            // 
            // txt_Arely
            // 
            this.txt_Arely.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Arely.Enabled = false;
            this.txt_Arely.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Arely.Location = new System.Drawing.Point(826, 434);
            this.txt_Arely.Name = "txt_Arely";
            this.txt_Arely.Size = new System.Drawing.Size(63, 21);
            this.txt_Arely.TabIndex = 6;
            this.txt_Arely.Text = "0";
            // 
            // txt_kcz
            // 
            this.txt_kcz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kcz.Enabled = false;
            this.txt_kcz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kcz.Location = new System.Drawing.Point(1217, 478);
            this.txt_kcz.Name = "txt_kcz";
            this.txt_kcz.Size = new System.Drawing.Size(65, 21);
            this.txt_kcz.TabIndex = 5;
            this.txt_kcz.Text = "0";
            // 
            // txt_kcy
            // 
            this.txt_kcy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kcy.Enabled = false;
            this.txt_kcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kcy.Location = new System.Drawing.Point(1217, 434);
            this.txt_kcy.Name = "txt_kcy";
            this.txt_kcy.Size = new System.Drawing.Size(65, 21);
            this.txt_kcy.TabIndex = 4;
            this.txt_kcy.Text = "0";
            // 
            // txt_oc0d
            // 
            this.txt_oc0d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_oc0d.Enabled = false;
            this.txt_oc0d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oc0d.Location = new System.Drawing.Point(173, 468);
            this.txt_oc0d.Multiline = true;
            this.txt_oc0d.Name = "txt_oc0d";
            this.txt_oc0d.Size = new System.Drawing.Size(62, 22);
            this.txt_oc0d.TabIndex = 2;
            this.txt_oc0d.Text = "0";
            // 
            // errorInput
            // 
            this.errorInput.ContainerControl = this;
            // 
            // txt_kz
            // 
            this.txt_kz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kz.Enabled = false;
            this.txt_kz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kz.Location = new System.Drawing.Point(826, 564);
            this.txt_kz.Name = "txt_kz";
            this.txt_kz.Size = new System.Drawing.Size(63, 21);
            this.txt_kz.TabIndex = 3;
            this.txt_kz.Text = "0";
            // 
            // txt_E005
            // 
            this.txt_E005.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_E005.Enabled = false;
            this.txt_E005.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_E005.Location = new System.Drawing.Point(446, 434);
            this.txt_E005.Name = "txt_E005";
            this.txt_E005.Size = new System.Drawing.Size(65, 21);
            this.txt_E005.TabIndex = 43;
            this.txt_E005.Text = "0";
            // 
            // txt_constMassiv
            // 
            this.txt_constMassiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_constMassiv.Enabled = false;
            this.txt_constMassiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_constMassiv.Location = new System.Drawing.Point(826, 499);
            this.txt_constMassiv.Name = "txt_constMassiv";
            this.txt_constMassiv.Size = new System.Drawing.Size(63, 21);
            this.txt_constMassiv.TabIndex = 44;
            this.txt_constMassiv.Text = "0";
            // 
            // txt_fcok
            // 
            this.txt_fcok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fcok.Enabled = false;
            this.txt_fcok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fcok.Location = new System.Drawing.Point(173, 499);
            this.txt_fcok.Name = "txt_fcok";
            this.txt_fcok.Size = new System.Drawing.Size(62, 21);
            this.txt_fcok.TabIndex = 45;
            this.txt_fcok.Text = "0";
            // 
            // txt_kmod
            // 
            this.txt_kmod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kmod.Enabled = false;
            this.txt_kmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kmod.Location = new System.Drawing.Point(173, 530);
            this.txt_kmod.Name = "txt_kmod";
            this.txt_kmod.Size = new System.Drawing.Size(62, 21);
            this.txt_kmod.TabIndex = 46;
            this.txt_kmod.Text = "0";
            // 
            // btn_lexique
            // 
            this.btn_lexique.BackColor = System.Drawing.Color.Transparent;
            this.btn_lexique.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_lexique.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_lexique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_lexique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lexique.Location = new System.Drawing.Point(950, 29);
            this.btn_lexique.Name = "btn_lexique";
            this.btn_lexique.Size = new System.Drawing.Size(76, 26);
            this.btn_lexique.TabIndex = 47;
            this.btn_lexique.UseVisualStyleBackColor = false;
            this.btn_lexique.Click += new System.EventHandler(this.btn_lexique_Click);
            // 
            // btn_tableau
            // 
            this.btn_tableau.BackColor = System.Drawing.Color.Transparent;
            this.btn_tableau.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_tableau.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_tableau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_tableau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tableau.Location = new System.Drawing.Point(1043, 29);
            this.btn_tableau.Name = "btn_tableau";
            this.btn_tableau.Size = new System.Drawing.Size(86, 26);
            this.btn_tableau.TabIndex = 48;
            this.btn_tableau.UseVisualStyleBackColor = false;
            this.btn_tableau.Click += new System.EventHandler(this.btn_tableau_Click);
            // 
            // btn_modeEmploi
            // 
            this.btn_modeEmploi.BackColor = System.Drawing.Color.Transparent;
            this.btn_modeEmploi.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_modeEmploi.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_modeEmploi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_modeEmploi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modeEmploi.Location = new System.Drawing.Point(1147, 29);
            this.btn_modeEmploi.Name = "btn_modeEmploi";
            this.btn_modeEmploi.Size = new System.Drawing.Size(132, 26);
            this.btn_modeEmploi.TabIndex = 49;
            this.btn_modeEmploi.UseVisualStyleBackColor = false;
            this.btn_modeEmploi.Click += new System.EventHandler(this.btn_modeEmploi_Click);
            // 
            // combUpDKmod
            // 
            this.combUpDKmod.AutoCompleteCustomSource.AddRange(new string[] {
            "P",
            "LT",
            "MT",
            "CT",
            "I"});
            this.combUpDKmod.DropDownHeight = 100;
            this.combUpDKmod.Enabled = false;
            this.combUpDKmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combUpDKmod.FormattingEnabled = true;
            this.combUpDKmod.IntegralHeight = false;
            this.combUpDKmod.Items.AddRange(new object[] {
            "P",
            "LT",
            "MT",
            "CT",
            "I"});
            this.combUpDKmod.Location = new System.Drawing.Point(543, 249);
            this.combUpDKmod.Name = "combUpDKmod";
            this.combUpDKmod.Size = new System.Drawing.Size(65, 23);
            this.combUpDKmod.TabIndex = 50;
            this.combUpDKmod.SelectedIndexChanged += new System.EventHandler(this.combUpDKmod_SelectedIndexChanged);
            this.combUpDKmod.Validated += new System.EventHandler(this.combUpDKmod_Validated);
            // 
            // comboUpDResisatnce
            // 
            this.comboUpDResisatnce.AutoCompleteCustomSource.AddRange(new string[] {
            "P",
            "LT",
            "MT",
            "CT",
            "I"});
            this.comboUpDResisatnce.DropDownHeight = 100;
            this.comboUpDResisatnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUpDResisatnce.FormattingEnabled = true;
            this.comboUpDResisatnce.IntegralHeight = false;
            this.comboUpDResisatnce.Location = new System.Drawing.Point(543, 220);
            this.comboUpDResisatnce.Name = "comboUpDResisatnce";
            this.comboUpDResisatnce.Size = new System.Drawing.Size(65, 23);
            this.comboUpDResisatnce.TabIndex = 51;
            this.comboUpDResisatnce.SelectedIndexChanged += new System.EventHandler(this.comboUpDResisatnce_SelectedIndexChanged);
            // 
            // combUpDResitanceClass
            // 
            this.combUpDResitanceClass.AutoCompleteCustomSource.AddRange(new string[] {
            "P",
            "LT",
            "MT",
            "CT",
            "I"});
            this.combUpDResitanceClass.DropDownHeight = 100;
            this.combUpDResitanceClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combUpDResitanceClass.FormattingEnabled = true;
            this.combUpDResitanceClass.IntegralHeight = false;
            this.combUpDResitanceClass.Location = new System.Drawing.Point(543, 186);
            this.combUpDResitanceClass.Name = "combUpDResitanceClass";
            this.combUpDResitanceClass.Size = new System.Drawing.Size(65, 23);
            this.combUpDResitanceClass.TabIndex = 52;
            this.combUpDResitanceClass.SelectedIndexChanged += new System.EventHandler(this.combUpDResitanceClass_SelectedIndexChanged);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.BackColor = System.Drawing.Color.White;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.Red;
            this.lblresult.Location = new System.Drawing.Point(365, 367);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(146, 15);
            this.lblresult.TabIndex = 53;
            this.lblresult.Text = "<Appuyer sur les flèches>";
            // 
            // Verifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1319, 624);
            this.ControlBox = false;
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.combUpDResitanceClass);
            this.Controls.Add(this.comboUpDResisatnce);
            this.Controls.Add(this.combUpDKmod);
            this.Controls.Add(this.btn_modeEmploi);
            this.Controls.Add(this.btn_tableau);
            this.Controls.Add(this.btn_lexique);
            this.Controls.Add(this.txt_kmod);
            this.Controls.Add(this.txt_fcok);
            this.Controls.Add(this.txt_constMassiv);
            this.Controls.Add(this.txt_E005);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_Validate);
            this.Controls.Add(this.txt_Verif);
            this.Controls.Add(this.txtNed);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtCoef);
            this.Controls.Add(this.txtLfz);
            this.Controls.Add(this.txtLfy);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txt_kz);
            this.Controls.Add(this.txt_Yy);
            this.Controls.Add(this.txt_Arelz);
            this.Controls.Add(this.txt_Yz);
            this.Controls.Add(this.txt_ky);
            this.Controls.Add(this.txt_Arely);
            this.Controls.Add(this.txt_Aire);
            this.Controls.Add(this.txt_lz);
            this.Controls.Add(this.txt_ly);
            this.Controls.Add(this.txt_fc0d);
            this.Controls.Add(this.txt_kc);
            this.Controls.Add(this.txt_kcz);
            this.Controls.Add(this.txt_oc0d);
            this.Controls.Add(this.txt_kcy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verifications";
            this.Text = "ViewWeightMax";
            this.Load += new System.EventHandler(this.ViewWeightMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtLfy;
        private System.Windows.Forms.TextBox txtNed;
        private System.Windows.Forms.TextBox txtCoef;
        private System.Windows.Forms.TextBox txtLfz;
        private System.Windows.Forms.Button btn_Validate;
        private System.Windows.Forms.TextBox txt_Aire;
        private System.Windows.Forms.TextBox txt_Verif;
        private System.Windows.Forms.TextBox txt_ky;
        private System.Windows.Forms.TextBox txt_fc0d;
        private System.Windows.Forms.TextBox txt_ly;
        private System.Windows.Forms.TextBox txt_lz;
        private System.Windows.Forms.TextBox txt_kc;
        private System.Windows.Forms.TextBox txt_Arelz;
        private System.Windows.Forms.TextBox txt_Yy;
        private System.Windows.Forms.TextBox txt_Yz;
        private System.Windows.Forms.TextBox txt_Arely;
        private System.Windows.Forms.TextBox txt_kcz;
        private System.Windows.Forms.TextBox txt_kcy;
        private System.Windows.Forms.TextBox txt_oc0d;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.ErrorProvider errorInput;
        private System.Windows.Forms.TextBox txt_kz;
        private System.Windows.Forms.TextBox txt_kmod;
        private System.Windows.Forms.TextBox txt_fcok;
        private System.Windows.Forms.TextBox txt_constMassiv;
        private System.Windows.Forms.TextBox txt_E005;
        private System.Windows.Forms.Button btn_tableau;
        private System.Windows.Forms.Button btn_lexique;
        private System.Windows.Forms.Button btn_modeEmploi;
        private System.Windows.Forms.ComboBox combUpDKmod;
        private System.Windows.Forms.ComboBox combUpDResitanceClass;
        private System.Windows.Forms.ComboBox comboUpDResisatnce;
        private System.Windows.Forms.Label lblresult;
    }
}