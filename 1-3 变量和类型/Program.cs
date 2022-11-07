using System;

namespace _1_3_变量和类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a; //定义一个变量，类型为int，名称为a
            //a = 2333;

            //// a = 3.14f; // 类型不匹配

            //float f = 3.14f; // 定义变量，同时赋初值
            //// float f = 4;     // 名字重复
            //float s = 3.44f;


            //string s1 = "abcgf我是谁";

            //Console.WriteLine("a ="  + a);

            //Console.WriteLine("f = {0}", f);
            //Console.WriteLine("f ="  + f); // 第二种写法

            //Console.WriteLine("s =" +  s);
            //Console.WriteLine($"s = {s}"); // 第三种写法

            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            // 变量练习1（交换存储）

            int a = 3;
            int b = 4;

            int temp;
            temp = a; // a放到temp以后就空了，所以下面开头的是a，因为a是被放置的单位
            a = b;    // 同理b放到了a中，b也是空置的状态
            b = temp;

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);


            // 变量练习2（人物对话）
            //Console.WriteLine("你叫什么名字？");
            //string name = Console.ReadLine();
            //Console.WriteLine("你好，" + name + "。");


            // 变量练习3(字符串转为数字）

            // CASE1:Convert.ToInt32
            string sa = Console.ReadLine();
            int na = Convert.ToInt32(sa);

            // CASE2：int.Parse
            string sb = Console.ReadLine();
            int nb = int.Parse(sb);

            Console.WriteLine("na+ba结果为" + (na + nb));

            Console.ReadKey();
        }
    }
}
