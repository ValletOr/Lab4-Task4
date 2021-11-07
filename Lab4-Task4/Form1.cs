using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Task4
{
    public partial class Form1 : Form
    {
        List<Vehicle> vList = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void listReCreateBtn_Click(object sender, EventArgs e)
        {
            vList.Clear();
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        vList.Add(new Bicycle());
                        break;
                    case 1:
                        vList.Add(new Car());
                        break;
                    case 2:
                        vList.Add(new Plane());
                        break;
                }
            }
            ShowInfo();
        }
        public void ShowInfo()
        {
            int bCounter = 0, cCounter = 0, pCounter = 0;
            if (vList.Count == 0)
            {
                queueBox.Text = "Очередь пуста.";
            }
            else
            {
                queueBox.Text = "Очередь талонов:";
            }
            for(int i = 0; i < vList.Count; i++)
            {
                Vehicle vehicle = vList[i];
                if (vehicle is Bicycle)
                {
                    bCounter++;
                    queueBox.Text += string.Format($"\n{i+1}) Велосипед");
                }
                else if (vehicle is Car)
                {
                    cCounter++;
                    queueBox.Text += string.Format($"\n{i+1}) Автомобиль");
                }
                else
                {
                    pCounter++;
                    queueBox.Text += string.Format($"\n{i+1}) Самолёт");
                }
            }
            cInfBox.Text = String.Format($"Количество талонов на транспорт в аппарате:\nВелосипед:\tАвтомобиль:\tСамолёт:\n{bCounter, 10}{cCounter, 30}{pCounter, 25}");

        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            if(vList.Count == 0)
            {
                outBox.Text = "Автомат пуст!!!";
                pictureBox1.Image = default;
            }
            else
            {
                Vehicle vehicle = vList[0];
                vList.RemoveAt(0);
                outBox.Text = "Ваш талон:\n" + vehicle.GetInfo();
                pictureBox1.Image = vehicle.img;
                ShowInfo();
            }
        }

        private void infBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автомат выдающий талоны на транспорт в виде:\n" +
                "Для раздачи транспортных средств (количество колес)\n" +
                "Велосипеды(тип(горный, городской, детский), радиус колес)\n" +
                "Автомобили(тип(автобус, грузовик, внедорожник, легковая), объем двигателя, количество дверей),\n" +
                "Самолеты(тип двигателя, максимальная высота полета)"
                ,"Описание автомата");
        }
    }
}
