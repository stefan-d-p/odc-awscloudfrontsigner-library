# AWS CloudFront Signing

This external logic connector for OutSystems Developer Cloud wraps AWS CloudFront SDK functions to generate signed URLs.

## GetCannedSignedUrl

Returns a signed URL that grants universal access to private content until a given date

### Input

* `DistributionDomainName` - The domain name of the distribution
* `ResourcePath` - The path for the resource
* `PrivateKey` - The private key for generating the signature.
* `KeyPairId` - The key pair id corresponding to the private key given
* `ExpiresOn` - The expiration date till which content can be accessed using the generated cookies

### Output

* `url` - CloudFront Canned Signed Url

## GetCustomSignedUrl

Returns a signed URL that provides tailored access to private content.

### Input

* `DistributionDomainName` - The domain name of the distribution
* `ResourcePath` - The path for the resource
* `PrivateKey` - The private key for generating the signature.
* `KeyPairId` - The key pair id corresponding to the private key given
* `ExpiresOn` - The expiration date till which content can be accessed using the generated cookies

### Output

* `Url` - Absolute URI of the signed URL
* `Path` - Absolute Path of the signed Url
* `Schema` - Scheme of the signed Url
* `Host` - Host of the signed Url
* `Query` - Query of the signed Url