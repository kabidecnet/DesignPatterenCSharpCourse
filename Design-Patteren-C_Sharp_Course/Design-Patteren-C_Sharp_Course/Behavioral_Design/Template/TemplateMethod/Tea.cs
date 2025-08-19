using Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod;

namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Template.TemplateMethod
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing for 3 min");
        }
        protected override void AddCondiments()
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
