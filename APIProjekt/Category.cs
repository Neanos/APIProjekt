using System.Text.Json.Serialization;

public class Category
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
    
}
