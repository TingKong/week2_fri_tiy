using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_emply
{
    public class Depart
    {
        string deptName;
        string managerName;
        string location;

        public string DeptName
        {
            get
            {
                return deptName;
            }
            set
            {
                deptName = value;
            }
        }

        public virtual void ChangeDeptName(string newDeptName)
        {

            deptName = newDeptName;
        }
    }

}

