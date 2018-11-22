using System;
using System.Diagnostics.Contracts;
using System.Threading;
public static class Program
{
    public static void Main()
    {
        // Создание объекта Timer, вызывающего метод TimerCallback
        // каждые 2000 миллисекунд
        Timer t = new Timer(TimerCallback, null, 0, 2000);
        // Ждем, когда пользователь нажмет Enter
        Console.ReadLine();

        // t.Dispose(); продлеваем жизнь обьекта таймер в Release билде.
    }

    private static void TimerCallback(Object o)
    {
        // Вывод даты/времени вызова этого метода
        Console.WriteLine("In TimerCallback: " + DateTime.Now);
        // Принудительный вызов уборщика мусора в этой программе
        GC.Collect();
    }
}