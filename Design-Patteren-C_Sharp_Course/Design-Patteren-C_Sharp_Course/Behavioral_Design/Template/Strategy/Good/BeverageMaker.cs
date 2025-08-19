namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod.Strategy.Good
{
    /// <summary>
    /// Polymorphism Solution
    /// </summary>
    public class BeverageMaker
    {
        private IBeverage _beverage;
        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public void SetBeverage(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            _beverage.Prepare();

        }
        private void BoilWater()
        {
            Console.WriteLine("BoilWater");
        }
        private void PourWaterIntoCup()
        {
            Console.WriteLine("Puoring water into cup");
        }
    }
}
