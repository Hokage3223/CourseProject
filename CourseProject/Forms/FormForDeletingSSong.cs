using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Model
{
    public partial class FormForDeletingSSong : Form
    {
        private songsMethods songMethods;
        private string filePath = @"..\..\..\Coursa4\json\kdot.json";
        public FormForDeletingSSong()
        {
            InitializeComponent();
            songMethods = new songsMethods();
            songMethods.JsonDataInCursach(filePath);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string artist = artistTextBox.Text;
            string album = albumTextBox.Text;
            string songTitle = songTitleTextBox.Text;
            int year;

            if (int.TryParse(yearTextBox.Text, out year))
            {
                SSong songToRemove = new SSong(artist, album, songTitle, year);                
                songMethods.RemoveSong(filePath, songToRemove);

            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний рік.");
            }
            artistTextBox.Clear();
            albumTextBox.Clear();
            songTitleTextBox.Clear();
            yearTextBox.Clear();
        }
    }
}
