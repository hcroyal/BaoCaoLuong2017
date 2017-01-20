namespace BaoCaoLuong2017.MyUserControl
{
    partial class uc_Loai_2
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Truong_002 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Truong_003 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Truong_004 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong_002.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong_003.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong_004.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "2.";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(11, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "3.";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(8, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(11, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "4.";
            // 
            // txt_Truong_002
            // 
            this.txt_Truong_002.Location = new System.Drawing.Point(35, 9);
            this.txt_Truong_002.Name = "txt_Truong_002";
            this.txt_Truong_002.Properties.Mask.EditMask = "[0-9?]+";
            this.txt_Truong_002.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_Truong_002.Properties.MaxLength = 12;
            this.txt_Truong_002.Size = new System.Drawing.Size(153, 20);
            this.txt_Truong_002.TabIndex = 2;
            // 
            // txt_Truong_003
            // 
            this.txt_Truong_003.Location = new System.Drawing.Point(35, 40);
            this.txt_Truong_003.Name = "txt_Truong_003";
            this.txt_Truong_003.Properties.Mask.EditMask = "[0-9?]+";
            this.txt_Truong_003.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_Truong_003.Properties.MaxLength = 12;
            this.txt_Truong_003.Size = new System.Drawing.Size(153, 20);
            this.txt_Truong_003.TabIndex = 3;
            // 
            // txt_Truong_004
            // 
            this.txt_Truong_004.Location = new System.Drawing.Point(35, 71);
            this.txt_Truong_004.Name = "txt_Truong_004";
            this.txt_Truong_004.Properties.Mask.EditMask = "[0-9?]+";
            this.txt_Truong_004.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_Truong_004.Properties.MaxLength = 13;
            this.txt_Truong_004.Size = new System.Drawing.Size(153, 20);
            this.txt_Truong_004.TabIndex = 4;
            // 
            // uc_Loai_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Truong_004);
            this.Controls.Add(this.txt_Truong_003);
            this.Controls.Add(this.txt_Truong_002);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Name = "uc_Loai_2";
            this.Size = new System.Drawing.Size(197, 100);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong_002.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong_003.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong_004.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Truong_002;
        private DevExpress.XtraEditors.TextEdit txt_Truong_003;
        private DevExpress.XtraEditors.TextEdit txt_Truong_004;
    }
}
