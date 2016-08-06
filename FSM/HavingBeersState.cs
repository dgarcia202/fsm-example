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

            entity.Boredom -= 12;
            entity.MoneyInPocket -= 18;

            if (entity.Tiredness >= 100)
            {
                entity.StateMachine.ChangeState(RestingState.Instance);
            }

            if (entity.Boredom <= 0 || entity.MoneyInPocket < 18)
            {
                entity.StateMachine.ChangeState(WorkingState.Instance);
            }
        }
    }
}