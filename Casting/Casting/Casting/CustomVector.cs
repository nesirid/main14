using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Casting
{
    public class CustomVector
    {

        public int X { get; set; }
        public int Y { get; set; }



        public CustomVector(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CustomVector other = (CustomVector)obj;
            return X == other.X && Y == other.Y;
        }
        public static CustomVector operator +(CustomVector v1, CustomVector v2)
        {
            return new CustomVector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static CustomVector operator -(CustomVector v1, CustomVector v2)
        {
            return new CustomVector(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static CustomVector operator *(CustomVector v, int scalar)
        {
            return new CustomVector(v.X * scalar, v.Y * scalar);
        }
        public static bool operator ==(CustomVector v1, CustomVector v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }
        public static bool operator !=(CustomVector v1, CustomVector v2)
        {
            return !(v1 == v2);
        }
        public static explicit operator string(CustomVector v)
        {
            return $"({v.X}, {v.Y})";
        }


 
    }


}
