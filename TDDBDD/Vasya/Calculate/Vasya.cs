using System;

namespace Calculate
{
    internal class Vasya : Human
    {
        public double apples;
        public double water;
        public void VasyaEat(double eaten)
        {
            this.Eat(eaten);
            apples = this.apples - eaten;
        }

        public void VasyaDrink(double liters)
        {
            this.Drink(liters);
            water = this.water - liters;
        }

        public bool IsWaterFinished()
        {
            bool _whaterIsFinised = false;
            if (this.water == 0)
            {
                _whaterIsFinised = true;
            }
            if (this.water < 0)
            {
                throw new Exception("Friends drink too much!");
            }
            return _whaterIsFinised;
        }
    }
}