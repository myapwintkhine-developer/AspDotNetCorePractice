using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public class TruckCar:Car
    {
        public int MaximumLoadInTon { get; set; }
        public int NumberOfWheel { get; set; }
        public void LoadMaterial(int ton)
        {
            if(ton < MaximumLoadInTon)
            {
                Console.WriteLine("Load material " + ton);
            }
            else
            {
                Console.WriteLine("Overload is " + MaximumLoadInTon);
            }
        }

        /// <summary>
        /// load material with ton and item
        /// </summary>
        /// <param name="ton"></param>
        /// <param name="itemType"></param>
        public void LoadMaterial(int ton,string itemType)   //compile time polymorphism =>Method Overload
        {
            if (ton < MaximumLoadInTon)
            {
                Console.WriteLine($"Load {itemType} with {ton} ton");
            }
            else
            {
                Console.WriteLine("Overload is " + MaximumLoadInTon);
            }
        }

        public override void ShowInfo()   //runtime polymorphism => Method Override
        {
            base.ShowInfo();
            Console.WriteLine("Max load is " + MaximumLoadInTon); 
            Console.WriteLine("Wheels " + NumberOfWheel);
        }


    }
}
