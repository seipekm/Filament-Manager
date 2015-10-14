namespace Filament_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gvFilament = new MetroFramework.Controls.MetroGrid();
            this.btnFilamentAdd = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnSearch = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnScan = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtPrintWeight = new MetroFramework.Controls.MetroTextBox();
            this.txtFilament = new MetroFramework.Controls.MetroTextBox();
            this.txtPrintID = new MetroFramework.Controls.MetroTextBox();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.gbBarcode = new System.Windows.Forms.GroupBox();
            this.txtGenBarcode = new MetroFramework.Controls.MetroTextBox();
            this.cbFactory = new MetroFramework.Controls.MetroComboBox();
            this.gvFi = new MetroFramework.Controls.MetroGrid();
            this.txtNetto = new MetroFramework.Controls.MetroTextBox();
            this.txtBrutto = new MetroFramework.Controls.MetroTextBox();
            this.txtColor = new MetroFramework.Controls.MetroTextBox();
            this.btnSaveBarcode = new MetroFramework.Controls.MetroLink();
            this.btnFilaDelete = new MetroFramework.Controls.MetroLink();
            this.btnFilaUpdate = new MetroFramework.Controls.MetroLink();
            this.btnFilaAdd = new MetroFramework.Controls.MetroLink();
            this.btnGenBarcode = new MetroFramework.Controls.MetroLink();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.MySqlSetting = new System.Windows.Forms.GroupBox();
            this.btnConTest = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtDB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbLabelLocation = new MetroFramework.Controls.MetroComboBox();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbRotateFlip = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chkGenerateLabel = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtHeight = new MetroFramework.Controls.MetroTextBox();
            this.txtWidth = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbBarcodeAlign = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbEncodeType = new MetroFramework.Controls.MetroComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lnlClose = new MetroFramework.Controls.MetroLink();
            this.btnConStringSave = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilament)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFi)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            this.MySqlSetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(1212, 614);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.gvFilament);
            this.metroTabPage1.Controls.Add(this.btnFilamentAdd);
            this.metroTabPage1.Controls.Add(this.btnSearch);
            this.metroTabPage1.Controls.Add(this.btnScan);
            this.metroTabPage1.Controls.Add(this.txtPrintWeight);
            this.metroTabPage1.Controls.Add(this.txtFilament);
            this.metroTabPage1.Controls.Add(this.txtPrintID);
            this.metroTabPage1.Controls.Add(this.txtBarcode);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1204, 566);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Print Job";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gvFilament
            // 
            this.gvFilament.AllowUserToAddRows = false;
            this.gvFilament.AllowUserToDeleteRows = false;
            this.gvFilament.AllowUserToResizeRows = false;
            this.gvFilament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFilament.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvFilament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvFilament.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvFilament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFilament.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvFilament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFilament.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvFilament.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvFilament.EnableHeadersVisualStyles = false;
            this.gvFilament.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvFilament.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvFilament.Location = new System.Drawing.Point(0, 225);
            this.gvFilament.Name = "gvFilament";
            this.gvFilament.ReadOnly = true;
            this.gvFilament.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFilament.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvFilament.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvFilament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFilament.Size = new System.Drawing.Size(1204, 341);
            this.gvFilament.TabIndex = 17;
            // 
            // btnFilamentAdd
            // 
            this.btnFilamentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilamentAdd.Image = null;
            this.btnFilamentAdd.Location = new System.Drawing.Point(13, 147);
            this.btnFilamentAdd.Name = "btnFilamentAdd";
            this.btnFilamentAdd.Size = new System.Drawing.Size(119, 30);
            this.btnFilamentAdd.TabIndex = 16;
            this.btnFilamentAdd.Text = "HINZUFÜGEN";
            this.btnFilamentAdd.UseSelectable = true;
            this.btnFilamentAdd.UseVisualStyleBackColor = true;
            this.btnFilamentAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = null;
            this.btnSearch.Location = new System.Drawing.Point(307, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 30);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "SUCHE";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Image = null;
            this.btnScan.Location = new System.Drawing.Point(307, 3);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(107, 30);
            this.btnScan.TabIndex = 14;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseSelectable = true;
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // txtPrintWeight
            // 
            // 
            // 
            // 
            this.txtPrintWeight.CustomButton.Image = null;
            this.txtPrintWeight.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtPrintWeight.CustomButton.Name = "";
            this.txtPrintWeight.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrintWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrintWeight.CustomButton.TabIndex = 1;
            this.txtPrintWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrintWeight.CustomButton.UseSelectable = true;
            this.txtPrintWeight.CustomButton.Visible = false;
            this.txtPrintWeight.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrintWeight.Lines = new string[0];
            this.txtPrintWeight.Location = new System.Drawing.Point(13, 111);
            this.txtPrintWeight.MaxLength = 32767;
            this.txtPrintWeight.Name = "txtPrintWeight";
            this.txtPrintWeight.PasswordChar = '\0';
            this.txtPrintWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrintWeight.SelectedText = "";
            this.txtPrintWeight.SelectionLength = 0;
            this.txtPrintWeight.SelectionStart = 0;
            this.txtPrintWeight.Size = new System.Drawing.Size(288, 30);
            this.txtPrintWeight.TabIndex = 13;
            this.txtPrintWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrintWeight.UseSelectable = true;
            this.txtPrintWeight.WaterMark = "Druck Gewicht";
            this.txtPrintWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrintWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFilament
            // 
            // 
            // 
            // 
            this.txtFilament.CustomButton.Image = null;
            this.txtFilament.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtFilament.CustomButton.Name = "";
            this.txtFilament.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFilament.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilament.CustomButton.TabIndex = 1;
            this.txtFilament.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilament.CustomButton.UseSelectable = true;
            this.txtFilament.CustomButton.Visible = false;
            this.txtFilament.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFilament.Lines = new string[0];
            this.txtFilament.Location = new System.Drawing.Point(13, 75);
            this.txtFilament.MaxLength = 32767;
            this.txtFilament.Name = "txtFilament";
            this.txtFilament.PasswordChar = '\0';
            this.txtFilament.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilament.SelectedText = "";
            this.txtFilament.SelectionLength = 0;
            this.txtFilament.SelectionStart = 0;
            this.txtFilament.Size = new System.Drawing.Size(288, 30);
            this.txtFilament.TabIndex = 12;
            this.txtFilament.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFilament.UseSelectable = true;
            this.txtFilament.WaterMark = "Filament";
            this.txtFilament.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilament.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrintID
            // 
            // 
            // 
            // 
            this.txtPrintID.CustomButton.Image = null;
            this.txtPrintID.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtPrintID.CustomButton.Name = "";
            this.txtPrintID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrintID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrintID.CustomButton.TabIndex = 1;
            this.txtPrintID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrintID.CustomButton.UseSelectable = true;
            this.txtPrintID.CustomButton.Visible = false;
            this.txtPrintID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrintID.Lines = new string[0];
            this.txtPrintID.Location = new System.Drawing.Point(13, 39);
            this.txtPrintID.MaxLength = 32767;
            this.txtPrintID.Name = "txtPrintID";
            this.txtPrintID.PasswordChar = '\0';
            this.txtPrintID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrintID.SelectedText = "";
            this.txtPrintID.SelectionLength = 0;
            this.txtPrintID.SelectionStart = 0;
            this.txtPrintID.Size = new System.Drawing.Size(288, 30);
            this.txtPrintID.TabIndex = 11;
            this.txtPrintID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrintID.UseSelectable = true;
            this.txtPrintID.WaterMark = "Druck ID";
            this.txtPrintID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrintID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = null;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtBarcode.CustomButton.Name = "";
            this.txtBarcode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarcode.CustomButton.TabIndex = 1;
            this.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarcode.CustomButton.UseSelectable = true;
            this.txtBarcode.CustomButton.Visible = false;
            this.txtBarcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(13, 3);
            this.txtBarcode.MaxLength = 32767;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.Size = new System.Drawing.Size(288, 30);
            this.txtBarcode.TabIndex = 10;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.WaterMark = "Barcode";
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.gbBarcode);
            this.metroTabPage2.Controls.Add(this.txtGenBarcode);
            this.metroTabPage2.Controls.Add(this.cbFactory);
            this.metroTabPage2.Controls.Add(this.gvFi);
            this.metroTabPage2.Controls.Add(this.txtNetto);
            this.metroTabPage2.Controls.Add(this.txtBrutto);
            this.metroTabPage2.Controls.Add(this.txtColor);
            this.metroTabPage2.Controls.Add(this.btnSaveBarcode);
            this.metroTabPage2.Controls.Add(this.btnFilaDelete);
            this.metroTabPage2.Controls.Add(this.btnFilaUpdate);
            this.metroTabPage2.Controls.Add(this.btnFilaAdd);
            this.metroTabPage2.Controls.Add(this.btnGenBarcode);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1204, 566);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Filament";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // gbBarcode
            // 
            this.gbBarcode.BackColor = System.Drawing.Color.Transparent;
            this.gbBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbBarcode.Location = new System.Drawing.Point(841, 5);
            this.gbBarcode.Name = "gbBarcode";
            this.gbBarcode.Size = new System.Drawing.Size(360, 229);
            this.gbBarcode.TabIndex = 29;
            this.gbBarcode.TabStop = false;
            this.gbBarcode.Text = "Barcode";
            // 
            // txtGenBarcode
            // 
            // 
            // 
            // 
            this.txtGenBarcode.CustomButton.Image = null;
            this.txtGenBarcode.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtGenBarcode.CustomButton.Name = "";
            this.txtGenBarcode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtGenBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenBarcode.CustomButton.TabIndex = 1;
            this.txtGenBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenBarcode.CustomButton.UseSelectable = true;
            this.txtGenBarcode.CustomButton.Visible = false;
            this.txtGenBarcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGenBarcode.Lines = new string[0];
            this.txtGenBarcode.Location = new System.Drawing.Point(13, 148);
            this.txtGenBarcode.MaxLength = 32767;
            this.txtGenBarcode.Name = "txtGenBarcode";
            this.txtGenBarcode.PasswordChar = '\0';
            this.txtGenBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenBarcode.SelectedText = "";
            this.txtGenBarcode.SelectionLength = 0;
            this.txtGenBarcode.SelectionStart = 0;
            this.txtGenBarcode.Size = new System.Drawing.Size(288, 30);
            this.txtGenBarcode.TabIndex = 25;
            this.txtGenBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGenBarcode.UseSelectable = true;
            this.txtGenBarcode.WaterMark = "Barcode...";
            this.txtGenBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbFactory
            // 
            this.cbFactory.ItemHeight = 23;
            this.cbFactory.Items.AddRange(new object[] {
            "Auswählen...",
            "BQ",
            "InnoFill",
            "ColorFab",
            "Orbi-Tech"});
            this.cbFactory.Location = new System.Drawing.Point(13, 5);
            this.cbFactory.Name = "cbFactory";
            this.cbFactory.Size = new System.Drawing.Size(288, 29);
            this.cbFactory.TabIndex = 24;
            this.cbFactory.UseSelectable = true;
            // 
            // gvFi
            // 
            this.gvFi.AllowUserToAddRows = false;
            this.gvFi.AllowUserToDeleteRows = false;
            this.gvFi.AllowUserToResizeColumns = false;
            this.gvFi.AllowUserToResizeRows = false;
            this.gvFi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvFi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvFi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvFi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvFi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFi.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvFi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvFi.EnableHeadersVisualStyles = false;
            this.gvFi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvFi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvFi.Location = new System.Drawing.Point(0, 240);
            this.gvFi.MultiSelect = false;
            this.gvFi.Name = "gvFi";
            this.gvFi.ReadOnly = true;
            this.gvFi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvFi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvFi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFi.Size = new System.Drawing.Size(1204, 326);
            this.gvFi.TabIndex = 23;
            // 
            // txtNetto
            // 
            // 
            // 
            // 
            this.txtNetto.CustomButton.Image = null;
            this.txtNetto.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtNetto.CustomButton.Name = "";
            this.txtNetto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNetto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNetto.CustomButton.TabIndex = 1;
            this.txtNetto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNetto.CustomButton.UseSelectable = true;
            this.txtNetto.CustomButton.Visible = false;
            this.txtNetto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNetto.Lines = new string[0];
            this.txtNetto.Location = new System.Drawing.Point(13, 112);
            this.txtNetto.MaxLength = 32767;
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.PasswordChar = '\0';
            this.txtNetto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetto.SelectedText = "";
            this.txtNetto.SelectionLength = 0;
            this.txtNetto.SelectionStart = 0;
            this.txtNetto.Size = new System.Drawing.Size(288, 30);
            this.txtNetto.TabIndex = 21;
            this.txtNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNetto.UseSelectable = true;
            this.txtNetto.WaterMark = "Netto[g]";
            this.txtNetto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNetto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtBrutto
            // 
            // 
            // 
            // 
            this.txtBrutto.CustomButton.Image = null;
            this.txtBrutto.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtBrutto.CustomButton.Name = "";
            this.txtBrutto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBrutto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBrutto.CustomButton.TabIndex = 1;
            this.txtBrutto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBrutto.CustomButton.UseSelectable = true;
            this.txtBrutto.CustomButton.Visible = false;
            this.txtBrutto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBrutto.Lines = new string[0];
            this.txtBrutto.Location = new System.Drawing.Point(13, 76);
            this.txtBrutto.MaxLength = 32767;
            this.txtBrutto.Name = "txtBrutto";
            this.txtBrutto.PasswordChar = '\0';
            this.txtBrutto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBrutto.SelectedText = "";
            this.txtBrutto.SelectionLength = 0;
            this.txtBrutto.SelectionStart = 0;
            this.txtBrutto.Size = new System.Drawing.Size(288, 30);
            this.txtBrutto.TabIndex = 20;
            this.txtBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrutto.UseSelectable = true;
            this.txtBrutto.WaterMark = "Brutto[g]";
            this.txtBrutto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBrutto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtColor
            // 
            // 
            // 
            // 
            this.txtColor.CustomButton.Image = null;
            this.txtColor.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtColor.CustomButton.Name = "";
            this.txtColor.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColor.CustomButton.TabIndex = 1;
            this.txtColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColor.CustomButton.UseSelectable = true;
            this.txtColor.CustomButton.Visible = false;
            this.txtColor.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtColor.Lines = new string[0];
            this.txtColor.Location = new System.Drawing.Point(13, 40);
            this.txtColor.MaxLength = 32767;
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColor.SelectedText = "";
            this.txtColor.SelectionLength = 0;
            this.txtColor.SelectionStart = 0;
            this.txtColor.Size = new System.Drawing.Size(288, 30);
            this.txtColor.TabIndex = 19;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColor.UseSelectable = true;
            this.txtColor.WaterMark = "Farbe";
            this.txtColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSaveBarcode
            // 
            this.btnSaveBarcode.Image = global::Filament_Manager.Properties.Resources.Save1;
            this.btnSaveBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBarcode.ImageSize = 50;
            this.btnSaveBarcode.Location = new System.Drawing.Point(785, 20);
            this.btnSaveBarcode.Name = "btnSaveBarcode";
            this.btnSaveBarcode.NoFocusImage = global::Filament_Manager.Properties.Resources.Save;
            this.btnSaveBarcode.Size = new System.Drawing.Size(50, 50);
            this.btnSaveBarcode.TabIndex = 35;
            this.btnSaveBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveBarcode.UseSelectable = true;
            this.btnSaveBarcode.Click += new System.EventHandler(this.btnSaveBarcode_Click);
            // 
            // btnFilaDelete
            // 
            this.btnFilaDelete.Image = global::Filament_Manager.Properties.Resources.Cancel1;
            this.btnFilaDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilaDelete.ImageSize = 50;
            this.btnFilaDelete.Location = new System.Drawing.Point(125, 184);
            this.btnFilaDelete.Name = "btnFilaDelete";
            this.btnFilaDelete.NoFocusImage = global::Filament_Manager.Properties.Resources.Cancel;
            this.btnFilaDelete.Size = new System.Drawing.Size(50, 50);
            this.btnFilaDelete.TabIndex = 34;
            this.btnFilaDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilaDelete.UseSelectable = true;
            // 
            // btnFilaUpdate
            // 
            this.btnFilaUpdate.Image = global::Filament_Manager.Properties.Resources.Rotate_Left1;
            this.btnFilaUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilaUpdate.ImageSize = 50;
            this.btnFilaUpdate.Location = new System.Drawing.Point(69, 184);
            this.btnFilaUpdate.Name = "btnFilaUpdate";
            this.btnFilaUpdate.NoFocusImage = global::Filament_Manager.Properties.Resources.Rotate_Left;
            this.btnFilaUpdate.Size = new System.Drawing.Size(50, 50);
            this.btnFilaUpdate.TabIndex = 33;
            this.btnFilaUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilaUpdate.UseSelectable = true;
            // 
            // btnFilaAdd
            // 
            this.btnFilaAdd.Image = global::Filament_Manager.Properties.Resources.Ok1;
            this.btnFilaAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilaAdd.ImageSize = 50;
            this.btnFilaAdd.Location = new System.Drawing.Point(13, 184);
            this.btnFilaAdd.Name = "btnFilaAdd";
            this.btnFilaAdd.NoFocusImage = global::Filament_Manager.Properties.Resources.Ok;
            this.btnFilaAdd.Size = new System.Drawing.Size(50, 50);
            this.btnFilaAdd.TabIndex = 32;
            this.btnFilaAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilaAdd.UseSelectable = true;
            this.btnFilaAdd.Click += new System.EventHandler(this.btnFilaAdd_Click);
            // 
            // btnGenBarcode
            // 
            this.btnGenBarcode.Image = global::Filament_Manager.Properties.Resources.Barcode1;
            this.btnGenBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenBarcode.ImageSize = 50;
            this.btnGenBarcode.Location = new System.Drawing.Point(185, 184);
            this.btnGenBarcode.Name = "btnGenBarcode";
            this.btnGenBarcode.NoFocusImage = global::Filament_Manager.Properties.Resources.Barcode;
            this.btnGenBarcode.Size = new System.Drawing.Size(116, 50);
            this.btnGenBarcode.TabIndex = 31;
            this.btnGenBarcode.Text = "ERZEUGEN";
            this.btnGenBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenBarcode.UseSelectable = true;
            this.btnGenBarcode.Click += new System.EventHandler(this.btnGenBarcode_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1204, 566);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Printer";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.MySqlSetting);
            this.metroTabPage4.Controls.Add(this.groupBox2);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1204, 566);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Einstellungen";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // MySqlSetting
            // 
            this.MySqlSetting.BackColor = System.Drawing.Color.Transparent;
            this.MySqlSetting.Controls.Add(this.btnConStringSave);
            this.MySqlSetting.Controls.Add(this.btnConTest);
            this.MySqlSetting.Controls.Add(this.txtPassword);
            this.MySqlSetting.Controls.Add(this.metroLabel11);
            this.MySqlSetting.Controls.Add(this.txtUser);
            this.MySqlSetting.Controls.Add(this.metroLabel10);
            this.MySqlSetting.Controls.Add(this.txtDB);
            this.MySqlSetting.Controls.Add(this.metroLabel9);
            this.MySqlSetting.Controls.Add(this.txtHost);
            this.MySqlSetting.Controls.Add(this.metroLabel8);
            this.MySqlSetting.Location = new System.Drawing.Point(251, 4);
            this.MySqlSetting.Name = "MySqlSetting";
            this.MySqlSetting.Size = new System.Drawing.Size(241, 340);
            this.MySqlSetting.TabIndex = 3;
            this.MySqlSetting.TabStop = false;
            this.MySqlSetting.Text = "MySQL";
            // 
            // btnConTest
            // 
            this.btnConTest.Image = null;
            this.btnConTest.Location = new System.Drawing.Point(6, 294);
            this.btnConTest.Name = "btnConTest";
            this.btnConTest.Size = new System.Drawing.Size(229, 40);
            this.btnConTest.TabIndex = 27;
            this.btnConTest.Text = "Test Verbindung";
            this.btnConTest.UseSelectable = true;
            this.btnConTest.UseVisualStyleBackColor = true;
            this.btnConTest.Click += new System.EventHandler(this.btnConTest_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(201, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(7, 217);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(229, 30);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(7, 189);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(60, 19);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "Passwort";
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(201, 2);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(7, 153);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(229, 30);
            this.txtUser.TabIndex = 23;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(7, 131);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(68, 19);
            this.metroLabel10.TabIndex = 24;
            this.metroLabel10.Text = "Username";
            // 
            // txtDB
            // 
            // 
            // 
            // 
            this.txtDB.CustomButton.Image = null;
            this.txtDB.CustomButton.Location = new System.Drawing.Point(201, 2);
            this.txtDB.CustomButton.Name = "";
            this.txtDB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDB.CustomButton.TabIndex = 1;
            this.txtDB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDB.CustomButton.UseSelectable = true;
            this.txtDB.CustomButton.Visible = false;
            this.txtDB.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDB.Lines = new string[0];
            this.txtDB.Location = new System.Drawing.Point(7, 98);
            this.txtDB.MaxLength = 32767;
            this.txtDB.Name = "txtDB";
            this.txtDB.PasswordChar = '\0';
            this.txtDB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDB.SelectedText = "";
            this.txtDB.SelectionLength = 0;
            this.txtDB.SelectionStart = 0;
            this.txtDB.Size = new System.Drawing.Size(229, 30);
            this.txtDB.TabIndex = 21;
            this.txtDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDB.UseSelectable = true;
            this.txtDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 73);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(71, 19);
            this.metroLabel9.TabIndex = 22;
            this.metroLabel9.Text = "Datenbank";
            // 
            // txtHost
            // 
            // 
            // 
            // 
            this.txtHost.CustomButton.Image = null;
            this.txtHost.CustomButton.Location = new System.Drawing.Point(201, 2);
            this.txtHost.CustomButton.Name = "";
            this.txtHost.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHost.CustomButton.TabIndex = 1;
            this.txtHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHost.CustomButton.UseSelectable = true;
            this.txtHost.CustomButton.Visible = false;
            this.txtHost.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHost.Lines = new string[] {
        "172.0.0.1"};
            this.txtHost.Location = new System.Drawing.Point(6, 40);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHost.SelectedText = "";
            this.txtHost.SelectionLength = 0;
            this.txtHost.SelectionStart = 0;
            this.txtHost.Size = new System.Drawing.Size(229, 30);
            this.txtHost.TabIndex = 19;
            this.txtHost.Text = "172.0.0.1";
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHost.UseSelectable = true;
            this.txtHost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(7, 15);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(35, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Host";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.cbLabelLocation);
            this.groupBox2.Controls.Add(this.btnBackColor);
            this.groupBox2.Controls.Add(this.btnForeColor);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.cbRotateFlip);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.chkGenerateLabel);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.cbBarcodeAlign);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.cbEncodeType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 373);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 223);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Label Location";
            // 
            // cbLabelLocation
            // 
            this.cbLabelLocation.FormattingEnabled = true;
            this.cbLabelLocation.ItemHeight = 23;
            this.cbLabelLocation.Items.AddRange(new object[] {
            "BottomCenter",
            "BottomLeft",
            "BottomRight",
            "TopCenter",
            "TopLeft",
            "TopRight"});
            this.cbLabelLocation.Location = new System.Drawing.Point(5, 248);
            this.cbLabelLocation.Name = "cbLabelLocation";
            this.cbLabelLocation.Size = new System.Drawing.Size(229, 29);
            this.cbLabelLocation.TabIndex = 17;
            this.cbLabelLocation.UseSelectable = true;
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(130, 328);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(79, 36);
            this.btnBackColor.TabIndex = 14;
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(5, 328);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(79, 36);
            this.btnForeColor.TabIndex = 13;
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(8, 73);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Rotate";
            // 
            // cbRotateFlip
            // 
            this.cbRotateFlip.FormattingEnabled = true;
            this.cbRotateFlip.ItemHeight = 23;
            this.cbRotateFlip.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbRotateFlip.Location = new System.Drawing.Point(7, 98);
            this.cbRotateFlip.Name = "cbRotateFlip";
            this.cbRotateFlip.Size = new System.Drawing.Size(229, 29);
            this.cbRotateFlip.TabIndex = 15;
            this.cbRotateFlip.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(130, 305);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Background";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(5, 305);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Foreground";
            // 
            // chkGenerateLabel
            // 
            this.chkGenerateLabel.AutoSize = true;
            this.chkGenerateLabel.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkGenerateLabel.Location = new System.Drawing.Point(6, 283);
            this.chkGenerateLabel.Name = "chkGenerateLabel";
            this.chkGenerateLabel.Size = new System.Drawing.Size(113, 19);
            this.chkGenerateLabel.TabIndex = 8;
            this.chkGenerateLabel.Text = "Generate label";
            this.chkGenerateLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chkGenerateLabel.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(110, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(15, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "x";
            // 
            // txtHeight
            // 
            // 
            // 
            // 
            this.txtHeight.CustomButton.Image = null;
            this.txtHeight.CustomButton.Location = new System.Drawing.Point(75, 2);
            this.txtHeight.CustomButton.Name = "";
            this.txtHeight.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHeight.CustomButton.TabIndex = 1;
            this.txtHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHeight.CustomButton.UseSelectable = true;
            this.txtHeight.CustomButton.Visible = false;
            this.txtHeight.Lines = new string[0];
            this.txtHeight.Location = new System.Drawing.Point(131, 190);
            this.txtHeight.MaxLength = 32767;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHeight.SelectedText = "";
            this.txtHeight.SelectionLength = 0;
            this.txtHeight.SelectionStart = 0;
            this.txtHeight.Size = new System.Drawing.Size(103, 30);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.UseSelectable = true;
            this.txtHeight.WaterMark = "Height";
            this.txtHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtWidth
            // 
            // 
            // 
            // 
            this.txtWidth.CustomButton.Image = null;
            this.txtWidth.CustomButton.Location = new System.Drawing.Point(70, 2);
            this.txtWidth.CustomButton.Name = "";
            this.txtWidth.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWidth.CustomButton.TabIndex = 1;
            this.txtWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWidth.CustomButton.UseSelectable = true;
            this.txtWidth.CustomButton.Visible = false;
            this.txtWidth.Lines = new string[0];
            this.txtWidth.Location = new System.Drawing.Point(6, 190);
            this.txtWidth.MaxLength = 32767;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PasswordChar = '\0';
            this.txtWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWidth.SelectedText = "";
            this.txtWidth.SelectionLength = 0;
            this.txtWidth.SelectionStart = 0;
            this.txtWidth.Size = new System.Drawing.Size(98, 30);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidth.UseSelectable = true;
            this.txtWidth.WaterMark = "Width";
            this.txtWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Alignment";
            // 
            // cbBarcodeAlign
            // 
            this.cbBarcodeAlign.FormattingEnabled = true;
            this.cbBarcodeAlign.ItemHeight = 23;
            this.cbBarcodeAlign.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbBarcodeAlign.Location = new System.Drawing.Point(5, 155);
            this.cbBarcodeAlign.Name = "cbBarcodeAlign";
            this.cbBarcodeAlign.Size = new System.Drawing.Size(229, 29);
            this.cbBarcodeAlign.TabIndex = 2;
            this.cbBarcodeAlign.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Encoding";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.ItemHeight = 23;
            this.cbEncodeType.Items.AddRange(new object[] {
            "UPC-A",
            "UPC-E",
            "UPC 2 Digit Ext.",
            "UPC 5 Digit Ext.",
            "EAN-13",
            "JAN-13",
            "EAN-8",
            "ITF-14",
            "Interleaved 2 of 5",
            "Standard 2 of 5",
            "Codabar",
            "PostNet",
            "Bookland/ISBN",
            "Code 11",
            "Code 39",
            "Code 39 Extended",
            "Code 39 Mod 43",
            "Code 93",
            "Code 128",
            "Code 128-A",
            "Code 128-B",
            "Code 128-C",
            "LOGMARS",
            "MSI",
            "Telepen",
            "FIM",
            "Pharmacode"});
            this.cbEncodeType.Location = new System.Drawing.Point(7, 41);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(229, 29);
            this.cbEncodeType.TabIndex = 0;
            this.cbEncodeType.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // lnlClose
            // 
            this.lnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnlClose.Image = ((System.Drawing.Image)(resources.GetObject("lnlClose.Image")));
            this.lnlClose.ImageSize = 32;
            this.lnlClose.Location = new System.Drawing.Point(1206, 8);
            this.lnlClose.Name = "lnlClose";
            this.lnlClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnlClose.NoFocusImage")));
            this.lnlClose.Size = new System.Drawing.Size(42, 39);
            this.lnlClose.TabIndex = 2;
            this.lnlClose.UseSelectable = true;
            this.lnlClose.Click += new System.EventHandler(this.lnlClose_Click);
            // 
            // btnConStringSave
            // 
            this.btnConStringSave.Image = null;
            this.btnConStringSave.Location = new System.Drawing.Point(6, 253);
            this.btnConStringSave.Name = "btnConStringSave";
            this.btnConStringSave.Size = new System.Drawing.Size(229, 35);
            this.btnConStringSave.TabIndex = 28;
            this.btnConStringSave.Text = "Speichern";
            this.btnConStringSave.UseSelectable = true;
            this.btnConStringSave.UseVisualStyleBackColor = true;
            this.btnConStringSave.Click += new System.EventHandler(this.btnConStringSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 694);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lnlClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Filament-Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFilament)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFi)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.MySqlSetting.ResumeLayout(false);
            this.MySqlSetting.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink lnlClose;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox txtPrintWeight;
        private MetroFramework.Controls.MetroTextBox txtFilament;
        private MetroFramework.Controls.MetroTextBox txtPrintID;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnFilamentAdd;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroGrid gvFilament;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSearch;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnScan;
        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private MetroFramework.Controls.MetroTextBox txtGenBarcode;
        private MetroFramework.Controls.MetroComboBox cbFactory;
        private MetroFramework.Controls.MetroGrid gvFi;
        private MetroFramework.Controls.MetroTextBox txtNetto;
        private MetroFramework.Controls.MetroTextBox txtBrutto;
        private MetroFramework.Controls.MetroTextBox txtColor;
        private System.Windows.Forms.GroupBox gbBarcode;
        private MetroFramework.Controls.MetroLink btnGenBarcode;
        private MetroFramework.Controls.MetroLink btnFilaAdd;
        private MetroFramework.Controls.MetroLink btnFilaUpdate;
        private MetroFramework.Controls.MetroLink btnFilaDelete;
        private MetroFramework.Controls.MetroLink btnSaveBarcode;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbBarcodeAlign;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbEncodeType;
        private MetroFramework.Controls.MetroCheckBox chkGenerateLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtHeight;
        private MetroFramework.Controls.MetroTextBox txtWidth;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnForeColor;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cbRotateFlip;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbLabelLocation;
        private System.Windows.Forms.GroupBox MySqlSetting;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtDB;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnConTest;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnConStringSave;
    }
}

