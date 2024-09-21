using Microsoft.AspNetCore.Diagnostics;

namespace CXL.DI.API
{
    public class CXLDeveloperPageExceptionFilter : IDeveloperPageExceptionFilter
    {
        public async Task HandleExceptionAsync(ErrorContext errorContext, Func<ErrorContext, Task> next)
        {
            await next(errorContext);
        }
    }
}
