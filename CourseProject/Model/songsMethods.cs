using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Windows.Forms;

namespace CourseProject
{
    public class songsMethods
    {
        public List<SSong> Songs { get; set; }

        public songsMethods()
        {
            Songs = new List<SSong>();
        }

        public void JsonDataInCursach(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                JObject obj = JObject.Parse(jsonString);

                foreach (JObject data in obj["Data"])
                {
                    string artist = (string)data["artist"];
                    string album = (string)data["album"];
                    string song = (string)data["song"];
                    int year = (int)data["year"];

                    Songs.Add(new SSong(artist, album, song, year));
                }
            }
        }

        public List<SSong> Search(string textForSearch)
        {
            textForSearch = textForSearch.ToLower();
            List<SSong> result = new List<SSong>();

            foreach (var song in Songs)
            {
                if (song.Artist.ToLower().Contains(textForSearch) ||
                    song.Album.ToLower().Contains(textForSearch) ||
                    song.SongTitle.ToLower().Contains(textForSearch) ||
                    song.Year.ToString().Contains(textForSearch))
                {
                    result.Add(song);
                }
            }
            return result;
        }
        public void AddSong(string filePath, SSong newSong)
        {
            JObject obj;
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                obj = JObject.Parse(jsonString);
            }
            else
            {
                obj = new JObject();
                obj["Data"] = new JArray();
            }

            JObject newSongObj = new JObject
            {
                { "artist", newSong.Artist },
                { "album", newSong.Album },
                { "song", newSong.SongTitle },
                { "year", newSong.Year }
            };

            JArray dataArray = (JArray)obj["Data"];
            dataArray.Add(newSongObj);

            File.WriteAllText(filePath, obj.ToString());

            Songs.Add(newSong);
            JsonDataInCursach(filePath);
        }
        public void RemoveSong(string filePath, SSong songToRemove)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                JObject obj = JObject.Parse(jsonString);
                JArray dataArray = (JArray)obj["Data"];

                JToken songToken = dataArray.FirstOrDefault(s =>
                    s["artist"].ToString() == songToRemove.Artist &&
                    s["album"].ToString() == songToRemove.Album &&
                    s["song"].ToString() == songToRemove.SongTitle &&
                    (int)s["year"] == songToRemove.Year);

                if (songToken != null)
                {                    
                    dataArray.Remove(songToken);

                    File.WriteAllText(filePath, obj.ToString());

                    Songs.Remove(songToRemove);
                }
                else
                {
                    MessageBox.Show("Інформацію не знайдено");
                }
            }
        }
        public void EditSong(string filePath, SSong originalSong, SSong updatedSong)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                JObject obj = JObject.Parse(jsonString);
                JArray dataArray = (JArray)obj["Data"];

                JToken songToken = dataArray.FirstOrDefault(s =>
                    s["artist"].ToString() == originalSong.Artist &&
                    s["album"].ToString() == originalSong.Album &&
                    s["song"].ToString() == originalSong.SongTitle &&
                    (int)s["year"] == originalSong.Year);

                if (songToken != null)
                {
                    songToken["artist"] = updatedSong.Artist;
                    songToken["album"] = updatedSong.Album;
                    songToken["song"] = updatedSong.SongTitle;
                    songToken["year"] = updatedSong.Year;

                    File.WriteAllText(filePath, obj.ToString());

                    int index = Songs.FindIndex(s =>
                        s.Artist == originalSong.Artist &&
                        s.Album == originalSong.Album &&
                        s.SongTitle == originalSong.SongTitle &&
                        s.Year == originalSong.Year);

                    if (index != -1)
                    {
                        Songs[index] = updatedSong;
                    }
                }
                else
                {
                    MessageBox.Show("Інформацію не знайдено");
                }
            }
        }   
    }
}
