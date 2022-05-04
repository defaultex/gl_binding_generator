namespace glregistry;

public static partial class Resources {
    public const string FormatCommandCdecl = "{1} {0}({2});";
    public const string FormatCommandCSdecl = "delegate* unmanaged[Cdecl]<{2}{1}> {0};";
    public const string FormatCommandParam = "{0}, ";
    public const string FormatType = "{0}{1}";

    public static readonly string[] PrototypeGroupBlacklist = new[] {
        "Boolean",
        "handleARB",
        "String",
        "vdpauSurfaceNV",
        "Half16NV",
        "WinCoord",
        "CoordF",
        "ClampedFixed",
        "BufferOffset",
        "BufferSize",
        "BufferOffsetARB",
        "CoordD",
        "ColorF",
        "BufferSizeARB",
        "List",
        "DrawBufferName",
        "ClampedFloat32",
        "MaskedColorIndexValueF",
        "StencilValue",
        "ColorB", 
        "ColorD", 
        "ColorI", 
        "ColorS", 
        "ColorUB", 
        "ColorUI", 
        "ColorUS", 
        "CheckedFloat32", 
        "CheckedInt32", 
        "CompressedTextureARB", 
        "Path", 
        "PathElement", 
        "FenceNV", 
        "ClampedFloat64", 
        "BooleanPointer", 
        "FeedbackElement", 
        "PathCommand", 
        "ProgramCharacterNV", 
        "MaskedColorIndexValueI", 
        "ColorIndexValueD", 
        "ColorIndexValueF", 
        "ColorIndexValueI", 
        "ColorIndexValueS", 
        "ColorIndexValueUB", 
        "MaskedStencilValue", 
        "LineStipple", 
        "SelectName", 
        "CoordI", 
        "CoordS", 
        "ClampedStencilValue", 
        "ReplacementCodeSUN", 
        "SampleMaskNV"
    };

    public static readonly string[] RemoveGroups = new[] {
        "Boolean",
    };

    public static readonly Dictionary<string, string> MergeGroups = new() {
        // { "From" , "To" },
        { "BufferUsageARB", "BufferUsage" },
        { "VertexBufferObjectUsage" , "BufferUsage" },

        { "BufferStorageTarget", "BufferTarget" },

        { "DepthFunction", "CompareFunction" },
        { "AlphaFunction", "CompareFunction" },

        { "SamplerParameterI", "SamplerParameter" },
        { "SamplerParameterF", "SamplerParameter" },

        { "TextureMinFilter", "MinFilter" },
        { "TextureMagFilter", "MagFilter" },

        { "VertexAttribPointerType", "VertexAttribType" },
        { "VertexAttribIType", "VertexAttribType" },
        { "VertexAttribLType", "VertexAttribType" },
    };

    public static bool IsPrototypeGroupBlacklisted(string name) {
        for (int i = 0; i < PrototypeGroupBlacklist.Length; i++) {
            if (PrototypeGroupBlacklist[i] == name) {
                return true;
            }
        }
        return false;
    }
}