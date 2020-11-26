using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2
{
    class Date
    {
        private int date;

        public Date(int date)
        {
            this.date = date;
        }

        public int this[int index]
        {
            get
            {
                int temp = date + index;
                if (temp > 31)
                {
                    while (temp > 31)
                    {
                        temp -= 31;
                    }
                    return temp;
                }
                else if (temp < 0)
                {
                    while (temp < -31)
                    {
                        temp += 31;
                    }
                    return 31 + temp;
                }
                else
                {
                    return temp;
                }
            }
        }
    }
}