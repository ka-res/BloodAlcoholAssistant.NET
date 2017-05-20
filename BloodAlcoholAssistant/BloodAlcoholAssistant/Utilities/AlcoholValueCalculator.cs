﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using BloodAlcoholAssistant.Models;

namespace BloodAlcoholAssistant.Utilities
{
    /*zgodnie z: http://www.wikihow.com/Calculate-Blood-Alcohol-Content-(Widmark-Formula)
     * i z pominieciem czasu tak, jak przy omawianiu */

    public class AlcoholValueCalculator
    {
        private const double FemaleConstat = 0.55;
        private const double MaleConstant = 0.68;

        public static double ReturnValue(Person person, double alcoholValue)
        {
            var factor = person.Sex == Gender.Female
                ? FemaleConstat
                : MaleConstant;

            return alcoholValue / (person.WeightAsKilo * factor);
        }
    }
}