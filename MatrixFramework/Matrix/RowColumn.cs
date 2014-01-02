using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFramework.Matrix
{
    public class RowColumn : Object
    {
        public RowColumn(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }
        public int Row { get; set; }
        public int Column { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is RowColumn)
            {
                return (this.Row.Equals(((RowColumn)obj).Row) && this.Column.Equals(((RowColumn)obj).Column));
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("Row={0},Column={1}", Row, Column);
        }
    }
}
