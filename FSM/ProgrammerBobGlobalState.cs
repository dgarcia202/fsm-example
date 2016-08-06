namespace FSM
{
    public class ProgrammerBobGlobalState : State<ProgrammerBob>
    {
        private static ProgrammerBobGlobalState innerInstance;

        public static ProgrammerBobGlobalState Instance => innerInstance ?? (innerInstance = new ProgrammerBobGlobalState());

        public override void Execute(ProgrammerBob entity)
        {
            entity.Boredom += 8;
            entity.Tiredness += 10;
        }
    }
}