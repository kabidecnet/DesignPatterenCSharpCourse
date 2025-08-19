namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy
{
    public class Bad_VideoStorage
    {
        private Compressors _compressors;
        private Overlays _overlays;

        public Bad_VideoStorage(Compressors compressors, Overlays overlays = Overlays.None)
        {
            _compressors = compressors;
            _overlays = overlays;
        }
        public void SetCompressor(Compressors compressors)
        {
            _compressors = compressors;
        }
        public void SetOverlays(Overlays overlays)
        {
            _overlays = overlays;
        }
        public void Store(string fileName)
        {
            if (_compressors == Compressors.MOV)
            {
                Console.WriteLine("Compressing using MOV");
            }
            else if (_compressors == Compressors.MP4)
            {
                Console.WriteLine("Compressing using MP4");
            }
            else if (_compressors != Compressors.WEBM)
            {
                Console.WriteLine("Compressing using WEBM");
            }

            // Apply overlay
            if (_overlays == Overlays.BlackWhite)
            {
                Console.WriteLine("Applying black and white overlays");
            }
            else if (_overlays == Overlays.Blur)
            {
                Console.WriteLine("Applying blur overlays");

            }
            else if (_overlays == Overlays.None)
            {
                Console.WriteLine("Not Applying overlays");
            }

            // store
            Console.WriteLine("Storing videos to File Name {0} {1}", fileName, _compressors);
        }
    }
}
