using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET05
{
    public class StudentEx5
    {
        public string name;
        public double firstgrade;
        public double secondgrade;
        public double thirdgrade;

        public double FinalGrade()
        {
            double final = firstgrade  + secondgrade + thirdgrade;
            return final;
        }

        public bool ResultFinal()
        {
            if(FinalGrade() >= 60.0)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public double RestResultGrade()
        {
            double rest = 60.0 - FinalGrade();
            return rest;
        }
    }
}
