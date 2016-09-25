using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4.Core.Logic
{
    public interface IVehicle
    {
        void DecreaseSpeed(int amount);
        int GetSpeed();
        void IncreaseSpeed(int amount);
    }
}
