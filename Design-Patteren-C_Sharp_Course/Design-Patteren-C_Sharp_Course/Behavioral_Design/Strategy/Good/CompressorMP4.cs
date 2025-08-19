namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy.Good
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing videos using MP4");
        }
    }
}
