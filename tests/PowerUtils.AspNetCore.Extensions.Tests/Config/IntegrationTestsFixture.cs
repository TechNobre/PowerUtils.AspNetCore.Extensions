﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.Testing;
using PowerUtils.AspNetCore.ErrorHandler.Samples;
using Xunit;

namespace PowerUtils.AspNetCore.Extensions.Tests.Config
{
    [CollectionDefinition(nameof(IntegrationApiTestsFixtureCollection))]
    public class IntegrationApiTestsFixtureCollection : ICollectionFixture<IntegrationTestsFixture> { }

    public class IntegrationTestsFixture : IDisposable
    {
        public HttpClient Client;

        private readonly WebApplicationFactory<Startup> _factory;

        public IntegrationTestsFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions();

            _factory = new WebApplicationFactory<Startup>();

            Client = _factory.CreateClient(clientOptions);
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
        }

        public void Dispose()
        {
            Client.Dispose();

            _factory.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
