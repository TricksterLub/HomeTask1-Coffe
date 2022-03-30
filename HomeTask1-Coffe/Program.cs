using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum doza
        {
            маленькая=1,
            средняя=2,
            большая=3
        }
        static void Main(string[] args)
        {   
            Random rand = new Random(); 
            string input = string.Empty;
            string inf = string.Empty;
            Console.WriteLine($"Выбор объёма: {(int)doza.маленькая}={doza.маленькая} {(int)doza.средняя}={doza.средняя} {(int)doza.большая}={doza.большая}");
            Console.WriteLine(inf="Укажите объём:[ ]");
            Console.SetCursorPosition(15, 1);
            input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Укажите объём:[{input}]");
           
            
            
            switch (input)
            {
                case "маленькая":
                    Console.WriteLine($"Внесите в афтомат {rand.Next(35)} рублей.");
                    break;
                case "средняя":
                    Console.WriteLine($"Внесите в афтомат {rand.Next(35)+35} рублей.");
                    break;
                case "большая":
                    Console.WriteLine($"Внесите в афтомат {rand.Next(35)+70} рублей.");
                    break;
                default:
                    bool logica = int.TryParse(input, out int input1);
                    switch (logica)
                        {
                        case true:
                            switch (input1) 
                            {
                                case 1:
                                    Console.WriteLine($"Внесите в афтомат {rand.Next(35)} рублей.");
                                    break;
                                case 2:
                                    Console.WriteLine($"Внесите в афтомат {rand.Next(35)+35} рублей.");
                                    break;
                                case 3:
                                    Console.WriteLine($"Внесите в афтомат {rand.Next(35)+70} рублей.");
                                    break;
                                default:
                                    Console.WriteLine("Данные введены не верно");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Данные введены не верно");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Спасибо, что воспользовались нашей Машиной");
        }
    }
}