using Racing.Model.Abstractions;
using Racing.Model.Classes;
using Racing.Model.Classes.Airs;
using Racing.Model.Classes.Grounds;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyFunc();
        }
        IEnumerable<Transport> CreateAll()
        {
            return new List<Transport>() { new Broomstick(), new FlyingShip(), new Centaur(), new BootsRunners(),
            new BabaYagaStupa(), new MagicCarpet(), new HutOnChickenLegs(), new PumpkinCarriage()};
        }
        IEnumerable<Transport> GetTransports()
        {
            var transports = new List<Transport>();
            foreach (var item in listBoxChoosen.Items)
            {
                transports.Add(item as Transport);
            }
            return transports;
        }
        bool CheckParametrs()
        {
            if(!int.TryParse(textBoxDistance.Text, out int numericValue) || numericValue < 1)
            {
                MessageBox.Show("Enter the correct distance", "Error");
                return false;
            }
            if(comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Choose the type of race", "Error");
                return false;
            }
            if (listBoxChoosen.Items.Count == 0) 
            {
                MessageBox.Show("Add at least one transport", "Error");
                return false;
            }
            return true;
        }
        private void buttonRace_MouseClick(object sender, MouseEventArgs e)
        {
            if (!CheckParametrs())
                return;
            Race race;
            switch (comboBoxType.SelectedItem)
            {
                case "All":
                    race = Race.CreateRace<Transport>(Convert.ToUInt32(textBoxDistance.Text), comboBoxType.SelectedItem.ToString(), GetTransports());
                    break;
                case "Air":
                    race = Race.CreateRace<Air>(Convert.ToUInt32(textBoxDistance.Text), comboBoxType.SelectedItem.ToString(), GetTransports());
                    break;
                case "Ground":
                    race = Race.CreateRace<Ground>(Convert.ToUInt32(textBoxDistance.Text), comboBoxType.SelectedItem.ToString(), GetTransports());
                    break;
                default:
                    race = Race.CreateRace<Transport>(Convert.ToUInt32(textBoxDistance.Text), comboBoxType.SelectedItem.ToString(), GetTransports());
                    break;
            }
             
            if(race==null)
            {
                MessageBox.Show("Some vehicles don't fit the race category", "Error");
                return;
            }
            race.SimulateRace();
            string winners = string.Empty;
            foreach (var item in race.Winners)
            {
                winners += item.ToString() + ",\n";
            }
            winners = winners.Remove(winners.Length - 2);
            MessageBox.Show("Winners:\n" + winners, "Result");
        }

        private void listBoxChoose_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxChoose.SelectedItem == null)
                return;
            listBoxChoosen.Items.Insert(listBoxChoosen.Items.Count, listBoxChoose.SelectedItem);
            listBoxChoose.Items.RemoveAt(listBoxChoose.SelectedIndex);
        }

        private void listBoxChoosen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxChoosen.SelectedItem == null)
                return;
            listBoxChoose.Items.Insert(listBoxChoose.Items.Count, listBoxChoosen.SelectedItem);
            listBoxChoosen.Items.RemoveAt(listBoxChoosen.SelectedIndex);
        }
    }
}
