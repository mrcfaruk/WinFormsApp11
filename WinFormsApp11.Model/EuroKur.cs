using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WinFormsApp11.Model
{
    public class EuroKur
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
    public class Data2
    {
        [JsonPropertyName("TRY")]
        public Try2 Try2 { get; set; }
    }

    public class Meta2
    {
        [JsonPropertyName("last_updated_at")]
        public DateTime LastUpdatedAt { get; set; }
    }



    public class Try2
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }
    }


}
