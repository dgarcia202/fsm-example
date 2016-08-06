namespace FSM
{
    using System;

    public class RestingState : State<ProgrammerBob>
    {
        private static RestingState innerInstance;

        public static RestingState Instance => innerInstance ?? (innerInstance = new RestingState());

        public override void Enter(ProgrammerBob entity)
        {
            Console.WriteLine("Qué cansado estoy, me voy a casa");
        }

        public override void Execute(ProgrammerBob entity)
        {
            Console.WriteLine("ZZZZZZZZZ");

            entity.Tiredness -= 20;

            if (entity.Tiredness <= 0)
            {
                entity.StateMachine.RevertToPreviousState();
            }
        }
    }
}