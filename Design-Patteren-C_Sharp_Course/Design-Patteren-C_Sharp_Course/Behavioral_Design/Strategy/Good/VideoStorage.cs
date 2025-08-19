namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Strategy.Good
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public void SetCompressor(ICompressor compressors)
        {
            _compressor = compressors;
        }
        public void SetOverlays(IOverlay overlays)
        {
            _overlay = overlays;
        }
        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            _compressor.Compress();
            _overlay.Apply();
            Console.WriteLine("Storing videos to {0}, {1}", fileName, _compressor);
        }
    }
}
