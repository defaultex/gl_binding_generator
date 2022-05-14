namespace glregistry;

public static partial class Resources {
    public const string FormatCommandCdecl = "{1} {0}({2});";
    public const string FormatCommandCSdecl = "        public static unsafe delegate* unmanaged[Cdecl]<{2}{1}> {0};";
    public const string FormatCommandParam = "{0}, ";
    public const string FormatType = "{0}{1}";

    public static readonly string[] Base10Digits = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public static readonly string[] DimensionSpec = new[] { "1D", "2D", "3D", "4D" };
    public static readonly string[] SkipWords = new[] { "BIT", "BITS" };

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

    public static readonly string[] GroupBlacklist = new[] { 
        "Boolean",
        "SpecialNumbers",
    };

    public static bool IsGroupBlacklisted(string name) => GroupBlacklist.Contains(name);

    public static bool IsPrototypeGroupBlacklisted(string name) => PrototypeGroupBlacklist.Contains(name);

    public static int CompareEnumerants(GLEnum x, GLEnum y) {
        long xval = x.Value.Contains('-') ? Convert.ToInt64(x.Value) : Convert.ToInt64(x.Value, 16);
        long yval = y.Value.Contains('-') ? Convert.ToInt64(y.Value) : Convert.ToInt64(y.Value, 16);
        int xycomp = xval.CompareTo(yval);
        // when values are equal, compare on name
        return (xycomp == 0) ? x.Name.CompareTo(y.Name) : xycomp;
    }

    public static int CompareCommands(GLCommand x, GLCommand y) => x.Name.CompareTo(y.Name);

    public static int CompareGroups(GLGroup x, GLGroup y) => x.Name.CompareTo(y.Name);
}