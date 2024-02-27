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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A.T.L.A.S.";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dimMax_btn
            // 
            this.dimMax_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.dimMax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimMax_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dimMax_btn.Location = new System.Drawing.Point(126, 215);
            this.dimMax_btn.Name = "dimMax_btn";
            this.dimMax_btn.Size = new System.Drawing.Size(169, 69);
            this.dimMax_btn.TabIndex = 1;
            this.dimMax_btn.Text = "Dimention Max";
            this.dimMax_btn.UseVisualStyleBackColor = false;
            this.dimMax_btn.UseWaitCursor = true;
            this.dimMax_btn.Click += new System.EventHandler(this.dimMax_btn_Click);
            this.dimMax_btn.MouseEnter += new System.EventHandler(this.dimMax_btn_MouseEnter);
            this.dimMax_btn.MouseLeave += new System.EventHandler(this.dimMax_btn_MouseLeave);
            // 
            // btn_VerifForm
            // 
            this.btn_VerifForm.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_VerifForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerifForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_VerifForm.Location = new System.Drawing.Point(126, 290);
            this.btn_VerifForm.Name = "btn_VerifForm";
            this.btn_VerifForm.Size = new System.Drawing.Size(169, 69);
            this.btn_VerifForm.TabIndex = 2;
            this.btn_VerifForm.Text = "Verifications";
            this.btn_VerifForm.UseVisualStyleBackColor = false;
            this.btn_VerifForm.UseWaitCursor = true;
            this.btn_VerifForm.Click += new System.EventHandler(this.btn_VerifForm_Click);
            // 
            // btnForce_form
            // 
            this.btnForce_form.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnForce_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForce_form.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnForce_form.Location = new System.Drawing.Point(126, 375);
            this.btnForce_form.Name = "btnForce_form";
            this.btnForce_form.Size = new System.Drawing.Size(169, 69);
            this.btnForce_form.TabIndex = 3;
            this.btnForce_form.Text = "Forces";
            this.btnForce_form.UseVisualStyleBackColor = false;
            this.btnForce_form.UseWaitCursor = true;
            this.btnForce_form.Click += new System.EventHandler(this.btnForce_form_Click);
            // 
            // ViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1319, 624);
            this.Controls.Add(this.btnForce_form);
            this.Controls.Add(this.btn_VerifForm);
            this.Controls.Add(this.dimMax_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewHome";
            this.Text = "7";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dimMax_btn;
        private System.Windows.Forms.Button btn_VerifForm;
        private System.Windows.Forms.Button btnForce_form;
    }
}