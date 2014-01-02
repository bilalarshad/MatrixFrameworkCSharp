using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFramework.Matrix
{
    public interface IMatrixCollection<T>
    {
        ICollection<T> AsCollection();
        T[,] AsArray();
    }

}
