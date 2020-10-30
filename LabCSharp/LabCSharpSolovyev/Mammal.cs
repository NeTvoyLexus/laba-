using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCSharp {
	public class Mammal : Animal {
		public float weight { get; protected set; }
		public Mammal(string name, int age, int countFeed, float weight) : base(name, age, countFeed) {
			this.weight = weight;
		}

		public override void Feeding() {
			if (weight < 5) {
				countFeed -= 1;
			} else {
				if (weight < 10) {
					countFeed -= 2;
				} else {
					countFeed -= 3;
				}
			}
		}
	}
}
