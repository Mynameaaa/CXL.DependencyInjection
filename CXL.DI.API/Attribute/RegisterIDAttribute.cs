namespace CXL.DI.API;

public class RegisterIDAttribute : Attribute
{
    public CXLServiceLifetime Lifetime { get; init; }

    public RegisterIDAttribute(CXLServiceLifetime lifetime)
    {
        Lifetime = lifetime;
    }
}
