using NewLife;
using NewLife.Data;
using NewLife.Log;

XTrace.UseConsole();

Console.WriteLine("一凡快算24点，输入逗号隔开的4个数字。");
while (true)
{
    Console.Write("请输入4个数字：");
    var line = Console.ReadLine();

    //var nums = new Double[] { 1, 5, 5, 5 };
    var nums = line.SplitAsInt().Select(e => (Double)e).ToArray();
    XTrace.WriteLine("开始24点运算：{0}", nums);

    var bt = new BinaryTree();
    //bt.Operations.Add("Sqrt");
    //bt.Operations.Add("Cbrt");
    var ss = bt.Execute(nums, 24);
    XTrace.WriteLine("共有结果：{0}", ss.Length);
    foreach (var item in ss)
    {
        XTrace.WriteLine(item);
    }
}

Console.ReadKey();
