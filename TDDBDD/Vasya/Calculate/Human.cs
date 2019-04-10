namespace Calculate
{
    internal class Human : Person
    {
        double _hungry = 8;
        public double hasEat = 0;
        public double hasLiters = 0;

        public double WhatHungryIs()
        {
            return this._hungry;
        }

        public void Eat(double eatenApples)
        {
            //this._hungry = this._hungry - eatenApples;
            this._hungry = new CalcCore().MinusMethod(this._hungry, eatenApples);
            this.hasEat = this.hasEat + eatenApples;
        }

        public void Drink(double liters)
        {
            //this._hungry = this._hungry - eatenApples;
          
            this.hasLiters = this.hasLiters + liters;
        }
    }
}