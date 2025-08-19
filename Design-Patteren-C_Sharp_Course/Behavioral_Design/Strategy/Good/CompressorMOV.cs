namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy.Good
{
    internal class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using MOV");
        }
    }
}
