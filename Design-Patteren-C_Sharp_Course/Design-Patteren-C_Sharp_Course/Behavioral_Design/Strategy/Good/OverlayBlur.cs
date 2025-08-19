namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy.Good
{
    internal class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying overlays using Blur");
        }
    }
}
