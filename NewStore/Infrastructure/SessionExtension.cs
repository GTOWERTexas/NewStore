using Microsoft.AspNetCore.Http;
using System.Text.Json;


namespace NewStore.Infrastructure
{   // Эти методы сериализуют объекты в формат JSON, поскольку средство состояния сеанса в ASPNET Core хранит только значения int, string, byte[]
    public static class SessionExtension
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
