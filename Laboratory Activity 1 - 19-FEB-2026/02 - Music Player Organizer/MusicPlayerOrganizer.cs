class Song
{
    public string Title;
    public string Artist;
    public double Duration;

    public Song() : this("Unknown", "Unknown", 0.0)
    {
    }

    public Song(string title, string artist) : this(title, artist, 0.0)
    {
    }

    public Song(string title, string artist, double duration)
    {
        Title = string.IsNullOrWhiteSpace(title) ? "Unknown" : title;
        Artist = string.IsNullOrWhiteSpace(artist) ? "Unknown" : artist;
        Duration = duration;
    }

    public void DisplaySong()
    {
        Console.WriteLine("{0,-20} {1,-15} {2,6:F2}", Title, Artist, Duration);
    }
}

class MusicPlayerOrganizer
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        int count = int.Parse(Console.ReadLine());

        Song[] playlist = new Song[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nSong #{i + 1}");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            double duration;
            bool isValid = double.TryParse(Console.ReadLine(), out duration);

            if (!isValid)
                duration = 0.0;

            if (string.IsNullOrWhiteSpace(title) &&
                string.IsNullOrWhiteSpace(artist) &&
                duration == 0.0)
            {
                playlist[i] = new Song();
            }
            else if (duration == 0.0)
            {
                playlist[i] = new Song(title, artist);
            }
            else
            {
                playlist[i] = new Song(title, artist, duration);
            }
        }

        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine("{0,-20} {1,-15} {2,6}", "Title", "Artist", "Time");
        Console.WriteLine("----------------------------------------------");

        double totalDuration = 0;
        foreach (Song song in playlist)
        {
            song.DisplaySong();
            totalDuration += song.Duration;
        }

        double average = count > 0 ? totalDuration / count : 0;

        Console.WriteLine();
        Console.WriteLine($"Total Duration: {totalDuration:F2} mins");
        Console.WriteLine($"Average Duration: {average:F2} mins");
    }
}
