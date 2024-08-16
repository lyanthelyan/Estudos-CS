
using StringBuilderStudy.Entities;
namespace Strinbuilder;
internal class Program
{
    private static void Main(string[] args)
    {
        Comment c1 = new Comment("Have a nice trip!");
        Comment c2 = new Comment("Wow that's awesome");
        Comment c3 = new Comment("Good night");
        Comment c4 = new Comment("May the Force be with you");

        Post p1 = new Post(
            DateTime.Parse("21/06/2018 13:05:44"),
            "Traveling to New Zeland",
            "I'm going to visit this wonderful country",
            12
            );
        p1.AddComments(c1); p1.AddComments(c2);

        Post p2 = new Post(
            DateTime.Parse("28/07/2019 23:14:19"),
            "Good night guys",
            "See you Tomorrow",
            9
            );
        p2.AddComments(c3); p2.AddComments(c4);

        Console.WriteLine(p1);
        Console.WriteLine(p2);

    }
}