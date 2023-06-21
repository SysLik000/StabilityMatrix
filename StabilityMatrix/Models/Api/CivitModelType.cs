﻿using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using StabilityMatrix.Extensions;

namespace StabilityMatrix.Models.Api;

[JsonConverter(typeof(JsonStringEnumConverter))]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public enum CivitModelType
{
    [ConvertTo<SharedFolderType>(SharedFolderType.StableDiffusion)]
    Checkpoint,
    [ConvertTo<SharedFolderType>(SharedFolderType.TextualInversion)]
    TextualInversion,
    [ConvertTo<SharedFolderType>(SharedFolderType.Hypernetwork)]
    Hypernetwork,
    AestheticGradient,
    [ConvertTo<SharedFolderType>(SharedFolderType.Lora)]
    LORA,
    [ConvertTo<SharedFolderType>(SharedFolderType.ControlNet)]
    Controlnet,
    Poses,
    [ConvertTo<SharedFolderType>(SharedFolderType.StableDiffusion)]
    Model,
    [ConvertTo<SharedFolderType>(SharedFolderType.LyCORIS)]
    LoCon,
    All,
}