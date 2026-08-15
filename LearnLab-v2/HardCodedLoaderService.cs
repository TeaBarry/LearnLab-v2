using System.Globalization;

namespace LearnLab_v2;

public class HardCodedLoaderService
{


    static void Main()
    {
        Card card1 = new Card();
        card1.Title = "What is the capital of Bulgaria?";
        card1.Text = "Sofia";
        
        Console.WriteLine("Question: " + card1.Title);
        Console.WriteLine("Press any key to reveal the answer...");

        Console.ReadKey(intercept: true);
        Console.WriteLine("Answer: " + card1.Text);
    }
    
}
