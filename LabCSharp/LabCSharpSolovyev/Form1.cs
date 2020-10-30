using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCSharp {
	public partial class Form1 : Form {
		
		AnimalsList animals = new AnimalsList();
		public Form1() {
			InitializeComponent();
			ResetField();
		}

		protected override void WndProc(ref Message m) {
			base.WndProc(ref m);
			if(TypeField.SelectedIndex == 0) {
				PanelOther.Visible = true;
			} else {
				PanelOther.Visible = false;
			}
		}

		private void AddButton_Click(object sender, EventArgs e) {
			PanelAdd.Visible = true;
		}

		private void Cancel_Click(object sender, EventArgs e) {
			PanelAdd.Visible = false;
		}

		private void Create_Click(object sender, EventArgs e) {
			ErrorLabel.Text = "";
			bool isTry = true;
			string name = "";
			int age = 0, countFeed = 0;
			float weight = 0, lenghtWing = 0;
			if(NameField.Text == "") {
				LogError("*Неверно введено название животного\n", out isTry);
			} else {
				name = NameField.Text;
			}
			if (AgeField.Text == "" || !int.TryParse(AgeField.Text, out age)) {
				LogError("*Неверно введен возраст животного\n", out isTry);
			}
			if (CountFeed.Text == "" || !int.TryParse(CountFeed.Text, out countFeed)) {
				LogError("*Неверно введено количество корма\n", out isTry);
			}
			if (WeightField.Text == "" || !float.TryParse(WeightField.Text, out weight)) {
				LogError("*Неверно введен вес\n", out isTry);
			}
			if(TypeField.SelectedIndex == 0) {
				if (LenghtWingsField.Text == "" || !float.TryParse(LenghtWingsField.Text, out lenghtWing)) {
					LogError("*Неверно введен размах крыльев\n", out isTry);
				}
			}

			if (!isTry) return;

			switch (TypeField.SelectedIndex) {
				case 0:
					animals.Add(new Bird(name, age, countFeed, weight, lenghtWing));
					break;
				case 1:
					animals.Add(new Mammal(name, age, countFeed, weight));
					break;
			}
			ResetField();
			PanelAdd.Visible = false;
			RenderTable();
		}

		void ResetField() {
			NameField.Text = "";
			AgeField.Text = "";
			WeightField.Text = "";
			LenghtWingsField.Text = "";
			CountFeed.Text = "";
			TypeField.SelectedIndex = 0;
		}

		void LogError(string str, out bool isTry) {
			isTry = false;
			ErrorLabel.Text += str;
		}

		void RenderTable() {
			if (animals.Count == 0) return;
			Table.RowCount = animals.Count;
			int index = 0;
			foreach(var i in animals) {
				Table.Rows[index].Cells[1].Value = i.name;
				Table.Rows[index].Cells[2].Value = i.age;
				Table.Rows[index].Cells[3].Value = i.countFeed;
				if(i is Mammal) {
					Table.Rows[index].Cells[0].Value = "Млекопитающее";
					Table.Rows[index].Cells[4].Value = (i as Mammal).weight;
					Table.Rows[index].Cells[5].Value = "";
				}
				if (i is Bird) {
					Table.Rows[index].Cells[0].Value = "Птица";
					Table.Rows[index].Cells[4].Value = (i as Bird).weight;
					Table.Rows[index].Cells[5].Value = "Размах="+(i as Bird).lenghtWing;
				}
				index++;
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			ResetField();
		}

		private void button3_Click(object sender, EventArgs e) {
			animals.Sort(AnimalsList.TypeSort.ageUp);
			RenderTable();
		}

		private void button2_Click(object sender, EventArgs e) {
			animals.Sort(AnimalsList.TypeSort.ageDown);
			RenderTable();
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PanelOther_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LenghtWingsField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
