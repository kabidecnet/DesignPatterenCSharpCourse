namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod.Strategy.Good
{
    internal class Camomile : IBeverage
    {
        public void Prepare()
        {
            Brew();
        }
        public void Brew()
        {
            Console.WriteLine("Brewing for 3 min");
        }
    }
}
