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
        public BicycleType type;
        public int wRad;
        public System.Drawing.Bitmap img = Properties.Resources.bicycle;
        public Bicycle()
        {
            this.type = (BicycleType)rnd.Next(3);
            this.wRad = rnd.Next(20, 31);
            this.nOfWheels = rnd.Next(1, 4);
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
        public System.Drawing.Bitmap img = Properties.Resources.car;
        public Car()
        {
            this.type = (CarType)rnd.Next(4);
            this.engVol = rnd.Next(1, 30);
            this.nOfWheels = rnd.Next(1, 7);
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
        public System.Drawing.Bitmap img = Properties.Resources.plane;
        public Plane()
        {
            this.type = (EngineType)rnd.Next(3);
            this.maxHeight = rnd.Next(1, 118000);
            this.nOfWheels = rnd.Next(1, 4);
        }
    }
}
