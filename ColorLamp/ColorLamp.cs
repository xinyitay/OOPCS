﻿using System;
namespace ColorLamp
{
    public class ColorLamp
    {
        private LED red, green, blue;
        private LED current;

        public ColorLamp(LED red, LED green, LED blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;

            // try not to instantiate null object!
            current = null;
        }

        public void turnOn()
        {
            // can't put here cos current is null object, cannot call the isLEDOn method!!
            //if (current.isLEDOn())
            //{
            //    return;
            //}

            if (current == red)
            {
                current = green;
            }
            else if (current == green)
            {
                current = blue;
            }
            else
            {
                current = red;
            }
        }

        public void turnOff()
        {
            if (!current.isLEDOn())
            {
                return;
            }
            current.turnOff();
        }

        public string getCurrColor()
        {
            // refer to LED object!
            return current.getColor();
        }
    }
}
