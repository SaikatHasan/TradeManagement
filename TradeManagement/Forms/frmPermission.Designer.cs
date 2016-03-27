namespace TradeManagement.Forms
{
    partial class frmPermission
    {
        private System.ComponentModel.IContainer components = null;

        private static frmPermission sForm = null;

        public static frmPermission Instance()
        {
            if (sForm == null) { sForm = new frmPermission(); }
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
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkCstN = new DevExpress.XtraEditors.CheckEdit();
            this.chkCstE = new DevExpress.XtraEditors.CheckEdit();
            this.chkCstD = new DevExpress.XtraEditors.CheckEdit();
            this.chkSupN = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.chkSupE = new DevExpress.XtraEditors.CheckEdit();
            this.chkSupD = new DevExpress.XtraEditors.CheckEdit();
            this.chkPctN = new DevExpress.XtraEditors.CheckEdit();
            this.chkPctE = new DevExpress.XtraEditors.CheckEdit();
            this.chkPctD = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.chkCstV = new DevExpress.XtraEditors.CheckEdit();
            this.chkSupV = new DevExpress.XtraEditors.CheckEdit();
            this.chkPctV = new DevExpress.XtraEditors.CheckEdit();
            this.chkBndN = new DevExpress.XtraEditors.CheckEdit();
            this.chkBndE = new DevExpress.XtraEditors.CheckEdit();
            this.chkBndD = new DevExpress.XtraEditors.CheckEdit();
            this.chkBndV = new DevExpress.XtraEditors.CheckEdit();
            this.chkPdtN = new DevExpress.XtraEditors.CheckEdit();
            this.chkPdtE = new DevExpress.XtraEditors.CheckEdit();
            this.chkPdtD = new DevExpress.XtraEditors.CheckEdit();
            this.chkPdtV = new DevExpress.XtraEditors.CheckEdit();
            this.chkPurN = new DevExpress.XtraEditors.CheckEdit();
            this.chkPurE = new DevExpress.XtraEditors.CheckEdit();
            this.chkPurD = new DevExpress.XtraEditors.CheckEdit();
            this.chkPurV = new DevExpress.XtraEditors.CheckEdit();
            this.chkPrtN = new DevExpress.XtraEditors.CheckEdit();
            this.chkPrtE = new DevExpress.XtraEditors.CheckEdit();
            this.chkPrtD = new DevExpress.XtraEditors.CheckEdit();
            this.chkPrtV = new DevExpress.XtraEditors.CheckEdit();
            this.chkSlsN = new DevExpress.XtraEditors.CheckEdit();
            this.chkSlsE = new DevExpress.XtraEditors.CheckEdit();
            this.chkSlsD = new DevExpress.XtraEditors.CheckEdit();
            this.chkSlsV = new DevExpress.XtraEditors.CheckEdit();
            this.chkSrtN = new DevExpress.XtraEditors.CheckEdit();
            this.chkSrtE = new DevExpress.XtraEditors.CheckEdit();
            this.chkSrtD = new DevExpress.XtraEditors.CheckEdit();
            this.chkSrtV = new DevExpress.XtraEditors.CheckEdit();
            this.chkTopRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.chkIvtRepV = new DevExpress.XtraEditors.CheckEdit();
            this.chkPftRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.chkDpcRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.chkDexRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.chkAcrRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.chkAcpRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.chkSlsRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.chkPurRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.chkDpcN = new DevExpress.XtraEditors.CheckEdit();
            this.chkDpcE = new DevExpress.XtraEditors.CheckEdit();
            this.chkDpcD = new DevExpress.XtraEditors.CheckEdit();
            this.chkDpcV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.chkExpN = new DevExpress.XtraEditors.CheckEdit();
            this.chkExpE = new DevExpress.XtraEditors.CheckEdit();
            this.chkExpD = new DevExpress.XtraEditors.CheckEdit();
            this.chkExpV = new DevExpress.XtraEditors.CheckEdit();
            this.chkAcrE = new DevExpress.XtraEditors.CheckEdit();
            this.chkAcrN = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.chkAcrD = new DevExpress.XtraEditors.CheckEdit();
            this.chkAcrV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.chkAcpN = new DevExpress.XtraEditors.CheckEdit();
            this.chkAcpE = new DevExpress.XtraEditors.CheckEdit();
            this.chkAcpD = new DevExpress.XtraEditors.CheckEdit();
            this.chkAcpV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUserGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.chkQotN = new DevExpress.XtraEditors.CheckEdit();
            this.chkQotE = new DevExpress.XtraEditors.CheckEdit();
            this.chkQotD = new DevExpress.XtraEditors.CheckEdit();
            this.chkQotV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.chkEctN = new DevExpress.XtraEditors.CheckEdit();
            this.chkEctE = new DevExpress.XtraEditors.CheckEdit();
            this.chkEctD = new DevExpress.XtraEditors.CheckEdit();
            this.chkEctV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.chkWdcN = new DevExpress.XtraEditors.CheckEdit();
            this.chkWdcE = new DevExpress.XtraEditors.CheckEdit();
            this.chkWdcD = new DevExpress.XtraEditors.CheckEdit();
            this.chkWdcV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.chkPrtRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.chkSrtRepV = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.chkWdcRepV = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCstN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCstE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCstD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSupN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSupE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSupD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPctN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPctE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPctD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCstV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSupV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPctV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBndN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBndE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBndD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBndV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPdtN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPdtE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPdtD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPdtV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTopRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIvtRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPftRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDexRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQotN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQotE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQotD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQotV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEctN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEctE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEctD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEctV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtRepV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcRepV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 12);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(354, 50);
            this.grcCaption.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Location = new System.Drawing.Point(2, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(350, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Permission";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.xtraScrollableControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 68);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(354, 423);
            this.groupControl1.TabIndex = 1;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.tlpOptions);
            this.xtraScrollableControl1.Controls.Add(this.labelControl3);
            this.xtraScrollableControl1.Controls.Add(this.cmbUserGroup);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(350, 419);
            this.xtraScrollableControl1.TabIndex = 3;
            // 
            // tlpOptions
            // 
            this.tlpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpOptions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpOptions.ColumnCount = 5;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOptions.Controls.Add(this.labelControl1, 0, 1);
            this.tlpOptions.Controls.Add(this.chkCstN, 1, 1);
            this.tlpOptions.Controls.Add(this.chkCstE, 2, 1);
            this.tlpOptions.Controls.Add(this.chkCstD, 3, 1);
            this.tlpOptions.Controls.Add(this.chkSupN, 1, 2);
            this.tlpOptions.Controls.Add(this.labelControl2, 1, 0);
            this.tlpOptions.Controls.Add(this.labelControl4, 2, 0);
            this.tlpOptions.Controls.Add(this.labelControl5, 3, 0);
            this.tlpOptions.Controls.Add(this.labelControl6, 4, 0);
            this.tlpOptions.Controls.Add(this.chkSupE, 2, 2);
            this.tlpOptions.Controls.Add(this.chkSupD, 3, 2);
            this.tlpOptions.Controls.Add(this.chkPctN, 1, 3);
            this.tlpOptions.Controls.Add(this.chkPctE, 2, 3);
            this.tlpOptions.Controls.Add(this.chkPctD, 3, 3);
            this.tlpOptions.Controls.Add(this.labelControl7, 0, 2);
            this.tlpOptions.Controls.Add(this.labelControl8, 0, 3);
            this.tlpOptions.Controls.Add(this.labelControl9, 0, 4);
            this.tlpOptions.Controls.Add(this.labelControl10, 0, 5);
            this.tlpOptions.Controls.Add(this.labelControl12, 0, 6);
            this.tlpOptions.Controls.Add(this.labelControl13, 0, 7);
            this.tlpOptions.Controls.Add(this.labelControl14, 0, 8);
            this.tlpOptions.Controls.Add(this.labelControl15, 0, 9);
            this.tlpOptions.Controls.Add(this.chkCstV, 4, 1);
            this.tlpOptions.Controls.Add(this.chkSupV, 4, 2);
            this.tlpOptions.Controls.Add(this.chkPctV, 4, 3);
            this.tlpOptions.Controls.Add(this.chkBndN, 1, 4);
            this.tlpOptions.Controls.Add(this.chkBndE, 2, 4);
            this.tlpOptions.Controls.Add(this.chkBndD, 3, 4);
            this.tlpOptions.Controls.Add(this.chkBndV, 4, 4);
            this.tlpOptions.Controls.Add(this.chkPdtN, 1, 5);
            this.tlpOptions.Controls.Add(this.chkPdtE, 2, 5);
            this.tlpOptions.Controls.Add(this.chkPdtD, 3, 5);
            this.tlpOptions.Controls.Add(this.chkPdtV, 4, 5);
            this.tlpOptions.Controls.Add(this.chkPurN, 1, 6);
            this.tlpOptions.Controls.Add(this.chkPurE, 2, 6);
            this.tlpOptions.Controls.Add(this.chkPurD, 3, 6);
            this.tlpOptions.Controls.Add(this.chkPurV, 4, 6);
            this.tlpOptions.Controls.Add(this.chkPrtN, 1, 7);
            this.tlpOptions.Controls.Add(this.chkPrtE, 2, 7);
            this.tlpOptions.Controls.Add(this.chkPrtD, 3, 7);
            this.tlpOptions.Controls.Add(this.chkPrtV, 4, 7);
            this.tlpOptions.Controls.Add(this.chkSlsN, 1, 8);
            this.tlpOptions.Controls.Add(this.chkSlsE, 2, 8);
            this.tlpOptions.Controls.Add(this.chkSlsD, 3, 8);
            this.tlpOptions.Controls.Add(this.chkSlsV, 4, 8);
            this.tlpOptions.Controls.Add(this.chkSrtN, 1, 9);
            this.tlpOptions.Controls.Add(this.chkSrtE, 2, 9);
            this.tlpOptions.Controls.Add(this.chkSrtD, 3, 9);
            this.tlpOptions.Controls.Add(this.chkSrtV, 4, 9);
            this.tlpOptions.Controls.Add(this.labelControl11, 0, 17);
            this.tlpOptions.Controls.Add(this.chkPurRepV, 4, 17);
            this.tlpOptions.Controls.Add(this.labelControl17, 0, 15);
            this.tlpOptions.Controls.Add(this.chkDpcN, 1, 15);
            this.tlpOptions.Controls.Add(this.chkDpcE, 2, 15);
            this.tlpOptions.Controls.Add(this.chkDpcD, 3, 15);
            this.tlpOptions.Controls.Add(this.chkDpcV, 4, 15);
            this.tlpOptions.Controls.Add(this.labelControl16, 0, 14);
            this.tlpOptions.Controls.Add(this.chkExpN, 1, 14);
            this.tlpOptions.Controls.Add(this.chkExpE, 2, 14);
            this.tlpOptions.Controls.Add(this.chkExpD, 3, 14);
            this.tlpOptions.Controls.Add(this.chkExpV, 4, 14);
            this.tlpOptions.Controls.Add(this.chkAcrE, 2, 12);
            this.tlpOptions.Controls.Add(this.chkAcrN, 1, 12);
            this.tlpOptions.Controls.Add(this.labelControl25, 0, 12);
            this.tlpOptions.Controls.Add(this.chkAcrD, 3, 12);
            this.tlpOptions.Controls.Add(this.chkAcrV, 4, 12);
            this.tlpOptions.Controls.Add(this.labelControl24, 0, 11);
            this.tlpOptions.Controls.Add(this.chkAcpN, 1, 11);
            this.tlpOptions.Controls.Add(this.chkAcpE, 2, 11);
            this.tlpOptions.Controls.Add(this.chkAcpD, 3, 11);
            this.tlpOptions.Controls.Add(this.chkAcpV, 4, 11);
            this.tlpOptions.Controls.Add(this.labelControl18, 0, 10);
            this.tlpOptions.Controls.Add(this.chkQotN, 1, 10);
            this.tlpOptions.Controls.Add(this.chkQotE, 2, 10);
            this.tlpOptions.Controls.Add(this.chkQotD, 3, 10);
            this.tlpOptions.Controls.Add(this.chkQotV, 4, 10);
            this.tlpOptions.Controls.Add(this.labelControl29, 0, 13);
            this.tlpOptions.Controls.Add(this.chkEctN, 1, 13);
            this.tlpOptions.Controls.Add(this.chkEctE, 2, 13);
            this.tlpOptions.Controls.Add(this.chkEctD, 3, 13);
            this.tlpOptions.Controls.Add(this.chkEctV, 4, 13);
            this.tlpOptions.Controls.Add(this.labelControl30, 0, 16);
            this.tlpOptions.Controls.Add(this.chkWdcN, 1, 16);
            this.tlpOptions.Controls.Add(this.chkWdcE, 2, 16);
            this.tlpOptions.Controls.Add(this.chkWdcD, 3, 16);
            this.tlpOptions.Controls.Add(this.chkWdcV, 4, 16);
            this.tlpOptions.Controls.Add(this.labelControl28, 0, 28);
            this.tlpOptions.Controls.Add(this.labelControl23, 0, 27);
            this.tlpOptions.Controls.Add(this.labelControl22, 0, 26);
            this.tlpOptions.Controls.Add(this.chkTopRepV, 4, 28);
            this.tlpOptions.Controls.Add(this.chkPftRepV, 4, 27);
            this.tlpOptions.Controls.Add(this.chkIvtRepV, 4, 26);
            this.tlpOptions.Controls.Add(this.labelControl21, 0, 24);
            this.tlpOptions.Controls.Add(this.chkDpcRepV, 4, 24);
            this.tlpOptions.Controls.Add(this.labelControl20, 0, 23);
            this.tlpOptions.Controls.Add(this.chkDexRepV, 4, 23);
            this.tlpOptions.Controls.Add(this.labelControl27, 0, 22);
            this.tlpOptions.Controls.Add(this.labelControl26, 0, 21);
            this.tlpOptions.Controls.Add(this.chkAcrRepV, 4, 22);
            this.tlpOptions.Controls.Add(this.chkAcpRepV, 4, 21);
            this.tlpOptions.Controls.Add(this.labelControl19, 0, 19);
            this.tlpOptions.Controls.Add(this.chkSlsRepV, 4, 19);
            this.tlpOptions.Controls.Add(this.labelControl31, 0, 18);
            this.tlpOptions.Controls.Add(this.chkPrtRepV, 4, 18);
            this.tlpOptions.Controls.Add(this.labelControl32, 0, 20);
            this.tlpOptions.Controls.Add(this.chkSrtRepV, 4, 20);
            this.tlpOptions.Controls.Add(this.labelControl33, 0, 25);
            this.tlpOptions.Controls.Add(this.chkWdcRepV, 4, 25);
            this.tlpOptions.Location = new System.Drawing.Point(3, 29);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.RowCount = 29;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOptions.Size = new System.Drawing.Size(327, 784);
            this.tlpOptions.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(5, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Customers";
            // 
            // chkCstN
            // 
            this.chkCstN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCstN.Location = new System.Drawing.Point(127, 32);
            this.chkCstN.Name = "chkCstN";
            this.chkCstN.Properties.Caption = "";
            this.chkCstN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkCstN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkCstN.Size = new System.Drawing.Size(42, 19);
            this.chkCstN.TabIndex = 5;
            // 
            // chkCstE
            // 
            this.chkCstE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCstE.Location = new System.Drawing.Point(177, 32);
            this.chkCstE.Name = "chkCstE";
            this.chkCstE.Properties.Caption = "";
            this.chkCstE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkCstE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkCstE.Size = new System.Drawing.Size(42, 19);
            this.chkCstE.TabIndex = 6;
            // 
            // chkCstD
            // 
            this.chkCstD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCstD.Location = new System.Drawing.Point(227, 32);
            this.chkCstD.Name = "chkCstD";
            this.chkCstD.Properties.Caption = "";
            this.chkCstD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkCstD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkCstD.Size = new System.Drawing.Size(42, 19);
            this.chkCstD.TabIndex = 7;
            // 
            // chkSupN
            // 
            this.chkSupN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSupN.Location = new System.Drawing.Point(127, 59);
            this.chkSupN.Name = "chkSupN";
            this.chkSupN.Properties.Caption = "";
            this.chkSupN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSupN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSupN.Size = new System.Drawing.Size(42, 19);
            this.chkSupN.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(127, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "New";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(177, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 19);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Edit";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(227, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 19);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Delete";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(277, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 19);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "View";
            // 
            // chkSupE
            // 
            this.chkSupE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSupE.Location = new System.Drawing.Point(177, 59);
            this.chkSupE.Name = "chkSupE";
            this.chkSupE.Properties.Caption = "";
            this.chkSupE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSupE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSupE.Size = new System.Drawing.Size(42, 19);
            this.chkSupE.TabIndex = 11;
            // 
            // chkSupD
            // 
            this.chkSupD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSupD.Location = new System.Drawing.Point(227, 59);
            this.chkSupD.Name = "chkSupD";
            this.chkSupD.Properties.Caption = "";
            this.chkSupD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSupD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSupD.Size = new System.Drawing.Size(42, 19);
            this.chkSupD.TabIndex = 12;
            // 
            // chkPctN
            // 
            this.chkPctN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPctN.Location = new System.Drawing.Point(127, 86);
            this.chkPctN.Name = "chkPctN";
            this.chkPctN.Properties.Caption = "";
            this.chkPctN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPctN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPctN.Size = new System.Drawing.Size(42, 19);
            this.chkPctN.TabIndex = 15;
            // 
            // chkPctE
            // 
            this.chkPctE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPctE.Location = new System.Drawing.Point(177, 86);
            this.chkPctE.Name = "chkPctE";
            this.chkPctE.Properties.Caption = "";
            this.chkPctE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPctE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPctE.Size = new System.Drawing.Size(42, 19);
            this.chkPctE.TabIndex = 16;
            // 
            // chkPctD
            // 
            this.chkPctD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPctD.Location = new System.Drawing.Point(227, 86);
            this.chkPctD.Name = "chkPctD";
            this.chkPctD.Properties.Caption = "";
            this.chkPctD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPctD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPctD.Size = new System.Drawing.Size(42, 19);
            this.chkPctD.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl7.Location = new System.Drawing.Point(5, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(114, 19);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Suppliers";
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl8.Location = new System.Drawing.Point(5, 86);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(114, 19);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Categories";
            // 
            // labelControl9
            // 
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl9.Location = new System.Drawing.Point(5, 113);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(114, 19);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Brands";
            // 
            // labelControl10
            // 
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl10.Location = new System.Drawing.Point(5, 140);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(114, 19);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Products";
            // 
            // labelControl12
            // 
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl12.Location = new System.Drawing.Point(5, 167);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(114, 19);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "Purchase";
            // 
            // labelControl13
            // 
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl13.Location = new System.Drawing.Point(5, 194);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(114, 19);
            this.labelControl13.TabIndex = 34;
            this.labelControl13.Text = "Purchase Return";
            // 
            // labelControl14
            // 
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl14.Location = new System.Drawing.Point(5, 221);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(114, 19);
            this.labelControl14.TabIndex = 39;
            this.labelControl14.Text = "Sales";
            // 
            // labelControl15
            // 
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.Location = new System.Drawing.Point(5, 248);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(114, 19);
            this.labelControl15.TabIndex = 44;
            this.labelControl15.Text = "Sales Return";
            // 
            // chkCstV
            // 
            this.chkCstV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCstV.Location = new System.Drawing.Point(277, 32);
            this.chkCstV.Name = "chkCstV";
            this.chkCstV.Properties.Caption = "";
            this.chkCstV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkCstV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkCstV.Size = new System.Drawing.Size(45, 19);
            this.chkCstV.TabIndex = 8;
            // 
            // chkSupV
            // 
            this.chkSupV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSupV.Location = new System.Drawing.Point(277, 59);
            this.chkSupV.Name = "chkSupV";
            this.chkSupV.Properties.Caption = "";
            this.chkSupV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSupV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSupV.Size = new System.Drawing.Size(45, 19);
            this.chkSupV.TabIndex = 13;
            // 
            // chkPctV
            // 
            this.chkPctV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPctV.Location = new System.Drawing.Point(277, 86);
            this.chkPctV.Name = "chkPctV";
            this.chkPctV.Properties.Caption = "";
            this.chkPctV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPctV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPctV.Size = new System.Drawing.Size(45, 19);
            this.chkPctV.TabIndex = 18;
            // 
            // chkBndN
            // 
            this.chkBndN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBndN.Location = new System.Drawing.Point(127, 113);
            this.chkBndN.Name = "chkBndN";
            this.chkBndN.Properties.Caption = "";
            this.chkBndN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkBndN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkBndN.Size = new System.Drawing.Size(42, 19);
            this.chkBndN.TabIndex = 20;
            // 
            // chkBndE
            // 
            this.chkBndE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBndE.Location = new System.Drawing.Point(177, 113);
            this.chkBndE.Name = "chkBndE";
            this.chkBndE.Properties.Caption = "";
            this.chkBndE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkBndE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkBndE.Size = new System.Drawing.Size(42, 19);
            this.chkBndE.TabIndex = 21;
            // 
            // chkBndD
            // 
            this.chkBndD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBndD.Location = new System.Drawing.Point(227, 113);
            this.chkBndD.Name = "chkBndD";
            this.chkBndD.Properties.Caption = "";
            this.chkBndD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkBndD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkBndD.Size = new System.Drawing.Size(42, 19);
            this.chkBndD.TabIndex = 22;
            // 
            // chkBndV
            // 
            this.chkBndV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBndV.Location = new System.Drawing.Point(277, 113);
            this.chkBndV.Name = "chkBndV";
            this.chkBndV.Properties.Caption = "";
            this.chkBndV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkBndV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkBndV.Size = new System.Drawing.Size(45, 19);
            this.chkBndV.TabIndex = 23;
            // 
            // chkPdtN
            // 
            this.chkPdtN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPdtN.Location = new System.Drawing.Point(127, 140);
            this.chkPdtN.Name = "chkPdtN";
            this.chkPdtN.Properties.Caption = "";
            this.chkPdtN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPdtN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPdtN.Size = new System.Drawing.Size(42, 19);
            this.chkPdtN.TabIndex = 25;
            // 
            // chkPdtE
            // 
            this.chkPdtE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPdtE.Location = new System.Drawing.Point(177, 140);
            this.chkPdtE.Name = "chkPdtE";
            this.chkPdtE.Properties.Caption = "";
            this.chkPdtE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPdtE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPdtE.Size = new System.Drawing.Size(42, 19);
            this.chkPdtE.TabIndex = 26;
            // 
            // chkPdtD
            // 
            this.chkPdtD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPdtD.Location = new System.Drawing.Point(227, 140);
            this.chkPdtD.Name = "chkPdtD";
            this.chkPdtD.Properties.Caption = "";
            this.chkPdtD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPdtD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPdtD.Size = new System.Drawing.Size(42, 19);
            this.chkPdtD.TabIndex = 27;
            // 
            // chkPdtV
            // 
            this.chkPdtV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPdtV.Location = new System.Drawing.Point(277, 140);
            this.chkPdtV.Name = "chkPdtV";
            this.chkPdtV.Properties.Caption = "";
            this.chkPdtV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPdtV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPdtV.Size = new System.Drawing.Size(45, 19);
            this.chkPdtV.TabIndex = 28;
            // 
            // chkPurN
            // 
            this.chkPurN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPurN.Location = new System.Drawing.Point(127, 167);
            this.chkPurN.Name = "chkPurN";
            this.chkPurN.Properties.Caption = "";
            this.chkPurN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPurN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPurN.Size = new System.Drawing.Size(42, 19);
            this.chkPurN.TabIndex = 30;
            // 
            // chkPurE
            // 
            this.chkPurE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPurE.Location = new System.Drawing.Point(177, 167);
            this.chkPurE.Name = "chkPurE";
            this.chkPurE.Properties.Caption = "";
            this.chkPurE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPurE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPurE.Size = new System.Drawing.Size(42, 19);
            this.chkPurE.TabIndex = 31;
            // 
            // chkPurD
            // 
            this.chkPurD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPurD.Location = new System.Drawing.Point(227, 167);
            this.chkPurD.Name = "chkPurD";
            this.chkPurD.Properties.Caption = "";
            this.chkPurD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPurD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPurD.Size = new System.Drawing.Size(42, 19);
            this.chkPurD.TabIndex = 32;
            // 
            // chkPurV
            // 
            this.chkPurV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPurV.Location = new System.Drawing.Point(277, 167);
            this.chkPurV.Name = "chkPurV";
            this.chkPurV.Properties.Caption = "";
            this.chkPurV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPurV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPurV.Size = new System.Drawing.Size(45, 19);
            this.chkPurV.TabIndex = 33;
            // 
            // chkPrtN
            // 
            this.chkPrtN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPrtN.Location = new System.Drawing.Point(127, 194);
            this.chkPrtN.Name = "chkPrtN";
            this.chkPrtN.Properties.Caption = "";
            this.chkPrtN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPrtN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPrtN.Size = new System.Drawing.Size(42, 19);
            this.chkPrtN.TabIndex = 35;
            // 
            // chkPrtE
            // 
            this.chkPrtE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPrtE.Location = new System.Drawing.Point(177, 194);
            this.chkPrtE.Name = "chkPrtE";
            this.chkPrtE.Properties.Caption = "";
            this.chkPrtE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPrtE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPrtE.Size = new System.Drawing.Size(42, 19);
            this.chkPrtE.TabIndex = 36;
            // 
            // chkPrtD
            // 
            this.chkPrtD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPrtD.Location = new System.Drawing.Point(227, 194);
            this.chkPrtD.Name = "chkPrtD";
            this.chkPrtD.Properties.Caption = "";
            this.chkPrtD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPrtD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPrtD.Size = new System.Drawing.Size(42, 19);
            this.chkPrtD.TabIndex = 37;
            // 
            // chkPrtV
            // 
            this.chkPrtV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPrtV.Location = new System.Drawing.Point(277, 194);
            this.chkPrtV.Name = "chkPrtV";
            this.chkPrtV.Properties.Caption = "";
            this.chkPrtV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPrtV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPrtV.Size = new System.Drawing.Size(45, 19);
            this.chkPrtV.TabIndex = 38;
            // 
            // chkSlsN
            // 
            this.chkSlsN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSlsN.Location = new System.Drawing.Point(127, 221);
            this.chkSlsN.Name = "chkSlsN";
            this.chkSlsN.Properties.Caption = "";
            this.chkSlsN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSlsN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSlsN.Size = new System.Drawing.Size(42, 19);
            this.chkSlsN.TabIndex = 40;
            // 
            // chkSlsE
            // 
            this.chkSlsE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSlsE.Location = new System.Drawing.Point(177, 221);
            this.chkSlsE.Name = "chkSlsE";
            this.chkSlsE.Properties.Caption = "";
            this.chkSlsE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSlsE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSlsE.Size = new System.Drawing.Size(42, 19);
            this.chkSlsE.TabIndex = 41;
            // 
            // chkSlsD
            // 
            this.chkSlsD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSlsD.Location = new System.Drawing.Point(227, 221);
            this.chkSlsD.Name = "chkSlsD";
            this.chkSlsD.Properties.Caption = "";
            this.chkSlsD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSlsD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSlsD.Size = new System.Drawing.Size(42, 19);
            this.chkSlsD.TabIndex = 42;
            // 
            // chkSlsV
            // 
            this.chkSlsV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSlsV.Location = new System.Drawing.Point(277, 221);
            this.chkSlsV.Name = "chkSlsV";
            this.chkSlsV.Properties.Caption = "";
            this.chkSlsV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSlsV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSlsV.Size = new System.Drawing.Size(45, 19);
            this.chkSlsV.TabIndex = 43;
            // 
            // chkSrtN
            // 
            this.chkSrtN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSrtN.Location = new System.Drawing.Point(127, 248);
            this.chkSrtN.Name = "chkSrtN";
            this.chkSrtN.Properties.Caption = "";
            this.chkSrtN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSrtN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSrtN.Size = new System.Drawing.Size(42, 19);
            this.chkSrtN.TabIndex = 45;
            // 
            // chkSrtE
            // 
            this.chkSrtE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSrtE.Location = new System.Drawing.Point(177, 248);
            this.chkSrtE.Name = "chkSrtE";
            this.chkSrtE.Properties.Caption = "";
            this.chkSrtE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSrtE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSrtE.Size = new System.Drawing.Size(42, 19);
            this.chkSrtE.TabIndex = 46;
            // 
            // chkSrtD
            // 
            this.chkSrtD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSrtD.Location = new System.Drawing.Point(227, 248);
            this.chkSrtD.Name = "chkSrtD";
            this.chkSrtD.Properties.Caption = "";
            this.chkSrtD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSrtD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSrtD.Size = new System.Drawing.Size(42, 19);
            this.chkSrtD.TabIndex = 47;
            // 
            // chkSrtV
            // 
            this.chkSrtV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSrtV.Location = new System.Drawing.Point(277, 248);
            this.chkSrtV.Name = "chkSrtV";
            this.chkSrtV.Properties.Caption = "";
            this.chkSrtV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSrtV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSrtV.Size = new System.Drawing.Size(45, 19);
            this.chkSrtV.TabIndex = 48;
            // 
            // chkTopRepV
            // 
            this.chkTopRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTopRepV.Location = new System.Drawing.Point(277, 761);
            this.chkTopRepV.Name = "chkTopRepV";
            this.chkTopRepV.Properties.Caption = "";
            this.chkTopRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkTopRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkTopRepV.Size = new System.Drawing.Size(45, 19);
            this.chkTopRepV.TabIndex = 91;
            // 
            // labelControl28
            // 
            this.labelControl28.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl28.Location = new System.Drawing.Point(5, 761);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(114, 19);
            this.labelControl28.TabIndex = 92;
            this.labelControl28.Text = "Top 10 Products Report";
            // 
            // labelControl22
            // 
            this.labelControl22.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl22.Location = new System.Drawing.Point(5, 707);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(114, 19);
            this.labelControl22.TabIndex = 90;
            this.labelControl22.Text = "Inventory";
            // 
            // chkIvtRepV
            // 
            this.chkIvtRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkIvtRepV.Location = new System.Drawing.Point(277, 707);
            this.chkIvtRepV.Name = "chkIvtRepV";
            this.chkIvtRepV.Properties.Caption = "";
            this.chkIvtRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkIvtRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkIvtRepV.Size = new System.Drawing.Size(45, 19);
            this.chkIvtRepV.TabIndex = 93;
            // 
            // chkPftRepV
            // 
            this.chkPftRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPftRepV.Location = new System.Drawing.Point(277, 734);
            this.chkPftRepV.Name = "chkPftRepV";
            this.chkPftRepV.Properties.Caption = "";
            this.chkPftRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPftRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPftRepV.Size = new System.Drawing.Size(45, 19);
            this.chkPftRepV.TabIndex = 75;
            // 
            // labelControl23
            // 
            this.labelControl23.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl23.Location = new System.Drawing.Point(5, 734);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(114, 19);
            this.labelControl23.TabIndex = 74;
            this.labelControl23.Text = "Profit Report";
            // 
            // labelControl21
            // 
            this.labelControl21.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl21.Location = new System.Drawing.Point(5, 653);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(114, 19);
            this.labelControl21.TabIndex = 70;
            this.labelControl21.Text = "Deposit Cash Report";
            // 
            // chkDpcRepV
            // 
            this.chkDpcRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDpcRepV.Location = new System.Drawing.Point(277, 653);
            this.chkDpcRepV.Name = "chkDpcRepV";
            this.chkDpcRepV.Properties.Caption = "";
            this.chkDpcRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkDpcRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkDpcRepV.Size = new System.Drawing.Size(45, 19);
            this.chkDpcRepV.TabIndex = 71;
            // 
            // labelControl20
            // 
            this.labelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl20.Location = new System.Drawing.Point(5, 626);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(114, 19);
            this.labelControl20.TabIndex = 68;
            this.labelControl20.Text = "Expenses Report";
            // 
            // chkDexRepV
            // 
            this.chkDexRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDexRepV.Location = new System.Drawing.Point(277, 626);
            this.chkDexRepV.Name = "chkDexRepV";
            this.chkDexRepV.Properties.Caption = "";
            this.chkDexRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkDexRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkDexRepV.Size = new System.Drawing.Size(45, 19);
            this.chkDexRepV.TabIndex = 69;
            // 
            // labelControl27
            // 
            this.labelControl27.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl27.Location = new System.Drawing.Point(5, 599);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(114, 19);
            this.labelControl27.TabIndex = 87;
            this.labelControl27.Text = "Acc. Receivable Report";
            // 
            // chkAcrRepV
            // 
            this.chkAcrRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcrRepV.Location = new System.Drawing.Point(277, 599);
            this.chkAcrRepV.Name = "chkAcrRepV";
            this.chkAcrRepV.Properties.Caption = "";
            this.chkAcrRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcrRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcrRepV.Size = new System.Drawing.Size(45, 19);
            this.chkAcrRepV.TabIndex = 89;
            // 
            // labelControl26
            // 
            this.labelControl26.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl26.Location = new System.Drawing.Point(5, 572);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(114, 19);
            this.labelControl26.TabIndex = 86;
            this.labelControl26.Text = "Acc. Payable Report";
            // 
            // chkAcpRepV
            // 
            this.chkAcpRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcpRepV.Location = new System.Drawing.Point(277, 572);
            this.chkAcpRepV.Name = "chkAcpRepV";
            this.chkAcpRepV.Properties.Caption = "";
            this.chkAcpRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcpRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcpRepV.Size = new System.Drawing.Size(45, 19);
            this.chkAcpRepV.TabIndex = 88;
            // 
            // labelControl19
            // 
            this.labelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl19.Location = new System.Drawing.Point(5, 518);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(114, 19);
            this.labelControl19.TabIndex = 66;
            this.labelControl19.Text = "Sales Report";
            // 
            // chkSlsRepV
            // 
            this.chkSlsRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSlsRepV.Location = new System.Drawing.Point(277, 518);
            this.chkSlsRepV.Name = "chkSlsRepV";
            this.chkSlsRepV.Properties.Caption = "";
            this.chkSlsRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSlsRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSlsRepV.Size = new System.Drawing.Size(45, 19);
            this.chkSlsRepV.TabIndex = 67;
            // 
            // labelControl11
            // 
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl11.Location = new System.Drawing.Point(5, 464);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(114, 19);
            this.labelControl11.TabIndex = 64;
            this.labelControl11.Text = "Purchase Report";
            // 
            // chkPurRepV
            // 
            this.chkPurRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPurRepV.Location = new System.Drawing.Point(277, 464);
            this.chkPurRepV.Name = "chkPurRepV";
            this.chkPurRepV.Properties.Caption = "";
            this.chkPurRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPurRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPurRepV.Size = new System.Drawing.Size(45, 19);
            this.chkPurRepV.TabIndex = 65;
            // 
            // labelControl17
            // 
            this.labelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl17.Location = new System.Drawing.Point(5, 410);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(114, 19);
            this.labelControl17.TabIndex = 54;
            this.labelControl17.Text = "Deposit Cash";
            // 
            // chkDpcN
            // 
            this.chkDpcN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDpcN.Location = new System.Drawing.Point(127, 410);
            this.chkDpcN.Name = "chkDpcN";
            this.chkDpcN.Properties.Caption = "";
            this.chkDpcN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkDpcN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkDpcN.Size = new System.Drawing.Size(42, 19);
            this.chkDpcN.TabIndex = 55;
            // 
            // chkDpcE
            // 
            this.chkDpcE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDpcE.Location = new System.Drawing.Point(177, 410);
            this.chkDpcE.Name = "chkDpcE";
            this.chkDpcE.Properties.Caption = "";
            this.chkDpcE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkDpcE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkDpcE.Size = new System.Drawing.Size(42, 19);
            this.chkDpcE.TabIndex = 56;
            // 
            // chkDpcD
            // 
            this.chkDpcD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDpcD.Location = new System.Drawing.Point(227, 410);
            this.chkDpcD.Name = "chkDpcD";
            this.chkDpcD.Properties.Caption = "";
            this.chkDpcD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkDpcD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkDpcD.Size = new System.Drawing.Size(42, 19);
            this.chkDpcD.TabIndex = 57;
            // 
            // chkDpcV
            // 
            this.chkDpcV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDpcV.Location = new System.Drawing.Point(277, 410);
            this.chkDpcV.Name = "chkDpcV";
            this.chkDpcV.Properties.Caption = "";
            this.chkDpcV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkDpcV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkDpcV.Size = new System.Drawing.Size(45, 19);
            this.chkDpcV.TabIndex = 58;
            // 
            // labelControl16
            // 
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl16.Location = new System.Drawing.Point(5, 383);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(114, 19);
            this.labelControl16.TabIndex = 49;
            this.labelControl16.Text = "Expenses";
            // 
            // chkExpN
            // 
            this.chkExpN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkExpN.Location = new System.Drawing.Point(127, 383);
            this.chkExpN.Name = "chkExpN";
            this.chkExpN.Properties.Caption = "";
            this.chkExpN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkExpN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkExpN.Size = new System.Drawing.Size(42, 19);
            this.chkExpN.TabIndex = 50;
            // 
            // chkExpE
            // 
            this.chkExpE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkExpE.Location = new System.Drawing.Point(177, 383);
            this.chkExpE.Name = "chkExpE";
            this.chkExpE.Properties.Caption = "";
            this.chkExpE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkExpE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkExpE.Size = new System.Drawing.Size(42, 19);
            this.chkExpE.TabIndex = 51;
            // 
            // chkExpD
            // 
            this.chkExpD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkExpD.Location = new System.Drawing.Point(227, 383);
            this.chkExpD.Name = "chkExpD";
            this.chkExpD.Properties.Caption = "";
            this.chkExpD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkExpD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkExpD.Size = new System.Drawing.Size(42, 19);
            this.chkExpD.TabIndex = 52;
            // 
            // chkExpV
            // 
            this.chkExpV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkExpV.Location = new System.Drawing.Point(277, 383);
            this.chkExpV.Name = "chkExpV";
            this.chkExpV.Properties.Caption = "";
            this.chkExpV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkExpV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkExpV.Size = new System.Drawing.Size(45, 19);
            this.chkExpV.TabIndex = 53;
            // 
            // chkAcrE
            // 
            this.chkAcrE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcrE.Location = new System.Drawing.Point(177, 329);
            this.chkAcrE.Name = "chkAcrE";
            this.chkAcrE.Properties.Caption = "";
            this.chkAcrE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcrE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcrE.Size = new System.Drawing.Size(42, 19);
            this.chkAcrE.TabIndex = 83;
            // 
            // chkAcrN
            // 
            this.chkAcrN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcrN.Location = new System.Drawing.Point(127, 329);
            this.chkAcrN.Name = "chkAcrN";
            this.chkAcrN.Properties.Caption = "";
            this.chkAcrN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcrN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcrN.Size = new System.Drawing.Size(42, 19);
            this.chkAcrN.TabIndex = 82;
            // 
            // labelControl25
            // 
            this.labelControl25.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl25.Location = new System.Drawing.Point(5, 329);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(114, 19);
            this.labelControl25.TabIndex = 77;
            this.labelControl25.Text = "Accounts Receivable";
            // 
            // chkAcrD
            // 
            this.chkAcrD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcrD.Location = new System.Drawing.Point(227, 329);
            this.chkAcrD.Name = "chkAcrD";
            this.chkAcrD.Properties.Caption = "";
            this.chkAcrD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcrD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcrD.Size = new System.Drawing.Size(42, 19);
            this.chkAcrD.TabIndex = 84;
            // 
            // chkAcrV
            // 
            this.chkAcrV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcrV.Location = new System.Drawing.Point(277, 329);
            this.chkAcrV.Name = "chkAcrV";
            this.chkAcrV.Properties.Caption = "";
            this.chkAcrV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcrV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcrV.Size = new System.Drawing.Size(45, 19);
            this.chkAcrV.TabIndex = 85;
            // 
            // labelControl24
            // 
            this.labelControl24.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl24.Location = new System.Drawing.Point(5, 302);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(114, 19);
            this.labelControl24.TabIndex = 76;
            this.labelControl24.Text = "Accounts Payable";
            // 
            // chkAcpN
            // 
            this.chkAcpN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcpN.Location = new System.Drawing.Point(127, 302);
            this.chkAcpN.Name = "chkAcpN";
            this.chkAcpN.Properties.Caption = "";
            this.chkAcpN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcpN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcpN.Size = new System.Drawing.Size(42, 19);
            this.chkAcpN.TabIndex = 78;
            // 
            // chkAcpE
            // 
            this.chkAcpE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcpE.Location = new System.Drawing.Point(177, 302);
            this.chkAcpE.Name = "chkAcpE";
            this.chkAcpE.Properties.Caption = "";
            this.chkAcpE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcpE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcpE.Size = new System.Drawing.Size(42, 19);
            this.chkAcpE.TabIndex = 79;
            // 
            // chkAcpD
            // 
            this.chkAcpD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcpD.Location = new System.Drawing.Point(227, 302);
            this.chkAcpD.Name = "chkAcpD";
            this.chkAcpD.Properties.Caption = "";
            this.chkAcpD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcpD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcpD.Size = new System.Drawing.Size(42, 19);
            this.chkAcpD.TabIndex = 80;
            // 
            // chkAcpV
            // 
            this.chkAcpV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAcpV.Location = new System.Drawing.Point(277, 302);
            this.chkAcpV.Name = "chkAcpV";
            this.chkAcpV.Properties.Caption = "";
            this.chkAcpV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkAcpV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkAcpV.Size = new System.Drawing.Size(45, 19);
            this.chkAcpV.TabIndex = 81;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "User Group";
            // 
            // cmbUserGroup
            // 
            this.cmbUserGroup.Location = new System.Drawing.Point(113, 3);
            this.cmbUserGroup.Name = "cmbUserGroup";
            this.cmbUserGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserGroup.Properties.PopupSizeable = true;
            this.cmbUserGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbUserGroup.Size = new System.Drawing.Size(172, 20);
            this.cmbUserGroup.TabIndex = 4;
            this.cmbUserGroup.SelectedIndexChanged += new System.EventHandler(this.cmbUserGroup_EditValueChanged);
            // 
            // labelControl18
            // 
            this.labelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl18.Location = new System.Drawing.Point(5, 275);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(114, 19);
            this.labelControl18.TabIndex = 94;
            this.labelControl18.Text = "Quatation";
            // 
            // chkQotN
            // 
            this.chkQotN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkQotN.Location = new System.Drawing.Point(127, 275);
            this.chkQotN.Name = "chkQotN";
            this.chkQotN.Properties.Caption = "";
            this.chkQotN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkQotN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkQotN.Size = new System.Drawing.Size(42, 19);
            this.chkQotN.TabIndex = 95;
            // 
            // chkQotE
            // 
            this.chkQotE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkQotE.Location = new System.Drawing.Point(177, 275);
            this.chkQotE.Name = "chkQotE";
            this.chkQotE.Properties.Caption = "";
            this.chkQotE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkQotE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkQotE.Size = new System.Drawing.Size(42, 19);
            this.chkQotE.TabIndex = 96;
            // 
            // chkQotD
            // 
            this.chkQotD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkQotD.Location = new System.Drawing.Point(227, 275);
            this.chkQotD.Name = "chkQotD";
            this.chkQotD.Properties.Caption = "";
            this.chkQotD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkQotD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkQotD.Size = new System.Drawing.Size(42, 19);
            this.chkQotD.TabIndex = 97;
            // 
            // chkQotV
            // 
            this.chkQotV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkQotV.Location = new System.Drawing.Point(277, 275);
            this.chkQotV.Name = "chkQotV";
            this.chkQotV.Properties.Caption = "";
            this.chkQotV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkQotV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkQotV.Size = new System.Drawing.Size(45, 19);
            this.chkQotV.TabIndex = 98;
            // 
            // labelControl29
            // 
            this.labelControl29.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl29.Location = new System.Drawing.Point(5, 356);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(114, 19);
            this.labelControl29.TabIndex = 99;
            this.labelControl29.Text = "Expense Categories";
            // 
            // chkEctN
            // 
            this.chkEctN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEctN.Location = new System.Drawing.Point(127, 356);
            this.chkEctN.Name = "chkEctN";
            this.chkEctN.Properties.Caption = "";
            this.chkEctN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkEctN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkEctN.Size = new System.Drawing.Size(42, 19);
            this.chkEctN.TabIndex = 100;
            // 
            // chkEctE
            // 
            this.chkEctE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEctE.Location = new System.Drawing.Point(177, 356);
            this.chkEctE.Name = "chkEctE";
            this.chkEctE.Properties.Caption = "";
            this.chkEctE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkEctE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkEctE.Size = new System.Drawing.Size(42, 19);
            this.chkEctE.TabIndex = 101;
            // 
            // chkEctD
            // 
            this.chkEctD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEctD.Location = new System.Drawing.Point(227, 356);
            this.chkEctD.Name = "chkEctD";
            this.chkEctD.Properties.Caption = "";
            this.chkEctD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkEctD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkEctD.Size = new System.Drawing.Size(42, 19);
            this.chkEctD.TabIndex = 102;
            // 
            // chkEctV
            // 
            this.chkEctV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEctV.Location = new System.Drawing.Point(277, 356);
            this.chkEctV.Name = "chkEctV";
            this.chkEctV.Properties.Caption = "";
            this.chkEctV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkEctV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkEctV.Size = new System.Drawing.Size(45, 19);
            this.chkEctV.TabIndex = 103;
            // 
            // labelControl30
            // 
            this.labelControl30.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl30.Location = new System.Drawing.Point(5, 437);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(114, 19);
            this.labelControl30.TabIndex = 104;
            this.labelControl30.Text = "Withdraw Cash";
            // 
            // chkWdcN
            // 
            this.chkWdcN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWdcN.Location = new System.Drawing.Point(127, 437);
            this.chkWdcN.Name = "chkWdcN";
            this.chkWdcN.Properties.Caption = "";
            this.chkWdcN.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkWdcN.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkWdcN.Size = new System.Drawing.Size(42, 19);
            this.chkWdcN.TabIndex = 105;
            // 
            // chkWdcE
            // 
            this.chkWdcE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWdcE.Location = new System.Drawing.Point(177, 437);
            this.chkWdcE.Name = "chkWdcE";
            this.chkWdcE.Properties.Caption = "";
            this.chkWdcE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkWdcE.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkWdcE.Size = new System.Drawing.Size(42, 19);
            this.chkWdcE.TabIndex = 106;
            // 
            // chkWdcD
            // 
            this.chkWdcD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWdcD.Location = new System.Drawing.Point(227, 437);
            this.chkWdcD.Name = "chkWdcD";
            this.chkWdcD.Properties.Caption = "";
            this.chkWdcD.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkWdcD.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkWdcD.Size = new System.Drawing.Size(42, 19);
            this.chkWdcD.TabIndex = 107;
            // 
            // chkWdcV
            // 
            this.chkWdcV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWdcV.Location = new System.Drawing.Point(277, 437);
            this.chkWdcV.Name = "chkWdcV";
            this.chkWdcV.Properties.Caption = "";
            this.chkWdcV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkWdcV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkWdcV.Size = new System.Drawing.Size(45, 19);
            this.chkWdcV.TabIndex = 108;
            // 
            // labelControl31
            // 
            this.labelControl31.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl31.Location = new System.Drawing.Point(5, 491);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(114, 19);
            this.labelControl31.TabIndex = 109;
            this.labelControl31.Text = "Pur. Return Report";
            // 
            // chkPrtRepV
            // 
            this.chkPrtRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPrtRepV.Location = new System.Drawing.Point(277, 491);
            this.chkPrtRepV.Name = "chkPrtRepV";
            this.chkPrtRepV.Properties.Caption = "";
            this.chkPrtRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkPrtRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkPrtRepV.Size = new System.Drawing.Size(45, 19);
            this.chkPrtRepV.TabIndex = 110;
            // 
            // labelControl32
            // 
            this.labelControl32.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl32.Location = new System.Drawing.Point(5, 545);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(114, 19);
            this.labelControl32.TabIndex = 111;
            this.labelControl32.Text = "Sales Return Report";
            // 
            // chkSrtRepV
            // 
            this.chkSrtRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSrtRepV.Location = new System.Drawing.Point(277, 545);
            this.chkSrtRepV.Name = "chkSrtRepV";
            this.chkSrtRepV.Properties.Caption = "";
            this.chkSrtRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkSrtRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkSrtRepV.Size = new System.Drawing.Size(45, 19);
            this.chkSrtRepV.TabIndex = 112;
            // 
            // labelControl33
            // 
            this.labelControl33.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl33.Location = new System.Drawing.Point(5, 680);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(114, 19);
            this.labelControl33.TabIndex = 113;
            this.labelControl33.Text = "Withdraw Cash Report";
            // 
            // chkWdcRepV
            // 
            this.chkWdcRepV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWdcRepV.Location = new System.Drawing.Point(277, 680);
            this.chkWdcRepV.Name = "chkWdcRepV";
            this.chkWdcRepV.Properties.Caption = "";
            this.chkWdcRepV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkWdcRepV.Properties.LookAndFeel.SkinName = "Office 2007 Green";
            this.chkWdcRepV.Size = new System.Drawing.Size(45, 19);
            this.chkWdcRepV.TabIndex = 114;
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 503);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grcCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPermission";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission";
            this.Load += new System.EventHandler(this.frmPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.tlpOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCstN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCstE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCstD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSupN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSupE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSupD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPctN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPctE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPctD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCstV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSupV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPctV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBndN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBndE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBndD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBndV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPdtN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPdtE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPdtD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPdtV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTopRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIvtRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPftRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDexRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSlsRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDpcV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcrV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAcpV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQotN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQotE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQotD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkQotV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEctN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEctE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEctD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEctV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrtRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSrtRepV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWdcRepV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkCstN;
        private DevExpress.XtraEditors.CheckEdit chkCstE;
        private DevExpress.XtraEditors.CheckEdit chkCstD;
        private DevExpress.XtraEditors.CheckEdit chkSupN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit chkSupE;
        private DevExpress.XtraEditors.CheckEdit chkSupD;
        private DevExpress.XtraEditors.CheckEdit chkPctN;
        private DevExpress.XtraEditors.CheckEdit chkPctE;
        private DevExpress.XtraEditors.CheckEdit chkPctD;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.CheckEdit chkCstV;
        private DevExpress.XtraEditors.CheckEdit chkSupV;
        private DevExpress.XtraEditors.CheckEdit chkPctV;
        private DevExpress.XtraEditors.CheckEdit chkBndN;
        private DevExpress.XtraEditors.CheckEdit chkBndE;
        private DevExpress.XtraEditors.CheckEdit chkBndD;
        private DevExpress.XtraEditors.CheckEdit chkBndV;
        private DevExpress.XtraEditors.CheckEdit chkPdtN;
        private DevExpress.XtraEditors.CheckEdit chkPdtE;
        private DevExpress.XtraEditors.CheckEdit chkPdtD;
        private DevExpress.XtraEditors.CheckEdit chkPdtV;
        private DevExpress.XtraEditors.CheckEdit chkPurN;
        private DevExpress.XtraEditors.CheckEdit chkPurE;
        private DevExpress.XtraEditors.CheckEdit chkPurD;
        private DevExpress.XtraEditors.CheckEdit chkPurV;
        private DevExpress.XtraEditors.CheckEdit chkPrtN;
        private DevExpress.XtraEditors.CheckEdit chkPrtE;
        private DevExpress.XtraEditors.CheckEdit chkPrtD;
        private DevExpress.XtraEditors.CheckEdit chkPrtV;
        private DevExpress.XtraEditors.CheckEdit chkSlsN;
        private DevExpress.XtraEditors.CheckEdit chkSlsE;
        private DevExpress.XtraEditors.CheckEdit chkSlsD;
        private DevExpress.XtraEditors.CheckEdit chkSlsV;
        private DevExpress.XtraEditors.CheckEdit chkSrtN;
        private DevExpress.XtraEditors.CheckEdit chkSrtE;
        private DevExpress.XtraEditors.CheckEdit chkSrtD;
        private DevExpress.XtraEditors.CheckEdit chkSrtV;
        private DevExpress.XtraEditors.CheckEdit chkPurRepV;
        private DevExpress.XtraEditors.CheckEdit chkSlsRepV;
        private DevExpress.XtraEditors.CheckEdit chkDexRepV;
        private DevExpress.XtraEditors.CheckEdit chkDpcRepV;
        private DevExpress.XtraEditors.CheckEdit chkPftRepV;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUserGroup;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.CheckEdit chkAcpN;
        private DevExpress.XtraEditors.CheckEdit chkAcpE;
        private DevExpress.XtraEditors.CheckEdit chkAcpD;
        private DevExpress.XtraEditors.CheckEdit chkAcpV;
        private DevExpress.XtraEditors.CheckEdit chkAcrN;
        private DevExpress.XtraEditors.CheckEdit chkAcrE;
        private DevExpress.XtraEditors.CheckEdit chkAcrD;
        private DevExpress.XtraEditors.CheckEdit chkAcrV;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.CheckEdit chkAcpRepV;
        private DevExpress.XtraEditors.CheckEdit chkAcrRepV;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.CheckEdit chkTopRepV;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.CheckEdit chkIvtRepV;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.CheckEdit chkExpN;
        private DevExpress.XtraEditors.CheckEdit chkDpcN;
        private DevExpress.XtraEditors.CheckEdit chkExpE;
        private DevExpress.XtraEditors.CheckEdit chkDpcE;
        private DevExpress.XtraEditors.CheckEdit chkExpD;
        private DevExpress.XtraEditors.CheckEdit chkDpcD;
        private DevExpress.XtraEditors.CheckEdit chkExpV;
        private DevExpress.XtraEditors.CheckEdit chkDpcV;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.CheckEdit chkQotN;
        private DevExpress.XtraEditors.CheckEdit chkQotE;
        private DevExpress.XtraEditors.CheckEdit chkQotD;
        private DevExpress.XtraEditors.CheckEdit chkQotV;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.CheckEdit chkEctN;
        private DevExpress.XtraEditors.CheckEdit chkEctE;
        private DevExpress.XtraEditors.CheckEdit chkEctD;
        private DevExpress.XtraEditors.CheckEdit chkEctV;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.CheckEdit chkWdcN;
        private DevExpress.XtraEditors.CheckEdit chkWdcE;
        private DevExpress.XtraEditors.CheckEdit chkWdcD;
        private DevExpress.XtraEditors.CheckEdit chkWdcV;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.CheckEdit chkPrtRepV;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.CheckEdit chkSrtRepV;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.CheckEdit chkWdcRepV;
    }
}