using System;
using System.Collections.Generic;


namespace EnglishQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vocabulary Master";
            Console.WriteLine("=== English Vocabulary Quiz ===");
            Console.WriteLine("Instruction: Type the word that matches the definition.\n");

            var words = new Dictionary<string, string>
            {
                { "Developer", "A person who creates computer software." },
                { "Repository", "A central location where data is stored" },
                { "Compiler", "A program that converts code into machine language." },
                { "Success", "The achievement of an intended goal." }
            };

            int score = 0;

            foreach (var item in words)
            {
                Console.WriteLine($"Definition: {item.Value}");
                Console.Write("Your Answer: ");
                string answer = Console.ReadLine();

                if (answer?.Trim().ToLower() == item.Key.ToLower())
                {

                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong. The word was: {item.Key}\n");
                }
            }

        Console.WriteLine($"Quiz Over! Score: {score}/{words.Count}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
          
            }
       }   
 }
