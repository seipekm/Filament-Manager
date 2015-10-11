﻿namespace Filament_Manager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGenBarcode = new MetroFramework.Controls.MetroTextBox();
            this.cbFactory = new MetroFramework.Controls.MetroComboBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.txtNetto = new MetroFramework.Controls.MetroTextBox();
            this.txtBrutto = new MetroFramework.Controls.MetroTextBox();
            this.txtColor = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.btnFilaDelete = new MetroFramework.Controls.MetroLink();
            this.btnFilaUpdate = new MetroFramework.Controls.MetroLink();
            this.btnFilaAdd = new MetroFramework.Controls.MetroLink();
            this.btnGenBarcode = new MetroFramework.Controls.MetroLink();
            this.lnlClose = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilament)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
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
            this.metroTabPage2.Controls.Add(this.metroLink1);
            this.metroTabPage2.Controls.Add(this.btnFilaDelete);
            this.metroTabPage2.Controls.Add(this.btnFilaUpdate);
            this.metroTabPage2.Controls.Add(this.btnFilaAdd);
            this.metroTabPage2.Controls.Add(this.btnGenBarcode);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.txtGenBarcode);
            this.metroTabPage2.Controls.Add(this.cbFactory);
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.Controls.Add(this.txtNetto);
            this.metroTabPage2.Controls.Add(this.txtBrutto);
            this.metroTabPage2.Controls.Add(this.txtColor);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(841, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 173);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barcode";
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
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 240);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1204, 326);
            this.metroGrid1.TabIndex = 23;
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
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // metroLink1
            // 
            this.metroLink1.Image = global::Filament_Manager.Properties.Resources.Save1;
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.ImageSize = 50;
            this.metroLink1.Location = new System.Drawing.Point(1008, 184);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = global::Filament_Manager.Properties.Resources.Save;
            this.metroLink1.Size = new System.Drawing.Size(50, 50);
            this.metroLink1.TabIndex = 35;
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.UseSelectable = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 694);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lnlClose);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Filament-Manager";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFilament)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
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
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtNetto;
        private MetroFramework.Controls.MetroTextBox txtBrutto;
        private MetroFramework.Controls.MetroTextBox txtColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLink btnGenBarcode;
        private MetroFramework.Controls.MetroLink btnFilaAdd;
        private MetroFramework.Controls.MetroLink btnFilaUpdate;
        private MetroFramework.Controls.MetroLink btnFilaDelete;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

