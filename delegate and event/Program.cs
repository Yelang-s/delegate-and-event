using System;

/// <summary>
///     案例：猫和老鼠
///     猫为被观察者，老鼠是观察者，观察者订阅被观察者的触发事件
///     观察者观察被观察者，当被观察者有动作时，观察者做出相应的其他动作
/// </summary>
namespace delegate_and_event
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Cat cat = new Cat("汤姆");
            Mouse mouse1 = new Mouse("PP", cat);
            Mouse mouse2 = new Mouse("PP儿子", cat);
            cat.Coming();
            Console.ReadKey();
        }
    }
}
