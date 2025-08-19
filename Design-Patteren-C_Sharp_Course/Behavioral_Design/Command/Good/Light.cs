namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Command.Good
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light is Off");
        }
        public void Dim()
        {
            Console.WriteLine("Light is dim");
        }
    }
}
