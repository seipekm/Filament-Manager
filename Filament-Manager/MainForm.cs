using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filament_Manager
{
    public partial class MainForm : MetroForm
    {
        SqlConnection CON = new SqlConnection("Data Source=localhost;Initial Catalog=FilamentManager;Integrated Security=True");
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();

        public MainForm()
        {
            InitializeComponent();
            cbFactory.SelectedIndex = 0;
            DataGridFill();

        }
                
        private void lnlClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CON.Open();
            string query = "INSERT INTO printJob (barcode, printID, Filament, printWeight, dateTime) VALUES ('" + txtBarcode.Text + "','" + txtPrintID.Text + "','"+ txtFilament.Text + "','" + txtPrintWeight.Text + "','" + DateTime.Now + "')"; 
            SqlDataAdapter SDA = new SqlDataAdapter(query,CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            DataGridFill();
        }

        private void DataGridFill()
        {
            CON.Open();
            string query = "SELECT * FROM printJob";
            SqlDataAdapter SDA = new SqlDataAdapter(query, CON);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            gvFilament.DataSource = DATA;
            CON.Close();
        }

        private void btnFilaAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGenBarcode_Click(object sender, EventArgs e)
        {
            string lastID = "";
            CON.Open();
            string query = "SELECT MAX(ID) FROM ";

            txtBarcode.Text = txtColor.Text + "_" + lastID + "_" + cbFactory.Text;
        }
    }
}
