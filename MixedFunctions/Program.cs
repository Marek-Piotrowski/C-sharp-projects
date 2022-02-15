
using System;


namespace MixedFunctionsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int user;
            bool goodIndex = true;
            bool color = false;
            




            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome!\nThis is a Mixed Functions program.\nPlease choose a function and see what i can do.\nHappy playing around :)\n");
            Console.WriteLine("===========================================================\n\n");
            Console.ResetColor();

            do
            {
                Console.WriteLine("Functions MENU:");
                Console.WriteLine("1 -  Write Hello World");
                Console.WriteLine("2 -  Takes in users data ");
                Console.WriteLine("3 -  Chnage console color ");
                Console.WriteLine("4 -  Date and time ");
                Console.WriteLine("5 -  Takes in 2 values and returns greater one ");
                Console.WriteLine("6 -  Guess a number game ");
                Console.WriteLine("7 -  Save your text file on harddrive ");
                Console.WriteLine("8 -  Read your text file from harddrive  ");
                Console.WriteLine("9 -  Write a number and get a root from it raised to 2 and 10  ");
                Console.WriteLine("10 - Make Multiplication tabel from 1 to 10  ");
                Console.WriteLine("11 - Make 2 arrays and sort ascending second one  ");
                Console.WriteLine("12 - Check if the word is a palindrom  ");
                Console.WriteLine("13 - Write your 2 numbers and get numbers between them ");
                Console.WriteLine("14 - Write your numbers and get them sort by even and odd numbers ");
                Console.WriteLine("15 - Write your numbers and get them sum up ");
                Console.WriteLine("16 - Make your character ");
                Console.WriteLine("0 -  Exit ");
                Console.WriteLine("\n\nPlease enter a number between 1 - 16 to choose a function or press 0 to exit ");




                try
                {

                    user = int.Parse(Console.ReadLine());


                    switch (user)
                    {
                        case 0:
                            Console.WriteLine("Thank you and see you soon.");
                            goodIndex = false;
                            break;
                        case 1:
                            Hello();
                            break;
                        case 2:
                            UserData();
                            break;
                        case 3:
                            ChangeColor(color);
                            color = !color;
                            break;
                        case 4:
                            DateToday();
                            break;
                        case 5:
                            Values2();
                            break;
                        case 6:
                            GuessNumberGame();
                            break;
                        case 7:
                            SaveNote();
                            break;
                        case 8:
                            ReadNote();
                            break;
                        case 9:
                            GetRoot();
                            break;
                        case 10:
                            Multiplicationtabell();
                            break;
                        case 11:
                            TwoArrays();
                            break;
                        case 12:
                            Palindrom();
                            break;
                        case 13:
                            UserNumbers();
                            break;
                        case 14:
                            EvenAndOdd();
                            break;
                        case 15:
                            SumUp();
                            break;
                        case 16:
                            MakeCharacter();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter a number between 1 - 16 to choose a function or press 0 to exit\n\n");
                            Console.WriteLine("===========================================================\n\n");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only numbers allowed. \nPlease enter a number between 1 - 16 or press 0 to exit\n\n");
                    Console.WriteLine("===========================================================\n\n");
                    Console.ResetColor();
                };

            }
            while (goodIndex);
            Console.WriteLine("Program closed");

            // ===============================    Functions   =============================

            // Function 1

            static void Hello()
            {

                Console.WriteLine("Hello World\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("===========================================================\n\n");
                Console.ResetColor();
            }

            // Function 2

            static void UserData()
            {

                Console.WriteLine("Please write your Name");
                string name = Console.ReadLine();
                Console.WriteLine("Please write your Surname ");
                string surname = Console.ReadLine();
                Console.WriteLine("Please write your Age ");
                string age = Console.ReadLine();
                Console.WriteLine("Hi " + name + " " + surname + ". Your age is: " + age);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("===========================================================\n\n");
                Console.ResetColor();
            }

            // Function 3
            static void ChangeColor(bool color)
            {
                if (color)
                {
                    Console.ResetColor();
                    Console.WriteLine("Your console color is set to default.");
                    Console.WriteLine("===========================================================\n\n");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your console color is set to green. Please use the function again to set it back to default.");
                    Console.WriteLine("===========================================================\n\n");
                }

            }

            // Function 4

            static void DateToday()
            {
                DateTime today = DateTime.Now;
                Console.WriteLine("Today's date is: " + today.ToString("d"));
                Console.WriteLine("===========================================================\n\n");
            }


            // Function 5

            static void Values2()
            {
                bool index = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Write your first number");
                        int userValue1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Write your second number");
                        int userValue2 = int.Parse(Console.ReadLine());


                        if (userValue1 > userValue2)
                        {
                            Console.WriteLine("Your first number is grater than the second one");
                            Console.WriteLine("===========================================================\n\n");
                            index = false;
                        }
                        else if (userValue1 < userValue2)
                        {
                            Console.WriteLine("Your second number is grater than the first one");
                            Console.WriteLine("===========================================================\n\n");
                            index = false;
                        }
                        else
                        {
                            Console.WriteLine("Values are equal");
                            Console.WriteLine("===========================================================\n\n");
                            index = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Only numbers allowed...");
                        Console.WriteLine("===========================================================\n\n");
                    }
                } while (index);




            }
            // Function 6

            static void GuessNumberGame()
            {
                Console.WriteLine("Hello! This is a guess a number game.");
                Console.WriteLine("I am going to generate a number between 1 - 100 . \nYour jobb is to guess that number. Easy right? Let's begin!");

                int counter = 0;
                int userNumber = 0;

                Random random = new Random();
                int randomNumber = random.Next(1, 101);


                do
                {
                    Console.WriteLine("What do you think a random number is ? ");

                    try
                    {
                        userNumber = int.Parse(Console.ReadLine());
                        if (userNumber > randomNumber)
                        {
                            counter++;
                            Console.WriteLine("Your number is too high");
                        }
                        else if (userNumber < randomNumber)
                        {
                            counter++;
                            Console.WriteLine("Your number is too low");
                        }
                        else if (userNumber == randomNumber)
                        {
                            counter++;
                            Console.WriteLine("Congrats!!");
                            Console.WriteLine("You guessed it!");
                            Console.WriteLine("Secret number was " + randomNumber);
                            Console.WriteLine("Attempts :" + counter);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Only numbers allowed...");
                        Console.WriteLine("===========================================================\n\n");
                    }

                }
                while (userNumber != randomNumber);


            }
            // Function 7


            static void SaveNote()
            {

                Console.WriteLine("Please write your short note :");
                string userPath = @"D:\Temp\UserText3.txt";

                string text = Console.ReadLine();
                File.WriteAllText(userPath, text);
            }

            // Function 8
            static void ReadNote()
            {

                string userPath = @"D:\Temp\UserText3.txt";
                Console.WriteLine("Your file from " + userPath + " contains: \n");
                string readText = File.ReadAllText(userPath);
                Console.WriteLine(readText);
                Console.WriteLine("===========================================================\n\n");
            }

            // Function 9
            static void GetRoot()
            {

                Console.WriteLine("Write a decimal number");
                double number = double.Parse(Console.ReadLine());
                var func2 = Math.Pow(Math.Sqrt(number), 10);
                Console.WriteLine("Root ur "+ number +" " + "rised to 2 is : "+ number);
                Console.WriteLine("Root ur " + number + " " + "rised to 10 is : " + func2.ToString("F"));
                Console.WriteLine("===========================================================\n\n");
            }

            // Function 10
            static void Multiplicationtabell()
            {
                Console.WriteLine("\t\t\tMultiplication table from 1 to 10 \n\n");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + "\t");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("===========================================================\n\n");
            }

            // Function 11
            static void TwoArrays()
            {
                Console.WriteLine("\n");
                Console.WriteLine("Unsorted array:");

                int[] array = new int[15] ;
                int[] array2 = new int[15];


                for (int i = 0; i < array.Length; i++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(1, 101);
                    array[i] = randomNumber;
                    
                    Console.Write(array[i] + " ");
                    array2[i] = array[i];
                }
                Console.WriteLine("\n");
                Console.WriteLine("Array sorted in ascending order:");
                // sort method
                Array.Sort<int>(array2, new Comparison<int>(
                  (i1, i2) => i1.CompareTo(i2)));
                // Array.Sort(array2);

                for (int i = 0;i < array2.Length; i++)
                {
                    
                    Console.Write(array2[i] + " ");
                }
                Console.WriteLine("\n");

                Console.WriteLine("===========================================================\n\n");



            }

            // Function 12
            static void Palindrom()
            {
                Console.WriteLine("Please enter your word:");
                string userInput = Console.ReadLine();
                // make sure this is non case sensitive
                string lower = userInput.ToLower();

                // array of chars
                char[] array = lower.ToCharArray();
                // reverse chars in array
                Array.Reverse(array);
                // make string of array
                String reverse = new String(array);


                if(lower == reverse)
                {
                    Console.WriteLine(lower+ " is equal to "+reverse+": "+" This is Polindrom");
                }
                else
                {
                    Console.WriteLine(lower + " is not equal to " + reverse + ": "+" This is not a Polindrom");
                }

                Console.WriteLine("===========================================================\n\n");
            }
            // Function 13
            static void UserNumbers()
            {
                bool index = true;
                
                    do
                    {
                        try {
                            Console.WriteLine("Please write your first number");
                            int userNumber1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please write your second number");
                            int userNumber2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Numbers between yours 2 numbers are:");

                            if (userNumber1 > userNumber2)
                            {
                                Console.WriteLine("\n");
                                // make a proper array length
                                int arrlength = userNumber1 - userNumber2;
                                int[] terms = new int[arrlength];

                                for (int i = 0; i < terms.Length; i++)
                                {
                                    terms[i] = userNumber1 - i;
                                }
                                // skip the first element of array
                                terms = terms.Skip(1).ToArray();
                                Array.Sort(terms);
                                Console.WriteLine(String.Join(",", terms));
                                index = false;

                            }
                            else if (userNumber1 < userNumber2)
                            {
                                Console.WriteLine("\n");
                                int arrlength = userNumber2 - userNumber1;
                                int[] terms = new int[arrlength];

                                for (int i = 0; i < terms.Length; i++)
                                {
                                    terms[i] = userNumber1 + i;
                                }
                                terms = terms.Skip(1).ToArray();
                                Console.WriteLine(String.Join(",", terms));
                                index = false;
                            }
                            else
                            {
                                Console.WriteLine(" Numbers are equal");
                                index = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Only numbers allowed.");
                        }


                    } while(index);
                    
                
                
                
                

                Console.WriteLine("===========================================================\n\n");
            }

            // Function 14
            static void EvenAndOdd()
            {
                bool index = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Write your numbers separated by comma. Example: 23,45,34..etc");
                        string userInput = Console.ReadLine();
                        string[] words = userInput.Split(',');

                        Console.WriteLine("\n");
                        // convert string array to int array
                        int[] numbers = Array.ConvertAll(words, s => int.Parse(s));
                        // Sort an array
                        Array.Sort(numbers);

                        Console.WriteLine("Even numbers: ");
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + "\t");
                            }

                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("Odd numbers: ");
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {

                                Console.Write(numbers[i] + "\t");
                            }

                        }
                        index = false;
                        Console.WriteLine("\n");
                        Console.WriteLine("===========================================================\n\n");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Something went wrong.");
                        Console.WriteLine("Only numbers separated by comma allowed");
                        Console.WriteLine("Please try again.");
                    }


                } while (index);
                
            }


            // Function 15
            static void SumUp()
            {
                bool index = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Write your numbers separated by comma. Example: 23,45,34..etc");
                        string userInput = Console.ReadLine();
                        string[] words = userInput.Split(',');
                        int total = 0;

                        Console.WriteLine("\n");
                        // convert string array to int array
                        int[] numbers = Array.ConvertAll(words, s => int.Parse(s));
                        // Sort an array
                        Array.Sort(numbers);

                        
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            total = total + numbers[i];

                        }
                        
                        Console.WriteLine("After adding up your numbers, total value is: " + total);
                        Console.WriteLine("\n");
                        Console.WriteLine("===========================================================\n\n");
                        index = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Something went wrong.");
                        Console.WriteLine("Only numbers separated by comma allowed");
                        Console.WriteLine("Please try again.");
                    }


                } while (index);

            }

            // Function 16
            static void MakeCharacter()
            {
                Console.WriteLine("Please write your character name");
                string name = Console.ReadLine();
                Console.WriteLine("Please write your enemy name");
                string enemy = Console.ReadLine();

                int health = new Random().Next(1, 101);
                int strength = new Random().Next(1, 101);
                int luck = new Random().Next(1, 101);


                Character userChar = new Character(strength,health,luck);

                userChar.Name = name;
                userChar.Enemy = enemy;

                Console.WriteLine("\n");
                Console.WriteLine("Your character name is : " + userChar.Name + " and his enemy is : " + userChar.Enemy);
                
                Console.WriteLine("\t\t\tYour character stats : ");
                Console.WriteLine("Health : " + userChar.Health + " / 100");
                Console.WriteLine("Strength : " + userChar.Strength  + " / 100");
                Console.WriteLine("Luck : " + userChar.Luck + " / 100");
                Console.WriteLine("\n");
                Console.WriteLine("===========================================================\n\n");

            }


        }
    }
    public class Character
    {
        public string Name { get; set; }

        public string Enemy { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public int Luck { get; set; }
        public Character(int strength, int health,int luck)
        {
            this.Strength = strength;
            this.Health = health;
            this.Luck = luck;    

        }

        
    }

    
}











