using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSday2
{
    class Exam
    {
        private int phy, che;
        private int passMark, maxMark;
        private int invalid, failed;

        public Exam()
        {
            maxMark = 100;
            passMark = 50;
        }

        public Exam(int m, int p)
        {
            maxMark = m;
            passMark = p;
        }

        public void physics(int p)
        {
            if (p >= 0 && p <= maxMark)
            {
                phy = p;

                if(p < passMark)
                {
                    Console.WriteLine("Failed Physics, pass mark is " + passMark);
                    failed = 1;
                }
            } else
            {
                Console.WriteLine("Invalid physics mark, maximum mark is " + maxMark);
                invalid++;
            }
        }

        public void chemistry(int c)
        {
            if (c >= 0 && c <= maxMark)

            {
                che = c;

                if (c < passMark)
                {
                    Console.WriteLine("Failed Chemistry, pass mark is " + passMark);
                    failed = 1;
                }
            }
            else
            {
                Console.WriteLine("Invalid chemisty mark, maximum mark is " + maxMark);
                invalid++; 
            }
        }


        public void showResults()
        {
            if (invalid == 0)
            {
                float total, per;
                total = phy + che;
                per = (float)total * 100 / (maxMark * 2);

                if (failed == 0)
                {
                    Console.WriteLine("Total marks: " + total);
                    Console.WriteLine("Percentage: " + per);
                }
            } else
            {
                Console.WriteLine("Number of invalid marks: " + invalid);
            }
        }
    }

}
