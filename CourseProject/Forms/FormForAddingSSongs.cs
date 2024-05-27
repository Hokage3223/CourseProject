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
    public partial class FormForAddingSSongs : Form
    {
        private songsMethods songsMethods;

        public FormForAddingSSongs()
        {
            InitializeComponent();
            songsMethods = new songsMethods();
            songsMethods.JsonDataInCursach(@"..\..\..\Coursa4\json\kdot.json");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string artist = artistTextBox.Text;
            string album = albumTextBox.Text;
            string songTitle = songTitleTextBox.Text;
            int year = int.Parse(yearTextBox.Text);

            SSong newSong = new SSong(artist, album, songTitle, year);
            songsMethods.AddSong(@"..\..\..\Coursa4\json\kdot.json", newSong);
            MessageBox.Show("Пісня була додана(Не забудьте оновити сторінку!!!)");

            artistTextBox.Clear();
            albumTextBox.Clear();
            songTitleTextBox.Clear();
            yearTextBox.Clear();
        }

        private void artistTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
