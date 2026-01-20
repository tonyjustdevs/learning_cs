using static System.Console;

HttpClient client = new();

HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");

WriteLine("Apple's home page has {0:N0} bytes.",
  response.Content.Headers.ContentLength);

WriteLine("Headers Content: \n{0:N0}",
  response.Content.Headers);