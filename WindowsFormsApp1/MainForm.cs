using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oauthForm = new OAuthForm(this);
            oauthForm.ShowDialog();
        }

        public void SetLabelTest(String labelText)
        {
            this.label1.Text = labelText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
