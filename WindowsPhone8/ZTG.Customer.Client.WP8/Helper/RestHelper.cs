﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using RestSharp;

namespace ZTG.Customer.Client.WP8.Helper
{
    public class RestHelper
    {
        private RestClient _restClient;

        public RestHelper(string baseUrl)
        {
            _restClient = new RestClient(baseUrl);
            _restClient.AddHandler("application/json", new CustomJsonDeserializer());
        }

        public void Get<T>(Action<T> callback) where T : class, new()
        {
            var noCaching = "?rand=" + DateTime.Now.Ticks.ToString(); // workaround to not cache
            var request = new RestRequest(Settings.CustomerUrl + noCaching, Method.GET);
            
            request.AddParameter("cache-control", "no-cache", ParameterType.HttpHeader);
            _restClient.ExecuteAsync<T>(request, response =>
                {
                    HandleResponse<T>(response);
                    callback(response.Data);
                });
        }

        public void Put<T>(T obj)
        {
            var putRequest = new RestRequest(Settings.CustomerUrl, Method.PUT) {RequestFormat = DataFormat.Json};
            putRequest.JsonSerializer = new CustomJsonSerializer();
            putRequest.AddBody(obj);
            _restClient.ExecuteAsync(putRequest, HandleResponse<T>);
        }

        public void Delete<T>(int id)
        {
            var putRequest = new RestRequest(Settings.CustomerUrl + @"/" + id, Method.DELETE);
            _restClient.ExecuteAsync(putRequest, HandleResponse<T>);
        }

        public void Post<T>(T obj)
        {
            var putRequest = new RestRequest(Settings.CustomerUrl, Method.POST) { RequestFormat = DataFormat.Json };
            putRequest.JsonSerializer = new CustomJsonSerializer();
            putRequest.AddBody(obj);
            _restClient.ExecuteAsync(putRequest, HandleResponse<T>);
        }

        private void HandleResponse<T>(IRestResponse response)
        {
            if (response.ErrorException != null)
            {
                Debug.WriteLine(response.ErrorException);
            }
            if (response.ErrorMessage != null)
            {
                Debug.WriteLine(response.ErrorMessage);
            }
        }
    }
}
