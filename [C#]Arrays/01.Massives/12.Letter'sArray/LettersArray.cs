using System;

// Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.

class LettersArray
{
    static void Main()
    {    //filling the lowercase  array
        char[] lowerLetter = new char[27];        // от 27 за да се пропусне 0 индекс(във форума това решиха)       
         for (int i = 0; i < lowerLetter.Length; i++)
        {
            lowerLetter[i] = (char)(i + 96);  //съфорумницте казаха че искат да започва 'а' от индекс 1 затова 96, а не 97 
        }
         // filling the lowercase  array
        char[] capitalLetter = new char[27];
        for (int i = 0; i < capitalLetter.Length; i++)
        {
            capitalLetter[i] = (char)(i + 64);
        }
        //Take word
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++) // first loop for scan the letter from word
        {
            for (int letter = 0; letter < lowerLetter.Length; letter++) //scan the letter arrays for indexes
            {
                if (word[i] == lowerLetter[letter])
                {
                    Console.WriteLine("Lowercase " + word[i] + " position: " + letter); //print lower letter
                }
                else if (word[i] == capitalLetter[letter])
                {
                    Console.WriteLine("Capitalcase " + word[i] + " position: " + letter); // print capital letter
                }
            }
        }

    }
}