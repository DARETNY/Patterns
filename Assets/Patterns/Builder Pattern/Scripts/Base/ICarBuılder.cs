using Patterns.Builder_Pattern.Scripts.Command;

namespace Patterns.Builder_Pattern.Scripts.Base
{
    public interface ICarBuılder
    {
        Car GetCar();
        ICarBuılder SetModel();
        
        ICarBuılder Construct();
        ICarBuılder SetColor();
        ICarBuılder SetSpeed();
        ICarBuılder SetAcceleration();
    }
}