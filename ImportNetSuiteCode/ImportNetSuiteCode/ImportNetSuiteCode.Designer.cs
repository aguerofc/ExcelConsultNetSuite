namespace ImportNetSuiteAddin
{
    partial class ImportNetSuiteCode
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
            this.executeProcess = new System.Windows.Forms.Button();
            this.cancelProcess = new System.Windows.Forms.Button();
            this.icgCode = new System.Windows.Forms.TextBox();
            this.userProcess = new System.Windows.Forms.Label();
            this.netSuiteView = new System.Windows.Forms.ListView();
            this.ICG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NestSuite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // executeProcess
            // 
            this.executeProcess.Location = new System.Drawing.Point(615, 17);
            this.executeProcess.Name = "executeProcess";
            this.executeProcess.Size = new System.Drawing.Size(165, 58);
            this.executeProcess.TabIndex = 0;
            this.executeProcess.Text = "Ejecutar Consulta";
            this.executeProcess.UseVisualStyleBackColor = true;
            this.executeProcess.Click += new System.EventHandler(this.executeProcess_Click);
            // 
            // cancelProcess
            // 
            this.cancelProcess.Location = new System.Drawing.Point(328, 249);
            this.cancelProcess.Name = "cancelProcess";
            this.cancelProcess.Size = new System.Drawing.Size(184, 58);
            this.cancelProcess.TabIndex = 1;
            this.cancelProcess.Text = "Salir";
            this.cancelProcess.UseVisualStyleBackColor = true;
            this.cancelProcess.Click += new System.EventHandler(this.cancelProcess_Click);
            // 
            // icgCode
            // 
            this.icgCode.Location = new System.Drawing.Point(133, 33);
            this.icgCode.Name = "icgCode";
            this.icgCode.Size = new System.Drawing.Size(379, 26);
            this.icgCode.TabIndex = 2;
            // 
            // userProcess
            // 
            this.userProcess.AutoSize = true;
            this.userProcess.Location = new System.Drawing.Point(16, 36);
            this.userProcess.Name = "userProcess";
            this.userProcess.Size = new System.Drawing.Size(92, 20);
            this.userProcess.TabIndex = 3;
            this.userProcess.Text = "Código ICG";
            this.userProcess.Click += new System.EventHandler(this.userProcess_Click);
            // 
            // netSuiteView
            // 
            this.netSuiteView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ICG,
            this.NestSuite,
            this.Descripcion});
            this.netSuiteView.FullRowSelect = true;
            this.netSuiteView.GridLines = true;
            this.netSuiteView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.netSuiteView.HideSelection = false;
            this.netSuiteView.Location = new System.Drawing.Point(133, 103);
            this.netSuiteView.Name = "netSuiteView";
            this.netSuiteView.Size = new System.Drawing.Size(647, 119);
            this.netSuiteView.TabIndex = 6;
            this.netSuiteView.UseCompatibleStateImageBehavior = false;
            this.netSuiteView.View = System.Windows.Forms.View.Details;
            // 
            // ICG
            // 
            this.ICG.Text = "Código ICG";
            this.ICG.Width = 150;
            // 
            // NestSuite
            // 
            this.NestSuite.Text = "Código NestSuite";
            this.NestSuite.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripción";
            this.Descripcion.Width = 100;
            // 
            // ImportNetSuiteCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 346);
            this.Controls.Add(this.netSuiteView);
            this.Controls.Add(this.userProcess);
            this.Controls.Add(this.icgCode);
            this.Controls.Add(this.cancelProcess);
            this.Controls.Add(this.executeProcess);
            this.Name = "ImportNetSuiteCode";
            this.Text = "Consulta de Datos";
            this.Load += new System.EventHandler(this.ImportOrderView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executeProcess;
        private System.Windows.Forms.Button cancelProcess;
        private System.Windows.Forms.TextBox icgCode;
        private System.Windows.Forms.Label userProcess;
        private System.Windows.Forms.ListView netSuiteView;
        private System.Windows.Forms.ColumnHeader ICG;
        private System.Windows.Forms.ColumnHeader NestSuite;
        private System.Windows.Forms.ColumnHeader Descripcion;
    }
}