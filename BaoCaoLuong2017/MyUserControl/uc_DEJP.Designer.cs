namespace BaoCaoLuong2017.MyUserControl
{
    partial class uc_DEJP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Truong_002 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong_002.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Trường 2:";
            // 
            // txt_Truong_002
            // 
            this.txt_Truong_002.Location = new System.Drawing.Point(2, 69);
            this.txt_Truong_002.Name = "txt_Truong_002";
            this.txt_Truong_002.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txt_Truong_002.Properties.Appearance.Options.UseFont = true;
            this.txt_Truong_002.Size = new System.Drawing.Size(533, 40);
            this.txt_Truong_002.TabIndex = 1;
            this.txt_Truong_002.EditValueChanged += new System.EventHandler(this.txt_Truong_002_EditValueChanged);
            // 
            // uc_DEJP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Truong_002);
            this.Controls.Add(this.labelControl1);
            this.Name = "uc_DEJP";
            this.Size = new System.Drawing.Size(538, 208);
            this.Load += new System.EventHandler(this.uc_DEJP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong_002.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Truong_002;
    }
}
