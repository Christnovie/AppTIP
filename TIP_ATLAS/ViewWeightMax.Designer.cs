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
            this.lsbTypebois = new System.Windows.Forms.ListBox();
            this.importCassDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTypebois = new System.Windows.Forms.TextBox();
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
            // lsbTypebois
            // 
            this.lsbTypebois.FormattingEnabled = true;
            this.lsbTypebois.Location = new System.Drawing.Point(28, 107);
            this.lsbTypebois.Name = "lsbTypebois";
            this.lsbTypebois.Size = new System.Drawing.Size(75, 212);
            this.lsbTypebois.TabIndex = 1;
            this.lsbTypebois.SelectedIndexChanged += new System.EventHandler(this.lsbTypebois_SelectedIndexChanged);
            // 
            // txtTypebois
            // 
            this.txtTypebois.Location = new System.Drawing.Point(28, 81);
            this.txtTypebois.Name = "txtTypebois";
            this.txtTypebois.Size = new System.Drawing.Size(201, 20);
            this.txtTypebois.TabIndex = 2;
            this.txtTypebois.TextChanged += new System.EventHandler(this.txtTypeBois_TextChanged);
            // 
            // ViewWeightMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(882, 511);
            this.ControlBox = false;
            this.Controls.Add(this.txtTypebois);
            this.Controls.Add(this.lsbTypebois);
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
        private System.Windows.Forms.ListBox lsbTypebois;
        private System.Windows.Forms.BindingSource importCassDataBindingSource;
        private System.Windows.Forms.TextBox txtTypebois;
    }
}