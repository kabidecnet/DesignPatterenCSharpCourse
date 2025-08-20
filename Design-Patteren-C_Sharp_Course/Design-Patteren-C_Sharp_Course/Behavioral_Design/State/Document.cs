using Design_Patteren_C_Sharp_Course.Behavioral_Design.State.GoodSolution;

namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.State
{
    public class Document
    {
        public DocumentStatus State { get; set; }
        public UserRoles CurrentUserRole { get; set; }
        public void Publish()
        {
            if (this.State == DocumentStatus.Draft)
            {
                State = DocumentStatus.Moderation;
            }
            else if (this.State == DocumentStatus.Moderation)
            {
                if (CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentStatus.Published;
                }
            }
            else if (this.State == DocumentStatus.Published)
            {
                // do nothing
            }
        }
    }
}
