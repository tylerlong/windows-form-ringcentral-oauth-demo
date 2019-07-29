using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RingCentral;

namespace WindowsFormsApp1
{
    public partial class OAuthForm : Form
    {
        private const string REDIRECT_URI = "https://does-not-exist.com";
        private RestClient rc = new RestClient("", "", true);
        private MainForm mainForm;
        public OAuthForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            this.webBrowser1.Navigating += WebBrowser1_Navigating;

            this.webBrowser1.Url = new Uri(rc.AuthorizeUri(REDIRECT_URI));
        }

        private async void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            var url = e.Url.ToString();
            if (url.StartsWith(REDIRECT_URI))
            {
                var code = url.Split(new string[] { "?code=" }, StringSplitOptions.None)[1];
                this.Hide();
                await rc.Authorize(code, REDIRECT_URI);
                mainForm.SetLabelTest("You have been authorized, access token is " + rc.token.access_token);
            }
        }
    }
}
