﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Beatle : Participant
    {
        public Beatle(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Debug.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
