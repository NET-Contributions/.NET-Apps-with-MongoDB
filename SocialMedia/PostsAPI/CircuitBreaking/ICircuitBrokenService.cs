namespace PostsAPI.CircuitBreaking;


// This interface defines the contract for a circuit broken
// or otherwise nominated as circuit breaker subscribed service.
public interface ICircuitBrokenService
{

    // Define the methods that your service should implement
    Task Execute(Func<bool> action);
    void ResetCircuit();
    bool IsCircuitOpen { get; }
    int FailureCount { get; }

    // Feel free to add any other methods or properties that are relevant to your circuit broken service
}
