﻿namespace ConvertEverything.Units
{
    internal class Mole : IUnit
    {
        public string Symbol => "mol";

        public IUnit DeepClone()
        {
            return new Mole();
        }
    }
}