namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Command
{
    public class RemoteControl_Bad
    {
        private readonly Light_Bad _light;

        public RemoteControl_Bad(Light_Bad light)
        {
            _light = light;
        }

        public void PressButton(bool turnOn)
        {
            if (turnOn)
            {
                _light.TurnOn();
            }
            else
            {
                _light.TurnOff();
            }
            //If I want to dim the light it breaks the OCP
        }
    }
}
