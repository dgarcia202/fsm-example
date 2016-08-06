using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var agent = new ProgrammerBob();

            for (int i = 0; i < 100; i++)
            {
                agent.Update();
                Thread.Sleep(2000);
            }
        }
    }
}
