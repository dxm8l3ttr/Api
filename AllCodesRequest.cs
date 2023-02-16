using MediatR;

namespace Api;

class AllCodesRequest : IRequest<List<Guid>>
{
}

class AllCodesRequestHandler : IRequestHandler<AllCodesRequest, List<Guid>>
{
    private ICodesService _service;

    public AllCodesRequestHandler(ICodesService service)
    {
        _service = service;
    }

    public async Task<List<Guid>> Handle(AllCodesRequest request, CancellationToken cancellationToken)
    {
        return _service.GetCodes();
    }
}