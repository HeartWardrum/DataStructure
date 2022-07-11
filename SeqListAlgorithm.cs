using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace C_Sharp.DataStructure
{
    class SeqListAlgorithm
    {

        //升序排列的整型顺序表La和Lb  合并成升序表Lc
        //算法的时间复杂度是0(m+n)，m是La的表长，n是Lb的表长
        public SeqList<int> Merge(SeqList<int> La, SeqList<int> Lb)
        {
            SeqList<int> Lc = new SeqList<int>(La.Maxsize + Lb.Maxsize);
            int i = 0;
            int j = 0;
            int k = 0;

            //两个表中都有数据
            while ((i <= (La.GetLength() - 1)) && (j <= (Lb.GetLength() - 1)))
            {
                if (La[i] < Lb[j])
                {
                    Lc.Append(La[i++]);
                }
                else
                {
                    Lc.Append(Lb[j++]);
                }
            }

            //a表中还有数据元素
            while (i <= La.GetLength() - 1)
            {
                Lc.Append(La[i++]);
            }

            //b表中还有数据元素
            while (j <= Lb.GetLength() - 1)
            {
                Lc.Append(Lb[j++]);
            }

            return Lc;

        }



        //已知一个存储整数的顺序表La，是构造顺序表Lb，要求顺序表Lb中只包含顺序表La中所有值不相同的数据元素
        //即：从表中删除相同数据
        //算法的时间复杂度是 0(m+n),m是La的表长，n是Lb的表长
        public SeqList<int> Purge(SeqList<int> La)
        {
            SeqList<int> Lb = new SeqList<int>(La.Maxsize);

            //将a表中的第1个数据元素赋给b表
            Lb.Append(La[0]);

            //依次处理a表中的数据元素
            for (int i = 1; i <= La.GetLength() - 1; ++i)
            {
                int j = 0;

                //查看b表中有无与a表相同的数据元素
                for (j = 0; j <= Lb.GetLength() - 1; ++j)
                {
                    //有相同的数据元素
                    if (La[i].CompareTo(Lb[j]) == 0)
                    {
                        break;//比如La[1] = 99 依次和Lb中的数据比较，若是Lb中有个99,那么直接跳出，换La[2]来和Lb中数据比较
                    }
                }

                //没有相同的数据元素，将a表中的数据元素附加到b表的末尾
                if (j > Lb.GetLength() - 1)
                {
                    Lb.Append(La[i]);
                }
            }

            return Lb;
        }






    }
}
