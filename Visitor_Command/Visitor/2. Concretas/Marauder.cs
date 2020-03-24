using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;
using Visitor.Concretas;

namespace Visitor.Concretas
{
   public class Marauder :IArmoredUnit
    {
        public int Health { get; set; } = variables.Health_marauder_initial;

        public void Accept(Ivisitor visitor)
        {
            visitor.VisitArmored(this);
        }
    }
}
