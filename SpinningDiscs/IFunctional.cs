using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IFunctional
    {
        string Spin();
        string Stop();
        string Eject();
        string Read();

    }
}
