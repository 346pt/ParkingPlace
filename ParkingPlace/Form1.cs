using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParkingPlace
{
    public partial class Form1 : Form
    {
        private List<Car> cars = new List<Car>();
        private List<ParkingSpot> spots = new List<ParkingSpot>();
        private string fileName = "parking.txt";
        public class Car
        {
            public string Id { get; set; }
            public string Brand { get; set; }

            public string Model { get; set; }
            public string Color { get; set; }
            public DateTime ArrivalTime { get; set; }
            public DateTime DepartureTime { get; set; }

            public int ParkingSpot { get; set; }
            public decimal TotalCost { get; set; }
        }

        public class ParkingSpot
        {
            public int Id { get; set; }
            public bool IsAvailable { get; set; }
        }
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 25; i++)
            {
                spots.Add(new ParkingSpot { Id = i, IsAvailable = true });
            }
            ListParkingSpot.View = View.Details;
            ListParkingSpot.Columns.Add("Номер", 50);
            ListParkingSpot.Columns.Add("Бренд", 50);
            ListParkingSpot.Columns.Add("Модель", 75);
            ListParkingSpot.Columns.Add("Цвет", 50);
            ListParkingSpot.Columns.Add("Время приезда", 150);
            ListParkingSpot.Columns.Add("Время выезда", 150);
            UpdateParkingSpot();

        }

        private void labelCarId_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int freeSpot = FindFreeSpot();
            if (freeSpot == -1)
            {
                MessageBox.Show("Все места заняты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание нового объекта Car
            Car newCar = new Car
            {
                Id = CarId.Text,
                Brand = CarBrand.Text,
                Model = CarModel.Text,
                Color = CarColor.Text,
                ArrivalTime = ArrivalDateTime.Value,
                DepartureTime = DepartureDateTime.Value,
                ParkingSpot = freeSpot
            };

            cars.Add(newCar);

            UpdateParkingSpot();

            UpdateCarsListView();

            ClearInputFields();
        }

        private int FindFreeSpot()
        {
            for (int i = 0; i < spots.Count; i++)
            {
                if (spots[i].IsAvailable)
                {
                    return spots[i].Id;
                }
            }
            return -1;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ListParkingSpot.SelectedItems.Count == 0)
            {
                return;
            }
        }

        private void CostCalculate_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateParkingSpot()
        {
            ListParkingSpot.Items.Clear();
            foreach (ParkingSpot spot in spots)
            {
                ListViewItem item = new ListViewItem(spot.Id.ToString());
                item.SubItems.Add(spot.IsAvailable ? "Да" : "Нет");
                ListParkingSpot.Items.Add(item);
            }
        }
        private void UpdateCarsListView()
        {
            ListParkingSpot.Items.Clear();
            foreach (Car car in cars)
            {
                ListViewItem item = new ListViewItem(car.Id);
                item.SubItems.Add(car.Brand);
                item.SubItems.Add(car.Model);
                item.SubItems.Add(car.Color);
                item.SubItems.Add(car.ArrivalTime.ToString());
                item.SubItems.Add(car.DepartureTime.ToString());
                item.SubItems.Add(car.ParkingSpot.ToString());
                item.SubItems.Add(car.TotalCost.ToString());
                ListParkingSpot.Items.Add(item);
            }
        }

        private void ClearInputFields()
        {
            CarId.Clear();
            CarBrand.Clear();
            CarModel.Clear();
            CarColor.Clear();
            ArrivalDateTime.Value = DateTime.Now;
            DepartureDateTime.Value = DateTime.Now;
        }
        private void CarId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}