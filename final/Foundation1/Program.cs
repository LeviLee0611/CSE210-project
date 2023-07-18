using System;

class Program
{
    static void Main(string[] args)
    {
                List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Animals", "Levi", 100);
        video1.AddComment("User 1", "Fun video!");
        video1.AddComment("User 2", "It's interested.");
        videos.Add(video1);

        Video video2 = new Video("Space", "Sophie", 125);
        video2.AddComment("User 3", "Great content!");
        video2.AddComment("User 4", "This helped me a lot.");
        video2.AddComment("User 5", "May I ask something in here?");
        videos.Add(video2);

        Video video3 = new Video("Traveling", "Lee", 170);
        video3.AddComment("User 6", "I knew it.");
        video3.AddComment("User 7", "I learned a lot.");
        video3.AddComment("User 8", "Looking forward to more videos.");
        video3.AddComment("User 9", "Thanks for sharing!");
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(" - " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
    }

    class Comment
{
    public string Name;
    public string Text;

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    public string Title;
    public string Author;
    public int Length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}