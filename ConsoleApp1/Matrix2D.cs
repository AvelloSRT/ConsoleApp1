using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public class Matrix2D
    {
        public int A { get; init; }//init gives one change chance
        public int B { get; init; }
        public int C { get; init; }
        public int D { get; init; }


        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Matrix2D() : this(1, 0, 0, 1) { }

        public static readonly Matrix2D Id = new(1, 0, 0, 1);
        public static readonly Matrix2D Zero = new(0, 0, 0, 0);

        public override string ToString() => $"[[{A}, {B}],[{C}, {D}]]";

        public bool Equals(Matrix2D? other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return A== other.A && B==other.B && C== other.C && D==other.D;
        }

        public override bool Equals(object? obj)
        {
            if(obj is null) return false;
            if(obj is not Matrix2D) return false;
            
            return Equals(obj as Matrix2D);
        }

        public override int GetHashCode() => HashCode.Combine(A, B, C, D);
        

        public static bool operator ==(Matrix2D? left, Matrix2D? right)
        {
            if(left == null && right == null) return true;
            if(left == null) return false;
            return left.Equals(right);
        }

        //addition
        public static Matrix2D operator +(Matrix2D m1, Matrix2D m2)
        {
            return new Matrix2D(m1.A + m2.A, m1.B + m2.B, m1.C + m2.C, m1.D + m2.D);

        }
        // subtraction
        public static Matrix2D operator -(Matrix2D m1, Matrix2D m2)
        {
            return new Matrix2D(m1.A - m2.A, m1.B - m2.B, m1.C - m2.C, m1.D - m2.D);
        //multiplication
        }
        public static Matrix2D operator *(Matrix2D m1, Matrix2D m2)
        {
            return new Matrix2D(m1.A *m2.A+m1.B*m2.C, m1.A * m2.B + m1.B * m2.D, m1.C * m2.A + m1.D * m2.C, m1.C * m2.B + m1.D * m2.D);
        }
        //inverse

    }
}
