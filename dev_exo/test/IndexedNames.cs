using System;
namespace test
{
    public class IndexedNames
    {
        // Fields
        private string[] nameList = new string[size];
        static public int size = 10;

        // Constructor
        public IndexedNames()
        {
            for (int i = 0; i < size; i++ )
            {
                nameList[i] = "N. A.";
            }
        }

        // Property Indexer with 'int': prends l'index, retourne le nom
        public string this[int index]
        {
            get
            {
                string tmp;

                if ( index >= 0 && index < size )
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }
            set
            {
                if ( index >= 0 && index < size )
                {
                    nameList[index] = value;
                }
            }
        }

        // Property Indexer with 'string': prends le nom et retourne l'index
        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < size)
                {
                    if ( nameList[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }
    }//end class IndexedNames
}
