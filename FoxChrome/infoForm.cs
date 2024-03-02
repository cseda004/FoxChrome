using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxChrome
{
    public partial class infoForm : Form
    {
        public infoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Version: " + Assembly.GetEntryAssembly().GetName().Version;
        }
    }
}
