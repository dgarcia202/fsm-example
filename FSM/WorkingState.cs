namespace FSM
{
    using System;

    public class WorkingState : State<ProgrammerBob>
    {
        private static WorkingState innerInstance;

        public static WorkingState Instance => innerInstance ?? (innerInstance = new WorkingState());

        public override void Enter(ProgrammerBob entity)
        {
            Console.WriteLine("Me dirijo a la oficina ¡Vamos al tajo!");
        }

        public override void Execute(ProgrammerBob entity)
        {
            Console.WriteLine("Trabaja, trabaja, trabaja...");

            entity.MoneyInBank += 10;

            if (entity.Tiredness >= 100)
            {
                entity.StateMachine.ChangeState(RestingState.Instance);
                return;
            }

            if (entity.Boredom >= 100 && entity.MoneyInPocket >= 25)
            {
                entity.StateMachine.ChangeState(HavingBeersState.Instance);
                return;
            }

            if (entity.Boredom >= 100 && entity.MoneyInPocket < 25)
            {
                entity.StateMachine.ChangeState(GettingCashState.Instance);
            }
        }
    }
}