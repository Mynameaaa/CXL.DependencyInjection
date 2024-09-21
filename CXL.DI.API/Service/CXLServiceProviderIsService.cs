﻿
namespace CXL.DI.API
{
    public class CXLServiceProviderIsService : IServiceProviderIsService
    {
        private readonly IServiceProvider _serviceProvider;

        public CXLServiceProviderIsService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public bool IsService(Type serviceType)
        {
            return _serviceProvider.GetService(serviceType) != null;
        }
    }
}
