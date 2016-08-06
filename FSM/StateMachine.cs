namespace FSM
{
    public class StateMachine<T>
    {
        private T Owner { get; set; }

        public State<T> CurrentState { get; set; }

        public State<T> PreviousState { get; set; }

        public State<T> GlobalState { get; set; }

        public StateMachine(T owner)
        {
            this.Owner = owner;
        }

        public void Update()
        {
            if (this.GlobalState != null)
            {
                this.GlobalState.Execute(this.Owner);
            }

            if (this.CurrentState != null)
            {
                this.CurrentState.Execute(this.Owner);
            }
        }

        public void ChangeState(State<T> newState)
        {
            if (newState == null)
            {
                return;
            }

            if (this.CurrentState != null)
            {
                //keep a record of the previous state
                this.PreviousState = this.CurrentState;

                //call the exit method of the existing state
                this.CurrentState.Exit(this.Owner);
            }

            //change state to the new state
            this.CurrentState = newState;

            //call the entry method of the new state
            this.CurrentState.Enter(this.Owner);
        }

        public void RevertToPreviousState()
        {
            this.ChangeState(this.PreviousState);
        }

        public bool IsInState(State<T> state)
        {
            return this.CurrentState == state;
        }
    }
}