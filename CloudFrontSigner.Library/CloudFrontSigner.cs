using Amazon.CloudFront;
using Without.Systems.CloudFrontSigner.Structures;

namespace Without.Systems.CloudFrontSigner;

public class CloudFrontSigner : ICloudFrontSigner
{
    public string Echo(string message)
    {
        return message;
    }
    
    public string GetCannedSignedUrl(Structures.GetCannedSignedUrlRequest request)
    {
        using TextReader keyReader = new StringReader(request.PrivateKey);
        
        string cannedSignedUrl = AmazonCloudFrontUrlSigner.GetCannedSignedURL(
            AmazonCloudFrontUrlSigner.Protocol.https,
            request.DistributionDomainName,
            keyReader,
            request.ResourcePath,
            request.KeyPairId,
            request.ExpiresOn);

        return cannedSignedUrl;
    }

    public Structures.GetCustomSignedUrlResponse GetCustomSignedUrl(Structures.GetCustomSignedUrlRequest request)
    {
        using TextReader keyReader = new StringReader(request.PrivateKey);

        string customSignedUrl = AmazonCloudFrontUrlSigner.GetCustomSignedURL(
            AmazonCloudFrontUrlSigner.Protocol.https,
            request.DistributionDomainName,
            keyReader,
            request.ResourcePath,
            request.KeyPairId,
            request.ExpiresOn,
            string.Empty);
        
        Uri uri = new Uri(customSignedUrl);

        return new Structures.GetCustomSignedUrlResponse
        {
            Url = uri.AbsoluteUri,
            Host = uri.Host,
            Path = uri.AbsolutePath,
            Query = uri.Query,
        };
    }
}