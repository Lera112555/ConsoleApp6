using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class cat
    {
        public int HungryStatus { get; private set; }

        public class Cat
        {


            byte _hungryStatus;
            public event EventHandler HungryStatusChanged;
            public Cat(string name, DateTime birthday)

            {
                Name = name;
                BirthDay = birthday;
                public static Cat (string name, DateTime birthday)

               public string Name
            {
                get; set;

            }
            public void MakeNoise()
            {
                Console.WriteLine($"{Name } мяукает");
            }

            public DateTime BirthDay
            {
                get; set;
            }

            public void MakeNoise()
            {
                Console.WriteLine(Name + " мяукает");
            }

            public int GetAge()
            {
               return (DateTime.Today - BirthDay).Days / 365;
            }

            public event EventHandler HungryStatusChanged;
            public void Feed() => HungryStatus = 100;
            public byte HungryStatus
            {
                get { return _hungryStatus; }
                set
                {
                    if (value < 0)
                        _hungryStatus = 0;
                    else if (value > 100)
                        _hungryStatus = 100;
                    byte status = value;
                    if (status < 0)
                    {
                        status = 0;
                    }
                    else if (status > 100)
                    {
                        status = 100;
                    }
                    else
                        _hungryStatus = value;

                    if (_hungryStatus != value)
                        HungryStatusChanged?.Invoke(this, null);
                    {
                        HungryStatusChanged?.Invoke(this, null);
                    }
                }
            }
            public void Feed(byte needFood)
            {
                HungryStatus += needFood;
            }

            public void GetStatus()
            {
                public void GetStatus();
             }
            Console.ResetColor();
        }


        async Task LifeCircle()
        {
            await Task.Delay(1000);
            await Task.Delay(100);
            HungryStatus -= 10;
            await LifeCircle();
        }


    } 
}