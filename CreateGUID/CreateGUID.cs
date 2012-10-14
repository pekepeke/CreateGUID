using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CreateGUID : Form
    {
        public CreateGUID() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            Guid guid = Guid.NewGuid();
            txtGuid.Text = guid.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e) {
            String guid = txtGuid.Text;
            // MessageBox.Show(guid);
            if (guid.Length > 0) {
                Clipboard.SetText(guid);
            }
        }

        private void txtGuid_Click(object sender, EventArgs e) {
            txtGuid.SelectAll();
        }

    }
}
