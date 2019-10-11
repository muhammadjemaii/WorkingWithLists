using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Windows.Forms;

namespace WorkingWithLists
{
    public partial class ListManagers : Form
    {
        SPSite site;
        SPFarm farm;
        SPWeb web;
        public ListManagers()
        {
            InitializeComponent();
            site = new SPSite("http://sf2016");
            web = site.OpenWeb();
            farm = SPFarm.Local;
            cbx_listType.DataSource = Enum.GetValues(typeof( SPListTemplateType));
        }

        private void Btn_clear_Click(object sender, System.EventArgs e)
        {
            ClearRichText();
        }

        private void ClearRichText()
        {
            if (rtxt_listSites.Text != string.Empty) rtxt_listSites.Clear();
        }

        private void Btn_add_new_list_Click(object sender, EventArgs e)
        {
            rtxt_listSites.Text = ListManager.AddList(txt_title.Text, rtxt_desc.Text,(SPListTemplateType) cbx_listType.SelectedItem);
        }

        private void GetListOfLists()
        {
            SPWeb web = site.OpenWeb();

            foreach (SPList list in web.Lists)
            {
                rtxt_listSites.AppendText("\n [Title] :" + list.Title + " [Row Count] : " + list.ItemCount + " [Author] :" + list.Author + " [Description] " + list.Description);
            }

            rtxt_listSites.AppendText("\n\n [Total Lists] :" + web.Lists.Count);
        }

        private void ShowHideItem(Boolean visible, string ListName)
        {           
            SPList list = web.Lists[ListName];
            list.OnQuickLaunch = visible;
            list.Update();
            rtxt_listSites.Text = "this list "+ txt_list_name.Text +" has visible " + visible;
        }
        private void ShowHideAllItem(Boolean visible)
        {
            foreach (SPList list in web.Lists)
            {
                list.OnQuickLaunch = visible;
                list.Update();
            }
            rtxt_listSites.Text = "All list  was visible to " + visible;
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            ClearRichText();
            GetListOfLists();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            rtxt_listSites.Text = ListManager.DeleteList(txt_title.Text);
        }

        private void Btn_hide_item_Click(object sender, EventArgs e)
        {
            ShowHideItem(false, txt_list_name.Text);
        }

        private void Btn_hide_all_item_Click(object sender, EventArgs e)
        {
            ShowHideAllItem(false);
        }

        private void Btn_show_item_Click(object sender, EventArgs e)
        {
            ShowHideItem(true, txt_list_name.Text);
        }

        private void Btn_show_all_item_Click(object sender, EventArgs e)
        {
            ShowHideAllItem(true);
        }
    }
}
