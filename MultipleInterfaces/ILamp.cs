﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    public interface ILamp : IPowerPlug
    {
        bool IsOn { get; }

        bool IsSwitchOn { get; set; }
    }
}
