public interface IFhirServer
{
    string GetBasedUrl();
    string GetAccessToken();
    bool IsExpired();
}