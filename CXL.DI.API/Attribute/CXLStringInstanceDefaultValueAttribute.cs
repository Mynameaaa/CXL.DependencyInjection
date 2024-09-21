namespace CXL.DI.API;

public class CXLStringInstanceDefaultValueAttribute : CXLInstanceDefaultValueAttribute
{
    public string DefaultValue { get; set; }

    public CXLStringInstanceDefaultValueAttribute(string defaultValue)
    {
        DefaultValue = defaultValue;
    }
}
