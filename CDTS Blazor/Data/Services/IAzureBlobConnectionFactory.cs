﻿using Microsoft.Azure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDNApplication.Data.Services
{
    public interface IAzureBlobConnectionFactory
    {

        Task<CloudBlobContainer> GetBlobContainer(string container = null);

    }
}