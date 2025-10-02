
HttpClient client = new();

HttpResponseMessage response = 
    await client.GetAsync("https://www.apple.com");


Console.WriteLine("http_response: {0:N0} bytes", response.Content.Headers.ContentLength);
//http_response: 215,626 bytes
