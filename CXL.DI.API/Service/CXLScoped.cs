﻿namespace CXL.DI.API;

public class CXLScoped : ICXLScoped, IServiceScope
{
    public readonly IServiceProvider _serviceProvider;

    public ICXLServiceSubProvider SubSerivceProvider { get; private set; }

    public IServiceProvider ServiceProvider => _serviceProvider;

    public CXLScoped(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        SubSerivceProvider = new CXLServiceSubProvider((CXLServiceProvider)_serviceProvider);
    }

    public void Dispose()
    {
        SubSerivceProvider.Dispose();
    }
}
