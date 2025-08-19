namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod.Strategy.Good
{
    public class Coffee : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 5 mint");
        }
        private void AddCondiments()
        {
            if (IsCondiments())
            {
                Console.WriteLine("Added cream to Tea");
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
