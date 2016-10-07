using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_emply
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;


            //Creating and changing departments
            Depart myDeptN = new Depart();
            myDeptN.DeptName = "Project Managers";
            myDeptN.ChangeDeptName("Senior Project Managers");
            Depart myDeptN2 = new Depart();
            myDeptN2.DeptName = "Front End Developer";
            myDeptN2.ChangeDeptName("Senior Front End Developer");

            Console.WriteLine("We have two departments: " + myDeptN.DeptName + " and " + myDeptN2.DeptName);

            //Creating employees name
            Employ employee1 = new Employ();
            Employ employee2 = new Employ();
            Employ employee3 = new Employ();
            Employ employee4 = new Employ();
            Employ employee5 = new Employ();
            employee1.FirstN = "John";
            employee1.LastN = "Smith";
            employee2.FirstN = "Snow";
            employee2.LastN = "White";
            employee3.FirstN = "Wall";
            employee3.LastN = "E";
            employee4.FirstN = "Buzz";
            employee4.LastN = "Lightyear";
            employee5.FirstN = "Winnie";
            employee5.LastN = "Pooh";

            //Changing employee 5's name
            employee5.ChangeName("Lama", "TheGreat");

            //Array of Employees
            //Employ[] myArray = new Employ[5];
            //myArray[0] = employee1;
            //myArray[1] = employee2;
            //myArray[2] = employee3;
            //myArray[3] = employee4;
            //myArray[4] = employee5;

            //Grade Employee
            employee1.Grade = 9;
            employee2.Grade = 13;
            employee3.Grade = 20;
            employee4.Grade = 10;
            employee5.Grade = 8;

            //Promoting Employee
            employee3.PayRate = 120000;
            employee3.Raise(employee3.PayRate);
            employee3.ChangeGrade(25);
            employee4.PayRate = 60000;
            employee4.Raise(employee3.PayRate);
            employee4.ChangeGrade(13);

            //Hired Employee
            employee3.DateHired = DateTime.Today;
            employee3.Hired(employee3.DateHired);
            employee4.DateHired = DateTime.Today.AddYears(-1);

            //Fired Employee
            employee1.DateHired = DateTime.Today.AddYears(-3);
            employee1.TermDate = DateTime.Today;


            Console.WriteLine();
            Console.WriteLine(employee3.FirstN + " " + employee3.LastN + " " + "received a promotion from grade 20 to " + employee3.Grade + "  and a 4% raise making his total salary " + employee3.PayRate);
            Console.WriteLine(employee3.FirstN + " was hired in on" + employee3.DateHired.ToShortDateString());
            Console.WriteLine(employee4.FirstN + " " + employee4.LastN + " received a promotion from grade 10 to " + employee4.Grade + " and a 4% raise making his total salary " + employee4.PayRate);
            Console.WriteLine(employee4.FirstN + " was hired in on " + employee4.DateHired.ToShortDateString());
            Console.WriteLine(employee1.FirstN + employee1.LastN + " was hired in on " + employee1.DateHired.ToShortDateString() + "  and terminated on " + employee1.TermDate.ToShortDateString());
            Console.WriteLine();

            //Utils.Pay(myArray);


            //Ask for Employee Name from User
            List<Employ> myEmployList = new List<Employ>();
            Console.WriteLine("Please enter an employee name\n  ");

            while (AddNewEmploy(userInput)) {
                for (int i = 0; i <= myEmployList.Count; i++)
                {
                    myEmployList.Add(new Employ());
                    myEmployList[i].FirstN = Console.ReadLine();

                }
               
            }
            Console.WriteLine("Would you like to add an employee Y|N");
            string userInput = Console.ReadLine().ToUpper();

            //Console.WriteLine(myEmployList[i].FirstN);



            Console.ReadLine();
        
        }

        static bool AddNewEmploy(string x)
        {
            if (x == "Y")
            {
                return true;


            }
            else if (x == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Incorrect input, Please enter a Y|N");
                return false;
            }
      
        }
    }
}
