using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.CloudFrontSigner.Structures;

[OSStructure(Description = "GetCustomSignedUrl Response Structure")]
public struct GetCustomSignedUrlResponse
{
    [OSStructureField(Description = "Absolute URI of the signed URL",
        DataType = OSDataType.Text)]
    public string Url;
    
    [OSStructureField(Description = "Absolute Path of the signed Url",
        DataType = OSDataType.Text)]
    public string Path;

    [OSStructureField(Description = "Scheme of the signed Url",
        DataType = OSDataType.Text)]
    public string Schema;
    
    [OSStructureField(Description = "Host of the signed Url",
        DataType = OSDataType.Text)]
    public string Host;
    
    [OSStructureField(Description = "Query of the signed Url",
        DataType = OSDataType.Text)]
    public string Query;

}