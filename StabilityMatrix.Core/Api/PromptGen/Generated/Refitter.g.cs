// <auto-generated>
//     This code was generated by Refitter.
// </auto-generated>


using Refit;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

#nullable enable annotations

namespace StabilityMatrix.Core.Api.PromptGenApi
{
    [System.CodeDom.Compiler.GeneratedCode("Refitter", "1.4.1.0")]
    public partial interface IPromptGenApi
    {
        /// <summary>Get current user's token balance</summary>
        /// <remarks>Retrieves the token balance for the currently authenticated user.</remarks>
        /// <returns>Payload of TokenBalance</returns>
        /// <exception cref="ApiException">Thrown when the request returns a non-success status code.</exception>
        [Headers("Accept: application/json")]
        [Get("/account/me/tokens")]
        Task<TokenBalance> AccountMeTokens();

        /// <summary>Expand a prompt</summary>
        /// <remarks>Expand a prompt using the OpenAI Chat API.</remarks>
        /// <param name="body">The prompt to expand.</param>
        /// <returns>Payload of PromptExpansionResponse</returns>
        /// <exception cref="ApiException">Thrown when the request returns a non-success status code.</exception>
        [Headers("Accept: application/json")]
        [Post("/expand-prompt")]
        Task<PromptExpansionResponse> ExpandPrompt([Body] PromptExpansionRequest body);


    }

}

//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 649 // Disable "CS0649 Field is never assigned to, and will always have its default value null"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"
#pragma warning disable 8625 // Disable "CS8625 Cannot convert null literal to non-nullable reference type"
#pragma warning disable 8765 // Disable "CS8765 Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes)."

namespace StabilityMatrix.Core.Api.PromptGenApi
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PromptEnhanceResponse
    {

        [JsonPropertyName("positivePrompt")]
        public string PositivePrompt { get; set; }

        [JsonPropertyName("negativePrompt")]
        public string NegativePrompt { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PromptExpansionRequest
    {

        [JsonPropertyName("prompt")]
        public PromptToEnhance Prompt { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("seed")]
        public long? Seed { get; set; }

        [JsonPropertyName("mode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PromptExpansionRequestMode Mode { get; set; } = StabilityMatrix.Core.Api.PromptGenApi.PromptExpansionRequestMode.Focused;

        [JsonPropertyName("clientOverride")]
        public string ClientOverride { get; set; }

        [JsonPropertyName("modelTags")]

        // TODO(system.text.json): Add string enum item converter
        public ICollection<ModelTags> ModelTags { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PromptExpansionResponse
    {

        [JsonPropertyName("availableTokens")]
        public int AvailableTokens { get; set; }

        [JsonPropertyName("operationId")]
        public string OperationId { get; set; }

        [JsonPropertyName("response")]
        public PromptEnhanceResponse Response { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PromptToEnhance
    {

        [JsonPropertyName("positivePrompt")]
        public string PositivePrompt { get; set; }

        [JsonPropertyName("negativePrompt")]
        public string NegativePrompt { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TokenBalance
    {

        [JsonPropertyName("available")]
        public int Available { get; set; }

        [JsonPropertyName("used")]
        public int Used { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PromptExpansionRequestMode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Focused")]
        Focused = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Balanced")]
        Balanced = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Imaginative")]
        Imaginative = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ModelTags
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Flux")]
        Flux = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Pony")]
        Pony = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Sdxl")]
        Sdxl = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Illustrious")]
        Illustrious = 3,

    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604
#pragma warning restore 8625