using Amazon.Lambda.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SimpleLambda
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        //public void FunctionHandler(ILambdaContext context)
        //{
        //    context.Logger.LogInformation("Selamlar");
        //}

        //public void FunctionHandler(string person, ILambdaContext context)
        //{
        //    context.Logger.LogInformation($"Selamlar {person}");
        //}

        public void FunctionHandler(Person person, ILambdaContext context)
        {
            context.Logger.LogInformation($"Selamlar {person.FullName}");
        }
    }

    public class Person
    {
        public string FullName { get; set; } = default!;
    }
}