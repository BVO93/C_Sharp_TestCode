using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingInterfaces
{
    interface IDestroyable
    {
 
        string DestructionSound { get; set; }

        void Destroy();
    }
}
