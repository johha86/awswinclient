using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWebClient
{
    public partial class Form1 : Form
    {
        private bool _hasStartup = false;

        public Form1()
        {
            InitializeComponent();

            this.Resize += new System.EventHandler(this.Form_Resize);
            webView21.NavigationStarting += NavigationStartingHandler;
            webView21.NavigationCompleted += NavigationCompletedHandler;
        }

        private void NavigationCompletedHandler(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            webView21.NavigationStarting -= NavigationStartingHandler;
            webView21.NavigationCompleted -= NavigationCompletedHandler;
        }

        private void NavigationStartingHandler(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            _hasStartup = true;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }
    }
}
