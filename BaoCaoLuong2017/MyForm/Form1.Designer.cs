namespace BaoCaoLuong2017.MyForm
{
    partial class Form1
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
            this.uc_Loai_11 = new BaoCaoLuonng2017.MyUserControl.uc_Loai_1();
            this.SuspendLayout();
            // 
            // uc_Loai_11
            // 
            this.uc_Loai_11.Location = new System.Drawing.Point(208, 103);
            this.uc_Loai_11.Name = "uc_Loai_11";
            this.uc_Loai_11.Size = new System.Drawing.Size(206, 86);
            this.uc_Loai_11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.uc_Loai_11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BaoCaoLuonng2017.MyUserControl.uc_Loai_1 uc_Loai_11;
    }
}