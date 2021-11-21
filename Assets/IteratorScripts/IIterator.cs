interface IIterator
{
    int FirstItem { get; }
    int NextItem { get; }
    int CurrentItem { get; }
    bool IsDone { get; }
}