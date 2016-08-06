namespace FSM
{
    public class ProgrammerBob
    {
        public StateMachine<ProgrammerBob> StateMachine { get; }

        public ProgrammerBob()
        {
            this.StateMachine = new StateMachine<ProgrammerBob>(this);
        }

        public void Update()
        {
            this.StateMachine.Update();
        }
    }
}