using Microsoft.Extensions.Configuration;
using Without.Systems.CloudFrontSigner.Structures;

namespace Without.Systems.CloudFrontSigner.Test;

public class Tests
{
    private static readonly ICloudFrontSigner _actions = new CloudFrontSigner();

    private string _cloudFrontPrivateKey;
    private string _cloudFrontDistributionDomainName;
    private string _cloudFrontKeyPairId;
    
    [SetUp]
    public void Setup()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddUserSecrets<Tests>()
            .AddEnvironmentVariables()
            .Build();

        _cloudFrontPrivateKey = configuration["CloudFrontPrivateKey"] ?? throw new InvalidOperationException();
        _cloudFrontDistributionDomainName = configuration["CloudFrontDistributionDomainName"] ?? throw new InvalidOperationException();
        _cloudFrontKeyPairId = configuration["CloudFrontKeyPairId"] ?? throw new InvalidOperationException();
    }

    [Test]
    public void Echo_Returns_Successful()
    {
        var request = new GetCannedSignedUrlRequest
        {
            DistributionDomainName = _cloudFrontDistributionDomainName,
            KeyPairId = _cloudFrontKeyPairId,
            ResourcePath = "/*",
            ExpiresOn = DateTime.Now.AddDays(1),
            PrivateKey = _cloudFrontPrivateKey
        };
        
        var cannedSignedUrl = _actions.GetCannedSignedUrl(request);
    }

    [Test]
    public void Get_Custom_Signed_Url()
    {
        var request = new GetCustomSignedUrlRequest
        {
            DistributionDomainName = _cloudFrontDistributionDomainName,
            KeyPairId = _cloudFrontKeyPairId,
            ResourcePath = "/*",
            ExpiresOn = DateTime.Now.AddDays(1),
            PrivateKey = _cloudFrontPrivateKey

        };

        var customSignedUrl = _actions.GetCustomSignedUrl(request);
    }
}