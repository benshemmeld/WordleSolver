using System;

namespace WordleSolver
{
    internal class Program
    {
        private static List<string> wordList = new();

        static void Main(string[] args)
        {
            LoadWords();
            Console.WriteLine($"{wordList.Count} words");
            List<string> possibleWords = wordList;

            while (true)
            {
                Console.WriteLine("Enter letters in known positions:");
                var knownPositions = Console.ReadLine();

                int index = 0;
                foreach (var knownPositionChar in knownPositions)
                {
                    var c = char.ToLower(knownPositionChar);
                    if (c != '*')
                    {
                        possibleWords = possibleWords.Where(x => x[index] == c).ToList();

                    }

                    index++;
                }

                Console.WriteLine("Enter letters in unknown position:");
                var unknownPositions = Console.ReadLine();
                foreach (var unknownPositionChar in unknownPositions)
                {
                    var c = char.ToLower(unknownPositionChar);
                    possibleWords = possibleWords.Where(x => x.Contains(c)).ToList();
                }

                Console.WriteLine("Enter letters NOT in the word:");
                var notInWordCharacters = Console.ReadLine();
                foreach (var notInWordCharacter in notInWordCharacters)
                {
                    var c = char.ToLower(notInWordCharacter);
                    possibleWords = possibleWords.Where(x => !x.Contains(c)).ToList();
                }

                Console.WriteLine();
                Console.WriteLine($"{possibleWords.Count} possible words");
                foreach (var possibleWord in possibleWords)
                {
                    Console.WriteLine(possibleWord.ToUpper());
                }
            }

        }

        private static void LoadWords()
        {
            foreach (var line in File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "twl06.txt")))
            {
                var word = line.Trim().ToLower();
                if (word.Length == 5)
                {
                    wordList.Add(word);
                }
            }
        }
    }
}