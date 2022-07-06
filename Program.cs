using System;

namespace Aibek_Shermatov_61294
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("| MAIN MENU               |");
            Console.WriteLine("| 1.Calculator            |");
            Console.WriteLine("| 2.Metric Conversation   |");
            Console.WriteLine("| 3.Exit                  |");
            Console.WriteLine("===========================");

            Console.Write("Choose what you want: [ ]\b\b");

            byte num = Convert.ToByte(Console.ReadLine());


            Boolean flag = true;
            while (flag)
            { 
                switch (num)
                {
                    case 1:
                        Console.WriteLine("===========================");
                        Console.WriteLine("| CALCULATOR              |");
                        Console.WriteLine("| 1.Addition              |");
                        Console.WriteLine("| 2.Subtraction           |");
                        Console.WriteLine("| 3.Multiplication        |");
                        Console.WriteLine("===========================");


                        Console.Write("Choose what calculation you want: [ ]\b\b");
                        byte calc_num = Convert.ToByte(Console.ReadLine());

                        
                        switch (calc_num)
                        {
                            case 1:
                                Console.Write("Write your first adding number: ");
                                int addition_1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Write your second adding number: ");
                                int addition_2 = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Sum of your two num is : ");
                                Console.WriteLine(addition_1 + addition_2);

                                flag = false;
                                break;
                            case 2:
                                Console.Write("Write your first subtraction number: ");
                                int subtraction_1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Write your second subtraction number: ");
                                int subtraction_2 = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Difference of your two num is : ");
                                Console.WriteLine(subtraction_1 - subtraction_2);
                                flag = false;
                                break;

                            case 3:
                                Console.Write("Write your first multiplacation number: ");
                                int multiplication_1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Write your second multiplication number: ");
                                int multiplication_2 = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Multiplication of your two num is : ");
                                Console.WriteLine(multiplication_1 * multiplication_2);
                                flag = false;
                                break;

                            default:
                                flag = false;
                                break;

                        }

                        break;

                    case 2:
                        Console.WriteLine("===========================");
                        Console.WriteLine("| METRIC CONVERSATION     |");
                        Console.WriteLine("| 1.Inches to Centimetres |");
                        Console.WriteLine("| 2.Centimetres to Inches |");
                        Console.WriteLine("===========================");

                        Console.Write("Converting : [ ]\b\b");
                        byte convert_num = Convert.ToByte(Console.ReadLine());
                        switch (convert_num)
                        {
                            case 1:
                                Console.Write("What inch num are you going to convert : ");
                                double inch_con = Convert.ToDouble(Console.ReadLine());



                                // 2.54 * inches = centimeter
                                double centimeter = 2.54 * inch_con;
                                Console.Write("Your [{0}] inch num converted Centimeter -> {1}",inch_con, Math.Round(centimeter, 2));
                                flag = false;

                                break;
                            case 2:
                                Console.WriteLine("What centimeter num are you going to convert : ");
                                double centi_con = Convert.ToDouble(Console.ReadLine());
                                flag = false;


                                // 2.54 * inches = centimeter
                                double inches = centi_con / 2.54;
                                Console.WriteLine("Your [{0}] centimeter num converted INCH num -> {1}",centi_con, Math.Round(inches, 2));
                                flag = false;
                                break;


                            default:
                                flag = false;
                                break;

                        }

                        break;


                    default:
                        flag = false;
                        break;

                }

            }
        }
            
    }
}
