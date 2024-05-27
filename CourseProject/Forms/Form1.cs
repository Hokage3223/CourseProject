using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void btnArtist_Click(object sender, EventArgs e)
        {
            loadform(new artistForm());
        }
        // missclick na winFormah - knopka btnSearch
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new searchForm());
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            loadform(new categoriesForm());

        }
        // missclick na winFormah - knopka btnclose
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 128, 227), 65f);
       
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
