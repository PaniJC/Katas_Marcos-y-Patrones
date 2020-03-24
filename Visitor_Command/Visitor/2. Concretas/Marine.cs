using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;
using Visitor.Concretas;

namespace Visitor.Concretas
{
    public class Marine : ILightUnit
    {
        public int Health { get; set; } = variables.Health__marine_initial;
       

        public void Accept(Ivisitor visitor)
        {
            visitor.VisitLight(this);
        }
    }
}
