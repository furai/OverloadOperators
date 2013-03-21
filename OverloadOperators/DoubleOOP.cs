using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
	class DoubleOOP
	{
		public double Value { get; set; }
		public DoubleOOP(double v)
		{
			this.Value = v;
		}
		public DoubleOOP()
		{

		}

		public static DoubleOOP operator +(double change, DoubleOOP v1)
		{
			return new DoubleOOP(change + v1.Value);
		}

		public static DoubleOOP operator -(double change, DoubleOOP v1)
		{
			return new DoubleOOP(change - v1.Value);
		}

		public static DoubleOOP operator +(DoubleOOP v1, double change)
		{
			return new DoubleOOP(v1.Value + change);
		}

		public static DoubleOOP operator -(DoubleOOP v1, double change)
		{
			return new DoubleOOP(v1.Value - change);
		}

		public static DoubleOOP operator +(DoubleOOP v1, DoubleOOP v2)
		{
			return new DoubleOOP(v1.Value + v2.Value);
		}

		public static DoubleOOP operator -(DoubleOOP v1, DoubleOOP v2)
		{
			return new DoubleOOP(v1.Value - v2.Value);
		}

		public static DoubleOOP operator /(DoubleOOP v1, DoubleOOP v2)
		{
			return new DoubleOOP(v1.Value / v2.Value);
		}

		public static DoubleOOP operator *(DoubleOOP v1, DoubleOOP v2)
		{
			return new DoubleOOP(v1.Value * v2.Value);
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			DoubleOOP p = obj as DoubleOOP;
			if ((System.Object)p == null)
			{
				return false;
			}
			return Value == p.Value;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public static bool operator ==(DoubleOOP v1, DoubleOOP v2)
		{
			if (((object)v1 == null) || ((object)v2 == null))
			{
				return false;
			}
			if (object.ReferenceEquals(v1, v2))
				return true;
			return v1.Value == v2.Value;
		}

		public static bool operator !=(DoubleOOP v1, DoubleOOP v2)
		{
			return !(v1 == v2);
		}

		public static implicit operator DoubleOOP(double value)
		{
			return new DoubleOOP { Value = value };
		}

		public static explicit operator double(DoubleOOP v1)
		{
			return v1.Value;
		}

		public override string ToString()
		{
			return this.Value.ToString();
		}
	}
}
