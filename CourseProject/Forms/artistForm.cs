using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class artistForm : Form
    {
        public artistForm()
        {
            InitializeComponent();
        }
        public void loadformartist(Form form)
        {
            artistpanel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            artistpanel.Controls.Add(form);

            form.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
            label1.Click += delegate { label1.Text = "Clicked"; };
            
            loadformartist(new FormButton1());
        }
    }
}
