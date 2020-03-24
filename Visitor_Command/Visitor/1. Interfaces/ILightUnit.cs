using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Interfaces
{
  public  interface ILightUnit
    {
        int Health { get; set; }
        void Accept(Ivisitor visitor);
    }
}
