using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Class1
{
    static void Main(string[] args)
    {
        ////問1
        //int[] array = new int[];
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //for (int j = 0; j < array.Length; j++;)
        //{
        //    Console.WriteLine(array[j] * 2);
        //}

        ////問2
        //int[] array = new int[10];
        //for(int i = 0; i < array.Length;  i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //Console.Write("偶数:");
        //for(int j = 0; j< array.Length;  j++)
        //{
        //    int even = array[j] % 2;
        //    if(even == 0)
        //    {
        //        Console.Write("{0}", array[j]);
        //    }
        //}

        //Console.Write("奇数:");
        //for(int n = 0; n < array.Length;  n++)
        //{
        //    int odd = array[n] % 2;
        //    if(odd != 0)
        //    {
        //        Console.Write("{0}", array[n]);
        //    }
        //}

        ////問3
        //int input = int.Parse(Console.ReadLine());
        //int num = 0;
        //bool isHit = false;
        //while(num < input)
        //{
        //    if((num + 1) * (num + 1) == input)
        //    {
        //        Console.WriteLine("この数は{0} * {0}の平方数です"
        //            , num + 1);
        //        isHit = true;
        //        break;
        //    }
        //    num++;
        //}
        //if(isHit == false)
        //{
        //    Console.WriteLine("この数は平方数ではありません");
        //}

        ////問4
        //Console.WriteLine("配列の大きさを入力してください");
        //int input  = int.Parse(Console.ReadLine());

        //Console.WriteLine("配列の大きさ分数値を入力してください");
        //int[]array = new int[input];
        //for(int i = 0; i < input; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //int min = array[0];
        //int max = array[0];
        //for(int i = 0; i < array.Length; i++)
        //{
        //    if(min = array[i])
        //    {
        //        min = array[i];
        //    }

        //    if(max = array[i])
        //    {
        //        max = array[i];
        //    }
        //}

        //Console.Write("一番大きい数:{0}",max);
        //Console.Write("一番小さい数:{0}", min);

        ////問5
        Random rand new Random();
        int array = new int[10];
        for (int i = 0; i < array; i++)
        {
            int ran = rand.Next(-100,100);
        }

        for (int i = 0;i < array; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if()
            }
        }
    }
}
