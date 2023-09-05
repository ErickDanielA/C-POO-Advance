using System.Security.Cryptography;
using EnumerateAtv2.Entities;

namespace EnumerateAtv2
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            p1.AddComments(c1);
            p1.AddComments(c2);
            Console.WriteLine(p1.Title);
            Console.WriteLine(p1.likes+" Likes - "+p1.Moment);
            Console.WriteLine(p1.Content);
            Console.WriteLine("Comments:");
            foreach(Comment c in p1.Comments)
                {
                Console.WriteLine(c.Text);
            }
            Console.WriteLine();
            c1 = new Comment("Good night");
            c2 = new Comment("May the force be with you");
            p1 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            p1.AddComments(c1);
            p1.AddComments(c2);
            Console.WriteLine(p1.Title);
            Console.WriteLine(p1.likes + " Likes - " + p1.Moment);
            Console.WriteLine(p1.Content);
            Console.WriteLine("Comments:");
            foreach (Comment c in p1.Comments)
                {
                Console.WriteLine(c.Text);
                }
            }
        }
    }