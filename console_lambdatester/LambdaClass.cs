using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace console_lambdatester
{
    internal class LambdaClass
    {
        public APIGatewayProxyResponse handler(APIGatewayProxyRequest request)
        {

            APIGatewayProxyResponse response = new APIGatewayProxyResponse();

            switch (request.HttpMethod)
            {
                case "GET":

                    string name = request.QueryStringParameters["name"];

                if(name != "") 
                {
                        response = new APIGatewayProxyResponse() { Body = "Hey " + name + " welcome! ", StatusCode = 200 };
                }
                else
                {
                    response = new APIGatewayProxyResponse() { Body = "Error: Query Parameter name missing", StatusCode = 200 };
                }
                break;
            }

            response.Body = request.QueryStringParameters["name"];
            return response;
        }
    }
}
