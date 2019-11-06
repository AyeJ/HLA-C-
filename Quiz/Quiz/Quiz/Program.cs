using System;

namespace Quiz
{
    class Program
    {



        public class Employee
        {

        }

        public class PartTimeEmployee
        {
            public PartTimeEmployee()
            { }

            public void PartSalaryCal()
            {


                Console.WriteLine("Enter your hours and hourly wage: ");
                string hrs = Console.ReadLine();
                string hourlywage = Console.ReadLine();
                double salary = (Convert.ToDouble(hrs) * Convert.ToDouble(hourlywage) * 520) / 12;
                Console.WriteLine("Total Salary is {0}", salary);
                Console.ReadLine();
            }


        }

        public class FullTimeEmployee
        {
            private char a;

            public FullTimeEmployee()
            { }

            public void FullSalaryCal()
            {


                Console.WriteLine("Enter your hours and hourly wage");
                string hrs = Console.ReadLine();
                string hourlywage = Console.ReadLine();
                double salary = (Convert.ToDouble(hrs) * Convert.ToDouble(hourlywage) * 520) / 12;
                Console.WriteLine("Total Salary is {0}", salary);
                double totalsalry = Convert.ToDouble(salary) * 25;
                Console.WriteLine("Aftet bonus Total Salary is {0}", totalsalry);
                Console.ReadLine();
            }



        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for part time employee or press 2 for full time employee");
            var temp = Console.ReadLine();
            char ans = Convert.ToChar(temp);
            if ( ans == '1' )
            {
                PartTimeEmployee emp1 = new PartTimeEmployee();
                emp1.PartSalaryCal();

            }
            
            else if (ans == '2')
            {
                FullTimeEmployee emp2 = new FullTimeEmployee();
                emp2.FullSalaryCal();

            }

           


        }
    }

          
}
