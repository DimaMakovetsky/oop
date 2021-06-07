using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using library;

namespace OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Transport transport
        }

        public List<Transport> list = new List<Transport>();
        string format;
        /**/


        private void addButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show()

            Form2 f = new Form2();
            f.Owner = this;
            // f.takeList(list);
            f.ShowDialog();
        }
        public void takeNewItem(Transport sas)
        {
            //Console.WriteLine(list.Count);
            list.Add(sas);
            dataGridView1.Rows.Add();
            //Console.WriteLine(sas.Type+"ass");

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list[0].Info.manufacturer + "   " + list[0].Info.model+"  " +list[0].MaxPassengers+"  "+sas.MaxPassengers);
            //Console.WriteLine(list[list.Count-1]);
        }
        public void UpdateTable()
        {
            /*
            Console.WriteLine(list.Count);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            
            
             */
            //Console.WriteLine(dataGridView1.Rows.Count);
            //Console.WriteLine(list.Count+"  ass");
            for (int i = 0; i < list.Count; i++)
            {
                //Console.WriteLine(list.Count);
                //Console.WriteLine(list[0].Info.manufacturer + "     |");
                
                dataGridView1.Rows[i].Cells[0].Value = list[i].Info.manufacturer;
                dataGridView1.Rows[i].Cells[1].Value = list[i].Info.model;
                dataGridView1.Rows[i].Cells[2].Value = list[i].Weight;
                dataGridView1.Rows[i].Cells[3].Value = list[i].HorsePower;
                dataGridView1.Rows[i].Cells[4].Value = list[i].StockPrice;/**/
                //Console.WriteLine(list[i]);
                if (list[i] is Car)
                {
                    dataGridView1.Rows[i].Cells[5].Value = list[i].DoorAmount;
                    for (int j = 6; j < 10; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                    }
                }
                else
                {
                    if (list[i] is Boat)
                    {
                        dataGridView1.Rows[i].Cells[7].Value = list[i].CruiseSpeed;
                        for (int j = 5; j < 10; j++)
                        {
                            if (j != 7)
                                dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                        }
                    }
                    else
                    {
                        if (list[i] is Bicycle)
                        {

                            //dataGridView1.Rows[i].Cells[9].Value = list[i].Type;
                            //Console.WriteLine(list[i]);
                            //Console.WriteLine(list[i].Type);
                            //Console.WriteLine(dataGridView1.Rows[i].Cells[9].Value);
                            dataGridView1.Rows[i].Cells[9].Value = list[i].Type;
                            dataGridView1.Rows[i].Cells[8].Value = list[i].Frame;

                            //Console.WriteLine(dataGridView1.Rows[i].Cells[9].Value);
                            for (int j = 5; j < 8; j++)
                            {
                                dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                            }

                        }

                        else
                        {
                            if (list[i] is Motorcycle)
                            {
                                dataGridView1.Rows[i].Cells[8].Value = list[i].Frame;
                                for (int j = 5; j < 10; j++)
                                {
                                    if (j != 8)
                                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                                }
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells[6].Value = list[i].MaxPassengers;
                                for (int j = 5; j < 10; j++)
                                {
                                    if (j != 6)
                                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                                }
                            }
                        }
                    }
                }
            }

            //Console.WriteLine(list[0].Info.manufacturer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*FactoryInfo info = new FactoryInfo("ass", "sas");
            Car car = new Car(info, 15.25, 1000, 400, 4);
            string ass = car.Info.manufacturer + "  " + car.Info.model;
            
            list.Add(car);
            List<Transport> assList = GetList;
            textBox1.Text = GetList.ToString();
            FactoryInfo info = new FactoryInfo("ass", "sas");
            Car car = new Car(info, 15.25, 1000, 400, 4);
            list.Add(car);
            Console.WriteLine(list[0].Info.manufacturer+"   "+list[0].Info.model);
            */
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            //UpdateTable();
            int toDeleteRow = dataGridView1.CurrentCell.RowIndex, toDeleteColumn = dataGridView1.CurrentCell.ColumnIndex;
            list.RemoveAt(toDeleteRow);
            dataGridView1.Rows.RemoveAt(toDeleteRow);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(dataGridView1.Rows.Count);
            //UpdateTable();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridView1.CurrentCell.ReadOnly&&dataGridView1.CurrentCell.Value!=null&&dataGridView1.Rows.Count!=0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex, columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                switch (columnIndex)
                {
                    case 0:
                        if (checkString(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].Info.manufacturer = dataGridView1.CurrentCell.Value.ToString();
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].Info.manufacturer;
                            return;
                        }
                        break;
                    case 1:
                        if (checkString(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].Info.model = dataGridView1.CurrentCell.Value.ToString();
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].Info.model;
                            return;
                        }
                        break;
                    case 2:
                        if (checkInt(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].Weight = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].Weight;
                            return;
                        }
                        break;
                    case 3:
                        if (checkInt(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].HorsePower = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].HorsePower;
                            return;
                        }
                        break;
                    case 4:
                        if (checkInt(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].StockPrice = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].StockPrice;
                            return;
                        }
                        break;
                    case 5:
                        if (checkInt(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].DoorAmount = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].DoorAmount;
                            return;
                        }
                        break;
                    case 6:
                        if (checkInt(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].MaxPassengers = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].MaxPassengers;
                            return;
                        }
                        break;
                    case 7:
                        if (checkInt(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].CruiseSpeed = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].CruiseSpeed;
                            return;
                        }
                        break;
                    case 8:
                        if (checkInt(dataGridView1.CurrentCell.Value.ToString()))
                            list[rowIndex].Frame = dataGridView1.CurrentCell.Value.ToString();
                        else
                        {
                            dataGridView1.CurrentCell.Value = list[rowIndex].Frame;
                            return;
                        }
                        break;
                    case 9:


                        //    Console.WriteLine(list[rowIndex].Type+"   "+ dataGridView1.CurrentCell.Value);
                        list[rowIndex].Type = Convert.ToBoolean(dataGridView1.CurrentCell.Value);
                        //  Console.WriteLine(list[rowIndex].Type + "   ASS   "+ dataGridView1.CurrentCell.Value);

                        break;
                }
            }

        }
        private bool checkString(string text)
        {
            if (text == string.Empty)
            {
                MessageBox.Show("Производитель не введён", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool checkInt(string number)
        {
            int check;

            try
            {
                check = Convert.ToInt32(number);
            }
            catch
            {
                MessageBox.Show("Цена введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (check <= 0)
            {
                MessageBox.Show("Цена введена неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Owner = this;
            f.ShowDialog();
            //Console.WriteLine(format);
            if (format.Equals("1"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream file = new FileStream("data.dat", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(file, list);
                }
            }
            else
            {
                if(format.Equals("2"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Transport>));
                    using (FileStream file = new FileStream("data.xml", FileMode.OpenOrCreate))
                    {
                        xml.Serialize(file, list);
                    }

                }
                else
                {

                }
            }
        
            
        }
        public void takeFormat(string formatSmol)
        {
            //Console.WriteLine(format + "sssss");
            format=formatSmol;
        }

        private void readFileButton4_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            //DialogResult result = openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string ext=Path.GetExtension(openFileDialog.FileName);
            if (ext.Equals(".dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    list = (List<Transport>)formatter.Deserialize(file);
                }
            }
            else
            {
                if (ext.Equals(".xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Transport>));
                    using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        list = (List<Transport>)xml.Deserialize(file);
                    }
                }
                else
                    return;
            }
            //Console.WriteLine(list.Count);
            dataGridView1.Rows.Clear();
            while(dataGridView1.Rows.Count < list.Count)
            {
                dataGridView1.Rows.Add();
            }
            //if(dataGridView1.Rows.Count!=list.Count)
            
            UpdateTable();
        }

        private void plugButton_Click(object sender, EventArgs e)
        {
            PluginLoader plugin = new PluginLoader();
            plugin.LoadPlugins();

        }
    }
}