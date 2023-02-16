using MediatR;

namespace Api;

class GetCodeRequest : IRequest<Guid>
{
}

class GetCodeRequestHandler : IRequestHandler<GetCodeRequest, Guid>
{
    private ICodesService _service;

    public GetCodeRequestHandler(ICodesService service)
    {
        _service = service;
    }

    public async Task<Guid> Handle(GetCodeRequest request, CancellationToken cancellationToken)
    {
        var guid = Guid.NewGuid();
        _service.SaveCode(guid);
        return guid;
    }
}