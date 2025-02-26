// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_DeviceDataModels
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<deviceDataModelId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<deviceDataModelId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
                manufacturer = "<manufacturer>",
                productCode = "<productCode>",
                ports = new object[]
            {
new
{
name = "<name>",
type = "<type>",
}
            },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<deviceDataModelId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("ports")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("ports")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
                manufacturer = "<manufacturer>",
                productCode = "<productCode>",
                ports = new object[]
            {
new
{
name = "<name>",
type = "<type>",
}
            },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<deviceDataModelId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("ports")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("ports")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDeviceDataModel_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetDeviceDataModel("<sensorPartnerId>", "<deviceDataModelId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDeviceDataModel_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetDeviceDataModelAsync("<sensorPartnerId>", "<deviceDataModelId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDeviceDataModel_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetDeviceDataModel("<sensorPartnerId>", "<deviceDataModelId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("ports")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("ports")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDeviceDataModel_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetDeviceDataModelAsync("<sensorPartnerId>", "<deviceDataModelId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("ports")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("ports")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<deviceDataModelId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<deviceDataModelId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<deviceDataModelId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<deviceDataModelId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDeviceDataModels_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetDeviceDataModels("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDeviceDataModels_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetDeviceDataModelsAsync("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDeviceDataModels_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetDeviceDataModels("<sensorPartnerId>", new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("manufacturer").ToString());
                Console.WriteLine(result.GetProperty("productCode").ToString());
                Console.WriteLine(result.GetProperty("ports")[0].GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("ports")[0].GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDeviceDataModels_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            DeviceDataModels client = new FarmBeatsClient(credential).GetDeviceDataModelsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetDeviceDataModelsAsync("<sensorPartnerId>", new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("manufacturer").ToString());
                Console.WriteLine(result.GetProperty("productCode").ToString());
                Console.WriteLine(result.GetProperty("ports")[0].GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("ports")[0].GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
