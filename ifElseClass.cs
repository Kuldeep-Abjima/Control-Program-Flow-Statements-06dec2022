using System;

namespace Dec062022
{
    public class ifElseClass
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter the marks");
            Console.WriteLine("maths");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks of english");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks of hindi");
            int hindi = Convert.ToInt32(Console.ReadLine());

            float total = maths + eng + hindi;
            
            double precentage = (total*100)/300;
            if (precentage > 90F && precentage <= 100F)
            {
                Console.WriteLine($"your result: \n total marks -: {total} \n total percentage -: {precentage} \n Your Grade is : A ");
            }
            else if (precentage <= 90F && precentage > 75F)
            {
                Console.WriteLine($"your result: \n total marks -: {total} \n total percentage -: {precentage} \n Your Grade is : B+");
            }
            else if (precentage <= 75F && precentage > 60F)
            {
                Console.WriteLine($"your result: \n total marks -: {total} \n total percentage -: {precentage} \n Your Grade is : B");
            }
            else if (precentage <= 60F && precentage > 50F)
            {
                Console.WriteLine($"your result: \n total marks -: {total} \n total percentage -: {precentage} \n Your Grade is : C+ ");
            }
            else
            {
                Console.WriteLine($"your result: \n total marks -: {total} \n total percentage -: {precentage} \n Your Grade is : Fail");
            }
        }
    }
}

