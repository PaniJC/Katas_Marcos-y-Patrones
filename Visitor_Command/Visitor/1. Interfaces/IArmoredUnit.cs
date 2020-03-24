using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Interfaces
{
   public interface IArmoredUnit
    {
        int Health { get; set; }
        void Accept(Ivisitor visitor);
    }
}
