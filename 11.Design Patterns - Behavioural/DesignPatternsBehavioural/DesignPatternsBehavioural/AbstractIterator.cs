
namespace DesignPatternsBehavioural
{
    public interface AbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }   
    }
}
