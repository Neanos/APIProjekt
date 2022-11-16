using System.Text.Json.Serialization;

public class Question
{
    [JsonPropertyName("answer")]
    public string Answer { get; set; }
    [JsonPropertyName("question")]
    public string Questions { get; set; }
    [JsonPropertyName("category")]
   public Category C {get; set;}
}
