namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy.Good
{
    public class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing using WEBM");
        }
    }
}
