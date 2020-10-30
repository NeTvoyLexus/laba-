using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCSharp {
	public class AnimalsList : IEnumerable<Animal>{
		public enum TypeSort {
			ageUp,
			ageDown
		}
		public enum TypeAnimal {
			mammol,
			bird
		}
		List<Animal> animals = new List<Animal>();
		public int Count {
			get {
				return animals.Count;
			}
		}
		public IEnumerator<Animal> GetEnumerator() {
			return ((IEnumerable<Animal>)animals).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return ((IEnumerable<Animal>)animals).GetEnumerator();
		}

		public void Add(Animal animal) {
			animals.Add(animal);
		}
		public void Remove(Animal animal) {
			animals.Remove(animal);
		}
		public void Remove(int index) {
			animals.RemoveAt(index);
		}
		public void Sort(TypeSort typeSort) {
			switch (typeSort) {
				case TypeSort.ageUp:
					SortAgeUp();
					break;
				case TypeSort.ageDown:
					SortAgeDown();
					break;
			}
		}

		public void SortAgeUp() {
			Animal temp;
			for (int i = 0; i < animals.Count - 1; i++) {
				for (int j = i + 1; j < animals.Count; j++) {
					if (animals[i].age > animals[j].age) {
						temp = animals[i];
						animals[i] = animals[j];
						animals[j] = temp;
					}
				}
			}
		}
		public void SortAgeDown() {
			Animal temp;
			for (int i = 0; i < animals.Count - 1; i++) {
				for (int j = i + 1; j < animals.Count; j++) {
					if (animals[i].age < animals[j].age) {
						temp = animals[i];
						animals[i] = animals[j];
						animals[j] = temp;
					}
				}
			}
		}
	}
}
