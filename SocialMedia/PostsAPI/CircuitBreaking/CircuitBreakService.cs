
namespace PostsAPI.CircuitBreaking;


// This concrete class implements the ICircuitBreakService interface and as such, in turn takes as input 
// ICircuitBrokenService as a generic type parameter. This allows for the implementation of a circuit breaker pattern
public class CircuitBreakService<T>: ICircuitBreakService<T> where T : ICircuitBrokenService
{

    // Circuit Breaker properties

    public bool IsCircuitOpen { get; private set; }
    private int _failureCount;
    private int _threshold;

    public CircuitBreakService(int threshold)
    {
        _threshold = threshold;
        IsCircuitOpen = false;
        _failureCount = 0;
    }

    public int FailureCount
    {
        get => _failureCount;
        set
        {
            _failureCount = value;
            if (_failureCount >= _threshold)
            {
                IsCircuitOpen = true;
            }
        }
    }

    public void ResetCircuit()
    {
        IsCircuitOpen = false;
        _failureCount = 0;
    }

    public void RecordFailure()
    {
        FailureCount++;
    }

    public void RecordSuccess()
    {
        if (IsCircuitOpen)
        {
            ResetCircuit();
        }
    }

    public void Reset()
    {
        IsCircuitOpen = false;
        _failureCount = 0;
    }


    // This method's purpose is to define the maximum number of failures before the circuit is opened.
    public void SetThreshold(int threshold)
    {
        if (threshold <= 0)
        {
            throw new ArgumentException("Threshold must be greater than zero.");
        }
        _threshold = threshold;
    }

    public int GetFailureCount()
    {
        return _failureCount;
    }

    //This is where the circuit breaker logic is implemented. OR run (this could also in turn have a handler
    // to properly propagate a proper expected result of an edge case if any applies.
    public Task Execute(Func<bool> action) => Task.FromResult(() => action.Invoke());
}
