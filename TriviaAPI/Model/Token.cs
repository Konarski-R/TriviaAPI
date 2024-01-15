using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace TriviaAPI.Model
{
	public class Token
	{
		[JsonPropertyName("response_code")]
		public int ResCode { get; set; }

		[JsonPropertyName("response_message")]
		public string ResMess { get; set; }

		[JsonPropertyName("token")]
		public string Toke { get; set; }
	}
}
