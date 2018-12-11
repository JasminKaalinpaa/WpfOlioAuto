using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOlioAuto
{
    public class Car
    {
        private int maxSpeed;

        public int MaxSpeed {
            get
            {
                return maxSpeed;
            }

            set
            {
                if (value > 0 && value < 400)
                {
                    maxSpeed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }                                        // kirjoita prop ja sitten paina kaksi kertaa tabulaattoria

        public string Color { get; set; }

        public void SetMaxSpeed(int max)
        {
            if (max > 0 && max < 400)
            {
                maxSpeed = max;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public int GetMaxSpeed()
        {
            return maxSpeed;
        }

        public void StartEngine()
        {

        }

        public void StopEngine()
        {

        }
    }
}
