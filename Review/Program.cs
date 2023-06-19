using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Please enter 3 numbers:");
        //string input = Console.ReadLine();
        //int [] arr = InputNumbers(input);
        //Console.WriteLine("The product of these 3 numbers is: "+Multiply(arr));

        //Console.WriteLine(GetAvg());

        //shape();


        int[] arr4 = { 6, 3, 3, 9 };
        Console.WriteLine(FrequentNumber(arr4));

        string path = "../../../words.txt";
        //WriteWords(path);
        //ReadFile(path);
        //RemoveWord(path, "Black");

        
        string [] words = WordsLength();

        for(int i=0; i <= words.Length-1; i++)
        {
            Console.Write(words[i]);
        }

    }

    // "4 8 15"
    public static int[] InputNumbers(string input)
    {
        string[] inputArr = input.Split(" "); //{"4","8","15"}

        int[] numbers = new int[inputArr.Length];
        for (int i = 0; i < inputArr.Length; i++)
        {
            numbers[i] = int.Parse(inputArr[i]); //{4,8,15}

        }

        return numbers;

    }


    //challenge 1
    public static int Multiply(int[] arr)
    {
        int result = 1;

        if (arr.Length <= 2)
            return 0;

        else if (arr.Length >= 3)
        {
            for (int i = 0; i <= 2; i++)
                result *= arr[i];
        }
        else
        {
            return 1;
        }
        return result;
    }







    //challenge 2

    public static int GetAvg()
    {
        Console.WriteLine("enter a number between 2-10:");
        int count = Convert.ToInt32(Console.ReadLine());

        if (count >= 2 && count <= 10)
        {

            int[] arr = new int[count];
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1} of {count} - Enter a number:");

                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            int avg = sum / count;



            Console.WriteLine("The average of these 4 numbers is:");

            return avg;
        }
        else
        {
            return count;
        }


    }





    //challenge 3
    public static void Shape()
    {


        for (int i = 1; i <= 9; i++)
        {
            int stars = i <= 5 ? i : 9 - i + 1;
            int spaces = 5 - stars;

            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * stars - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }



    }


    //challenge 4
    public static int FrequentNumber(int[] arr)
    { //[1,1,2,2,3,3,3,1,1,5,5,6,7,8,2,1,1]
        // { 6, 3, 3, 9 };
        int max_count = 0;
        int number = arr[0];


        for (int i = 0; i <= arr.Length - 1; i++)
        {
            int count = 1;

            for (int j = i + 1; j <= arr.Length - 1; j++)
            {
                if (arr[i] == arr[j])
                    count++;

            }


            if (count > max_count)
            {
                max_count = count;
                number = arr[i];
            }

        }



        return number;
    }


    //challenge 5
    public static int FindMax(int[] arr)
    {


        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }


    //challenge 6
    public static void WriteWords(string path)
    {
        Console.WriteLine("Enter a word:");
        string newWord = Console.ReadLine();

        File.AppendAllText(path, newWord + Environment.NewLine);
    }

    //challenge 7
    public static void ReadFile(string path)
    {
        string words = File.ReadAllText(path);
        Console.WriteLine(words);
    }

    //challenge 8
    public static void RemoveWord(string path, string word)
    {
        string content = File.ReadAllText(path);

        // Remove the word
        content = content.Replace(word, string.Empty);

        // update content
        File.WriteAllText(path, content);

    }



    //challenge 9
    public static string[] WordsLength()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string []words = sentence.Split(" ") ;

        string[] wordLengths = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            int length = word.Length;
            wordLengths[i] = $"{word}: {length} ";
        }
        return wordLengths;

        // Output: ["this: 4","is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6"]

    }

  
}