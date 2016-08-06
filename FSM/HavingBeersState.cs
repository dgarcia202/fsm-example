namespace FSM
{
    using System;

    public class HavingBeersState : State<ProgrammerBob>
    {
        private static HavingBeersState innerInstance;

        public static HavingBeersState Instance => innerInstance ?? (innerInstance = new HavingBeersState());

        public override void Enter(ProgrammerBob entity)
        {
            Console.WriteLine("Me voy un rato al pub");
        }

        public override void Execute(ProgrammerBob entity)
        {
            Console.WriteLine("One more beer!");

            if (entity.MoneyInPocket < 18)
            {
                Console.WriteLine("Oh! no tengo dinero");
                entity.StateMachine.ChangeState(WorkingState.Instance);
                return;
            }

            entity.Boredom -= 60;
            entity.MoneyInPocket -= 18;

            if (entity.Tiredness >= 100)
            {
                entity.StateMachine.ChangeState(RestingState.Instance);
                return;
            }

            if (entity.Boredom <= 0 || entity.MoneyInPocket < 18)
            {
                entity.StateMachine.ChangeState(WorkingState.Instance);
            }
        }
    }
}