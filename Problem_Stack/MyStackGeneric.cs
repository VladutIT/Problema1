using System;

public class MyStackGenerric<T>
{
	private T[] data;
	private int capacity = 16;
	private int count = 0;
	public MyStackGenerric()
	{
		data = new T[capacity];
	}
    public void Push(T value)
    {
        if (Count == Capacity)
        {
            capacity = capacity * 2;
            T[] v = new T[capacity];
            for (int i = 0; i < Count; i++)
            {
                v[i] = data[i];
            }
            data = v;
        }
        data[Count] = value;
        count++;
    }
    public T Peek()
    {
        if (Count > 0)
        {
            return data[Count - 1];
        }
        else
        {
            throw new Exception("Am incercat sa examinez elementul din varful unei stive goale");
        }
    }
    public T Pop()
    {

        if (Count > 0)
        {
            count--;
            return data[count];
        }
        else
        {
            throw new Exception("Am incercat sa elimin un element din stiva goala");
        }
    }
    public int Count
    {
		get
		{
			return count;
		}
	}
	public int Capacity
    {
		get
        {
			return capacity;
        }
	}


}
