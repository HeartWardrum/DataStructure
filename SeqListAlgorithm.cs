using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.DataStructure
{
    class SeqListAlgorithm
    {
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

    }
}
