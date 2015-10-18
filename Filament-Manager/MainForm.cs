using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filament_Manager
{
    public partial class MainForm : MetroForm
    {
        private MySqlConnection Sqlconnection;
        private MySqlCommand cmd;
        private delegate bool DelBackup(string filename);

        BarcodeLib.Barcode b = new BarcodeLib.Barcode();

        public MainForm()
        {                      
            InitializeComponent();
            loadSetting();
            SqlCon();
            initStyle();
            cbFactory.SelectedIndex = 0;
            metroTabControl1.SelectedIndex = 0;
        }

        public void _tile_Click(object sender, EventArgs e)
        {
            StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        public void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                DataGridPrintJob();
                DataGridFilament();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void lnlClose_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Sqlconnection.Open();
                string query = "INSERT INTO PrintJob (Barcode, PrintID, Filament, PrintWeight, Time) VALUES ('" + txtBarcode.Text + "','" + txtPrintID.Text + "','" + txtFilament.Text + "','" + txtPrintWeight.Text + "','" + DateTime.Now + "')";
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, Sqlconnection);
                SDA.SelectCommand.ExecuteNonQuery();
                Sqlconnection.Close();
                DataGridPrintJob();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Sqlconnection.Close();
            }
            
        }

        private void btnFilaAdd_Click(object sender, EventArgs e)
        {
            if (cbFactory.Text == "Auswählen..." || txtColor.Text == "" || txtBrutto.Text == "" || txtNetto.Text == "")
            {
                MetroMessageBox.Show(this, "Es wurde nicht alles ausgefüllt", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if(txtGenBarcode.Text == "")
                {
                    MetroMessageBox.Show(this, "Barcode wurde nicht erstellt. Bitte erstellen sie einen Barcode", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Sqlconnection.Open();
                        string query = "INSERT INTO Filament (Barcode, Factory, Color, Brutto, Netto, Time) VALUES ('" + txtGenBarcode.Text + "','" + cbFactory.Text + "','" + txtColor.Text + "','" + txtBrutto.Text + "','" + txtNetto.Text + "','" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd") + "')";
                        MySqlDataAdapter SDA = new MySqlDataAdapter(query, Sqlconnection);
                        SDA.SelectCommand.ExecuteNonQuery();
                        Sqlconnection.Close();
                        DataGridFilament();
                    }
                    catch(Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        Sqlconnection.Close();
                    }
                    
                }
            }
            
        }

        private void btnGenBarcode_Click(object sender, EventArgs e)
        {
            if(txtGenBarcode.Text == "")
            {
                if (txtColor.Text == "" || cbFactory.Text == "Auswählen...")
                {
                    MetroMessageBox.Show(this, "Es wurde nicht alles ausgefüllt", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {

                    try
                    {
                        cmd = new MySqlCommand("SELECT ID FROM Filament ORDER BY ID DESC LIMIT 1", Sqlconnection);
                    }
                    catch (MySqlException ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    try
                    {
                        int lastID;

                        Sqlconnection.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            int nextID;
                            if (reader.GetInt32(0) == 0)
                            {
                                nextID = 1;
                                break;
                            }
                            else
                            {
                                lastID = reader.GetInt32(0);
                                nextID = lastID + 1;

                            }
                            txtGenBarcode.Text = txtColor.Text + "_" + nextID + "_" + cbFactory.Text;

                        }
                        Sqlconnection.Close();
                        BarcodeGenerator();

                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        Sqlconnection.Close();
                    }
                }
            }
            else
            {
                BarcodeGenerator();
            }

            
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.b.ForeColor = cdialog.Color;
                    this.btnForeColor.BackColor = cdialog.Color;
                }//if
            }//using
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.b.BackColor = cdialog.Color;
                    this.btnBackColor.BackColor = cdialog.Color;
                }//if
            }//using
        }

        private void btnSaveBarcode_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 4;
            sfd.AddExtension = true;
            sfd.FileName = "Barcode_" + txtGenBarcode.Text;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = BarcodeLib.SaveTypes.BMP; break;
                    case 2: /* GIF */  savetype = BarcodeLib.SaveTypes.GIF; break;
                    case 3: /* JPG */  savetype = BarcodeLib.SaveTypes.JPG; break;
                    case 4: /* PNG */  savetype = BarcodeLib.SaveTypes.PNG; break;
                    case 5: /* TIFF */ savetype = BarcodeLib.SaveTypes.TIFF; break;
                    default: break;
                }
                b.SaveImage(sfd.FileName, savetype);
            }
        }

        private void btnConStringSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBAdress = txtHost.Text;
            Properties.Settings.Default.DB = txtDB.Text;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.password = txtPassword.Text;
            Properties.Settings.Default.Save();
            SqlCon();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void btnConTest_Click(object sender, EventArgs e)
        {
            try
            {
                Sqlconnection.Open();
                MetroMessageBox.Show(this, "Verbindung OK", "Erfolgreich", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                System.Threading.Thread.Sleep(5000);
                Console.Write("Connect");
                Sqlconnection.Close();

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        Sqlconnection.Close();
                        break;

                    case 1045:
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        Sqlconnection.Close();
                        break;
                }
            }
        }

        private void btnFilaUpdate_Click(object sender, EventArgs e)
        {
            Sqlconnection.Open();
            string query = "UPDATE Filament SET Barcode='" + txtGenBarcode.Text + "',Factory='" + cbFactory.Text + "',Color='" + txtColor.Text + "',Brutto='" + txtBrutto.Text + "',Netto='" + txtNetto.Text + "',Time='" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd") + "' WHERE Barcode='" + txtGenBarcode.Text + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, Sqlconnection);
            SDA.SelectCommand.ExecuteNonQuery();
            Sqlconnection.Close();
            DataGridFilament();
        }

        private void btnFilaDelete_Click(object sender, EventArgs e)
        {
            Sqlconnection.Open();
            string query = "DELETE FROM Filament WHERE Barcode='" + txtGenBarcode.Text + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, Sqlconnection);
            SDA.SelectCommand.ExecuteNonQuery();
            Sqlconnection.Close();
            DataGridFilament();
        }

        private void gvFi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtGenBarcode.Text = gvFi.SelectedRows[0].Cells[1].Value.ToString();
            cbFactory.Text = gvFi.SelectedRows[0].Cells[2].Value.ToString();
            txtColor.Text = gvFi.SelectedRows[0].Cells[3].Value.ToString();
            txtBrutto.Text = gvFi.SelectedRows[0].Cells[4].Value.ToString();
            txtNetto.Text = gvFi.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void txtBrutto_TextChanged(object sender, EventArgs e)
        {
            if (txtBrutto.Text == "")
            {

            }
            else
            {
                int Brutto = Convert.ToInt32(txtBrutto.Text);
                int Sum = Brutto - 250;

                txtNetto.Text = Convert.ToString(Sum);
            }

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            bool _close = false;


            string _filename = txtDB.Text + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            SaveFileDialog _dia = new SaveFileDialog();
            _dia.Title = "Backup Database";
            _dia.Filter = "SQL files (*.sql)|*.sql";
            _dia.FileName = _filename;
            _dia.DefaultExt = "*.sql";
            _dia.InitialDirectory = string.Empty;
            if (_dia.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(_dia.FileName.Trim()))
            {
                _filename = _dia.FileName;
            }
            else
            {
                _close = true;
            }
            _dia.Dispose();
            _dia = null;

            if (_close) return;

            DelBackup _del = new DelBackup(DoBackup);
            IAsyncResult _asc = _del.BeginInvoke(_filename, null, _del);



            if (_del.EndInvoke(_asc))
            {
                MetroMessageBox.Show(this, "Backup was written successfully!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _close = true;
            }
            else
            {
                Size _size = this.Size;
                MetroMessageBox.Show(this, "Please check if supporting backup tools were present at the application's current path", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Size = _size;
            }

            _del = null;
            _asc = null;

            if (_close)
            {
                DialogResult = DialogResult.OK;

            }
        }

        private void SqlCon()
        {
            string ConnectionString = "server=" + txtHost.Text + ";user=" + txtUser.Text + ";database=" +
            txtDB.Text + ";password=" + txtPassword.Text + ";";

            Sqlconnection = new MySqlConnection(ConnectionString);
        }
                        
        private void DataGridPrintJob()
        {
            try
            {
                Sqlconnection.Open();
                string query = "SELECT * FROM PrintJob";
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, Sqlconnection);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                gvFilament.DataSource = DATA;
                Sqlconnection.Close();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Sqlconnection.Close();
            }
            
        }

        private void DataGridFilament()
        {
            try
            {
                Sqlconnection.Open();
                string query = "SELECT * FROM Filament";
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, Sqlconnection);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                gvFi.DataSource = DATA;
                Sqlconnection.Close();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Sqlconnection.Close();
            }
            
        }

        private void BarcodeGenerator()
        {
            int W = Convert.ToInt32(this.txtWidth.Text.Trim());
            int H = Convert.ToInt32(this.txtHeight.Text.Trim());
            b.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            switch (cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower())
            {
                case "left": b.Alignment = BarcodeLib.AlignmentPositions.LEFT; break;
                case "right": b.Alignment = BarcodeLib.AlignmentPositions.RIGHT; break;
                default: b.Alignment = BarcodeLib.AlignmentPositions.CENTER; break;
            }

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            switch (cbEncodeType.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = BarcodeLib.TYPE.UPCA; break;
                case "UPC-E": type = BarcodeLib.TYPE.UPCE; break;
                case "UPC 2 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                case "UPC 5 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                case "EAN-13": type = BarcodeLib.TYPE.EAN13; break;
                case "JAN-13": type = BarcodeLib.TYPE.JAN13; break;
                case "EAN-8": type = BarcodeLib.TYPE.EAN8; break;
                case "ITF-14": type = BarcodeLib.TYPE.ITF14; break;
                case "Codabar": type = BarcodeLib.TYPE.Codabar; break;
                case "PostNet": type = BarcodeLib.TYPE.PostNet; break;
                case "Bookland/ISBN": type = BarcodeLib.TYPE.BOOKLAND; break;
                case "Code 11": type = BarcodeLib.TYPE.CODE11; break;
                case "Code 39": type = BarcodeLib.TYPE.CODE39; break;
                case "Code 39 Extended": type = BarcodeLib.TYPE.CODE39Extended; break;
                case "Code 39 Mod 43": type = BarcodeLib.TYPE.CODE39_Mod43; break;
                case "Code 93": type = BarcodeLib.TYPE.CODE93; break;
                case "LOGMARS": type = BarcodeLib.TYPE.LOGMARS; break;
                case "MSI": type = BarcodeLib.TYPE.MSI_Mod10; break;
                case "Interleaved 2 of 5": type = BarcodeLib.TYPE.Interleaved2of5; break;
                case "Standard 2 of 5": type = BarcodeLib.TYPE.Standard2of5; break;
                case "Code 128": type = BarcodeLib.TYPE.CODE128; break;
                case "Code 128-A": type = BarcodeLib.TYPE.CODE128A; break;
                case "Code 128-B": type = BarcodeLib.TYPE.CODE128B; break;
                case "Code 128-C": type = BarcodeLib.TYPE.CODE128C; break;
                case "Telepen": type = BarcodeLib.TYPE.TELEPEN; break;
                case "FIM": type = BarcodeLib.TYPE.FIM; break;
                case "Pharmacode": type = BarcodeLib.TYPE.PHARMACODE; break;
                default: MessageBox.Show("Please specify the encoding type."); break;
            }
            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    b.IncludeLabel = this.chkGenerateLabel.Checked;

                    b.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.cbRotateFlip.SelectedItem.ToString(), true);

                    switch (this.cbLabelLocation.SelectedItem.ToString().Trim().ToUpper())
                    {
                        case "BOTTOMLEFT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT; break;
                        case "BOTTOMRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMRIGHT; break;
                        case "TOPCENTER": b.LabelPosition = BarcodeLib.LabelPositions.TOPCENTER; break;
                        case "TOPLEFT": b.LabelPosition = BarcodeLib.LabelPositions.TOPLEFT; break;
                        case "TOPRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.TOPRIGHT; break;
                        default: b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER; break;
                    }//switch

                    gbBarcode.BackgroundImage = b.Encode(type, this.txtGenBarcode.Text.Trim(), this.btnForeColor.BackColor, this.btnBackColor.BackColor, W, H);
                }
                gbBarcode.Location = new Point((this.gbBarcode.Location.X + this.gbBarcode.Width / 2) - gbBarcode.Width / 2, (this.gbBarcode.Location.Y + this.gbBarcode.Height / 2) - gbBarcode.Height / 2);
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void saveSettings()
        {
            Properties.Settings.Default.checkLabel = chkGenerateLabel.Checked;
            Properties.Settings.Default.lablLocation = cbBarcodeAlign.SelectedIndex;
            Properties.Settings.Default.btnForColor = btnForeColor.BackColor;
            Properties.Settings.Default.btnBackColor = btnBackColor.BackColor;
            Properties.Settings.Default.barcodeHeight = Convert.ToInt32(this.txtHeight.Text.Trim());
            Properties.Settings.Default.barcodeWidth = Convert.ToInt32(this.txtWidth.Text.Trim());
            Properties.Settings.Default.barcodeTyp = cbEncodeType.SelectedIndex;
            Properties.Settings.Default.labelpos = cbLabelLocation.SelectedIndex;
            Properties.Settings.Default.styleColor = msmMain.Style;
            Properties.Settings.Default.FullScreen = ctFullScreen.Checked;
            Properties.Settings.Default.Save();
        }

        private void loadSetting()
        {
            chkGenerateLabel.Checked = Properties.Settings.Default.checkLabel;
            cbBarcodeAlign.SelectedIndex = Properties.Settings.Default.lablLocation;
            btnForeColor.BackColor = Properties.Settings.Default.btnForColor;
            btnBackColor.BackColor = Properties.Settings.Default.btnBackColor;
            txtWidth.Text = Convert.ToString(Properties.Settings.Default.barcodeWidth);
            txtHeight.Text = Convert.ToString(Properties.Settings.Default.barcodeHeight);
            cbEncodeType.SelectedIndex = Properties.Settings.Default.barcodeTyp;
            cbLabelLocation.SelectedIndex = Properties.Settings.Default.labelpos;
            txtHost.Text = Properties.Settings.Default.DBAdress;
            txtDB.Text = Properties.Settings.Default.DB;
            txtUser.Text = Properties.Settings.Default.User;
            txtPassword.Text = Properties.Settings.Default.password;
            msmMain.Style = Properties.Settings.Default.styleColor;
            ctFullScreen.Checked = Properties.Settings.Default.FullScreen;


            this.cbRotateFlip.DataSource = System.Enum.GetNames(typeof(RotateFlipType));

            int i = 0;
            foreach (object o in cbRotateFlip.Items)
            {
                if (o.ToString().Trim().ToLower() == "rotatenoneflipnone")
                    break;
                i++;
            }//foreach
            this.cbRotateFlip.SelectedIndex = i;


        }

        private void initStyle()
        {
            this.StyleManager = msmMain;

            for (int i = 3; i < 15; i++)
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flpSettings.Controls.Add(_tile);
            }
        }

        private bool DoBackup(string filename)
        {
            string _batfile = "";
            bool _return = true;
            string _sqlfile = Path.GetFileName(filename).Replace(Path.GetExtension(filename), ".sql");
            _sqlfile = Application.StartupPath + "\\Maker\\" + _sqlfile;

            if (!Directory.Exists(Application.StartupPath + "\\Maker"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Maker");
            }

            _batfile = Application.StartupPath + "\\Maker\\batmake.bat";

            try
            {
                if (File.Exists(_sqlfile)) File.Delete(_sqlfile);
            }
            catch (Exception)
            {
            }

            StreamWriter _sw = File.CreateText(_batfile);
            _sw.WriteLine(@"""" + Application.StartupPath + @"\Resources\mysqldump"" --host=" + txtHost.Text + " --port=" + 3306 + " --user=" + txtUser.Text + " --password=" + txtPassword.Text + " " + txtDB.Text + " --routines > " + @"""" + _sqlfile + @"""");
            _sw.Close();
            _sw.Dispose();

            Process _bu = new Process();
            _bu.StartInfo.FileName = _batfile;
            _bu.StartInfo.CreateNoWindow = true;
            _bu.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            _bu.StartInfo.RedirectStandardError = true;
            _bu.StartInfo.UseShellExecute = false;
            _bu.Start();

            while (!_bu.HasExited)
            {
                //Application.DoEvents();
            }

            _bu.Dispose();
            _bu = null;

            if (!File.Exists(_sqlfile))
            {
                _return = false;
            }
            else
            {
                File.Copy(_sqlfile, filename);
            }

            File.Delete(_sqlfile);
            File.Delete(_batfile);

            return _return;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCheckInfo info;
            if(ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MetroMessageBox.Show(this, "The new Version of the application can't be downloaded at this time.\n\nPlease check you Network connection or try again later. Error: "+
                        dde.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch(InvalidDeploymentException ide)
                {
                    MetroMessageBox.Show(this, "Can't check for a new version of the application. The ClickOnce deployment is currupt. Please redeploy the application and try again . Error: " +
                        ide.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch(InvalidOperationException ioe)
                {
                    MetroMessageBox.Show(this, "This application can't be update. it's likely not a ClickOnce application .Error: " +
                        ioe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(info.UpdateAvailable)
                {
                    if (MetroMessageBox.Show(this, "A newer version is available. Would you like to update it now?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ad.Update();
                            Application.Restart();
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "You are running the latest version",
                        "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            else
            {
                MetroMessageBox.Show(this, "Fehler",
                        "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void ctFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if(ctFullScreen.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }
    }
    
}
