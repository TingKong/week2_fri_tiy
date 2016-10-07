using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_emply
{

    public abstract class People
    {

        protected DateTime dateBirth;
        protected string ssNumber;
        protected string fN;
        protected string lN;
        protected string changeName;
        protected string name;
        protected string firstN;
        protected string lastN;
        

        public string FirstN
        {
            get
            {
                return firstN;
            }
            set
            {
                firstN = value;
            }
        }


        public string LastN
        {
            get
            {
                return lastN;
            }
            set
            {
                lastN = value;
            }
        }


        public virtual void ChangeName(string firstName, string lastName)
        {
            this.fN = firstName;
            this.lN = lastName;

            

        }

        
    }

    

       

    }


