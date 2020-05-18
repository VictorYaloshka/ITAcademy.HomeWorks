using HW12.RP_Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.RP_DAL
{
    public interface IMotoRepository
    {
        public void CreateMotorcycle(Motorcycle motorcycle);
        public Motorcycle GetMotorcycleByID(int id);
        public void GetMotorcycles();
        public void UpdateMotorcycle(Motorcycle motorcycle);
        public void DeleteMotorcycle(int id);
    }
}
