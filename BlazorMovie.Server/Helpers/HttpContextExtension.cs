using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Server.Helpers
{
    public static class HttpContextExtension
    {
        public static async Task InsertPaginationParameterInResponse<T>(this HttpContext httpContext, 
                            IQueryable<T> queryAble, int recordsPerPage )
        {
            if (httpContext==null)
            {
                throw new ArgumentNullException(nameof(HttpContext));
            }

            double count = await queryAble.CountAsync();
            double totalAmountPages = Math.Ceiling(count / recordsPerPage);
            httpContext.Response.Headers.Add("totalAmountPages", totalAmountPages.ToString());
        }
    }
}
