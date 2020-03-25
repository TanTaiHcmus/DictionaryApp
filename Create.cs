using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary2
{
    public partial class Create : Form
    {
        private Dictionary dic;
        public Create(Dictionary dictionary)
        {
            InitializeComponent();
            dic = dictionary;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtfilename.Text == "") MessageBox.Show("File name is empty!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Hash.Key = txtfilename.Text;
                Hash.Create();
                MessageBox.Show("ACCESS!!!", "Result", MessageBoxButtons.OK);
            }
        }

        private void Create_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Do you want to exit?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                e.Cancel = false;
                dic.Show();
            }
            else e.Cancel = true;
        }
    }
}
