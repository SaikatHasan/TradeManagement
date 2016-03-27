namespace TradeManagement.Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private static frmLogin sForm = null;

        public static frmLogin Instance()
        {
            if (sForm == null) { sForm = new frmLogin(); }
            return sForm;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            sForm = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 57);
            this.panel1.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(384, 57);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Trade Management Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 54);
            this.panel2.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Courier New", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Location = new System.Drawing.Point(196, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(176, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "CopyRight © Alpha Soft";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(126)))), ((int)(((byte)(220)))));
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 125);
            this.panel3.TabIndex = 15;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(259, 81);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "&Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(224, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(110, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(166, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "&Password";
            // 
            // txtUserName
            // 
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(224, 24);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(110, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(166, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "&User Name";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::TradeManagement.Properties.Resources.trade_icon;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(12, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUserName;

    }
}