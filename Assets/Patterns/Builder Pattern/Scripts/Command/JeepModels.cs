using Patterns.Builder_Pattern.Scripts.Base;

namespace Patterns.Builder_Pattern.Scripts.Command
{
    public class JeepModels : ICarBuılder
    {
        private Car _car;

        public Car GetCar()
        {
            return _car;
        }

        public ICarBuılder SetModel()
        {
            _car.Model = "Jeep";
            return this;
        }

        public ICarBuılder Construct()
        {
            _car = new Car();
            return this;
        }

        public ICarBuılder SetColor()
        {
            _car.Color = "White";
            return this;
        }

        public ICarBuılder SetSpeed()
        {
            _car.Speed = 100;
            return this;
        }

        public ICarBuılder SetAcceleration()
        {
            _car.Acceleration = 10;
            return this;
        }
        public ICarBuılder Setall()
        {
            SetAcceleration();
            SetColor();
            SetModel();
            SetSpeed();
            return this;
        }
    }
}