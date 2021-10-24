using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task4
{
    public class Vehicle
    {
        protected int nOfWheels = 0;
        protected Random rnd = new Random();
        public System.Drawing.Bitmap img;
        public virtual string GetInfo()
        {
            return "Транспорт";
        }
    }
    //========================================================
    public enum BicycleType
    {
        Горный,
        Городской,
        Детский,
    }
    public class Bicycle : Vehicle
    {
        private BicycleType type;
        public int wRad;
        public Bicycle()
        {
            this.type = (BicycleType)rnd.Next(3);
            this.wRad = rnd.Next(20, 31);
            this.nOfWheels = rnd.Next(1, 4);
            img = Properties.Resources.bicycle;
        }
        public override string GetInfo()
        {
            string outMessage = "";
            outMessage += string.Format("Велосипед\nТип: {0}\nКол-во колёс: {1}\nРадиус колёс: {2}", this.type, this.nOfWheels, this.wRad);
            return outMessage;
        }
    }
    //========================================================
    public enum CarType
    {
        Автобус,
        Грузовик,
        Внедорожник,
        Легковая,
    }
    public class Car : Vehicle
    {
        public CarType type;
        public int engVol;
        public int dAmount;
        public Car()
        {
            this.type = (CarType)rnd.Next(4);
            this.engVol = rnd.Next(1, 30);
            this.dAmount = rnd.Next(2, 5);
            this.nOfWheels = rnd.Next(3, 9);
            img = Properties.Resources.car;
        }
        public override string GetInfo()
        {
            string outMessage = "";
            outMessage += string.Format("Автомобиль\nТип: {0}\nКол-во колёс: {1}\nОбъём двигателя: {2}\nКол-во дверей: {3}", this.type, this.nOfWheels, this.engVol, this.dAmount);
            return outMessage;
        }
    }
    //=========================================================
    public enum EngineType
    {
        Винтовой,
        Реактивный,
        Турбовентиляторный,
    }
    public class Plane : Vehicle
    {
        public EngineType type;
        public int maxHeight;
        public Plane()
        {
            this.type = (EngineType)rnd.Next(3);
            this.maxHeight = rnd.Next(1, 118000);
            this.nOfWheels = rnd.Next(3, 33);
            img = Properties.Resources.plane;
        }
        public override string GetInfo()
        {
            string outMessage = "";
            outMessage += string.Format("Самолёт\nТип двигателя: {0}\nКол-во колёс: {1}\nМакс. высота полёта: {2}", this.type, this.nOfWheels, this.maxHeight);
            return outMessage;
        }
    }
}
