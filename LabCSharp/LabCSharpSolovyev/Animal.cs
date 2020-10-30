using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCSharp {
	public abstract class Animal {
		public string name { get; protected set; }
		public int age { get; protected set; }
		public int countFeed { get; protected set; }

		public Animal(string name, int age, int countFeed) {
			this.name = name;
			this.age = age;
			this.countFeed = countFeed;
		}

		public abstract void Feeding();
	}
}
