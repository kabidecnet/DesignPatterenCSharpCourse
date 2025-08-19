namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Command.Good
{
    public class TurnOffCommand : ICommand
    {
        private Light _light;
        public TurnOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
