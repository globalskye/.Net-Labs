using System;
using System.Collections;
using System.Text.RegularExpressions;

public class task2
{
    public static void Main(string[] args)
    { 
        string str = Console.ReadLine(); 
        string[] sentences = str.Split(".");
       
        /*Dictionary < string, int > phonebook = new Dictionary < string, int > ();*/
        //phonebook["Hello"] = 0;
       // Console.WriteLine(phonebook["Hello"]);

        /*phonebook["Hello"] += 1;
        Console.WriteLine(phonebook["Hello"]);*/

        /*for (int i = 0; i < s.Length; i++)
        {
            string[] words = s[i].Split(" ");
            
            for (int j = 0; j < words.Length; j++)
            {
               
                phonebook[words[j]] = 0;
            }
        }*/

        
        string result;
        int i = 0;
        string[] words = new string[0];
        for (int j = 0; j < sentences.Length; j++)
        {
            string[] st = sentences[j].Split(" ");
            for (int k = 0; k < st.Length; k++)
            {
                words =   Extensions.Append(words, st[k]);
            }
        }
        foreach (var word in words)
        {
            i = 0;
            foreach (var sentence in sentences)
            {
                if (!sentence.Contains(word))
                {
                    break;
                }

                i++;
                result = word;
            }

            if (i == sentences.Length)
            {
                Console.WriteLine(word);
                break;
            }
        }
        
        /*
        for (int i = 0; i < s.Length; i++)
        {
            string[] words = s[i].Split(" ");
            for (int j = 0; j < words.Length; j++)
            {
                if (phonebook.ContainsKey(words[j]))
                {
                    phonebook[words[j]] += 1;
                }
            }
        }
        */

      
        /*foreach (var k in phonebook)
        {
            if (k.Value == s.Length)
            {
                Console.WriteLine(k.Key.ToString());
            }
            
        }*/
    }
}

public static class Extensions
{
    public static T[] Append<T>(this T[] array, T item)
    {
        if (array == null) {
            return new T[] { item };
        }
        T[] result = new T[array.Length + 1];
        array.CopyTo(result, 0);
        result[array.Length] = item;
        return result;
    }
}
