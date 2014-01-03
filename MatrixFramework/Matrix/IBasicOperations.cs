using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFramework.Matrix
{
    public interface IBasicOperations<T>
    {
        bool IsValid(int r, int c);

        bool Replace(int r, int c, int r1, int c1);

        bool Remove(int r, int c);

        bool Update(int r, int c, T obj);

        bool Add(int r, int c, T obj);

        bool SwapRows(int r, int r1);

        bool SwapColumns(int r, int r1);

        T ElementAt(int r, int c);
    }

}
