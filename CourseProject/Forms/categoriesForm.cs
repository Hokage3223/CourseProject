using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class categoriesForm : Form
    {
        string filePath = @"..\..\..\Coursa4\json\infoForCoursach.txt";
        public categoriesForm()
        {
            InitializeComponent();
        }

        private void categoriesForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                PropositionTextBox.Text = text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            string textToSave = PropositionTextBox.Text;
            
            using (StreamWriter saveInfo = new StreamWriter(filePath))
            {
                saveInfo.Write(textToSave);
            }

            MessageBox.Show("Інформацію збережено у файлі.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            PropositionTextBox.Clear();

            File.WriteAllText(filePath, string.Empty);

            MessageBox.Show("Інформацію видалено з файлу.");
        }
    }
}
