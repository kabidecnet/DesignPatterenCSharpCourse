namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod.Strategy.Bad
{
    public class BadTea
    {
        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
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
            Console.WriteLine("Brewing tea for 3 mint");
        }
        private void Condiments()
        {
            if (IsCondiments())
            {
                Console.WriteLine("Added lemon to Tea");
            }
        }
        private bool IsCondiments()
        {
            Console.WriteLine("Is customer want lemon press y/n \n");
            var input = Console.ReadLine();
            return input == "y";
        }
    }
}
