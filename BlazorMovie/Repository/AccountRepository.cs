using BlazorMovie.Helpers;
using BlazorMovie.Shared.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Repository
{
    public class AccountRepository:IAccountRepository
    {
        private readonly IHttpService httpService;
        private readonly string baseURL = "Api/accounts";

        public AccountRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<UserToken> Register(UserInfo userInfo)
        {
            var httpResponse = await httpService.Post<UserInfo, UserToken>($"{baseURL}/Create", userInfo);
            if (!httpResponse.Success)
            {
                throw new ApplicationException(await httpResponse.GetBody());
            }
            return httpResponse.Response;
        }
        public async Task<UserToken> Login(UserInfo userInfo)
        {
            var httpResponse = await httpService.Post<UserInfo, UserToken>($"{baseURL}/Login", userInfo);
            if (!httpResponse.Success)
            {
                throw new ApplicationException(await httpResponse.GetBody());
            }
            return httpResponse.Response;
        }
    }
}
