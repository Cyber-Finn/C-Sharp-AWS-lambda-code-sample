# C-Sharp Lambda_Production ready template

## Description:
I created a production-ready aws lambda template, using C#.
<br>
There are currently no up-to-date docs of how to do this in AWS.

## Usage:
1. Clone and change whatever you need to, then build. 
2. Create a new aws lambda (from either terraform or the AWS console) and upload the code .zip to it
3. Create an API Gateway that will call this lambda function, and test

## Why this is awesome:
It allows us to take existing services (Such as legacy APIs/Webservices) and host them in lambdas - using C#.
The use case for this is to simply use the sample to build up your system/api functionality, then host the app in the lambda.
There are no accurate docs of how to host a C# REST API in a lambda, so this should be invaluable to anyone looking for samples of how to do this
