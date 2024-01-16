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
            this.label1 = new System.Windows.Forms.Label();
            this.dimMax_btn = new System.Windows.Forms.Button();
            this.btn_Verifmode = new System.Windows.Forms.Button();
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
            this.dimMax_btn.Location = new System.Drawing.Point(213, 272);
            this.dimMax_btn.Name = "dimMax_btn";
            this.dimMax_btn.Size = new System.Drawing.Size(121, 55);
            this.dimMax_btn.TabIndex = 1;
            this.dimMax_btn.Text = "Dimention Max";
            this.dimMax_btn.UseVisualStyleBackColor = true;
            this.dimMax_btn.UseWaitCursor = true;
            this.dimMax_btn.Click += new System.EventHandler(this.dimMax_btn_Click);
            this.dimMax_btn.MouseEnter += new System.EventHandler(this.dimMax_btn_MouseEnter);
            this.dimMax_btn.MouseLeave += new System.EventHandler(this.dimMax_btn_MouseLeave);
            // 
            // btn_Verifmode
            // 
            this.btn_Verifmode.Location = new System.Drawing.Point(529, 272);
            this.btn_Verifmode.Name = "btn_Verifmode";
            this.btn_Verifmode.Size = new System.Drawing.Size(121, 55);
            this.btn_Verifmode.TabIndex = 2;
            this.btn_Verifmode.Text = "Verfication";
            this.btn_Verifmode.UseVisualStyleBackColor = true;
            this.btn_Verifmode.UseWaitCursor = true;
            this.btn_Verifmode.MouseEnter += new System.EventHandler(this.btn_Verifmode_MouseEnter);
            this.btn_Verifmode.MouseLeave += new System.EventHandler(this.btn_Verifmode_MouseLeave);
            // 
            // ViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(882, 511);
            this.Controls.Add(this.btn_Verifmode);
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
        private System.Windows.Forms.Button btn_Verifmode;
    }
}