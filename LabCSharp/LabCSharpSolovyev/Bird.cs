using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCSharp {
	public class Bird : Animal {
		public float weight { get; protected set; }
		public float lenghtWing { get; protected set; }
		public Bird(string name, int age, int countFeed, float weight, float lenghtWing) : base(name, age, countFeed) {
			this.weight = weight;
			this.lenghtWing = lenghtWing;
		}
		public override void Feeding() {
			countFeed-=1;
		}
	}
}
