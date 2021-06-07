using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        
        
        private void OKbutton_Click(object sender, EventArgs e)
        {
            var f = (Form1)this.Owner;
            if (!checkTextBoxes())
                return;
            FactoryInfo info = new FactoryInfo(manufacturerTextBox.Text, modelTextBox.Text);
            switch(ChooseComboBox.SelectedIndex)
            {
                case 0:
                   // Console.WriteLine(doorAmountTextBox.Text+" ass");
                    Car car = new Car(info, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(massTextBox.Text), Convert.ToInt32(horsePowerTextBox.Text), Convert.ToInt32(doorAmountTextBox.Text));
                    //Console.WriteLine(doorAmountTextBox.Text+" ass");
                    f.takeNewItem(car);
                    break;
                case 1:
                    Motorcycle motorcycle= new Motorcycle(info, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(massTextBox.Text), Convert.ToInt32(horsePowerTextBox.Text), frameTextBox.Text);
                    f.takeNewItem(motorcycle);
                    break;
                case 2:
                    Console.WriteLine(typeCheckBox.Checked);
                    Bicycle bicycle= new Bicycle(info, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(massTextBox.Text), Convert.ToInt32(horsePowerTextBox.Text),frameTextBox.Text, typeCheckBox.Checked);
                    f.takeNewItem(bicycle);
                    break;
                case 3:
                    Boat boat = new Boat(info, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(massTextBox.Text), Convert.ToInt32(horsePowerTextBox.Text), Convert.ToInt32(cruiserSpeedTextBox.Text));
                    f.takeNewItem(boat);
                    break;
                case 4:
                    Plane plane= new Plane(info, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(massTextBox.Text), Convert.ToInt32(horsePowerTextBox.Text), Convert.ToInt32(maxPassengersTextBox.Text));
                    f.takeNewItem(plane);
                    //Console.WriteLine("ass " + plane.MaxPassengers+"ass");

                    break;
            }
            f.UpdateTable();
            this.Close();
        }
        private bool checkTextBoxes()
        {
            if(manufacturerTextBox.Text==string.Empty)
            {
                MessageBox.Show("Производитель не введён", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (modelTextBox.Text == string.Empty)
            {
                MessageBox.Show("Модель не введена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (priceTextBox.Text == string.Empty)
            {
                MessageBox.Show("Цена не введена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            int price;
            
            try
            {
                price = Convert.ToInt32(priceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Цена введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (price <= 0)
            {
                MessageBox.Show("Цена введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (massTextBox.Text == string.Empty)
            {
                MessageBox.Show("Масса не введена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int mass;
            try
            {
                mass = Convert.ToInt32(massTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Масса введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mass <= 0)
            {
                MessageBox.Show("Масса введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (horsePowerTextBox.Enabled)
            {
                int horse;

                if (horsePowerTextBox.Text == string.Empty)
                {
                    MessageBox.Show("ЛС не введены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                try
                {
                    horse = Convert.ToInt32(horsePowerTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("ЛС введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (horse <= 0)
                {
                    MessageBox.Show("ЛС введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (doorAmountTextBox.Enabled)
            {
                int doors;
                if (doorAmountTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Количество дверей не введено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                try
                {
                    doors = Convert.ToInt32(doorAmountTextBox.Text);
                    
                }
                catch
                {
                    MessageBox.Show("Количество дверей введено неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (doors <= 0)
                {
                    MessageBox.Show("Количество дверей введено неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            if (maxPassengersTextBox.Enabled)
            {
                int maxPassengers;
                if (maxPassengersTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Максимум пассажиров не введён", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                try
                {
                    maxPassengers = Convert.ToInt32(maxPassengersTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Количество пассажиров введено неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (maxPassengers <= 0)
                {
                    MessageBox.Show("Количество пассажиров введено неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            if (cruiserSpeedTextBox.Enabled)
            {
            int cruiserSpeed;
                if (cruiserSpeedTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Крейсерская скорость не введена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                try
                {
                    cruiserSpeed = Convert.ToInt32(cruiserSpeedTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Крейсерская скорость введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (cruiserSpeed <= 0)
                {
                    MessageBox.Show("Крейсерская скорость введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if(frameTextBox.Enabled)
                if (frameTextBox.Text==string.Empty)
                {
                        MessageBox.Show("Рама не введена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                }
            return true;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //manufacturerTextBox.Text = ass[0].Info.manufacturer;
            //modelTextBox.Text = ass.ToString();
            //priceTextBox.Text = ass.Count.ToString();
            //System.Collections.Generic.List`1[OOP3.Transport]
            //System.Collections.Generic.List`1[OOP3.Transport]
            //System.Collections.Generic.List`1[OOP3.Transport]
            manufacturerTextBox.Enabled = false;
            modelTextBox.Enabled = false;
            massTextBox.Enabled = false;
            priceTextBox.Enabled = false;
            horsePowerTextBox.Enabled = false;
            doorAmountTextBox.Enabled = false;
            frameTextBox.Enabled = false;
            typeCheckBox.Enabled = false;
            cruiserSpeedTextBox.Enabled = false;
            maxPassengersTextBox.Enabled = false;
            OKbutton.Enabled = false;
            ChooseComboBox.Items.Add("Машина");
            ChooseComboBox.Items.Add("Мотоцикл");
            ChooseComboBox.Items.Add("Велосипед");
            ChooseComboBox.Items.Add("Лодка");
            ChooseComboBox.Items.Add("Самолёт");
        }

        private void ChooseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKbutton.Enabled = true;
            manufacturerTextBox.Enabled = true;
            modelTextBox.Enabled = true;
            massTextBox.Enabled = true;
            priceTextBox.Enabled = true;
            horsePowerTextBox.Enabled = true;
            doorAmountTextBox.Enabled = false;
            frameTextBox.Enabled = false;
            typeCheckBox.Enabled = false;
            cruiserSpeedTextBox.Enabled = false;
            maxPassengersTextBox.Enabled = false;
            switch (ChooseComboBox.SelectedIndex)
            {
                case 0:
                    doorAmountTextBox.Enabled = true;
                    frameTextBox.Text = maxPassengersTextBox.Text = cruiserSpeedTextBox.Text = "";
                    typeCheckBox.Checked = false;
                    break;
                case 1:
                    frameTextBox.Enabled = true;
                    doorAmountTextBox.Text = maxPassengersTextBox.Text = cruiserSpeedTextBox.Text = "";
                    typeCheckBox.Checked = false;
                    break;
                case 2:
                    frameTextBox.Enabled = true;
                    typeCheckBox.Enabled = true;
                    doorAmountTextBox.Text = maxPassengersTextBox.Text = cruiserSpeedTextBox.Text = "";
                    break;
                case 3:
                    cruiserSpeedTextBox.Enabled = true;

                    doorAmountTextBox.Text = maxPassengersTextBox.Text = frameTextBox.Text = "";
                    typeCheckBox.Checked = false;
                    break;
                case 4:
                    maxPassengersTextBox.Enabled = true;

                    doorAmountTextBox.Text = frameTextBox.Text = cruiserSpeedTextBox.Text = "";
                    typeCheckBox.Checked = false;
                    break;




            }
        }
    }
}
