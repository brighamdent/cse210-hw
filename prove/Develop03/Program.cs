// So for my extra feature I added a way to see the percentage of words that you
// have memorized thus far.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            int hiddenWordCount = scripture.GetHiddenWordCount();
            int totalWordCount = scripture.GetTotalWordCount();
            double percentageHidden = (double)hiddenWordCount / totalWordCount * 100;
            Console.WriteLine(
                $"\n{hiddenWordCount} of {totalWordCount} words hidden ({percentageHidden:F1}%)"
            );

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

            if (scripture.GetHiddenWordCount() == totalWordCount)
            {
                Console.WriteLine(
                    "\nAll words are hidden! You have successfully memorized the scripture."
                );
                break;
            }
        }
    }
}
