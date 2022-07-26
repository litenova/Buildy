using System.Threading;
using System.Threading.Tasks;

namespace ChainRunner.UnitTests.Data;

public class SecondFakeResponsibilityHandler : IResponsibilityHandler<FakeChainRequest>
{
    public Task HandleAsync(FakeChainRequest request, IChainContext chainContext, CancellationToken cancellationToken = default)
    {
        request.ExecutionLogs.Add("2");
        return Task.CompletedTask;
    }
}