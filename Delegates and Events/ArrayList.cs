using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    class ArrayList
    {
        private int[] numList = new int[4];
        //TypeCatsing
        //int num = (int)someObject;
        public ArrayList()
        {
        }

        public virtual int[] Add(int[] array, int value)
        {
            numList = new int[array.Length + 1];
            
            for (int i = 0; i < array.Length; i++)
            {
                numList[i] = array[i];
            }

            numList[array.Length] = value;

            for(int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }

            return numList;
        }
        public virtual void Remove(int index)
        {
            int[] newArray = new int[numList.Length - 1];
            int newSpot = 0;
            for (int i = 0; i < numList.Length; i++)
            {
                if (i!= index)
                {
                    newArray[newSpot] = numList[i];
                    newSpot++;
                }
            }
        }


        public virtual object Clear()
        {
            numList = new int[0];

            return numList;
        }

        public virtual object this[int index]
        {
            set
            {
                index = (int)value;
            }
        }
        
        //public int Length
        //{
        //    get
        //    {

        //    }
        //}
            

    }
}
