using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSday2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam school = new Exam();
            Console.WriteLine("SCHOOL----------------");
            school.physics(50);
            school.chemistry(50);
            school.showResults();

            Exam college = new Exam(150, 60);
            Console.WriteLine("COLLEGE----------------");
            college.physics(60);
            college.chemistry(60);
            college.showResults();

            Nottingham N = new Nottingham();
            N.msg();

            MathA a = new MathA();
            a.add(10,5);

            MathB b = new MathB();
            b.add(10, 5);
            b.sub(10, 5);

            Console.Read();
        }
    }
}
