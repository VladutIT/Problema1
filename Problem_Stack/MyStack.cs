using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1
{
    class MyStack
    {/// <summary>
    ///  count=Count
    ///  capacity=Capacity
    /// </summary>
    /// 
        private int[] data;
        private int capacity = 16;
        private int count = 0;
        public MyStack()
        {
            data = new int[capacity];
        }
        public void Push(int value)
        {
           /// adaugam valoarea value in stiva
           if(Count==Capacity)
            {
                capacity = capacity * 2;
                int[] v = new int[capacity];
                for(int i=0;i<Count;i++)
                {
                    v[i] = data[i];
                }
                data = v;
                /// dublam capacitatea stivei
            }
            data[Count] = value;
            count++;
        }
        public int Peek()
        {
            if(Count>0)
            {
                return data[Count - 1];
            }
            else
            {
                throw new Exception("Am incercat sa examinez elementul din varful unei stive goale");
            }
        }
        public int Pop()
        {
            if(Count>0)
            {
                count--;
                //se elimina din stiva elementul data[count];
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
}
