namespace FSM
{
    public abstract class State<T>
    {
        public virtual void Enter(T entity)
        {
        }

        public virtual void Execute(T entity)
        {
        }

        public virtual void Exit(T entity)
        {
        }
    }
}