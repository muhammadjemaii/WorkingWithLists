using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingWithLists.ListProgrammaticlly;
using WorkingWithLists.ImportDataToList;

namespace WorkingWithLists
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Mnu_list_manager_Click(object sender, EventArgs e)
        {
            ListManagers list = new ListManagers();
            list.MdiParent = this;
            list.Show();
        }

        private void AddRecordToProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = new AddRecordToProduct();
            list.MdiParent = this;
            list.Show();
        }

        private void ImportDataToListProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = new ImportDataToListProduct();
            list.MdiParent = this;
            list.Show();
        }
    }
}
