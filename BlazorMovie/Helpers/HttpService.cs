﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorMovie.Helpers
{
    public class HttpService:IHttpService
    {
        private readonly HttpClient httpClient;

        public HttpService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        } 
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T data)
        {
            var datajson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(datajson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);
            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
        }

    }
}
