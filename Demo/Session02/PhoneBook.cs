
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Session02
{
    internal struct PhoneBook
    {
        #region Attr
        string[] names;
        long[] numbers;
        int size;
        #endregion

        #region Prop
        public int Size
        {
            get { return size; }
        }
        #endregion

        #region Ctor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion

        #region Method
        public void AddPerson(int position, string name, long number)
        {
            if (name is not null && numbers is not null)
            {
                if (position >= 0 && position <= size)
                {
                    names[position] = name;
                    numbers[position] = number;
                }

            }
        }
        #endregion


        public long GetNumber(string Name)
        {
            if (!string.IsNullOrEmpty(Name) && numbers is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name == names[i])
                    {
                        return numbers[i];
                    }
                }
               
            }
            return -1;  
        }

        public void SetNumber(string name, long newNumber)
        {
            if (!string.IsNullOrEmpty(name) && numbers is not null)
            {
                for (int i = 0; i < name.Length; i++)
                {   
                    if (name == names[i])
                    {
                        numbers[i] = newNumber;
                    }
                }

            }
        }


        public long this[string Name]
        {
            get
            {
                if (!string.IsNullOrEmpty(Name) && numbers is not null)
                {
                    for (int i = 0; i < Name.Length; i++)
                    {
                        if (Name == names[i])
                        {
                            return numbers[i];
                        }
                    }

                }
                return -1;
            }
            //set
            //{
            //    if (!string.IsNullOrEmpty(Name) && numbers is not null)
            //    {
            //        for (int i = 0; i < Name.Length; i++)
            //        {
            //            if (Name == names[i])
            //            {
            //                numbers[i] = newNumber;
            //            }
            //        }

            //    }
            //}

        }

    }
}
