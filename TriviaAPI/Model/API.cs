using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace TriviaAPI.Model
{
    public class API
    {
        [JsonPropertyName("response_code")]
        public int ResCode { get; set; }

        [JsonPropertyName("results")]
        public Result[] Results { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("difficulty")]
        public string Difficulty { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("question")]
        public string Question { get; set; }

        [JsonPropertyName("correct_answer")]
        public string CorrAnswer { get; set; }

        [JsonPropertyName("incorrect_answers")]
        public string[] IncorrAnswers { get; set; }

    }
}
