namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy.Good
{
    internal class OverLayBlackWhite : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying Black and white overlays");
        }
    }
}
