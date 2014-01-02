using MatrixFramework.Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<Me> matrix = new Matrix<Me>(3, 3);
            matrix.Add(0, 0, new Me() { Name = "B" });
            matrix.Add(1, 1, new Me() { Name = "I" });
            matrix.Add(2, 2, new Me() { Name = "L" });
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix.ElementAt(i, j).Name);
                    Console.Write(" , ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

    }
    public class Me
    {
        private string name;

        public string Name
        {
            get
            {
                if (this == null)
                {
                    return "null";
                }
                return name;
            }
            set { name = value; }
        }

    }
}
