using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Terminal
{
    public class Music : LibraryItems
    {
        public string Artist { get; set; }

        public Music()
        {

        }
        public Music(string artist, string barcode, string title, string checkOut, string genre, string year, string dueDate)
        : base(barcode, title, checkOut, genre, year, dueDate)
        {

        }
        public void DisplayMusicMenu()
        {
            
        }
        public void FilterMusicListByArtist(string filterField, List<Music> musicList)
        {
            int counter = 0;
            foreach (Music music in musicList)
            {
                if (music.Artist == filterField)
                { 
                    counter++;
                    Console.WriteLine($"{counter}. {music.Title}"); 
                }
            }
        }
        public void FilterMusicListByTitle(string filterField, List<Music> musicList)
        {
            int counter = 0;
            foreach (Music music in musicList)
            {
                if (music.Title.Contains(filterField))
                {
                counter++;
                    Console.WriteLine($"{counter}. {music.Title}");
                }
            }
        }
    }
}
