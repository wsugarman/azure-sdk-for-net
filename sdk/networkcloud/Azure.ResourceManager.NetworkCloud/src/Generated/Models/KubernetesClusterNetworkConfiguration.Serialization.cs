// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class KubernetesClusterNetworkConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AttachedNetworkConfiguration))
            {
                writer.WritePropertyName("attachedNetworkConfiguration"u8);
                writer.WriteObjectValue(AttachedNetworkConfiguration);
            }
            if (Optional.IsDefined(BgpServiceLoadBalancerConfiguration))
            {
                writer.WritePropertyName("bgpServiceLoadBalancerConfiguration"u8);
                writer.WriteObjectValue(BgpServiceLoadBalancerConfiguration);
            }
            writer.WritePropertyName("cloudServicesNetworkId"u8);
            writer.WriteStringValue(CloudServicesNetworkId);
            writer.WritePropertyName("cniNetworkId"u8);
            writer.WriteStringValue(CniNetworkId);
            if (Optional.IsDefined(DnsServiceIP))
            {
                writer.WritePropertyName("dnsServiceIp"u8);
                writer.WriteStringValue(DnsServiceIP.ToString());
            }
            if (Optional.IsCollectionDefined(PodCidrs))
            {
                writer.WritePropertyName("podCidrs"u8);
                writer.WriteStartArray();
                foreach (var item in PodCidrs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceCidrs))
            {
                writer.WritePropertyName("serviceCidrs"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceCidrs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KubernetesClusterNetworkConfiguration DeserializeKubernetesClusterNetworkConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AttachedNetworkConfiguration> attachedNetworkConfiguration = default;
            Optional<BgpServiceLoadBalancerConfiguration> bgpServiceLoadBalancerConfiguration = default;
            ResourceIdentifier cloudServicesNetworkId = default;
            ResourceIdentifier cniNetworkId = default;
            Optional<IPAddress> dnsServiceIP = default;
            Optional<IList<string>> podCidrs = default;
            Optional<IList<string>> serviceCidrs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attachedNetworkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attachedNetworkConfiguration = AttachedNetworkConfiguration.DeserializeAttachedNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("bgpServiceLoadBalancerConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bgpServiceLoadBalancerConfiguration = BgpServiceLoadBalancerConfiguration.DeserializeBgpServiceLoadBalancerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("cloudServicesNetworkId"u8))
                {
                    cloudServicesNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cniNetworkId"u8))
                {
                    cniNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsServiceIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dnsServiceIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("podCidrs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    podCidrs = array;
                    continue;
                }
                if (property.NameEquals("serviceCidrs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    serviceCidrs = array;
                    continue;
                }
            }
            return new KubernetesClusterNetworkConfiguration(attachedNetworkConfiguration.Value, bgpServiceLoadBalancerConfiguration.Value, cloudServicesNetworkId, cniNetworkId, dnsServiceIP.Value, Optional.ToList(podCidrs), Optional.ToList(serviceCidrs));
        }
    }
}
