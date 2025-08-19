using Design_Patteren_C_Sharp_Course.Behavioral_Design.TemplateMethod;

namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Template.TemplateMethod
{
    public class Camanile : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brew comamile for 3 min");
        }
    }
}
