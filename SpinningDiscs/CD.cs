using System;
namespace SpinningDiscs
{
    public class CD : Disc, IFunctional
    {
        public CD(double storageCapacity, string name, string discType, int rPM) : base(storageCapacity, name, discType, 400) { }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public string Eject()
        {
            return "CD ejected!";
        }

        public string Read()
        {
            return "CD has been read!";
        }

        public string Spin()
        {
            return $"CD is spinning at {RPM}";
        }

        public string Stop()
        {
            return "CD stopped.";
        }
    }
}
