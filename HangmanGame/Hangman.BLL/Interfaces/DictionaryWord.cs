using System;
using System.IO;

namespace Hangman.BLL.Interfaces
{

    public class DictionaryWord : IWordSource
    {
        public string GetWord()
        {
            string filepath = "dictionary.txt";

            var word = File.ReadAllLines(filepath);
            Random random = new Random();
            return word[random.Next(word.Length)].ToLower();
        }
    }
}