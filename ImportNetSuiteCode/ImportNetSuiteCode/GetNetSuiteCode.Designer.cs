namespace ImportNetSuiteAddin
{
    partial class Consult : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Consult()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.consultTab = this.Factory.CreateRibbonTab();
            this.consultGroup = this.Factory.CreateRibbonGroup();
            this.icgConsultData = this.Factory.CreateRibbonButton();
            this.consultTab.SuspendLayout();
            this.consultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultTab
            // 
            this.consultTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.consultTab.Groups.Add(this.consultGroup);
            this.consultTab.Label = "Spoon";
            this.consultTab.Name = "consultTab";
            // 
            // consultGroup
            // 
            this.consultGroup.Items.Add(this.icgConsultData);
            this.consultGroup.Name = "consultGroup";
            // 
            // icgConsultData
            // 
            this.icgConsultData.Label = "Consulta Código NetSuite";
            this.icgConsultData.Name = "icgConsultData";
            this.icgConsultData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.icgConsultData_Click);
            // 
            // Consult
            // 
            this.Name = "Consult";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.consultTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Consult_Load);
            this.consultTab.ResumeLayout(false);
            this.consultTab.PerformLayout();
            this.consultGroup.ResumeLayout(false);
            this.consultGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab consultTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup consultGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton icgConsultData;
    }

    partial class ThisRibbonCollection
    {
        internal Consult Orders
        {
            get { return this.GetRibbon<Consult>(); }
        }
    }
}
