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
    public partial class Edit : Form
    {
        private Dictionary dic;
        public Edit(Dictionary dictionary)
        {
            InitializeComponent();
            dic = dictionary;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtWord.Text == "") MessageBox.Show("Keyword is empty!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtSub.Text == "") MessageBox.Show("Meaning of word is empty!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Hash.Key = txtWord.Text;
                Hash.Sub = txtSub.Text;
                if (Hash.Edit())
                {
                    MessageBox.Show("ACCESS!!!", "Result", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Keyword is not exists!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
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
