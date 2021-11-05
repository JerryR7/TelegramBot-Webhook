using System;
using NotifyTaskAPI.Models.ValueObjects.Request;
using RestSharp;

namespace NotifyTaskAPI.Models
{
    public static class UrlTool
    {
        public static ResponseStatus Send(string url, BotMessageRequest botMessage)
        {
            var request = new RestRequest(url, Method.GET);
            request.AddObject(botMessage);

            return Execute(request);
        }

        private static ResponseStatus Execute(IRestRequest request)
        {
            var client = new RestClient();
            var response = client.Execute(request);

            if (response.ErrorException == null) return response.ResponseStatus;

            var message = response.Content;
            var exception = new ApplicationException(message, response.ErrorException);
            throw exception;
        }
    }
}