using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    internal class CitizenCollection : IEnumerable<Citizen>, IEnumerator<Citizen>
    {

        private Citizen[] citizens;

        private int position = -1;

        public CitizenCollection()
        {
            citizens = new Citizen[0];
        }


        public int Add(Citizen citizen)
        {

            if (!Contains(citizen))
            {
                position++;
                Citizen[] tempArr = new Citizen[citizens.Length + 1];

                if (citizen is Pensioner)
                {
                    tempArr[0] = citizen;
                    int index = 1;
                    for (int i = 0; i < citizens.Length; i++)
                    {
                        tempArr[index++] = citizens[i];
                    }
                }
                else
                {
                    for (int i = 0; i < citizens.Length; i++)
                    {
                        tempArr[i] = citizens[i];
                    }
                    tempArr[tempArr.Length - 1] = citizen;
                }

                citizens = tempArr;
                return citizens.Length - 1;

            }
            else
            {
                Console.WriteLine("Такой элемент уже есть в колекции");
                return -1;
            }

        }


        private bool Contains(Citizen citizen)
        {

            foreach (Citizen cit in citizens)
            {
                if (citizen.Equals(cit))
                {
                    return true;
                }
            }
            return false;

        }

        public bool Delete(Citizen citizen)
        {
            if (citizens.Length > 0)
            {
                if (!Contains(citizen))
                {
                    Citizen[] tempArr = new Citizen[citizens.Length - 1];
                    int index = 1;
                    for (int i = 0; i < tempArr.Length; i++)
                    {
                        tempArr[i] = citizens[index++];
                    }
                    citizens = tempArr;
                    return true;
                }
                else
                {
                    Console.WriteLine("Колекция не содержит такой элемент");
                    return false;
                }
            }

            Console.WriteLine("Колекция не содержит элементов");
            return false;

        }

        public bool Delete()
        {

            if (citizens.Length>0)
            {
                Citizen[] tempArr = new Citizen[citizens.Length - 1];
                int index = 1;
                for (int i = 0; i < tempArr.Length; i++)
                {
                    tempArr[i] = citizens[index++];
                }
                citizens = tempArr;
                return true;
            }

            Console.WriteLine("Колекция не содержит элементов");
            return false;

        }

        public void Clear()
        {
            citizens = new Citizen[0];
        }


        public IEnumerator<Citizen> GetEnumerator()
        {
            return (IEnumerator<Citizen>)this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            if (position < citizens.Length-1 )
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            } 
        }

        public void Reset()
        {
            position = -1;
        }

        public Citizen Current { get; }

        //object IEnumerator.Current => Current;

        object IEnumerator.Current
        {
            get
            {
                return citizens[position];
            }
        }




    }
}
