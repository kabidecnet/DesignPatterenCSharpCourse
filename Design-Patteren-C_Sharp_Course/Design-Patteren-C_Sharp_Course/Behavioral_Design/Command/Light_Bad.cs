namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Command
{
    public class Light_Bad
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light is Off");
        }
        //Voilates the OCP
        //public void DimLight()
        //{

        //}
    }
}
