using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }
        private string licenseNo;
        public string LicenseNo
        {
            get { return licenseNo; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid License No"); 
                }
                licenseNo = value;
            }
        }

        public string Type { get; set; }
        private string gearNo;

        public string GearNo
        {
            get { return gearNo; }
            set { gearNo = value; }
        }

        public void Drive()
        {
            Console.WriteLine("Car is driving with gear no " + gearNo);
            if (gearNo.Equals("p",StringComparison.OrdinalIgnoreCase))
            {
                this.ChangePinion(0);
            }
            else if (gearNo.Equals("d", StringComparison.OrdinalIgnoreCase))
            {
                this.ChangePinion(3);
            }
            if (gearNo.Equals("r", StringComparison.OrdinalIgnoreCase))
            {
                this.ChangePinion(5);
            }
        }
        public void StartEngine() => Console.WriteLine("Start the engine");
        public void StopEngine() => Console.WriteLine("Stop the engine");
        public void PlayHorn(int count) 
        {
            for (int i = 1; i <= count; i++) { 
            Console.WriteLine("T");
        }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Color " + Color);
            Console.WriteLine("Model " + Model);
            Console.WriteLine("LicenseNo " + LicenseNo);
            Console.WriteLine("GearNo " + GearNo);
            Console.WriteLine("Type " + Type);

        }

        private void ChangePinion(int pinion)
        {
            Console.WriteLine("Change Pinion " + pinion);
        }
    }
}
