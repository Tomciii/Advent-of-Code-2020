//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the Hangman game logic.</summary>
//-----------------------------------------------------------------------
namespace adventofcode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Coool man this is the main program.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Cool man this is the main method.
        /// </summary>
        /// <param name="args">The args that we might need.</param>
        public static void Main()
        {
            Advent4();
            Console.ReadLine();
        }

        public static void Advent4()
        {
            Console.WriteLine("Advent 4");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tomcii\Documents\Coding\CodingAdvent2020\Input_04.txt");
            int validPassportCount = 0;
            int requiredFieldCount = 0;
            string[] values = new string[7];
            string[] value2 = new string[2];
            int value = 0;
            bool tryParse;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("byr:"))
                {
                    values = lines[i].Split(' ');
                    
                    if (values[0].Contains("byr:"))
                    {
                        value2 = values[0].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[0].Contains("byr:"))
                    {
                        value2 = values[0].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[1].Contains("byr:"))
                    {
                        value2 = values[1].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[2].Contains("byr:"))
                    {
                        value2 = values[2].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[3].Contains("byr:"))
                    {
                        value2 = values[3].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[4].Contains("byr:"))
                    {
                        value2 = values[4].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[5].Contains("byr:"))
                    {
                        value2 = values[5].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[6].Contains("byr:"))
                    {
                        value2 = values[6].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                }
                
                if (lines[i].Contains("iyr:"))
                {
                    values = lines[i].Split(' ');

                    if (values[0].Contains("byr:"))
                    {
                        value2 = values[0].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[0].Contains("iyr:"))
                    {
                        value2 = values[0].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2010 && value <= 2020)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[1].Contains("iyr:"))
                    {
                        value2 = values[1].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2010 && value <= 2020)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[2].Contains("iyr:"))
                    {
                        value2 = values[2].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2010 && value <= 2020)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[3].Contains("iyr:"))
                    {
                        value2 = values[3].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2010 && value <= 2020)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[4].Contains("iyr:"))
                    {
                        value2 = values[4].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2010 && value <= 2020)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[5].Contains("iyr:"))
                    {
                        value2 = values[5].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2010 && value <= 2020)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[6].Contains("iyr:"))
                    {
                        value2 = values[6].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2010 && value <= 2020)
                        {
                            requiredFieldCount++;
                        }
                    }
                }
                
                if (lines[i].Contains("eyr:"))
                {
                    values = lines[i].Split(' ');

                    if (values[0].Contains("eyr:"))
                    {
                        value2 = values[0].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 1920 && value <= 2002)
                        {
                            requiredFieldCount++;
                        }
                    }
                   else if (values[1].Contains("eyr:"))
                    {
                        value2 = values[1].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2020 && value <= 2030)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[2].Contains("eyr:"))
                    {
                        value2 = values[2].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2020 && value <= 2030)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[3].Contains("eyr:"))
                    {
                        value2 = values[3].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2020 && value <= 2030)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[4].Contains("eyr:"))
                    {
                        value2 = values[4].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2020 && value <= 2030)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[5].Contains("eyr:"))
                    {
                        value2 = values[5].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2020 && value <= 2030)
                        {
                            requiredFieldCount++;
                        }
                    }
                    else if (values[6].Contains("eyr:"))
                    {
                        value2 = values[6].Split(':');
                        tryParse = int.TryParse(value2[1], out value);
                        if (value >= 2020 && value <= 2030)
                        {
                            requiredFieldCount++;
                        }
                    }
                }
                
                if (lines[i].Contains("hgt:") && (lines[i].Contains("cm") || lines[i].Contains("in")))
                {
                    requiredFieldCount++;
                }
                
                if (lines[i].Contains("hcl:#"))
                {
                    requiredFieldCount++;
                }
                
                if (lines[i].Contains("ecl:"))
                {
                    requiredFieldCount++;
                }
                
                if (lines[i].Contains("pid:"))
                {
                    requiredFieldCount++;
                }

                if (lines[i].Equals("") || (i == lines.Length - 1))
                {
                    if (requiredFieldCount == 7)
                    {
                        validPassportCount++;
                    }

                    requiredFieldCount = 0;
                }
            }

            Console.WriteLine("Valid Passports: " + validPassportCount);
        }

        public static void Advent3()
        {
            Console.WriteLine("Advent 3");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tomcii\Documents\Coding\CodingAdvent2020\Input_03.txt");
            int[] totalhits = new int[5];
            int hits = 0;
            int x = 0;

            totalhits[0] = slopeOne(hits, x, lines);
            totalhits[1] = slopetwo(hits, x, lines);
            totalhits[2] = slopeThree(hits, x, lines);
            totalhits[3] = slopeFour(hits, x, lines);
            totalhits[4] = slopeFive(hits, x, lines);
        }

        public static int slopeFive(int hits, int x, string[] lines)
        {
            for (int i = 0; i < lines.Length; i =  i + 2)
            {
                if (lines[i][x].Equals('#'))
                {
                    hits++;
                }

                if (x == 30)
                {
                    x = 0;
                }
                else
                {
                    x++;
                }
            }
            Console.WriteLine(hits);
            return hits;
        }


        public static int slopeOne(int hits, int x, string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i][x].Equals('#'))
                {
                    hits++;
                }

                if (x == 30)
                {
                    x = 2;
                }
                else if (x == 29)
                {
                    x = 1;
                }
                else if (x == 28)
                {
                    x = 0;
                }
                else
                {
                    x = x + 3;
                }
            }
            Console.WriteLine(hits);
            return hits;
        }

        public static int slopeFour(int hits, int x, string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i][x].Equals('#'))
                {
                    hits++;
                }

                if (x == 30)
                {
                    x = 6;
                }
                else if (x == 29)
                {
                    x = 5;
                }
                else if (x == 28)
                {
                    x = 4;
                }
                else if (x == 27)
                {
                    x = 3;
                }
                else if (x == 26)
                {
                    x = 2;
                }
                else if (x == 25)
                {
                    x = 1;

                }
                else if (x == 24)
                {
                    x = 0;
                }
                else
                {
                    x = x + 7;
                }
            }
            Console.WriteLine(hits);
            return hits;
        }

        public static int slopeThree(int hits, int x, string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i][x].Equals('#'))
                {
                    hits++;
                }

                if (x == 30)
                {
                    x = 4;
                }
                else if (x == 29)
                {
                    x = 3;
                }
                else if (x == 28)
                {
                    x = 2;
                }
                else if (x == 27)
                {
                    x = 1;
                }
                else if (x == 26)
                {
                    x = 0;
                }
                else
                {
                    x = x + 5;
                }
            }
            Console.WriteLine(hits);
            return hits;
        }

        public static int slopetwo(int hits, int x, string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i][x].Equals('#'))
                {
                    hits++;
                }

                if (x == 30)
                {
                    x = 0;
                }
                else
                {
                    x++;
                }
            }
            Console.WriteLine(hits);
            return hits;
        }

        public static void Advent2()
        {
            int rightPasswords = 0;
            Console.WriteLine("Advent 2");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tomcii\Documents\Coding\CodingAdvent2020\Input_02.txt");
            string[] lineSplitter = new string[3];
            string[] parameterSplitter = new string[2];
            string password = string.Empty;
            string parametersString;

            char[] symbols = new char[lines.Length];
            int[] parameters = new int[2];
            int matches = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                lineSplitter = lines[i].Split(' ');
                symbols[i] = lineSplitter[1][0];
                parametersString = lineSplitter[0];

                parameterSplitter = parametersString.Split('-');
                bool tryParse = int.TryParse(parameterSplitter[0], out parameters[0]);
                bool tryParse2 = int.TryParse(parameterSplitter[1], out parameters[1]);

                parameters[0] = parameters[0] - 1;
                parameters[1] = parameters[1] - 1;

                password = lineSplitter[2];

                for (int j = 0; j < password.Length; j++)
                {
                    if (j == parameters[0] || j == parameters[1])
                    {
                        if (symbols[i] == password[j])
                        {
                            matches++;
                        }
                    }
                }

                if (matches == 1)
                {
                    rightPasswords++;
                }

                matches = 0;
                

                /*
                for (int j = 0; j < password.Length; j++)
                {
                    if (symbols[i] == password[j])
                    {
                        matches++;
                    }
                }

                if ( matches >= parameters[0] && matches <= parameters[1])
                {
                    rightPasswords++;
                }
                matches = 0;
                */
            }
            Console.WriteLine($"Right Passwords: {rightPasswords}");
           
        }



        public static void Advent1()
        {
            int wantedSum = 2020;
            int wantedProduct;

            Console.WriteLine("Advent 1");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tomcii\Documents\Coding\CodingAdvent2020\Input_01.txt");
            int[] numbers = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                int.TryParse(lines[i], out numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++) { 
                    if (numbers[j] + numbers[i] + numbers[k] == wantedSum)
                    {
                        Console.WriteLine($"{numbers[j]} + {numbers[i]} + {numbers[k]} = {wantedSum}");
                        Console.WriteLine($"{numbers[j]} * {numbers[i]} * {numbers[k]} = {numbers[j] * numbers[i] * numbers[k]}");
                        }
                    }
                }
            }
        }
    }
}
