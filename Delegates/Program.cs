using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            Maths oMaths = new Maths();
           int a = oMaths.GetPointer(5).Invoke(4, 4);
        }       
    }

    class Maths
    {
        public delegate int MathOperation(int i, int j);
        
        //Added Comment line here : 
        public MathOperation GetPointer(int i)
        {
            MathOperation oDelegete = null;
            if (i == 1)
                oDelegete = Add;
            else
                oDelegete = Sub;

            return oDelegete;
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
