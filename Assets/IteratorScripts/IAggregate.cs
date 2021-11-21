interface IAggregate
{
    IIterator GetIterator();
    //This will handle manipulation of objects in the array
    int this[int itemIndex] { set; get; }
    int Count { get; }
}