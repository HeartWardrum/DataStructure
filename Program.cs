using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {


            Random ran = new Random();

            float xunyi = 0;
            float liduo = 0;
            for (int j = 1; j < 1000001; j++)
            {
                int total = 28;
                //Console.WriteLine("初始总数为：" + total);
                float a1 = 0;
                float a2 = 0;
                float a3 = 0;
                float times = 0;

                for (int i = 1; i < 28; i++)
                {
                    if (total > 0)
                    {
                        int n = ran.Next(1, 4);

                        switch (n)
                        {
                            case 1:
                                a1 += 1;
                                break;
                            case 2:
                                a2 += 1;
                                break;
                            case 3:
                                a3 += 1;
                                break;
                        }
                        total -= n;
                       // Console.WriteLine("第    " + i + "   次抽取了    " + n + "   个贝壳，此时剩余的贝壳总数为：" + total);

                    }


                }
                times = a1 + a2 + a3;
                float a11 = a1 / times;
                float a22 = a2 / times;
                float a33 = a3 / times;
               //Console.WriteLine("双方抽取次数为：" + times);
               //Console.WriteLine("1出现的概率为：" + a11);
               //Console.WriteLine("2出现的概率为：" + a22);
               //Console.WriteLine("3出现的概率为：" + a33);            
               //Console.WriteLine("第" + j + "次循环抽取了：" + times + "次");
                //if (times % 2 == 0)
                //{
                //    Console.WriteLine("荀一获胜");
                //}
                //else
                //{
                //    Console.WriteLine("龙王获胜");
                //}
               // Console.WriteLine("*******************************************************************************");
                if (times % 2 == 0)
                {
                    xunyi +=1;
                }
                else
                {
                    liduo += 1;
                }
            }
            float total2 = xunyi + liduo;
            Console.WriteLine("********************************最 终 结 果********************************");
            Console.WriteLine("共循环" + total2 + "次");
            Console.WriteLine("荀一：" + xunyi + "胜场");
            Console.WriteLine("龙王：" + liduo + "胜场");














            //float a1 = 0;
            //float a2 = 0;
            //float a3 = 0;
            //for (int i = 0; i < 100000000; i++)
            //{
            //    int temp = ran.Next(1, 4);
            //    switch (temp)
            //    {
            //        case 1:
            //            a1 += 1;
            //            break;
            //        case 2:
            //            a2 += 1;
            //            break;
            //        case 3:
            //            a3 += 1;
            //            break;
            //    }

            //}
            //float a4 = a1 + a2 + a3;
            //float a11 = a1 / a4;
            //float a22 = a2 / a4;
            //float a33 = a3 / a4;
            //Console.WriteLine("循环总次数为：" + a4);
            //Console.WriteLine("1出现的概率为：" + a11);
            //Console.WriteLine("2出现的概率为：" + a22);
            //Console.WriteLine("3出现的概率为：" + a33);





        }






    }

}
