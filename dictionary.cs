using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Dictionary2
{
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search(this);
            this.Hide();
            search.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);
            this.Hide();
            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(this);
            this.Hide();
            edit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(this);
            this.Hide();
            delete.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create create = new Create(this);
            this.Hide();
            create.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dictionary_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Do you want to exit?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) Environment.Exit(0);
            else e.Cancel = true;
        }
    }
}
