using System.Text.Json;
using System.Globalization;

namespace LearnLab_v2;

public class ConsoleUI
{


    static void Main(string[] args)
    {
        // Card card = new Card
        // { 
        //     Title = "What is the capital of Bulgaria?",
        //     Text = "Sofia",
        //     Category = "Geography"
        //
        //  //Console.WriteLine("Question: " + card1.Title);
        // //Console.WriteLine("Press any key to reveal the answer...");
        // //     //
        // //  // Console.ReadKey(intercept: true);
        // //     // Console.WriteLine("Answer: " + card1.Text);
        // };
        
        
        //Give ability to serialize Json to view field format in file (unused in app)
        //var jsonOptions = new JsonSerializerOptions();
        //jsonOptions.WriteIndented = true;
        //string jsonString = JsonSerializer.Serialize(card);
        //Card card = new Card();
       var getAllCards = File.ReadAllText("card1.json");
       
       Card card = JsonSerializer.Deserialize<Card>(getAllCards);


       // Give ability to deserialize Json which will be used to load/input data from file

    }
    
}
