# C-Sharp AWS Lambda code sample template

## Description:
This is a production-ready aws lambda template for C#.
<br>
There are also currently no up-to-date docs of how to host C# .net core Web APIs in AWS (all the docs I found seemed to lead to nowhere after installing a bunch of random 3rd party libraries), which I hope to resolve with this sample.

## Why this is awesome:
Besides being one of the only accurate (and simple!) examples of how to actually run C# in AWS,
<br>
it also allows us to take existing services (Such as legacy APIs/Webservices) and host them in lambdas (which are scalable) as well - using C# (This is a massive benefit if you have a team of .net Developers, because they can use the language they already know to work in the cloud).
<br>
In this case, you'd simply port portions of your application's business logic functionality into this template, then set up the API Gateway to call your handler when it receives a specific HTTP method (Post or Get, etc.).
<br> 
Essentially, you'd be removing the entry-points into your old system (your external facing methods, like "HTTPGet" methods, for example), porting the business-logic as-is into the template (if done in C#), and then setting up the API Gateway to act as a new entry-point into your system (this provides its own "HTTPGet" methods, etc. - which you can map!).

## Usage:
1. Clone and change whatever you need, then zip the app code. 
2. Create a new aws lambda (from either terraform or the AWS console) and upload the code .zip to it
3. Create an API Gateway that will call this lambda function, and test
