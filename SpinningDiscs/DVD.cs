using System;
namespace SpinningDiscs
{
    public class DVD : Disc, IFunctional
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(double storageCapacity, string name, string discType) : base(storageCapacity, name, discType, 500)  { }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public string Eject()
        {
            return "DVD ejected!";
        }

        public string Read()
        {
            return "DVD has been read!";
        }

        public string Spin()
        {
            return $"DVD is spinning at {RPM}";
        }

        public string Stop()
        {
            return "DVD stopped.";
        }
    }
}
