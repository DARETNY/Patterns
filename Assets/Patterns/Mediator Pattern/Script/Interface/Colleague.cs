namespace Patterns.Mediator_Pattern.Script.Interface
{
    public abstract class Colleague
    {
        protected readonly IMediator Mediator;

        protected Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Dosomething();
    }
}