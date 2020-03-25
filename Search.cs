using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Dictionary2
{
    public partial class Search : Form
    {
        private Dictionary dic;
        public Search(Dictionary dictionary)
        {
            InitializeComponent();
            dic = dictionary;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "") MessageBox.Show("Keyword is empty!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Hash.Key = txtKey.Text;
                if (Hash.kiemtra())
                {
                    MessageBox.Show(Hash.getSub(), "Result", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Keyword is not exists!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
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
