using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class gkms : Form
    {
        public gkms()
        {
            InitializeComponent();
        }
        public void loadsongGKMC(Form form)
        {
            gkmspanel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            gkmspanel.Controls.Add(form);
            form.Show();
        }
        // first song click:
        private void label1_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new FistSongGKMC());
        }
        // 2 song click:
        private void label3_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new SecondsongGKMC());
        }
        //3 song
        private void label4_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new ThirdSongGKMC());

        }
        //4 
        private void label5_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new fourthSongGKMC());
        }
        //5 song
        private void label6_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new fifthSongGKMC());
            
        }
        //6 song
        private void label7_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new sixthSongGKMC());
        }
        //7 song
        private void label2_Click_1(object sender, EventArgs e)
        {
            
            loadsongGKMC(new SeventhSongGKMC());
        }
        //8 song
        private void label8_Click(object sender, EventArgs e)
        {
           
            loadsongGKMC(new EightSongGKMCcs());
        }
        //9 song
        private void label9_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new ninthSongGKMC());
        }
        //10 song
        private void label10_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new RealSong());
        }
        // 11 song
        private void label11_Click(object sender, EventArgs e)
        {
           
            loadsongGKMC(new ComptonSong());
        }
        // 12 song
        private void label12_Click(object sender, EventArgs e)
        {
            
            loadsongGKMC(new remixGKMC());
        }

        //The Art of peer Pressure (Ya propustil((((((( )
        private void label13_Click(object sender, EventArgs e)
        {
            loadsongGKMC(new TheArtOfPeerPressure());
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
