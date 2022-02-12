using System;

namespace WordleSolver
{
    internal class Program
    {
        private static readonly List<string> WordList = new();

        static void Main(string[] args)
        {
            LoadWords();
            Console.WriteLine($"{WordList.Count} words");
            List<string> possibleWords = WordList;

            while (possibleWords.Count > 1)
            {
                Console.WriteLine("Green letters:");
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

                Console.WriteLine("Gold letters:");
                var unknownPositions = Console.ReadLine();

                index = 0;
                foreach (var unknownPositionChar in unknownPositions)
                {
                    var c = char.ToLower(unknownPositionChar);
                    if (c != '*')
                    {
                        possibleWords = possibleWords.Where(x => x.Contains(c))
                            .Where(x => x[index] != c)
                            .ToList();
                    }

                    index++;
                }

                Console.WriteLine("Grey letters");
                var notInWordCharacters = Console.ReadLine();
                foreach (var notInWordCharacter in notInWordCharacters)
                {
                    var c = char.ToLower(notInWordCharacter);
                    if (c != '*')
                    {
                        possibleWords = possibleWords.Where(x => !x.Contains(c)).ToList();
                    }
                }

                DisplayPossibleWords(possibleWords);
            }

        }

        private static void DisplayPossibleWords(List<string> possibleWords)
        {
            if (possibleWords.Count > 100)
                return;

            Console.WriteLine();
            Console.WriteLine($"{possibleWords.Count} possible words");
            foreach (var possibleWord in possibleWords)
            {
                Console.WriteLine(possibleWord.ToUpper());
            }
        }

        private static void LoadWords()
        {
            foreach (var line in File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "twl06.txt")))
            {
                var word = line.Trim().ToLower();
                if (word.Length == 5)
                {
                    WordList.Add(word);
                }
            }
        }
    }
}