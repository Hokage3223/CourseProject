using CourseProject.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class searchForm : Form
    {
        private songsMethods songsMethods;

        public searchForm()
        {
            InitializeComponent();
            songsMethods = new songsMethods();
            LoadJsonData();
        }

        private void LoadJsonData()
        {
            string filePath = @"..\..\..\Coursa4\json\kdot.json";
            songsMethods.JsonDataInCursach(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string searchQuery = searchBox.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Потрібен запит");
                return;
            }

            var searchResults = songsMethods.Search(searchQuery);
            if (searchResults.Any())
            {
                foreach (var song in searchResults)
                {
                    ListViewItem item = new ListViewItem(new[] { song.Artist, song.Album, song.SongTitle, song.Year.ToString() });
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("В базі немає поточної інформації");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormForAddingSSongs addSongForm = new FormForAddingSSongs();
            addSongForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormForDeletingSSong addSongForm = new FormForDeletingSSong();
            addSongForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsForEditingSSong EditingSongForm = new FormsForEditingSSong();
            EditingSongForm.Show();
        }
    }
}
