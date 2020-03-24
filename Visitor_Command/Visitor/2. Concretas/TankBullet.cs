using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;
using Visitor.Concretas;




namespace Visitor.Concretas
{
   public class TankBullet : Ivisitor
    {
       
       
        public void VisitLight(ILightUnit unit)
        {
            unit.Health -= variables.Ataque_Marine;
             
        }

        public void VisitArmored(IArmoredUnit unit)
        {
            unit.Health -= variables.Ataque_Marauder;
        }
    }
}
