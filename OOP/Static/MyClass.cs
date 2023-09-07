using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class MyClass
    {
		public MyClass()
		{
			Counter++;
		}

		private static int counter;

		public static int Counter
		{
			get { return counter; }
			private set { counter = value; }
		}

		public int ObjectsCount
		{
			get { return counter; }
		}

		public static int GetCounter()
		{
			return counter;
		}

		public int GetObjectsCount()
		{
			return counter;
		}

	}
}
