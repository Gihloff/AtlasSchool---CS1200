using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;

ConsoleApplication.Run();

public class ConsoleApplication
{
    public static void Run()
    {
        /*Declare Variables, arrays, and use for loop to set random numbers to each dice*/
        Random rand = new Random();

        int[] dice = new int[5];

        for (int i = 0; i < 5; i++)
        {
            dice[i] = rand.Next(1, 7);
        }

        int reroll = 2;

        /*Clear the screen and display initial roll*/
        Console.Clear();
        Console.WriteLine("Initial Roll: ");
        DisplayDice(dice); 
        Console.WriteLine();

        /*While loop to prompt user, nested for loop to convert user input to integer*/
        while(reroll > 0)
        {
            Console.WriteLine("Enter the dice numbers to reroll (comma-separated, ex: 2,3,5) or leave blank to keep current dice. ");
            Console.Write($"You have {reroll} rerolls remaining: ");
            
            string input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input))
            {
                break;
            }
           
            string[] userInput = input.Split(',');
            
            for(int i = 0; i < userInput.Length; i++)
            {
                if(int.TryParse(userInput[i], out int result))
                {
                    /*reroll dice*/
                    dice[result - 1] = rand.Next(1, 7);
                }
                else
                {
                    Console.WriteLine($"'{userInput[i]}' is not a valid dice number.");
                }
            }

            reroll--;
            Console.Clear();
            Console.WriteLine("Updated Rolls: ");
            DisplayDice(dice);
        }

        /*Compute Final Score*/
        int score = ComputeScore(dice);
        Console.WriteLine($"Final Score: {score}");
    }


    /*Method to display dice*/
    private static void DisplayDice(int[] dice)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Die {i + 1}: {dice[i]}");
        }
    }

    /*Method to compute score*/
    private static int ComputeScore(int[] dice)
    {
        int[] occurences = new int[6];
        int sum = 0;

        foreach(int die in dice)
        {
            occurences[die-1]++;
            sum += die;
        }

        int score = 0;

        foreach (int occurence in occurences)
        {
            switch (occurence)
            {
                case 2:
                    score += 10;
                    break;
                case 3:
                    score += 15;
                    break;
                case 4:
                    score += 25;
                    break;
                case 5:
                    score += 30;
                    break;
            }
        }

        score += sum;

        return score;
    }

}

