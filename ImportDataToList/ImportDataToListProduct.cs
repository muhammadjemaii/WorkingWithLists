using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithLists.ImportDataToList
{
    public partial class ImportDataToListProduct : Form
    {

        SPSite site;
        SPFarm farm;
        SPWeb web;
        StreamReader sr;
        public ImportDataToListProduct()
        {
            InitializeComponent();
            site = new SPSite("http://sf2016");
            web = site.OpenWeb();

        }

        private void Btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sr = new StreamReader(openFileDialog1.FileName);
                    txt_fileName.Text = openFileDialog1.FileName;
                    SetText(sr.ToString());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void SetText(string text)
        {
            rtxt_listSites.Text = text;
        }

        private void ImportDataTxt()
        {
            SPList list = web.Lists["Products"];
            SPListItem item = null;
            while (sr.Peek() != -1)
            {
                item = list.Items.Add();
                item["Title"] = sr.ReadLine();
                item["Cost"] = sr.ReadLine();
                item.Update();
            }
            rtxt_listSites.Text = "All record have been imported";

        }
        private void ImportDataCSV()
        {
            SPList list = web.Lists["Products"];
            SPListItem item = null;
            string str;
            while (sr.Peek() != -1)
            {
                str = sr.ReadLine();
                string[] data = str.Split(',');

                item = list.Items.Add();
                item["Title"] = data[0];
                item["Price"] = data[1];
                item.Update();
            }
            rtxt_listSites.Text = "All record have been imported";

        }

        private void ImportDataSql()
        {
            SPList list = web.Lists["Products"];
            SPListItem item = null;


            SqlConnection cn = new SqlConnection("data source=.;initial catalog=dbdemo;integrated security=true;");
            SqlCommand cmd = new SqlCommand("select  * from products", cn);
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (sdr.Read())
            {
                item = list.Items.Add();
                item["Title"] = sdr["Title"];
                item["Price"] = sdr["Price"];
                item.Update();
            }
            Console.WriteLine("Records have been imported..");
            sdr.Close();
            sdr.Dispose();
            sdr = null;



            rtxt_listSites.Text = "All record have been imported";

        }

        private void Txt_imp_txt_Click(object sender, EventArgs e)
        {
            ImportDataTxt();
        }

        private void Txt_imp_csv_Click(object sender, EventArgs e)
        {
            ImportDataCSV();
        }
    }
}
