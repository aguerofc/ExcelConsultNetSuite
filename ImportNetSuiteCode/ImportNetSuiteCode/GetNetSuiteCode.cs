using Microsoft.Office.Tools.Ribbon;
using System;

namespace ImportNetSuiteAddin
{
    /// <summary>
    /// Import process class
    /// </summary>
    public partial class Consult
    {
        private  ImportNetSuiteCode form;

        public event EventHandler<int> ValueSent;

        /// <summary>
        /// Consult load method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event argument</param>
        private void Consult_Load(object sender, RibbonUIEventArgs e)
        {
            form = new ImportNetSuiteCode();
            ValueSent += form.RibbonValueSent;            
        }
        
        /// <summary>
        /// Load form to consult ICG code
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event argument</param>
        private void icgConsultData_Click(object sender, RibbonControlEventArgs e)
        {
            ValueSent?.Invoke(this, 0);
            form.ShowDialog();           
            
        }
    }
}
