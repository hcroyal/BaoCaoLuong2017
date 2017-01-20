namespace BaoCaoLuonng2017.MyUserControl
{
    partial class uc_Loai_1
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
            this.txt_Truong_001 = new System.Windows.Forms.RichTextBox();
            this.txt_Truong_002 = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "1.";
            // 
            // txt_Truong_001
            // 
            this.txt_Truong_001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Truong_001.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Truong_001.Location = new System.Drawing.Point(20, 9);
            this.txt_Truong_001.Multiline = false;
            this.txt_Truong_001.Name = "txt_Truong_001";
            this.txt_Truong_001.Size = new System.Drawing.Size(174, 24);
            this.txt_Truong_001.TabIndex = 1;
            this.txt_Truong_001.Text = "";
            this.txt_Truong_001.TextChanged += new System.EventHandler(this.txt_Truong_001_TextChanged);
            this.txt_Truong_001.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Truong_001_KeyPress);
            // 
            // txt_Truong_002
            // 
            this.txt_Truong_002.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Truong_002.Enabled = false;
            this.txt_Truong_002.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Truong_002.Location = new System.Drawing.Point(20, 49);
            this.txt_Truong_002.Multiline = false;
            this.txt_Truong_002.Name = "txt_Truong_002";
            this.txt_Truong_002.Size = new System.Drawing.Size(174, 24);
            this.txt_Truong_002.TabIndex = 3;
            this.txt_Truong_002.Text = "";
            this.txt_Truong_002.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Truong_002_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "2.";
            // 
            // uc_Loai_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Truong_002);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_Truong_001);
            this.Controls.Add(this.labelControl1);
            this.Name = "uc_Loai_1";
            this.Size = new System.Drawing.Size(206, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.RichTextBox txt_Truong_001;
        public System.Windows.Forms.RichTextBox txt_Truong_002;
        public DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
