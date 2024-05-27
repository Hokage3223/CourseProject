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
    public partial class FormsForEditingSSong : Form
    {
        private songsMethods songsManager;
        public FormsForEditingSSong()
        {
            InitializeComponent();
            songsManager = new songsMethods();
        }

        private void FormsForEditingSSong_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string originalArtist = artistTextBox.Text;
            string originalAlbum = albumTextBox.Text;
            string originalSongTitle = songTitleTextBox.Text;
            int originalYear = int.Parse(yearTextBox.Text); 

            string updatedArtist = newartistTextBox.Text;
            string updatedAlbum = newalbumTextBox.Text;
            string updatedSongTitle = newsongTitleTextBox.Text;
            int updatedYear = int.Parse(newyearTextBox.Text); 

            SSong originalSong = new SSong(originalArtist, originalAlbum, originalSongTitle, originalYear);
            SSong updatedSong = new SSong(updatedArtist, updatedAlbum, updatedSongTitle, updatedYear);

            songsManager.EditSong(@"..\..\..\Coursa4\json\kdot.json", originalSong, updatedSong);
            artistTextBox.Clear();
            albumTextBox.Clear();
            songTitleTextBox.Clear();
            yearTextBox.Clear();

            newartistTextBox.Clear();
            newalbumTextBox.Clear();
            newsongTitleTextBox.Clear();
            newyearTextBox.Clear();

        }
    }
}
