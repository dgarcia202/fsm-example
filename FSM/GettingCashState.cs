namespace FSM
{
    using System;

    public class GettingCashState : State<ProgrammerBob>
    {
        private static GettingCashState innerInstance;

        public static GettingCashState Instance => innerInstance ?? (innerInstance = new GettingCashState());

        public override void Enter(ProgrammerBob entity)
        {
            Console.WriteLine("Necesito efectivo, voy al banco");
        }

        public override void Execute(ProgrammerBob entity)
        {
            entity.MoneyInPocket += entity.MoneyInBank;
            entity.MoneyInBank = 0;

            Console.WriteLine("Ahora tengo {0} en el bolsillo", entity.MoneyInPocket);

            entity.StateMachine.ChangeState(HavingBeersState.Instance);
        }
    }
}