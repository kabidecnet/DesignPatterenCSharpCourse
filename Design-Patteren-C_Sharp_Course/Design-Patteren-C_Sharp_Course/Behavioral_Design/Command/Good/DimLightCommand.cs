namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Command.Good
{
    public class DimLightCommand : ICommand
    {
        private Light _light;
        public DimLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Dim();
        }
    }
}
