namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
               case "math":
                   Console.WriteLine("Math is cool, I love numbers!");
                   break;
               case "science":
                   Console.WriteLine("Science is really interesting!");
                   break;
               case "history":
                   Console.WriteLine("History! I love learning about the ancient ways of life!");
                   break;
               case "reading":
                   Console.WriteLine("Reading is fun! I love adventure books!");
                   break;
               case "lunch":
                   Console.WriteLine("Yummy yummy in the tummy!");
                   break;
               default: 
                   Console.WriteLine($"Wow that is interesting! What do you like about {favoriteSubject}?"); 
                   break;
            
            }
        }
    }
}