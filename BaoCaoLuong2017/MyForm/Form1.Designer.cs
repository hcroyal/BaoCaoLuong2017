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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.uc_Loai_21 = new BaoCaoLuong2017.MyUserControl.uc_Loai_2();
            this.uc_Loai_11 = new BaoCaoLuonng2017.MyUserControl.uc_Loai_1();
            this.uc_Loai_31 = new BaoCaoLuong2017.MyUserControl.uc_Loai_3();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(33, 229);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // uc_Loai_21
            // 
            this.uc_Loai_21.Location = new System.Drawing.Point(231, 95);
            this.uc_Loai_21.Name = "uc_Loai_21";
            this.uc_Loai_21.Size = new System.Drawing.Size(202, 105);
            this.uc_Loai_21.TabIndex = 2;
            // 
            // uc_Loai_11
            // 
            this.uc_Loai_11.Location = new System.Drawing.Point(230, 16);
            this.uc_Loai_11.Name = "uc_Loai_11";
            this.uc_Loai_11.Size = new System.Drawing.Size(198, 73);
            this.uc_Loai_11.TabIndex = 0;
            // 
            // uc_Loai_31
            // 
            this.uc_Loai_31.Location = new System.Drawing.Point(230, 206);
            this.uc_Loai_31.Name = "uc_Loai_31";
            this.uc_Loai_31.Size = new System.Drawing.Size(197, 77);
            this.uc_Loai_31.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 289);
            this.Controls.Add(this.uc_Loai_31);
            this.Controls.Add(this.uc_Loai_21);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.uc_Loai_11);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaoCaoLuonng2017.MyUserControl.uc_Loai_1 uc_Loai_11;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private MyUserControl.uc_Loai_2 uc_Loai_21;
        private MyUserControl.uc_Loai_3 uc_Loai_31;
    }
}