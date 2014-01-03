using MatrixFramework.Beem.Matrix;
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
            var matrix = new BaseMatrix<Me>(4, 4);
            char ch = 'a';
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix.Add(i, j, new Me() { Name = ch.ToString() });
                    ch++;
                }
            }
            //matrix.Add(
            //Matrix<Me> matrix = new Matrix<Me>(3, 3);
            //matrix.Add(0, 0, new Me() { Name = "B" });
            //matrix.Add(1, 1, new Me() { Name = "I" });
            //matrix.Add(2, 2, new Me() { Name = "L" });

            Console.WriteLine("");
            Console.WriteLine(@"/\/\/\/\/\/\/\/\/\/\");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix.ElementAt(i, j).Name);
                    Console.Write(" , ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(@"/\/\/\/\/\/\/\/\/\/\");

            Console.WriteLine("");

            Console.WriteLine("");

            Console.WriteLine(@"/\/\/\/\/\/\/\/\/\/\");

            //matrix.Replace(1, 1, 2, 2);
            var t = matrix.Swap(1, 1, 2, 2);
            Console.WriteLine(@"/\/\/\/\/\/\/\/\/\/\");

            Console.WriteLine("");


            Console.WriteLine("");

            Console.WriteLine(@"/\/\/\/\/\/\/\/\/\/\");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix.ElementAt(i, j).Name);
                    Console.Write(" , ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(@"/\/\/\/\/\/\/\/\/\/\");

            var test = matrix.Find(new Me() { Name = "a" });

            Console.ReadKey();
        }

    }
    public class Me : MatrixItem
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


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                return this.Name.Equals(((Me)obj).Name);
            }
        }
    }
}
