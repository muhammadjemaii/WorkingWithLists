using System;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace WorkingWithLists.ListProgrammaticlly
{
    public partial class AddRecordToProduct :Form
    {
        public AddRecordToProduct()
        {
            InitializeComponent();
        }
        SPList list = ListManager.web.Lists["Products"];


        private void ClearRichText()
        {
            if (rtxt_listSites.Text != string.Empty) rtxt_listSites.Clear();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void AddRecord()
        {
            SPListItem listItem = list.Items.Add();
            listItem["Title"] = txt_title.Text;
            listItem["Price"] = txt_price.Text;

            listItem.Update();

            rtxt_listSites.Text = "Your Record of Product <"+txt_title.Text +"> : <"+ txt_price.Text +">  has been added"; 

        }

        private void SowAllrecord()
        {
            rtxt_listSites.AppendText("\n List All of products ");
            foreach (SPListItem item in list.Items)
            {
                rtxt_listSites.AppendText("\n Title : "+ item["Title"] + "Price : "+ item["Price"]);
            }
        }
        private void FilterProduct(string filter)
        {
            SPQuery query = new SPQuery();
            query.Query = "<Where><Gt><FieldRef Name='Price' /><Value Type='Currency'>" + filter + "</Value></Gt></Where>< OrderBy >< FieldRef Name = 'Price' Ascending = 'True' /></ OrderBy >";


               //"<Where>< Gt >< FieldRef Name = 'Price' />< Value Type = 'Number' >250</ Value ></ Gt ></ Where > ";
               //"< OrderBy > < FieldRef Name = 'Title' Ascending = 'False' /></ OrderBy > ";
               SPListItemCollection itemCollection = list.GetItems(query);

            rtxt_listSites.AppendText("\n List All of products ");
            foreach (SPListItem item in itemCollection)
            {
                rtxt_listSites.AppendText("\n Title : " + item["Title"] + "Price : " + item["Price"]);
            }
        }

        private void Btn_clear_Click_1(object sender, EventArgs e)
        {
            ClearRichText();

        }

        private void Btn_ok_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_cancel_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void Btn_showProducts_Click(object sender, EventArgs e)
        {
            ClearRichText();
            SowAllrecord();
        }

        private void Btn_filter_price_Click(object sender, EventArgs e)
        {
            ClearRichText();
            FilterProduct(txt_price_filter.Text);


        }

        private void Btn_rename_Click(object sender, EventArgs e)
        {
            RenameField();
        }

        private void RenameField()
        {
            SPField field = list.Fields[txt_old_name.Text];
            field.Title = txt_recent_name.Text;
            field.Update();
            rtxt_listSites.Text = "The O ldColum Name " + txt_old_name.Text + "has been rename To : " + txt_recent_name.Text;

        }
    }
}
