﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class fifthSongGKMC : Form
    {
        WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
        bool isPaused = false;
        double pausePosition = 0;
        private TrackBar trackBarSongProgress;
        private Timer timer;

        public fifthSongGKMC()
        {
            InitializeComponent();

            trackBarSongProgress = new TrackBar();
            trackBarSongProgress.Minimum = 0;
            trackBarSongProgress.Maximum = 100;
            trackBarSongProgress.TickStyle = TickStyle.None;
            trackBarSongProgress.Dock = DockStyle.Bottom;
            trackBarSongProgress.Scroll += TrackBarSongProgress_Scroll;
            this.Controls.Add(trackBarSongProgress);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (wmp != null && wmp.currentMedia != null)
            {
                trackBarSongProgress.Maximum = (int)wmp.currentMedia.duration;

                if ((int)wmp.controls.currentPosition <= trackBarSongProgress.Maximum)
                {
                    trackBarSongProgress.Value = (int)wmp.controls.currentPosition;
                }
            }

            if (wmp.controls.currentPosition >= wmp.currentMedia.duration)
            {
                timer.Stop();
                wmp.controls.stop();
                trackBarSongProgress.Value = trackBarSongProgress.Maximum;
            }
        }

        private void TrackBarSongProgress_Scroll(object sender, EventArgs e)
        {
            if (wmp != null)
            {
                wmp.controls.currentPosition = trackBarSongProgress.Value;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                wmp.controls.pause();
                pausePosition = wmp.controls.currentPosition;
                isPaused = true;
                timer.Stop();
            }
            else
            {
                wmp.controls.currentPosition = pausePosition;
                wmp.controls.play();
                isPaused = false;
                timer.Start();
            }
        }

        public void loadpage(Form form)
        {
            fifthpanel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            fifthpanel.Controls.Add(form);

            form.Show();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (wmp != null && wmp.currentMedia != null)
            {
                wmp.controls.currentPosition = trackBar2.Value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            wmp.URL = @"C:\Users\david\source\repos\CourseProject\Coursa4\songs\Poetic.mp3";
            wmp.controls.play();
            isPaused = false;
            timer.Start();
            trackBarSongProgress.Value = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadpage(new sixthSongGKMC());
            if (!isPaused)
            {
                wmp.controls.pause();
                pausePosition = wmp.controls.currentPosition;
                isPaused = true;
                timer.Stop();
            }

        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            if (wmp != null && wmp.currentMedia != null)
            {
                wmp.controls.currentPosition = trackBar2.Value;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wmp.settings.volume = trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=yyr2gEouEMM");
        }
    }
}