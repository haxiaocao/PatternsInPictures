﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    public class Lamp : ILamp
    {
        bool _isSwitchOn = false;
        public bool IsSwitchOn
        {
            get => _isSwitchOn;
            set
            {
                if (_isSwitchOn == value)
                    return;

                _isSwitchOn = value;

                IsOn = IsSwitchOn && IsPlugged;
            }
        }

        bool _isOn = false;
        public bool IsOn
        {
            get => _isOn;

            set
            {
                if (_isOn == value)
                    return;

                _isOn = value;

                Console.WriteLine($"The lamp is {(_isOn ? "On": "Off")}");
            }
        }

        bool _isPlugged = false;
        public bool IsPlugged
        {
            get => _isPlugged;

            set
            {
                if (_isPlugged == value)
                    return;

                _isPlugged = value;

                IsOn = IsSwitchOn && IsPlugged;
            }
        }
    }
}
