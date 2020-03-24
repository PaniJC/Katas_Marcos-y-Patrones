using System;
using System.Collections.Generic;
using System.Text;
using Commad.Interfaces;

namespace Commad.Concretas
{
   public class Probe : IUnit
    {
        public Probe()
        {
            Commands = new Queue<ICommad>();
            Minerals = 0;
            Position = new Point { X = 0, Y = 0 };
        }

        public Queue<ICommad> Commands { get; set; }
        public int Minerals { get; set; }
        public Point Position { get; set; }

        public void Move(int x, int y)
        {
            ICommad moveCmd = new MoveCommand(this, x, y);
            Commands.Enqueue(moveCmd);
        }
        public void Gather()
        {
            ICommad gatherCmd = new GatherCommand(this);
            Commands.Enqueue(gatherCmd);
        }
    }
}
