using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class FormButton1 : Form
    {
        public FormButton1()
        {
            InitializeComponent();
        }
        public void loadformkl(Form form)
        {
            KLpanel.Controls.Clear();
            
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            
            KLpanel.Controls.Add(form);
            
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadformkl(new gkms());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/kendricklamar"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://open.spotify.com/artist/2YZyLoL8N0Wb9xBt1NhZWg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC3lBXcrKFnFAFkfVk5WuKcQ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/kendricklamar/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/kendricklamar");
        }

    }
}
