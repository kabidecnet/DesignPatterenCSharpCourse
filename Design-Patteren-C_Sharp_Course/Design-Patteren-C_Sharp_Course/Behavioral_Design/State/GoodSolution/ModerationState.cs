namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.State.GoodSolution
{
    internal class ModerationState : IState
    {
        private readonly Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            if (_document.CurrentRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
}