

using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WinFormsApp11.Model
{
    public class Kur
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("TRY")]
        public Try Try { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("last_updated_at")]
        public DateTime LastUpdatedAt { get; set; }
    }


    public class Try
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }
    }


}
