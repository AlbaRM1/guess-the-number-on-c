using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte language;
            int dio1, dio2, enter;

            Console.WriteLine("Guess the number (Отгадай число)");
            Console.WriteLine("Warning: The translation into English may be of poor quality\n");
            Console.WriteLine("Select language (Выберите язык):\n");

            Console.WriteLine(" 1. English \n 2. Русский\n");

            while (true)
            {
                try
                {
                    language = sbyte.Parse(Console.ReadLine());

                    if (language == 1)
                    {
                        Console.WriteLine("Enter the range from");
                        dio1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the range to");
                        dio2 = int.Parse(Console.ReadLine());

                        Random random = new Random();
                        int val = random.Next(dio1, dio2);

                        while (true)
                        {
                            Console.WriteLine("Guess!");
                            enter = int.Parse(Console.ReadLine());

                            if (enter < val)
                            {
                                Console.WriteLine("this number is smaller than the one generated");
                            }
                            else if (enter > val)
                            {
                                Console.WriteLine("this number is bigger than the one generated");
                            }
                            else {
                                Console.WriteLine("Great, you guessed the number!");
                                break; 
                            }
                        }break;
                    }else if(language == 2)
                    {
                        Console.WriteLine("Введите диапозон от");
                        dio1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите диапозон до");
                        dio2 = int.Parse(Console.ReadLine());

                        Random random = new Random();
                        int val = random.Next(dio1, dio2);

                        while (true)
                        {
                            Console.WriteLine("Отгадывайте!");
                            enter = int.Parse(Console.ReadLine());

                            if (enter < val)
                            {
                                Console.WriteLine("Это число меньше сгенерированного");
                            }
                            else if (enter > val)
                            {
                                Console.WriteLine("Это число больше сгенерированного");
                            }
                            else
                            {
                                Console.WriteLine("Отлично, вы отгадали число!");
                                break;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter the correct number from the list (Введите корректную цифру из списка)");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Enter the correct number from the list (Введите корректную цифру из списка)");
                }
            }
            
        }
    }
}
