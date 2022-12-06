using System;
namespace switchProgram
{
    public class switchClass
    {
        public static void Main(String[] args)
        {
            start:
            Console.WriteLine("Enter the number in range between 0-7");
            var num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    Console.WriteLine("monday");
                    break;
                case "2":
                    Console.WriteLine("tueday");
                    break;
                case "3":
                    Console.WriteLine("wednesday");
                    break;
                case "4":
                    Console.WriteLine("thursday");
                    break;
                case "5":
                    Console.WriteLine("friday");
                    break;
                 case "6":
                    Console.WriteLine("saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("you enter wrong value! want to play again then press 1 or for exit press 0");
                    var again = Console.ReadLine();
                    switch (again)
                    {
                        case "1":
                            goto start;
                           
                        case "0":
                            goto exit;
                            break;
                    }
                    break;
                    
                                 

            }
            Console.WriteLine("you want to play again? say yes or no");
            var question = Console.ReadLine();
            switch (question)
            {
                case "yes":
                    goto start;
                case"no":
                    Console.WriteLine("thank visit again");
                    break;
            }
        exit:
            Console.WriteLine("bye");
        }
    }
}