using System;

namespace 入门12练习题1
{
    class Program
    {
        static void Main(string[] args)
        {
            //名字
            string name = "吴炳灿";
            Console.WriteLine("姓名：" + name);

            //年龄
            byte age = 34;
            Console.WriteLine("年龄：" + age + "岁");

            //性别：true=男，false=女。
            bool sex = true;
            Console.WriteLine("性别：" + sex + "(True=男，False=女。)");

            //身高
            float height = 167.5f;
            Console.WriteLine("身高：" + height + "cm");

            //体重
            float weight = 65.5f;
            Console.WriteLine("体重：" + weight + "kg");

            //家庭住址
            string address = "中国福建";
            Console.WriteLine("住址：" + address);

            byte shuxue = 80, yuwen = 78, yingyu = 98;
            Console.WriteLine("数学成绩：" + shuxue);
            Console.WriteLine("语文成绩：" + yuwen);
            Console.WriteLine("英语成绩：" + yingyu);


        }
    }
}