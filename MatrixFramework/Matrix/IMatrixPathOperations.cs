using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFramework.Matrix
{
    public interface IMatrixPathOperations<T>
    {
        ICollection<RowColumn> GetShortestPath(int r, int c, int r1, int c1);
        ICollection<RowColumn> GetShortestPath(int r, int c, T obj);
        ICollection<RowColumn> GetShortestPath(T obj, int r1, int c1);
    }
}
