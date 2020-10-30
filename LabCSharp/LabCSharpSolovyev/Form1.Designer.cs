namespace LabCSharp {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TypeField = new System.Windows.Forms.ComboBox();
            this.typeAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Table = new System.Windows.Forms.DataGridView();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountFeedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameField = new System.Windows.Forms.TextBox();
            this.LAbelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CountFeed = new System.Windows.Forms.TextBox();
            this.WeghtLabel = new System.Windows.Forms.Label();
            this.WeightField = new System.Windows.Forms.TextBox();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LenghtWingsField = new System.Windows.Forms.TextBox();
            this.LabelLenghtWings = new System.Windows.Forms.Label();
            this.PanelOther = new System.Windows.Forms.Panel();
            this.mammalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.typeAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.PanelOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mammalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeField
            // 
            this.TypeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeField.FormattingEnabled = true;
            this.TypeField.Items.AddRange(new object[] {
            "Птица",
            "Млекопитающее"});
            this.TypeField.Location = new System.Drawing.Point(15, 43);
            this.TypeField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(114, 28);
            this.TypeField.TabIndex = 0;
            // 
            // typeAnimalBindingSource
            // 
            this.typeAnimalBindingSource.DataSource = typeof(LabCSharp.AnimalsList.TypeAnimal);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeColumn,
            this.NameColumn,
            this.Age,
            this.CountFeedColumn,
            this.WeightColumn,
            this.Other});
            this.Table.Location = new System.Drawing.Point(9, 10);
            this.Table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(749, 342);
            this.Table.TabIndex = 1;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Тип";
            this.TypeColumn.MinimumWidth = 6;
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Width = 125;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // CountFeedColumn
            // 
            this.CountFeedColumn.HeaderText = "Корм";
            this.CountFeedColumn.MinimumWidth = 6;
            this.CountFeedColumn.Name = "CountFeedColumn";
            this.CountFeedColumn.ReadOnly = true;
            // 
            // WeightColumn
            // 
            this.WeightColumn.HeaderText = "Вес";
            this.WeightColumn.MinimumWidth = 6;
            this.WeightColumn.Name = "WeightColumn";
            this.WeightColumn.ReadOnly = true;
            // 
            // Other
            // 
            this.Other.HeaderText = "Другое";
            this.Other.MinimumWidth = 6;
            this.Other.Name = "Other";
            this.Other.ReadOnly = true;
            this.Other.Width = 140;
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(16, 148);
            this.NameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(181, 27);
            this.NameField.TabIndex = 2;
            // 
            // LAbelName
            // 
            this.LAbelName.AutoSize = true;
            this.LAbelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAbelName.Location = new System.Drawing.Point(11, 121);
            this.LAbelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAbelName.Name = "LAbelName";
            this.LAbelName.Size = new System.Drawing.Size(111, 26);
            this.LAbelName.TabIndex = 3;
            this.LAbelName.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(195, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Возраст";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AgeField
            // 
            this.AgeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeField.Location = new System.Drawing.Point(200, 148);
            this.AgeField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgeField.Name = "AgeField";
            this.AgeField.Size = new System.Drawing.Size(181, 27);
            this.AgeField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(563, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество корма";
            // 
            // CountFeed
            // 
            this.CountFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountFeed.Location = new System.Drawing.Point(568, 148);
            this.CountFeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountFeed.Name = "CountFeed";
            this.CountFeed.Size = new System.Drawing.Size(181, 27);
            this.CountFeed.TabIndex = 7;
            // 
            // WeghtLabel
            // 
            this.WeghtLabel.AutoSize = true;
            this.WeghtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeghtLabel.Location = new System.Drawing.Point(378, 121);
            this.WeghtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeghtLabel.Name = "WeghtLabel";
            this.WeghtLabel.Size = new System.Drawing.Size(50, 26);
            this.WeghtLabel.TabIndex = 10;
            this.WeghtLabel.Text = "Вес";
            // 
            // WeightField
            // 
            this.WeightField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightField.Location = new System.Drawing.Point(383, 148);
            this.WeightField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WeightField.Name = "WeightField";
            this.WeightField.Size = new System.Drawing.Size(181, 27);
            this.WeightField.TabIndex = 9;
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.button1);
            this.PanelAdd.Controls.Add(this.ErrorLabel);
            this.PanelAdd.Controls.Add(this.Cancel);
            this.PanelAdd.Controls.Add(this.Create);
            this.PanelAdd.Controls.Add(this.PanelOther);
            this.PanelAdd.Controls.Add(this.TypeField);
            this.PanelAdd.Controls.Add(this.NameField);
            this.PanelAdd.Controls.Add(this.WeghtLabel);
            this.PanelAdd.Controls.Add(this.LAbelName);
            this.PanelAdd.Controls.Add(this.WeightField);
            this.PanelAdd.Controls.Add(this.label1);
            this.PanelAdd.Controls.Add(this.label3);
            this.PanelAdd.Controls.Add(this.AgeField);
            this.PanelAdd.Controls.Add(this.CountFeed);
            this.PanelAdd.Controls.Add(this.label2);
            this.PanelAdd.Location = new System.Drawing.Point(9, 7);
            this.PanelAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(978, 390);
            this.PanelAdd.TabIndex = 13;
            this.PanelAdd.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(477, 97);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorLabel.MaximumSize = new System.Drawing.Size(270, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 22);
            this.ErrorLabel.TabIndex = 16;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(253, 213);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(116, 31);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(133, 213);
            this.Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(116, 31);
            this.Create.TabIndex = 14;
            this.Create.Text = "Добавить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(475, 356);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 31);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(253, 356);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Возраст по убыванию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(10, 356);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 31);
            this.button3.TabIndex = 18;
            this.button3.Text = "Возраст по возрастанию";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LenghtWingsField
            // 
            this.LenghtWingsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtWingsField.Location = new System.Drawing.Point(2, 29);
            this.LenghtWingsField.Margin = new System.Windows.Forms.Padding(2);
            this.LenghtWingsField.Name = "LenghtWingsField";
            this.LenghtWingsField.Size = new System.Drawing.Size(181, 27);
            this.LenghtWingsField.TabIndex = 11;
            this.LenghtWingsField.TextChanged += new System.EventHandler(this.LenghtWingsField_TextChanged);
            // 
            // LabelLenghtWings
            // 
            this.LabelLenghtWings.AutoSize = true;
            this.LabelLenghtWings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLenghtWings.Location = new System.Drawing.Point(2, 0);
            this.LabelLenghtWings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLenghtWings.Name = "LabelLenghtWings";
            this.LabelLenghtWings.Size = new System.Drawing.Size(183, 26);
            this.LabelLenghtWings.TabIndex = 12;
            this.LabelLenghtWings.Text = "Размах крыльев";
            // 
            // PanelOther
            // 
            this.PanelOther.Controls.Add(this.LenghtWingsField);
            this.PanelOther.Controls.Add(this.LabelLenghtWings);
            this.PanelOther.Location = new System.Drawing.Point(769, 121);
            this.PanelOther.Margin = new System.Windows.Forms.Padding(2);
            this.PanelOther.Name = "PanelOther";
            this.PanelOther.Size = new System.Drawing.Size(190, 56);
            this.PanelOther.TabIndex = 13;
            this.PanelOther.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOther_Paint);
            // 
            // mammalBindingSource
            // 
            this.mammalBindingSource.DataSource = typeof(LabCSharp.Mammal);
            // 
            // birdBindingSource
            // 
            this.birdBindingSource.DataSource = typeof(LabCSharp.Bird);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 398);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.typeAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.PanelOther.ResumeLayout(false);
            this.PanelOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mammalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox TypeField;
		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.TextBox NameField;
		private System.Windows.Forms.Label LAbelName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox AgeField;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox CountFeed;
		private System.Windows.Forms.Label WeghtLabel;
		private System.Windows.Forms.TextBox WeightField;
		private System.Windows.Forms.Panel PanelAdd;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Create;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.BindingSource mammalBindingSource;
		private System.Windows.Forms.BindingSource birdBindingSource;
		private System.Windows.Forms.BindingSource typeAnimalBindingSource;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn CountFeedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn WeightColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Other;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ImageList imageList3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LabelLenghtWings;
        private System.Windows.Forms.Panel PanelOther;
        private System.Windows.Forms.TextBox LenghtWingsField;
    }
}

