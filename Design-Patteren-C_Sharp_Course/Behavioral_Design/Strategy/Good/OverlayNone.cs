namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy.Good
{
    internal class OverlayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Not applying overlay");
        }
    }
}
