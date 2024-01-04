using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace Webdock.Extensions;

public static class JsonNetSerializerExtensions
{
    public static RestClient UseJsonNetSerializer(this RestClient client)
    {
        client.UseSerializer(() => new JsonNetSerializer());
        return client;
    }
}