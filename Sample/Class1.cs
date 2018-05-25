using System;

namespace Sample
{
    public class Class1
    {
        public int SomeThing(int num)
        {
            switch (num)
            {
                case 1:
                    return 1;
                default:
                    throw new Exception("Error");
            }
        }
    }
}
