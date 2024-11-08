using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.CloudFrontSigner.Structures;

[OSStructure(Description = "Generic Key Value pair of type string, string")]
public struct KeyValue
{
    [OSStructureField(Description = "Key",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string Key;
    
    [OSStructureField(Description = "Value",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string Value;
    
    public KeyValue(string key, string value)
    {
        Key = key;
        Value = value;
    }
}