using System.Collections.Generic;

class Aggregate : IAggregate
{
    //Here is why Iterator methods returns integers;
    List<int> values = null;

    public Aggregate()
    {
        values = new List<int>();
    }

    public IIterator GetIterator()
    {
        //Iterator constructor takes IAggregate as parameter
        return new Iterator(this);
    }

    public int this[int itemIndex]
    {
        get
        {
            if (itemIndex < values.Count)
            {
                return values[itemIndex];
            }
            else
            {
                return -1;
            }
        }
        set
        {
            values.Add(value);
        }
    }

    public int Count
    {
        get
        {
            return values.Count;
        }
    }
}