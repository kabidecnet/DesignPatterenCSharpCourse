namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.State.GoodSolution
{
    public class PublishedState : IState
    {
        private readonly Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            Console.WriteLine("Document in published state");
        }
    }
}