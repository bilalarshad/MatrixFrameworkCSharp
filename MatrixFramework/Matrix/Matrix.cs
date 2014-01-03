using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFramework.Matrix
{
    public class Matrix<T> : MatrixPathFinder<T>, IBasicOperations<T>, IMatrixCollection<T> where T : new()
    {
        public Matrix(int Rows, int Columns)
        {
            this.Rows = Rows;
            this.Columns = Columns;
            Grid = new T[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Grid[i, j] = new T();
                }
            }
        }

        private int Rows { get; set; }

        private int Columns { get; set; }

        private T[,] Grid { get; set; }

        public bool IsValid(int r, int c)
        {
            return r < Rows && r > -1 && c < Columns && c > -1;
        }

        public bool Replace(int r, int c, int r1, int c1)
        {
            var temp = Grid[r, c];
            Grid[r, c] = Grid[r1, c1];
            Grid[r1, c1] = temp;
            return true;
        }

        public bool Remove(int r, int c)
        {
            Grid[r, c] = new T();
            return true;
        }

        public bool Update(int r, int c, T obj)
        {
            Grid[r, c] = obj;
            return true;
        }

        public bool Add(int r, int c, T obj)
        {
            Grid[r, c] = obj;
            return true;
        }

        public ICollection<T> AsCollection()
        {
            var tempCollection = new List<T>();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    tempCollection.Add(Grid[i, j]);
                }
            }
            return tempCollection;
        }

        public T ElementAt(int r, int c)
        {
            return Grid[r, c];
        }

        public T[,] AsArray()
        {
            return Grid;
        }

        public override bool SetPathFinderCondition()
        {
            throw new NotImplementedException();
        }


        public bool SwapRows(int r, int r1)
        {
            throw new NotImplementedException();
        }

        public bool SwapColumns(int r, int r1)
        {
            throw new NotImplementedException();
        }
    }
}
