namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod.Strategy.Good
{
    public class Tea : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 3 mint");
        }
        private void AddCondiments()
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
