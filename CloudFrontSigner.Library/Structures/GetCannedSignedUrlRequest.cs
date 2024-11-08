using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.CloudFrontSigner.Structures;

[OSStructure(Description = "GetCannedSignedUrl Request Structure")]
public struct GetCannedSignedUrlRequest
{
    [OSStructureField(
        Description = "The domain name of the distribution",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string DistributionDomainName;
    
    [OSStructureField(
        Description = "The path for the resource",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string ResourcePath;
    
    [OSStructureField(
        Description = "The private key for generating the signature.",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string PrivateKey;
    
    [OSStructureField(
        Description = "The key pair id corresponding to the private key given",
        DataType = OSDataType.Text,
        IsMandatory = true)]
    public string KeyPairId;
    
    [OSStructureField(
        Description = "The expiration date till which content can be accessed using the generated cookies",
        DataType = OSDataType.DateTime,
        IsMandatory = true)]
    public DateTime ExpiresOn;
}