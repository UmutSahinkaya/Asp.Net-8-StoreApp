﻿using System.Text.Json;

namespace StoreApp.Web.Helpers
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session,string key,object value)
        {
            session.SetJson(key, JsonSerializer.Serialize(value));
        }

        public static T? GetJson<T>(this ISession session,string key)
        {
            var sessionData=session.GetString(key);
            return sessionData== null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
