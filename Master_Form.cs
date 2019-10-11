using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithLists
{
    public partial class Master_Form : Form
    {
        public Master_Form()
        {
            InitializeComponent();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Btn_clear_Click(object sender, System.EventArgs e)
        {
            ClearRichText();
        }

        private void ClearRichText()
        {
            if (rtxt_listSites.Text != string.Empty) rtxt_listSites.Clear();
        }

    }
}
