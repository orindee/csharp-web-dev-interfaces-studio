using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD dvd = new DVD(500.00, "Cool Movie", "DVD-R");
            CD cd = new CD(400.00, "Cool CD", "CD-R", 425);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            Console.WriteLine(
            dvd.Spin()+ 
            dvd.Stop()+ 
            dvd.Eject()+ 
            dvd.Read());

            Console.WriteLine(
            cd.Spin()+ 
            cd.Stop()+ 
            cd.Eject()+ 
            cd.Read());

        }
    }
}
