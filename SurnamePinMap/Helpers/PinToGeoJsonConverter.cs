using Newtonsoft.Json;
using SurnamePinMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurnamePinMap.Helpers
{
    public class PinToGeoJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.Name.Equals("Pin");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var pin = value as Pin;
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteValue("Feature");
            writer.WritePropertyName("geometry");
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteValue("Point");
            writer.WritePropertyName("coordinates");
            writer.WriteStartArray();
            writer.WriteValue(pin.Latitude);
            writer.WriteValue(pin.Longitude);
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("FirstName");
            writer.WriteValue(pin.FirstName);
            writer.WritePropertyName("LastName");
            writer.WriteValue(pin.LastName);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}