using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.NET
{
    public class PersonEx1
    {
        public string name;
        public int age;


        public static PersonEx1 CompareWeight(PersonEx1 obj1, PersonEx1 obj2)
        {
            if (obj1.age > obj2.age)
            {
                return obj1;
            }
            else
            {
                return obj2;
            }
        }

    }
}
