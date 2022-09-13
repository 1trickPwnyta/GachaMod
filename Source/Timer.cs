using System;
using System.Threading.Tasks;

namespace GachaMod
{
    public static class Timer
    {
        public static void Set(Action action, int ms)
        {
            Task.Run(async delegate
            {
                await Task.Delay(ms);
                action();
            });
        }
    }
}
