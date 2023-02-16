namespace Api;

public interface ICodesService
{
    public void SaveCode(Guid code);

    public List<Guid> GetCodes();
}

public class CodesService : ICodesService
{
    private List<Guid> _codes;

    public CodesService()
    {
        _codes = new();
    }

    public List<Guid> GetCodes()
    {
        return _codes;
    }

    public void SaveCode(Guid code)
    {
        _codes.Add(code);
    }
}