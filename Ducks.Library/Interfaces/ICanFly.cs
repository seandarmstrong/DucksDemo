namespace Ducks.Library.Interfaces
{
    public interface ICanFly
    {
        void PerformFly();
        void SetFlyBehavior(IFlyBehavior flyBehavior);
    }
}