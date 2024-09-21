namespace CXL.DI.API;

public interface ICXLServiceSubProvider : IDisposable
{
    public object GetService(Type interfaceType);

}
