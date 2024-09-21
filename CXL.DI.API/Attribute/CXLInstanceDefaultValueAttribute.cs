namespace CXL.DI.API;

[AttributeUsage(AttributeTargets.Parameter)]
public class CXLInstanceDefaultValueAttribute : Attribute
{
    public bool UseContainerService { get; set; } = false;

    public CXLInstanceDefaultValueAttribute()
    {
        
    }
}
