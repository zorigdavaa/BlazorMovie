using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorMovie.Helpers
{
    public class HttpResponseWrapper<T>
    {
        #region Ctor
        public HttpResponseWrapper(T respone, bool success, HttpResponseMessage httpResponseMessage)
        {
            Response = respone;
            Success = success;
            HttpResponseMessage = httpResponseMessage;
        }
        #endregion

        #region Properties
        public bool Success { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
        #endregion

        #region Methods
        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
        #endregion
    }
}
