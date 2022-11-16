using RestSharp;
using System.Text.Json;
using System.Net;
RestClient JeopardyClient = new("https://jservice.io/");
RestRequest request = new("api/random");
int points = 0;

while (true)
{

    RestResponse response = JeopardyClient.GetAsync(request).Result;

    if (response.StatusCode == HttpStatusCode.OK)
    {
        Console.Clear();
        Question q = JsonSerializer.Deserialize<Question[]>(response.Content)[0];
        Console.WriteLine(q.C.Title);
        Console.WriteLine(q.Questions);
        string playerAnswer = Console.ReadLine();
        if (playerAnswer == q.Answer)
        {
            Console.WriteLine("Correct");
            points++;
            Console.WriteLine($"Points:{points}");
        }
        else
        {
            Console.WriteLine("Wrong");
            Console.WriteLine("Answer:{0}",q.Answer);
        }
    }
    Console.ReadLine();
}


//Console.WriteLine(response.Content);

