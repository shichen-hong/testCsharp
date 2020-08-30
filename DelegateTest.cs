using System;

namespace DelegateTest
{
    class TestDelegate
    {
        static int num = 10;
        public int AddNum(int p)
        {
            num += p;
            return num;
        }
        public int MultNum(int p)
        {
            num *= p;
            return num;
        }
        public int getNum()
        {
            return num;
        }
    }

}