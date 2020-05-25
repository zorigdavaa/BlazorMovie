﻿using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Server.Helpers
{

    public class InAppStorageService : IFileStorageService
    {
        private readonly IWebHostEnvironment env;
        public readonly IHttpContextAccessor httpContextAccessor;
        public InAppStorageService(IWebHostEnvironment env, 
                                    IHttpContextAccessor httpContextAccessor
                                    )
        {
            this.env = env;
            this.httpContextAccessor = httpContextAccessor;
        }

        

        public Task DeleteFile(string fileRoute, string containerName)
        {
            var filename = Path.GetFileName(fileRoute);
            string fileDirectory = Path.Combine(env.WebRootPath, containerName, filename);
            if (File.Exists(fileDirectory))
            {
                File.Delete(fileDirectory);
            }
            return Task.FromResult(0);
        }

        public async Task<string> EditFile(byte[] content, string extension, string containerName, string fileRoute)
        {
            if (!string.IsNullOrEmpty(fileRoute))
            {
                await DeleteFile(fileRoute, containerName);
            }
            return await SaveFile(content, extension, containerName);
        }

        public async Task<string> SaveFile(byte[] content, string extension, string containerName)
        {
            var filename = $"{Guid.NewGuid()}.{extension}";
            string folder = Path.Combine(env.WebRootPath, containerName);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            string savingPath = Path.Combine(folder, filename);
            await File.WriteAllBytesAsync(savingPath, content);
            var currentUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}";
            var test = $"{httpContextAccessor.HttpContext.Request.PathBase.Value} %% {httpContextAccessor.HttpContext.Request.Path}";
            var pathForDatabase = Path.Combine(currentUrl, containerName, filename);
            return pathForDatabase;
        }
    }
}
