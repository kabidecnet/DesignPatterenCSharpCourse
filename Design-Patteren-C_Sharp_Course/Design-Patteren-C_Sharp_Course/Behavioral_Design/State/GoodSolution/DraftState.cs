namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.State.GoodSolution
{
    public class DraftState : IState
    {
        private readonly Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            _document.State = new ModerationState(_document);

            Console.WriteLine("Draft publishing");
        }
    }
}