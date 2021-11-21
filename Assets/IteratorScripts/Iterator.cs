class Iterator : IIterator
{
    IAggregate aggregate = null;

    //We need an index to track the iteration process
    int currentIndex = 0;

    public Iterator(IAggregate newAggregate)
    {
        aggregate = newAggregate;
    }
    //Returns item with index 0
    public int FirstItem
    {
        get
        {
            currentIndex = 0;
            return aggregate[currentIndex];
        }
    }

    //Returns next item
    public int NextItem
    {
        get
        {
            currentIndex += 1;

            if (IsDone == false)
            {
                return aggregate[currentIndex];
            }
            else
            {
                return -1;
            }
        }
    }

    public int CurrentItem
    {
        get
        {
            return aggregate[currentIndex];
        }
    }
    //This method will give us feedabck when iteration ended
    public bool IsDone
    {
        get
        {
            if (currentIndex < aggregate.Count)
            {
                return false;
            }
            return true;
        }
    }
}