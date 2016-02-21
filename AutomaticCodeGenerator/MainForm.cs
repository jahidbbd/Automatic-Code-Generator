using AutomaticCodeGenerator.Class.BLL;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomaticCodeGenerator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Automatic Code Generator
        /// Developed by: Abdullah Al-Muzahid
        /// </summary>
        /// 
        //private SqlConnection con;
        private string table;
        private string project;
        private string connectionString;
        private List<Entity> entities;
              
        public MainForm()
        {
            InitializeComponent();          
        }
               
        #region Methods
        private void extractERDDiagram(string path)
        {
            string message = string.Empty;

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Must select an image file", "Select File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string extension = Path.GetExtension(path);

            //Parsing From Image
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".vdx")
            {
                using (FileOperationManager fop = new FileOperationManager(grdColumns, project, table))
                {
                    entities = fop.extractERDDiagram(path, out message);
                    loadTableDropDownList();
                }
            }
            else
            {
                MessageBox.Show("File format invalid!", "Select File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void loadTableDropDownList()
        {
            ddlTables.Items.Clear();

            foreach (Entity ent in entities)
            {
                ddlTables.Items.Add(ent.Name);
            }
            ddlTables.Text = "Select Table";
        }
        
        private bool valid(out string message)
        {
            message = string.Empty;

            bool valid = true;

            if (txtDatabaseServer.Text == "")
            {
                valid = false;
                message += "Enter Database Server Name! \n";
            }

            if (txtDatabaseName.Text == "")
            {
                valid = false;
                message += "Enter Database Name! \n";
            }

            if (txtDatabaseUser.Text == "")
            {
                valid = false;
                message += "Enter Database User! \n";
            }

            if (txtDatabasePassword.Text == "")
            {
                valid = false;
                message += "Enter Database Password! \n";
            }

            if (table == "")
            {
                valid = false;
                message += "Enter Table Name! \n";
            }

            if (project == "")
            {
                valid = false;
                message += "Enter Project Location! \n";
            }

            return valid;
        }
        #endregion

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception Ex)
            {
                ErrorManager errL = new ErrorManager();
                errL.WriteError("", Ex.Message.ToString(), Ex.Source.ToString(), Ex.StackTrace.ToString());
                txtLog.Text += "\n\n" + Ex.Message + "\n\n";
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialogImage.FileName;
                extractERDDiagram(txtFileName.Text);
            }
        }

        private void cmdBrowseProjectLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogProjectLocation.ShowDialog() == DialogResult.OK)
            {
                txtProjectLocation.Text = folderBrowserDialogProjectLocation.SelectedPath;
            }
        }

        private void ddlTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdColumns.Rows.Clear();

            var ent = from en in entities
                      where en.Name == ddlTables.Text
                      select en;

            foreach (Entity en in ent.ToList())
            {
                txtTableName.Text = en.Name.Trim();

                for (int i = 0; i < en.Attributes.Count; i++)
                {
                    try
                    {
                        grdColumns.Rows.Add();
                        grdColumns.Rows[i].Cells[0].Value = en.Attributes[i].Name;

                        if (!string.IsNullOrWhiteSpace(en.Attributes[i].Type) && en.Attributes[i].Type.Trim().ToUpper() == "INTEGER")
                            grdColumns.Rows[i].Cells[1].Value = "int";

                        else if (!string.IsNullOrWhiteSpace(en.Attributes[i].Type) && en.Attributes[i].Type.Trim().ToUpper() == "DATETIME")
                            grdColumns.Rows[i].Cells[1].Value = "DateTime";
                        else
                            grdColumns.Rows[i].Cells[1].Value = en.Attributes[i].Type;

                        if (en.Attributes[i].Size.HasValue)
                        {
                            grdColumns.Rows[i].Cells[2].Value = en.Attributes[i].Size.ToString();
                        }

                        if (en.Attributes[i].PrimaryKey.HasValue)
                        {
                            grdColumns.Rows[i].Cells[3].Value = en.Attributes[i].PrimaryKey.Value;
                        }
                    }
                    catch
                    {
                        txtLog.Text += "\n\n" + "Error Parsing Fields." + "\n\n";
                    }
                }
            }

        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string message = string.Empty;

                if (!valid(out message))
                {
                    MessageBox.Show(message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }

                table = txtTableName.Text.Trim();
                project = txtProjectLocation.Text.Trim();
                connectionString = string.Format("data source={0};database={1};Integrated Security=false;user id={2};password={3};", txtDatabaseServer.Text.Trim(), txtDatabaseName.Text.Trim(), txtDatabaseUser.Text.Trim(), txtDatabasePassword.Text.Trim());

                cmdGenerate.Enabled = false;
                cmdClear.Enabled = false;
                cmdExit.Enabled = false;

                //SqlConnection con = new SqlConnection("Persist Security Info=False;User ID=CGUser; Password=AITAgradut123; Initial Catalog=CodeGenerator;Data Source=AGRADUT3\\SQLEXPRESS");
                //SqlCommand cmd = new SqlCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "INSERT INTO [GenerateLog] VALUES ('" + frmLogin.userName + "', '" + Environment.MachineName + "', '" + DateTime.Now + "', '" + project + "', '" + txtConnectionString.Text.Trim() + "', '" + table + "')";
                //cmd.Connection = con;
                //con.Open();

                //int res = cmd.ExecuteNonQuery();

                //con.Close();

                if (1 == 1) //(res > 0)
                {

                    using (DBOperationManager dbop = new DBOperationManager(connectionString, grdColumns, table))
                    {
                        if (chkTable.Checked)
                        {
                            txtLog.Text += "\n\n" + "Creating Table ......" + "\n\n";
                            if (dbop.createTable(out message))
                                txtLog.Text += "\n\n" + "Table Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Table." + "\n\n" + message;
                        }

                        if (chkSp.Checked)
                        {
                            txtLog.Text += "\n\n" + "Creating Stored Procedures ......" + "\n\n";

                            if (dbop.createStoredProcedures(out message))
                                txtLog.Text += "\n\n" + "Stored Procedures Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Stored Procedures." + "\n\n" + message;
                        }
                    }

                    using (FileOperationManager fop = new FileOperationManager(grdColumns, project, table))
                    {
                        txtLog.Text += "\n\n" + "Creating Project Template ......" + "\n\n";
                        fop.createProjectTemplate();
                        txtLog.Text += "\n\n" + "Project Template Created Successfully ......" + "\n\n";

                        if (chkClasses.Checked)
                        {
                            txtLog.Text += "\n\n" + "Creating Property Class ......" + "\n\n";

                            if (fop.createPropertyClass(out message))
                                txtLog.Text += "\n\n" + "Property Class Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Property Class." + "\n\n" + message;

                            txtLog.Text += "\n\n" + "Creating Provider Class ......" + "\n\n";

                            if (fop.createProviderClass(out message))
                                txtLog.Text += "\n\n" + "Provider Class Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Provider Class." + "\n\n" + message;

                            txtLog.Text += "\n\n" + "Creating Manager Class ......" + "\n\n";
                            if (fop.createManagerClass(out message))
                                txtLog.Text += "\n\n" + "Manager Class Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Manager Class." + "\n\n" + message;
                        }

                        if (chkAdminPages.Checked)
                        {
                            txtLog.Text += "\n\n" + "Creating Admin View Page ......" + "\n\n";
                            if (fop.createAdminViewPage(out message))
                                txtLog.Text += "\n\n" + "Admin View Page Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Admin View Page." + "\n\n" + message;

                            txtLog.Text += "\n\n" + "Creating Admin View Code Behind Class ......" + "\n\n";
                            if (fop.createAdminViewCodeBehindPage(out message))
                                txtLog.Text += "\n\n" + "Admin View Code Behind Class Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Admin View Code Behind Class." + "\n\n" + message;

                            txtLog.Text += "\n\n" + "Creating Admin Insert Update Page ......" + "\n\n";
                            if (fop.createAdminInsertUpdatePage(out message))
                                txtLog.Text += "\n\n" + "Admin Insert Update Page Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Admin Insert Update Page." + "\n\n" + message;

                            txtLog.Text += "\n\n" + "Creating Admin Insert Update Code Behind Class ......" + "\n\n";
                            if (fop.createAdminInsertUpdateCodeBehind(out message))
                                txtLog.Text += "\n\n" + "Admin Insert Update Code Behind Class Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating Admin Insert Update Code Behind Class." + "\n\n" + message;
                        }

                        if (chkVPages.Checked)
                        {
                            txtLog.Text += "\n\n" + "Creating View Page ......" + "\n\n";
                            if (fop.createViewPage(out message))
                                txtLog.Text += "\n\n" + "View Page Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating View Page." + "\n\n" + message;

                            txtLog.Text += "\n\n" + "Creating View Page Code Behind Class ......" + "\n\n";
                            if (fop.createViewCodeBehindPage(out message))
                                txtLog.Text += "\n\n" + "View Page Code Behind Class Created Successfully." + "\n\n";
                            else
                                txtLog.Text += "\n\n" + "Error Creating View Page Code Behind Class." + "\n\n" + message;


                        }
                    }

                    MessageBox.Show("Process Completed. Please check the log for details.", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmdGenerate.Enabled = true;
                    cmdClear.Enabled = true;
                    cmdExit.Enabled = true;
                }
            }
            catch (Exception Ex)
            {
                ErrorManager errL = new ErrorManager();
                errL.WriteError("", Ex.Message.ToString(), Ex.Source.ToString(), Ex.StackTrace.ToString());
                txtLog.Text += "\n\n" + Ex.Message + "\n\n";
                //if (con.State != ConnectionState.Closed)
                //    con.Close();
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            txtTableName.Text = "";
            grdColumns.Rows.Clear();            
            table = string.Empty;
            project = string.Empty;
            connectionString = string.Empty;
            entities = new List<Entity>();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
