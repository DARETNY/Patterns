using Patterns.Mediator_Pattern.Script.Interface;
using Patterns.Mediator_Pattern.Script.MoveSystem;

namespace Patterns.Mediator_Pattern.Script.MadiatorManager
{
    public class MedManager : IMediator
    {
        public Jumper Jumper1 { get; set; }

        public Rotater Slider1 { get; set; }

        public void SetterMed(Colleague colleague)
        {
            switch (colleague)
            {
                case Jumper jumper:
                    Jumper1 = jumper;
                    break;
                case Rotater slider:
                    Slider1 = slider;
                    break;
            }
        }
    }
}