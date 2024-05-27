namespace ParkingPlace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            DeleteButton = new Button();
            CostCalculate = new Button();
            CarId = new TextBox();
            CarBrand = new TextBox();
            CarModel = new TextBox();
            CarColor = new TextBox();
            CarArrivalTime = new TextBox();
            labelCarId = new Label();
            labelCarBrand = new Label();
            labelCarModel = new Label();
            labelCarColor = new Label();
            label1 = new Label();
            ListParkingSpot = new ListView();
            ArrivalDateTime = new DateTimePicker();
            DepartureDateTime = new DateTimePicker();
            labelDepartureTime = new Label();
            CarDepartureTime = new TextBox();
            SaveButton = new Button();
            LoadButton = new Button();
            labelParkingSpot = new Label();
            labelParkingCost = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(129, 46);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавление авто";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(164, 12);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(129, 46);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = " Удаление авто";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CostCalculate
            // 
            CostCalculate.Location = new Point(320, 12);
            CostCalculate.Name = "CostCalculate";
            CostCalculate.Size = new Size(129, 46);
            CostCalculate.TabIndex = 2;
            CostCalculate.Text = "Вычислить стоимость парковки";
            CostCalculate.UseVisualStyleBackColor = true;
            CostCalculate.Click += CostCalculate_Click;
            // 
            // CarId
            // 
            CarId.Location = new Point(164, 91);
            CarId.Name = "CarId";
            CarId.Size = new Size(205, 23);
            CarId.TabIndex = 3;
            CarId.TextChanged += CarId_TextChanged;
            // 
            // CarBrand
            // 
            CarBrand.Location = new Point(164, 131);
            CarBrand.Name = "CarBrand";
            CarBrand.Size = new Size(205, 23);
            CarBrand.TabIndex = 4;
            // 
            // CarModel
            // 
            CarModel.Location = new Point(164, 174);
            CarModel.Name = "CarModel";
            CarModel.Size = new Size(205, 23);
            CarModel.TabIndex = 5;
            // 
            // CarColor
            // 
            CarColor.Location = new Point(164, 222);
            CarColor.Name = "CarColor";
            CarColor.Size = new Size(205, 23);
            CarColor.TabIndex = 6;
            // 
            // CarArrivalTime
            // 
            CarArrivalTime.Location = new Point(793, 274);
            CarArrivalTime.Name = "CarArrivalTime";
            CarArrivalTime.Size = new Size(205, 23);
            CarArrivalTime.TabIndex = 7;
            // 
            // labelCarId
            // 
            labelCarId.AutoSize = true;
            labelCarId.Location = new Point(44, 94);
            labelCarId.Name = "labelCarId";
            labelCarId.Size = new Size(75, 15);
            labelCarId.TabIndex = 8;
            labelCarId.Text = "Номер авто:";
            labelCarId.Click += labelCarId_Click;
            // 
            // labelCarBrand
            // 
            labelCarBrand.AutoSize = true;
            labelCarBrand.Location = new Point(44, 134);
            labelCarBrand.Name = "labelCarBrand";
            labelCarBrand.Size = new Size(70, 15);
            labelCarBrand.TabIndex = 9;
            labelCarBrand.Text = "Бренд авто:";
            // 
            // labelCarModel
            // 
            labelCarModel.AutoSize = true;
            labelCarModel.Location = new Point(44, 182);
            labelCarModel.Name = "labelCarModel";
            labelCarModel.Size = new Size(80, 15);
            labelCarModel.TabIndex = 10;
            labelCarModel.Text = "Модель авто:";
            // 
            // labelCarColor
            // 
            labelCarColor.AutoSize = true;
            labelCarColor.Location = new Point(44, 230);
            labelCarColor.Name = "labelCarColor";
            labelCarColor.Size = new Size(63, 15);
            labelCarColor.TabIndex = 11;
            labelCarColor.Text = "Цвет авто:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 277);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 12;
            label1.Text = "Время приезда: ";
            // 
            // ListParkingSpot
            // 
            ListParkingSpot.Location = new Point(483, 91);
            ListParkingSpot.Name = "ListParkingSpot";
            ListParkingSpot.Size = new Size(288, 290);
            ListParkingSpot.TabIndex = 13;
            ListParkingSpot.UseCompatibleStateImageBehavior = false;
            // 
            // ArrivalDateTime
            // 
            ArrivalDateTime.Location = new Point(164, 269);
            ArrivalDateTime.Name = "ArrivalDateTime";
            ArrivalDateTime.Size = new Size(205, 23);
            ArrivalDateTime.TabIndex = 14;
            // 
            // DepartureDateTime
            // 
            DepartureDateTime.Location = new Point(164, 310);
            DepartureDateTime.Name = "DepartureDateTime";
            DepartureDateTime.Size = new Size(205, 23);
            DepartureDateTime.TabIndex = 15;
            // 
            // labelDepartureTime
            // 
            labelDepartureTime.AutoSize = true;
            labelDepartureTime.Location = new Point(44, 318);
            labelDepartureTime.Name = "labelDepartureTime";
            labelDepartureTime.Size = new Size(89, 15);
            labelDepartureTime.TabIndex = 16;
            labelDepartureTime.Text = "Время выезда: ";
            // 
            // CarDepartureTime
            // 
            CarDepartureTime.Location = new Point(793, 315);
            CarDepartureTime.Name = "CarDepartureTime";
            CarDepartureTime.Size = new Size(205, 23);
            CarDepartureTime.TabIndex = 17;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(585, 413);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(90, 25);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(681, 413);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(90, 25);
            LoadButton.TabIndex = 19;
            LoadButton.Text = "Загрузить";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // labelParkingSpot
            // 
            labelParkingSpot.AutoSize = true;
            labelParkingSpot.Location = new Point(483, 60);
            labelParkingSpot.Name = "labelParkingSpot";
            labelParkingSpot.Size = new Size(122, 15);
            labelParkingSpot.TabIndex = 20;
            labelParkingSpot.Text = "Парковочные места:";
            // 
            // labelParkingCost
            // 
            labelParkingCost.AutoSize = true;
            labelParkingCost.Location = new Point(44, 366);
            labelParkingCost.Name = "labelParkingCost";
            labelParkingCost.Size = new Size(125, 15);
            labelParkingCost.TabIndex = 21;
            labelParkingCost.Text = "Стоимость парковки:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 450);
            Controls.Add(labelParkingCost);
            Controls.Add(labelParkingSpot);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(CarDepartureTime);
            Controls.Add(labelDepartureTime);
            Controls.Add(DepartureDateTime);
            Controls.Add(ArrivalDateTime);
            Controls.Add(ListParkingSpot);
            Controls.Add(label1);
            Controls.Add(labelCarColor);
            Controls.Add(labelCarModel);
            Controls.Add(labelCarBrand);
            Controls.Add(labelCarId);
            Controls.Add(CarArrivalTime);
            Controls.Add(CarColor);
            Controls.Add(CarModel);
            Controls.Add(CarBrand);
            Controls.Add(CarId);
            Controls.Add(CostCalculate);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button DeleteButton;
        private Button CostCalculate;
        private TextBox CarId;
        private TextBox CarBrand;
        private TextBox CarModel;
        private TextBox CarColor;
        private TextBox CarArrivalTime;
        private Label labelCarId;
        private Label labelCarBrand;
        private Label labelCarModel;
        private Label labelCarColor;
        private Label label1;
        private ListView ListParkingSpot;
        private DateTimePicker ArrivalDateTime;
        private DateTimePicker DepartureDateTime;
        private Label labelDepartureTime;
        private TextBox CarDepartureTime;
        private Button SaveButton;
        private Button LoadButton;
        private Label labelParkingSpot;
        private Label labelParkingCost;
    }
}