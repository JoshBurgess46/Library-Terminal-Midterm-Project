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
        public void FilterMusicByArtist(List<Music> musicList)
        {
            Console.WriteLine("What artist would you like to search for?");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z. ]+$"))
            {
                int counter = 0;
                foreach (Music music in musicList)
                {
                    if (musicList.Artist == input)
                    {
                        counter++;
                        Console.WriteLine($"{counter}. {musicList.Artist}");
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a valid author.\n");
                FilterMusicByArtist(musicList);
            }

        }
        public static void FilterMusicByTitle(List<Music> musicList)
        {
            int counter = 0;

            Console.WriteLine("What title would you like to search for?");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z. ]+$"))
            {
                int counter = 0;
                foreach (Music music in musicList)
                {
                    counter++;
                    if (musicList.Title.Contains(input))
                    {
                        counter++;
                        Console.WriteLine($"{counter}. {musicList.Title}");
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a valid title.");
                FilterMusicByTitle(musicList);
            }


        }
    }
}
