Domain and IP Pinger API
============

Pinger is a simple tool for checking if a URL is up. It returns a boolean value indicating whether the URL is up or not.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Domain and IP Pinger API](https://apiverve.com/marketplace/api/pinger)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.DomainandIPPinger
```

Using the Package Manager:
```
nuget install APIVerve.API.DomainandIPPinger
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.DomainandIPPinger
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.DomainandIPPinger".
5. Click on the APIVerve.API.DomainandIPPinger package, click Install.


---

## Configuration

Before using the pinger API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Domain and IP Pinger API documentation is found here: [https://docs.apiverve.com/api/pinger](https://docs.apiverve.com/api/pinger).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Domain and IP Pinger API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new DomainandIPPingerAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new DomainandIPPingerQueryOptions {
  host = "google.com",
  retries = 1
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "host": "google.com",
    "numericHost": "2607:f8b0:4001:c1d::64",
    "alive": true,
    "roundTrips": 3,
    "packetLoss": 0,
    "minMS": 1.3,
    "avgMS": 25.373333333333335,
    "maxMS": 72.9,
    "stdDev": 33.607381464328476,
    "times": [
      72.9,
      1.3,
      1.92
    ]
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.