using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altman.Forms
{
    public partial class FormWget : Form
    {
        private string _saveDir;

        public string UrlPath { get { return textBox_url.Text; } }
        public string SavePath { get { return textBox_save.Text; } }

        public FormWget(string saveDir)
        {
            InitializeComponent();

            _saveDir = saveDir;
            textBox_url.Text = "http://";
            textBox_save.Text = _saveDir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_url.Text == "")
            {
                MessageBox.Show(this, "the url couldn't be empty");
                return;
            }
            if (!textBox_url.Text.StartsWith("http://") && !textBox_url.Text.StartsWith("https://"))
            {
                MessageBox.Show(this, "the url should beginning with http[s]://");
                return;
            }
            if (textBox_save.Text == "")
            {
                MessageBox.Show(this, "the save url is empty");
                return;
            }
            if (textBox_save.Text.EndsWith("/"))
            {
                MessageBox.Show(this, "the save url couldn't be folder");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void textBox_url_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_url.Text.Substring(textBox_url.Text.LastIndexOf("/", StringComparison.Ordinal) + 1);
            textBox_save.Text = _saveDir + name;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
