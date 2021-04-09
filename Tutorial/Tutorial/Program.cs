using System;

namespace Tutorial
{
    class MainClasss
    {
        static void Main(string[] args)
        {
            string [,]array = MyArrays.NewArray(3,2);
            MyArrays.ReadArray(array);
        }
    }
}
