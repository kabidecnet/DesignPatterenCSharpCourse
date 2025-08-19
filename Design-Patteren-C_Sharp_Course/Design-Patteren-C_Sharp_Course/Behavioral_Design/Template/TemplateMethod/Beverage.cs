namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod
{
    /// <summary>
    /// Polymorphism Solution
    /// </summary>
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiments();
        }
        private void BoilWater()
        {
            Console.WriteLine("BoilWater");
        }
        private void PourWaterIntoCup()
        {
            Console.WriteLine("Puoring water into cup");
        }

        protected abstract void Brew();
        protected virtual void AddCondiments()
        {

        }
    }
}
