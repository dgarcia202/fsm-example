namespace FSM
{
    public class ProgrammerBob
    {
        public StateMachine<ProgrammerBob> StateMachine { get; }

        public ProgrammerBob()
        {
            this.StateMachine = new StateMachine<ProgrammerBob>(this);

            this.StateMachine.GlobalState = ProgrammerBobGlobalState.Instance;
            this.StateMachine.ChangeState(WorkingState.Instance);
        }

        public int MoneyInBank { get; set; }

        public int MoneyInPocket { get; set; }

        public int Tiredness { get; set; }

        public int Boredom { get; set; }

        public void Update()
        {
            this.StateMachine.Update();
        }
    }
}