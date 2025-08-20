namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod.Strategy.Bad
{
    public class BadCoffee
    {
        public void MakeBeverage()
        {
            // Identical setps - Should go to common base class
            BoilWater();
            PourWaterIntoCup();

            // Different steps
            Brew();
            Condiments();
        }
        private void BoilWater()
        {
            Console.WriteLine("BoilWater");
        }
        private void PourWaterIntoCup()
        {
            Console.WriteLine("Puoring water into cup");
        }
        private void Brew()
        {
            Console.WriteLine("Brewing tea for 5 mint");
        }
        private void Condiments()
        {
            if (IsCondiments())
            {
                Console.WriteLine("Added Cream to Tea");
            }
        }
        private bool IsCondiments()
        {
            Console.WriteLine("Is customer want cream press y/n \n");
            var input = Console.ReadLine();
            return input == "y";
        }
    }
}
