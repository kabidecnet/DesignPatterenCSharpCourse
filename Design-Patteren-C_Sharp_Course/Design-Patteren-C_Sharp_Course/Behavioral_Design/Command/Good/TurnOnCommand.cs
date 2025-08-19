namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Command.Good
{
    public class TurnOnCommand : ICommand
    {
        private Light _light;
        public TurnOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
