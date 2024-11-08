using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.CloudFrontSigner
{
    [OSInterface(
        Name = "AWSCloudFrontSigner",
        Description = "Allows to generate CloudFront signed URLs and Cookies.",
        IconResourceName = "Without.Systems.CloudFrontSigner.Resources.CloudFront.png")]
    public interface ICloudFrontSigner
    {
        [OSAction(
            Description = "Returns a signed URL that grants universal access to private content until a given date",
            ReturnName = "url",
            ReturnDescription = "CloudFront Canned Signed Url",
            ReturnType = OSDataType.Text,
            IconResourceName = "Without.Systems.CloudFrontSigner.Resources.CloudFront.png")]
        string GetCannedSignedUrl(
            [OSParameter(
                DataType = OSDataType.InferredFromDotNetType,
                Description = "GetCookiesCannedPolicy Request Structure")]
            Structures.GetCannedSignedUrlRequest request);

        [OSAction(
            Description = "Returns a signed URL that provides tailored access to private content.",
            ReturnName = "response",
            ReturnDescription = "Structure containing the full url and its deconstructed parts.",
            ReturnType = OSDataType.InferredFromDotNetType,
            IconResourceName = "Without.Systems.CloudFrontSigner.Resources.CloudFront.png")]
        Structures.GetCustomSignedUrlResponse GetCustomSignedUrl(
            [OSParameter(
                DataType = OSDataType.InferredFromDotNetType,
                Description = "GetCustomSignedUrl Request Structure")]
            Structures.GetCustomSignedUrlRequest request);
    }
}