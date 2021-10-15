using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class Disc
    {

        public double StorageCapacity;
        public int RPM;
        public string Name;
        public string DiscType;
        public Disc(double storageCapacity, string name, string discType, int rPM) 
        {
            StorageCapacity = storageCapacity;
            RPM = rPM;
            Name = name;
            DiscType = discType;
        } 
        string WriteData()
        {
            return "It worked!";
        }
        string ReportInfo()
        {
            return $"Name: {Name} Storage Capacity: {StorageCapacity} Disc Type : {DiscType}"; 
        }
    }
}
