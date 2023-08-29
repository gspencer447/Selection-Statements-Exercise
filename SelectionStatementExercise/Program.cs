namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number between 1 and 20.");
            var userInput = int.Parse(Console.ReadLine());
            int favoriteNumber = 13;

            if (favoriteNumber > userInput)
            {
                Console.WriteLine("Your guess was too low.");
            }

            else if (favoriteNumber < userInput)
            {
                Console.WriteLine("Your guess was too high.");
            }

            else
            {
                Console.WriteLine("Congratulations, you guessed it!!!");
            }
        }
    }
}
