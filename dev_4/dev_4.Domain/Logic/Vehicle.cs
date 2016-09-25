using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dev_4.Core.Logic;

namespace dev_4.Domain.Logic
{
    public class Vehicle : IVehicle
    {
        protected int Speed = 0;

        public void DecreaseSpeed(int amount)
        {
            Speed = Speed - amount;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public void IncreaseSpeed(int amount)
        {
            Speed = Speed + amount;
        }
    }
}
