using System;

namespace exercisepart4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book thought Alice without pictures or conversation?";
            Console.WriteLine(sentence);
            Console.WriteLine("Enter a word to search:");
            string searchWord = Console.ReadLine();
            string word = searchWord.ToLower();
            string aliceSentence = sentence.ToLower();

            int index = aliceSentence.IndexOf(word, 0);
            Console.WriteLine("The search term, " + searchWord + "can be found at" + index);
            Console.WriteLine("The search term is " + searchWord.Length + "characters long.");

            string newSentence = sentence.Remove(index, searchWord.Length);
            Console.WriteLine(newSentence);

        }
    }
}
