
namespace MessageObj {
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class MessageList {
        [JsonProperty("messages")]
        public Message[] Messages { get; set; }
    }

    public partial class Message {
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        private long _TimestampMs;
        [JsonProperty("timestamp_ms")]
        public long TimestampMs {
            get { return _TimestampMs; }
            set { MessageReceivedTime = TimespampConverter(value); _TimestampMs=value; }
        }

        public DateTime MessageReceivedTime { get; set; }
           

        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("photos", NullValueHandling = NullValueHandling.Ignore)]
        public Photo[] Photos { get; set; }

        [JsonProperty("reactions", NullValueHandling = NullValueHandling.Ignore)]
        public ReactionElement[] Reactions { get; set; }

        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public Share Share { get; set; }

        [JsonProperty("videos", NullValueHandling = NullValueHandling.Ignore)]
        public Video[] Videos { get; set; }

        [JsonProperty("gifs", NullValueHandling = NullValueHandling.Ignore)]
        public Sticker[] Gifs { get; set; }

        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public User[] Users { get; set; }

        [JsonProperty("sticker", NullValueHandling = NullValueHandling.Ignore)]
        public Sticker Sticker { get; set; }

        public static DateTime TimespampConverter(double timestamp) {

            timestamp /= 1000;
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (long)(timestamp * TimeSpan.TicksPerSecond);
            return new DateTime(unixStart.Ticks + unixTimeStampInTicks, System.DateTimeKind.Utc);


        }


    }

    public partial class Sticker {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public partial class Photo {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("creation_timestamp")]
        public long CreationTimestamp { get; set; }
    }

    public partial class ReactionElement {
        [JsonProperty("reaction")]
        public string Reaction { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }
    }

    public partial class Share {
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Link { get; set; }

        [JsonProperty("share_text", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareText { get; set; }
    }

    public partial class User {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Video {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("creation_timestamp")]
        public long CreationTimestamp { get; set; }

        [JsonProperty("thumbnail")]
        public Sticker Thumbnail { get; set; }
    }


    public enum TypeEnum { Generic, Share, Subscribe, Unsubscribe };

    internal class TypeEnumConverter : JsonConverter {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer) {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value) {
                case "Generic":
                    return TypeEnum.Generic;
                case "Share":
                    return TypeEnum.Share;
                case "Subscribe":
                    return TypeEnum.Subscribe;
                case "Unsubscribe":
                    return TypeEnum.Unsubscribe;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer) {
            if (untypedValue == null) {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value) {
                case TypeEnum.Generic:
                    serializer.Serialize(writer, "Generic");
                    return;
                case TypeEnum.Share:
                    serializer.Serialize(writer, "Share");
                    return;
                case TypeEnum.Subscribe:
                    serializer.Serialize(writer, "Subscribe");
                    return;
                case TypeEnum.Unsubscribe:
                    serializer.Serialize(writer, "Unsubscribe");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
