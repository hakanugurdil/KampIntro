using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMyDictionary
{
    class MyDictionary<K, V>
    {
        K[] Keys;
        V[] Values;


        public MyDictionary()
        {
            Keys = new K[0];
            Values = new V[0];
        }

        public void Add(K Key, V Value)
        {
            K[] tempArray = Keys;
            V[] _tempArray = Values;
            Keys = new K[Keys.Length + 1];
            Values = new V[Values.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Keys[i] = tempArray[i];
            }

            Keys[Keys.Length - 1] = Key;

            for (int i = 0; i < _tempArray.Length; i++)
            {
                Values[i] = _tempArray[i];
            }

            Values[Values.Length - 1] = Value;
        }
        public int Count
        {
            get { return Keys.Length; }
           
        }
    }
}
