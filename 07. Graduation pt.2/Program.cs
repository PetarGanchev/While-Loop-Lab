using System;

namespace _06._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double sumGrade = 0;
            int countExcluded = 0;


            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sumGrade += grade;
                    counter++;
                }
                else
                {
                    countExcluded++;
                    if (countExcluded >= 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        break;
                    }
                }


            }
            if (counter >= 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumGrade / 12:f2}");
            }



        }
    }
}
