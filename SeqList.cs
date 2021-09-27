using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.DataStructure
{
    class SeqList<T> : IListDS<T>
    {

        private int maxsize;        //顺序表的容量
        private T[] data;           //数组，用于存储顺序表中的数据元素
        private int last;           //指示顺序表最后一个元素的索引值


        //索引器
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //最后一个数据元素位置属性
        public int Last
        {
            get { return last; }
        }

        //容量属性
        public int Maxsize
        {
            get { return maxsize; }
            set { maxsize = value; }
        }

        //构造器
        public SeqList(int size)
        {
            data = new T[size];
            maxsize = size;
            last = -1;
        }

        public int GetLength()
        {
            return last + 1;
        }


        public void Clear()
        {
            last = -1;
        }

        public bool IsEmpty()
        {
            if (last == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (last == maxsize - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在顺序表末尾添加新元素
        public void Append(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full 顺序表已满");
                return;
            }
            data[++last] = item;
        }

        //在顺序表第i个数据元素的位置插入一个新数据元素（索引值为i-1）
        public void Insert(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full 顺序表已满");
                return;
            }

            if (i < 1 || i > last + 2)//i-1<0 || i-1>last+1
            {
                Console.WriteLine("Position is error!  索引值溢出!");
                return;
            }

            if (i == last + 2)//i-1 == last+1
            {
                data[last + 1] = item;
            }
            else
            {
                for (int j = last; j >= i - 1; --j)//将索引值i-1后面的所有元素往后移一位
                {
                    data[j + 1] = data[j];
                }

                data[i - 1] = item;//添加新数据元素
            }
            ++last;
        }


        public T Delete(int i)
        {
            T tempVal = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("List is empty  顺序表是空的，删你马呢");
                return tempVal;
            }

            if (i < 1 || i > last + 1)//i-1<0 || i-1>last
            {
                Console.WriteLine("Position is Error  索引值溢出");
                return tempVal;
            }

            if (i - 1 == last)
            {
                tempVal = data[last--];
            }
            else
            {
                tempVal = data[i - 1];
                for (int j = i; j <= last; ++j)
                {
                    data[j - 1] = data[j];        //《c#数据结构预算法》中出现错误
                }
            }

            --last;
            return tempVal;
        }


        //获得顺序表的第i个数据元素
        public T GetElem(int i)
        {
            if (IsEmpty() || (i < 1) || (i > last + 1))
            {
                Console.WriteLine("List is empty or Position is error!  ");
                return default(T);
            }
            return data[i - 1];
        }

        //在顺序白哦中查找值为value的数据元素
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return -1;
            }

            int i = 0;
            for (i = 0; i < last; ++i)
            {
                if (value.Equals(data[i]))
                {
                    break;
                }
            }
            if (i > last)
            {
                return -1;
            }
            return i;
        }

        public void Reverse()
        {
            //顺序表倒置算法
            //算法思路： 第i个元素与第n-i个元素交换 0<=i<=n/2
            //时间复杂度: 0(n)
            T tempVal = default(T);
            int len = GetLength();
            for (int i = 0; i <= len / 2; ++i)
            {
                tempVal = data[i];
                data[i] = data[len - i];
                data[len - i] = tempVal;
            }
        }








    }
}
