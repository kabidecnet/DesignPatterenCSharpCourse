namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.State.GoodSolution
{
    public class Document
    {
        public IState State { get; set; }

        public UserRoles CurrentRole { get; set; }
        public Document(UserRoles currentUserRole)
        {
            State = new DraftState(this);
            CurrentRole = currentUserRole;
        }
        public void Publish()
        {
            State.Publish();
        }
    }
}
