using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_emply
{
    public class Employ : People
    {
        //Hire date
        //Termination date
        //Pay rate
        //Pay grade
        //Hours worked
        //Department

        DateTime dateHired;
        DateTime termDate;
        double payRate;
        int grade;

        Depart department;

        

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }

        }

        public double PayRate
        {
            get
            {
                return payRate;
            }
            set
            {
                payRate = value;
            }

        }

        public DateTime DateHired
        {
            get
            {
                return dateHired;
            }
            set
            {
                dateHired = value;
            }

        }


        public DateTime TermDate
        {
            get
            {
                return termDate;
            }
            set
            {
                termDate= value;
            }

        }

        public virtual void ChangeGrade(int newGrade)
        {
            grade = newGrade;
        }



        public virtual void Hired(DateTime hDate)
        {

            dateHired = hDate.AddYears(-1);
            
        }

        public virtual bool Fired()
        {

           termDate = DateTime.Today;
            return true;
        }

        public void Raise(Double money)
        {

           payRate = money * 1.04;
        }



        //public string EmpInputN(string empNewName)
        //{
              
        
        //    public Square(double side) : base(side, 0)
        //    {
        //    }

        //    public override double Area()
        //    {
        //        return x * x;
        //    }
        //}
    }



    }

