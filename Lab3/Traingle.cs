using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Traingle
    {
        private int x;
        private int y;
        private int z;

        public Traingle(int A,int B, int C)
        {
            this.x = A;
            this.y = B;
            this.z = C;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Buttom length : " + x);
            Console.WriteLine("Right side length : " + y);
            Console.WriteLine("Left side length : " + z);
        }
        
        public void TestTraingle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("This is an equilateral triangle.\n");
            }
            else if (x == y || x== z || y == z)
            {
                Console.WriteLine("This is an isosceles triangle.\n");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle.\n");
            }
        }
    }

    
}
