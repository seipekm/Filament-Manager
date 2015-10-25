using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Deployment;
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
using System.Net;
using Newtonsoft.Json.Linq;
using Filament_Manager.Class;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Filament_Manager
{
    public partial class MainForm : MetroForm
    {
        private MySqlConnection Sqlconnection;
        private MySqlCommand cmd;
        private delegate bool DelBackup(string filename);

        public string ApiServerVersion = "1.2.7";

        BarcodeLib.Barcode b = new BarcodeLib.Barcode();
        

        public MainForm()
        {                      
            InitializeComponent();
            loadSetting();
            SqlCon();
            initStyle();
            cbFactory.SelectedIndex = 0;
            metroTabControl1.SelectedIndex = 0;
            btnCamDisCon.Enabled = false;
            btnCamCon.Enabled = true;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                lbVersion.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
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
                getPrintOsVersion();
                getPrintOperation();
                timer1.Start();
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
                MetroMessageBox.Show(this, "Verbindung OK", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.Write("Connect");
                Sqlconnection.Close();

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Sqlconnection.Close();
                        break;

                    case 1045:
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCamCon_Click(object sender, EventArgs e)
        {
            var uri = new Uri("http://" + txtIpOcto.Text + "/webcam/?action=stream");
            streamPlayerControl.StartPlay(uri);
            btnCamDisCon.Enabled = true;
            btnCamCon.Enabled = false;


        }

        private void btnCamDisCon_Click(object sender, EventArgs e)
        {
            streamPlayerControl.Stop();
            btnCamDisCon.Enabled = false;
            btnCamCon.Enabled = true;

        }

        private void ctFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (ctFullScreen.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnSetTemp_Click(object sender, EventArgs e)
        {

            var targetTemp = new TargetTemp { command = "target" };
            targetTemp.targets = new targets { tool0 = Int16.Parse(txtSetTemp.Text) };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(targetTemp, setting);

            Console.WriteLine(data);
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/tool?apikey=" + txtApi.Text, data);

            txtSetTemp.Text = "";
        }

        private void btnJogXneg01_Click(object sender, EventArgs e)
        {
            var jogXneg01 = new JogX { command = "jog", x = 0.1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogXneg01, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogXneg1_Click(object sender, EventArgs e)
        {
            var jogXneg1 = new JogX { command = "jog", x = 1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogXneg1, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogXneg10_Click(object sender, EventArgs e)
        {
            var jogXneg10 = new JogX { command = "jog", x = 10 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogXneg10, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogXneg100_Click(object sender, EventArgs e)
        {
            var jogXneg100 = new JogX { command = "jog", x = 100 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogXneg100, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnHomeXY_Click(object sender, EventArgs e)
        {
            var jogHomeXY = new Command { command = "G28 X Y" };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogHomeXY, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/command?apikey=" + txtApi.Text, data);
        }

        private void btnJogXpos01_Click(object sender, EventArgs e)
        {
            var jogXpos01 = new JogX { command = "jog", x = -0.1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogXpos01, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogXpos1_Click(object sender, EventArgs e)
        {
            var jogXpos1 = new JogX { command = "jog", x = -1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogXpos1, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogXpos10_Click(object sender, EventArgs e)
        {
            var jogXpos10 = new JogX { command = "jog", x = -10 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogXpos10, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogXpos100_Click(object sender, EventArgs e)
        {
            var jogXpos100 = new JogX { command = "jog", x = -100 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogXpos100, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogYneg01_Click(object sender, EventArgs e)
        {
            var jogYneg01 = new JogY { command = "jog", y = -0.1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogYneg01, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogYneg1_Click(object sender, EventArgs e)
        {
            var jogYneg1 = new JogY { command = "jog", y = -1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogYneg1, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogYneg10_Click(object sender, EventArgs e)
        {
            var jogYneg10 = new JogY { command = "jog", y = -10 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogYneg10, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogYneg100_Click(object sender, EventArgs e)
        {
            var jogYneg100 = new JogY { command = "jog", y = -100 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogYneg100, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogYpos01_Click(object sender, EventArgs e)
        {
            var jogYpos01 = new JogY { command = "jog", y = 0.1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogYpos01, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogYpos1_Click(object sender, EventArgs e)
        {
            var jogYpos1 = new JogY { command = "jog", y = 1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogYpos1, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogYpos10_Click(object sender, EventArgs e)
        {
            var jogYpos10 = new JogY { command = "jog", y = 10 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogYpos10, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogYpos100_Click(object sender, EventArgs e)
        {
            var jogYpos100 = new JogY { command = "jog", y = 100 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogYpos100, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogZneg01_Click(object sender, EventArgs e)
        {
            var jogZneg01 = new JogZ { command = "jog", z = -0.1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogZneg01, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogZneg1_Click(object sender, EventArgs e)
        {
            var jogZneg1 = new JogZ { command = "jog", z = -1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogZneg1, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogZneg10_Click(object sender, EventArgs e)
        {
            var jogZneg10 = new JogZ { command = "jog", z = -10 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogZneg10, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogZneg100_Click(object sender, EventArgs e)
        {
            var jogZneg100 = new JogZ { command = "jog", z = -100 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogZneg100, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogZpos01_Click(object sender, EventArgs e)
        {
            var jogZpos01 = new JogZ { command = "jog", z = 0.1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogZpos01, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogZpos1_Click(object sender, EventArgs e)
        {
            var jogZpos1 = new JogZ { command = "jog", z = 1 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogZpos1, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogZpos10_Click(object sender, EventArgs e)
        {
            var jogZpos10 = new JogZ { command = "jog", z = 10 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogZpos10, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnJogZpos100_Click(object sender, EventArgs e)
        {
            var jogZpos100 = new JogZ { command = "jog", z = 100 };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogZpos100, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/printhead?apikey=" + txtApi.Text, data);
        }

        private void btnHomePosition_Click(object sender, EventArgs e)
        {
            var jogHome = new Command { command = "G28 X0 Y0 Z0" };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogHome, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/command?apikey=" + txtApi.Text, data);
        }

        private void btnHomeZ_Click(object sender, EventArgs e)
        {
            var jogHome = new Command { command = "G28 Z0" };

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var data = JsonConvert.SerializeObject(jogHome, setting);

            Console.WriteLine(data);

            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.UploadString("http://" + txtIpOcto.Text + "/api/printer/command?apikey=" + txtApi.Text, data);
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
            Properties.Settings.Default.PrinterIP = txtIpOcto.Text;
            Properties.Settings.Default.ApiKey = txtApi.Text;
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
            txtApi.Text = Properties.Settings.Default.ApiKey;
            txtIpOcto.Text = Properties.Settings.Default.PrinterIP;


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            getPrintOperation();
            getJobOperation();
        }

        private void getPrintOsVersion()
        {
            try
            {
                WebClient client = new WebClient();
                var data = client.DownloadString("http://" + txtIpOcto.Text + "/api/version?apikey=" + txtApi.Text);
                Console.Write(data);
                JObject json = JObject.Parse(data);
                txtApiVersion.Text = json["api"].ToString();
                txtServerVersion.Text = (json["server"].ToString() + " / " + ApiServerVersion);

                if(json["server"].ToString() != ApiServerVersion)
                {
                    MetroMessageBox.Show(this, "Server version ist warscheinlich nicht Kompaktibel", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getPrintOperation()
        {
            WebClient client = new WebClient();
            var data = client.DownloadString("http://" + txtIpOcto.Text + "/api/printer?apikey=" + txtApi.Text);
            JObject json = JObject.Parse(data);
            txtPrintTemp.Text = json["temperature"]["tool0"]["actual"].ToString() + "°C / " + json["temperature"]["tool0"]["target"].ToString()+"°C";
            txtPrintState.Text = json["state"]["text"].ToString();
            txtSetTemp.WaterMark = json["temperature"]["tool0"]["target"].ToString() + "°C";

        }
        private void getJobOperation()
        {
            WebClient client = new WebClient();
            var data = client.DownloadString("http://" + txtIpOcto.Text + "/api/job?apikey=" + txtApi.Text);
            JObject json = JObject.Parse(data);

            //File Name
            if(json["job"]["file"]["name"].ToString() == "")
            {
                txtFileName.Text = "-";
            }
            else
            {
                txtFileName.Text = json["job"]["file"]["name"].ToString();
            }
            

            //calculation Print Weight with print length
            if(json["job"]["file"]["name"].ToString() != "")
            {
                try
                {
                    if (json["job"]["filament"]["tool0"]["length"].ToString() == "")
                    {
                        txtWeight.Text = "-";
                    }
                    else
                    {
                        string volumeStr = json["job"]["filament"]["tool0"]["length"].ToString();
                        double volume = double.Parse(volumeStr);
                        double calcWeight = 0.00121 * 0.875 * 0.875 * Math.PI * volume;
                        txtWeight.Text = calcWeight.ToString("0.#") + "g";
                    }
                }
                catch
                {
                    txtWeight.Text = "-";
                }
            }
            else
            {
                txtWeight.Text = "-";
            }
            

            //Calc Print Time
            if (json["job"]["lastPrintTime"].ToString() == "" && json["job"]["estimatedPrintTime"].ToString() != "")
            {
                string calcNewTimeStr = json["job"]["estimatedPrintTime"].ToString();
                double calcNewTime = double.Parse(calcNewTimeStr);
                TimeSpan calcnewt = TimeSpan.FromSeconds(calcNewTime);
                txtCalcPrintTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", calcnewt.Hours, calcnewt.Minutes, calcnewt.Seconds);
            }
            else if(json["job"]["lastPrintTime"].ToString() != "")
            {
                string calcNewTimeStr = json["job"]["lastPrintTime"].ToString();
                double calcNewTime = double.Parse(calcNewTimeStr);
                TimeSpan calcnewt = TimeSpan.FromSeconds(calcNewTime);
                txtCalcPrintTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", calcnewt.Hours, calcnewt.Minutes, calcnewt.Seconds);
            }
            else
            {
                txtCalcPrintTime.Text = "-";
            }

            //Print Time
            string TimeStr = json["progress"]["printTime"].ToString();
            if(TimeStr == "")
            {
                txtPrintTime.Text = "-";
            }
            else
            {
                double Time = double.Parse(TimeStr);
                TimeSpan t = TimeSpan.FromSeconds(Time);
                txtPrintTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            }
            

            //Print time left
            string TimeLeftStr = json["progress"]["printTimeLeft"].ToString();
            if(TimeLeftStr == "")
            {
                txtPrintTimeEnd.Text = "-";
            }
            else
            {
                double TimeLeft = double.Parse(TimeLeftStr);
                TimeSpan tl = TimeSpan.FromSeconds(TimeLeft);
                txtPrintTimeEnd.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", tl.Hours, tl.Minutes, tl.Seconds);
            }
            
            //Processbar
            string ProcessStr = json["progress"]["completion"].ToString();
            double ProcessDouble = double.Parse(ProcessStr);
            int ProgressBar = Convert.ToInt32(ProcessDouble);
            pbProcess.Value = ProgressBar;
        }

        
    }
    
}
