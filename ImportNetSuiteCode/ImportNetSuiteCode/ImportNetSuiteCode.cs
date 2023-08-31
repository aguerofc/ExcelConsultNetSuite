using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImportNetSuiteAddin
{
    /// <summary>
    /// Import process view 
    /// </summary>
    public partial class ImportNetSuiteCode : Form
    {
        

        string  connectionString = ConfigurationManager.ConnectionStrings["NetSuiteConnection"].ConnectionString;



        /// <summary>
        /// Import ribbon 
        /// </summary>
        public Consult ribbon;

        
        /// <summary>
        /// Import view constructor
        /// </summary>
        public ImportNetSuiteCode()
        {
            InitializeComponent();
            
            this.Width = 890;
            this.Height = 390;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;           
            ribbon = new Consult();            
        }


        public void RibbonValueSent(object sender, int value)
        {
            // Use the value received from the ribbon as needed
            icgCode.Text = string.Empty;
            netSuiteView.Items.Clear();

        }

        /// <summary>
        /// Execute import process button
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">Event argument</param>
        private void executeProcess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.icgCode.Text))
            {
                LoadDataIntoListView();
            }
            else
            {
                MessageBox.Show("Debe digitar el codigo ICG para ejecutar la consulta");
            }

        }

        /// <summary>
        /// Cancel process button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelProcess_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportOrderView_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.icgCode;
        }        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void userProcess_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load data into listview
        /// </summary>
        private void LoadDataIntoListView()
        {
            netSuiteView.Items.Clear(); 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                 
                string query = ConfigurationManager.AppSettings["NetsuiteConsult"] + " '"  + icgCode.Text.Trim() + "'"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {                            
                            while (reader.Read())
                            {
                                string icgCode = reader["ICGCode"].ToString();
                                string netsuiteCode = reader["NetSuiteCode"].ToString();
                                string description = reader["Description"].ToString();


                                ListViewItem item = new ListViewItem(icgCode);
                                item.SubItems.Add(netsuiteCode);
                                item.SubItems.Add(description);

                                netSuiteView.Items.Add(item);
                                if (description.Length > 12)
                                {
                                    netSuiteView.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                                }
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("El código consultado no existe, por favor validarlo");
                        }                      
                    }
                }
            }
        }

        
    }
}

