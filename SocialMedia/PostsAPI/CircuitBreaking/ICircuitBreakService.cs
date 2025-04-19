namespace PostsAPI.CircuitBreaking
{
    public interface ICircuitBreakService<T> where T : ICircuitBrokenService
    {
        // Define the methods that your service should implement
        Task Execute(Func<bool> action);
        void ResetCircuit();
        bool IsCircuitOpen { get; }
        int FailureCount { get; }
    }
}