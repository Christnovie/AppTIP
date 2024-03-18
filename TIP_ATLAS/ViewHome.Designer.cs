namespace TIP_ATLAS
{
    partial class ViewHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHome));
            this.label1 = new System.Windows.Forms.Label();
            this.dimMax_btn = new System.Windows.Forms.Button();
            this.btn_VerifForm = new System.Windows.Forms.Button();
            this.btnForce_form = new System.Windows.Forms.Button();
            this.btn_lexique = new System.Windows.Forms.Button();
            this.btn_tableau = new System.Windows.Forms.Button();
            this.btn_modeEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue sur A.T.L.A.S.";
            // 
            // dimMax_btn
            // 
            this.dimMax_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.dimMax_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dimMax_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dimMax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimMax_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dimMax_btn.Location = new System.Drawing.Point(126, 215);
            this.dimMax_btn.Name = "dimMax_btn";
            this.dimMax_btn.Size = new System.Drawing.Size(254, 69);
            this.dimMax_btn.TabIndex = 1;
            this.dimMax_btn.Text = "CALCUL DE LA TAILLE EN FONCTION DE LA RESISTANCE";
            this.dimMax_btn.UseVisualStyleBackColor = false;
            this.dimMax_btn.Click += new System.EventHandler(this.dimMax_btn_Click);
            // 
            // btn_VerifForm
            // 
            this.btn_VerifForm.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_VerifForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_VerifForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_VerifForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerifForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_VerifForm.Location = new System.Drawing.Point(126, 290);
            this.btn_VerifForm.Name = "btn_VerifForm";
            this.btn_VerifForm.Size = new System.Drawing.Size(254, 69);
            this.btn_VerifForm.TabIndex = 2;
            this.btn_VerifForm.Text = "VERIFICATION DE LA RESISTANCE A LA COMPRESSION";
            this.btn_VerifForm.UseVisualStyleBackColor = false;
            this.btn_VerifForm.Click += new System.EventHandler(this.btn_VerifForm_Click);
            // 
            // btnForce_form
            // 
            this.btnForce_form.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnForce_form.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnForce_form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForce_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForce_form.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnForce_form.Location = new System.Drawing.Point(126, 375);
            this.btnForce_form.Name = "btnForce_form";
            this.btnForce_form.Size = new System.Drawing.Size(254, 69);
            this.btnForce_form.TabIndex = 3;
            this.btnForce_form.Text = "CALCUL DE LA RESISTANCE EN FONCTION DE LA TAILLE";
            this.btnForce_form.UseVisualStyleBackColor = false;
            this.btnForce_form.Click += new System.EventHandler(this.btnForce_form_Click);
            // 
            // btn_lexique
            // 
            this.btn_lexique.BackColor = System.Drawing.Color.White;
            this.btn_lexique.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_lexique.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_lexique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lexique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lexique.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_lexique.Location = new System.Drawing.Point(847, 103);
            this.btn_lexique.Name = "btn_lexique";
            this.btn_lexique.Size = new System.Drawing.Size(89, 28);
            this.btn_lexique.TabIndex = 4;
            this.btn_lexique.Text = "Lexique";
            this.btn_lexique.UseVisualStyleBackColor = false;
            this.btn_lexique.Click += new System.EventHandler(this.btn_lexique_Click);
            // 
            // btn_tableau
            // 
            this.btn_tableau.BackColor = System.Drawing.Color.White;
            this.btn_tableau.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tableau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tableau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_tableau.Location = new System.Drawing.Point(942, 103);
            this.btn_tableau.Name = "btn_tableau";
            this.btn_tableau.Size = new System.Drawing.Size(108, 28);
            this.btn_tableau.TabIndex = 5;
            this.btn_tableau.Text = "Tableau";
            this.btn_tableau.UseVisualStyleBackColor = false;
            this.btn_tableau.Click += new System.EventHandler(this.btn_tableau_Click);
            // 
            // btn_modeEmp
            // 
            this.btn_modeEmp.BackColor = System.Drawing.Color.White;
            this.btn_modeEmp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_modeEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modeEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modeEmp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_modeEmp.Location = new System.Drawing.Point(1056, 103);
            this.btn_modeEmp.Name = "btn_modeEmp";
            this.btn_modeEmp.Size = new System.Drawing.Size(151, 28);
            this.btn_modeEmp.TabIndex = 6;
            this.btn_modeEmp.Text = "Mode d\'emploi";
            this.btn_modeEmp.UseVisualStyleBackColor = false;
            this.btn_modeEmp.Click += new System.EventHandler(this.btn_modeEmp_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(991, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aide";
            // 
            // ViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1319, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_modeEmp);
            this.Controls.Add(this.btn_tableau);
            this.Controls.Add(this.btn_lexique);
            this.Controls.Add(this.btnForce_form);
            this.Controls.Add(this.btn_VerifForm);
            this.Controls.Add(this.dimMax_btn);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewHome";
            this.Load += new System.EventHandler(this.ViewHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dimMax_btn;
        private System.Windows.Forms.Button btn_VerifForm;
        private System.Windows.Forms.Button btnForce_form;
        private System.Windows.Forms.Button btn_lexique;
        private System.Windows.Forms.Button btn_tableau;
        private System.Windows.Forms.Button btn_modeEmp;
        private System.Windows.Forms.Label label2;
    }
}