namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Iterator
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current();
    }
}
