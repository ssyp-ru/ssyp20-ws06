﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    class Simulator
    {
        private double Step;

        public Simulator(double step)
        {
            Step = step;
        }

        public void SimulateOneTimeSlot(IFeigned feigned)
        {
            feigned.Simulate(Step);
        }
    }
}
