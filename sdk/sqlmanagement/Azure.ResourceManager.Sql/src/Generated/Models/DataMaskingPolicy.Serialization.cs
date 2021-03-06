// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class DataMaskingPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DataMaskingState))
            {
                writer.WritePropertyName("dataMaskingState");
                writer.WriteStringValue(DataMaskingState.Value.ToSerialString());
            }
            if (Optional.IsDefined(ExemptPrincipals))
            {
                writer.WritePropertyName("exemptPrincipals");
                writer.WriteStringValue(ExemptPrincipals);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataMaskingPolicy DeserializeDataMaskingPolicy(JsonElement element)
        {
            Optional<string> location = default;
            Optional<string> kind = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<DataMaskingState> dataMaskingState = default;
            Optional<string> exemptPrincipals = default;
            Optional<string> applicationPrincipals = default;
            Optional<string> maskingLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataMaskingState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataMaskingState = property0.Value.GetString().ToDataMaskingState();
                            continue;
                        }
                        if (property0.NameEquals("exemptPrincipals"))
                        {
                            exemptPrincipals = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationPrincipals"))
                        {
                            applicationPrincipals = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maskingLevel"))
                        {
                            maskingLevel = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataMaskingPolicy(id.Value, name.Value, type.Value, location.Value, kind.Value, Optional.ToNullable(dataMaskingState), exemptPrincipals.Value, applicationPrincipals.Value, maskingLevel.Value);
        }
    }
}
