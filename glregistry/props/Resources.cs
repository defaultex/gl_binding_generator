namespace glregistry;

public static partial class Resources {
    public const string FormatCommandCdecl = "{1} {0}({2});";
    public const string FormatCommandCSdecl = "delegate* unmanaged[Cdecl]<{2}{1}> {0};";
    public const string FormatCommandParam = "{0}, ";
    public const string FormatPtrType = "{0}{1}";
    public const string FormatDecl = "{0} {1}";
    public const string FormatObjType = "GL{0}";

    public static readonly string[] Base10Digits = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public static readonly string[] DimensionSpec = new[] { "1D", "2D", "3D", "4D" };
    public static readonly string[] SkipWords = new[] { "BIT", "BITS" };

    // note to code monkey: try to keep these sorted based on dict-value
    public static readonly Dictionary<string, string> MergeGroups = new() {
        // { "From" , "To" },
        { "AtomicCounterBufferPName", "AtomicCounterBufferParameter" },

        { "BlendEquationModeEXT", "BlendEquationMode" },

        { "BufferAccessARB", "BufferAccess" },

        { "BufferPNameARB", "BufferParameter" },

        { "BufferPointerNameARB", "BufferPointerParameter" },

        { "CopyBufferSubDataTarget", "BufferTarget" },

        { "BufferTargetARB", "BufferTarget" },
        { "BufferStorageTarget", "BufferTarget" },

        { "BufferUsageARB", "BufferUsage" },
        { "VertexBufferObjectUsage" , "BufferUsage" },

        { "DrawBufferMode", "ColorBuffer" },
        { "ReadBufferMode", "ColorBuffer" },

        { "ClampColorModeARB", "ClampColorMode" },

        { "ClampColorTargetARB", "ClampColorTarget" },

        { "AttribMask", "ClearBufferMask" },

        { "DepthFunction", "CompareFunction" },
        { "AlphaFunction", "CompareFunction" },

        { "TextureCompareMode", "CompareMode" },

        { "BinormalPointerTypeEXT", "DataType" },

        { "DrawElementsType", "ElementType" },

        { "CullFaceMode", "FaceDirection" },
        { "StencilFaceDirection", "FaceDirection" },

        { "InvalidateFramebufferAttachment", "FramebufferAttachment" },

        { "FramebufferAttachmentParameterName", "FramebufferAttachmentParameter" },

        { "FramebufferParameterName", "FramebufferParameter" },
        { "GetFramebufferParameter", "FramebufferParameter" },

        { "EnableCap", "GLCapability" },

        { "ErrorCode", "GLError" },

        { "GetPName", "GLParameter" },

        { "StringName", "GLString" },

        { "CopyImageSubDataTarget", "ImageSubDataTarget" },

        { "InternalFormatPName", "InternalFormatParameter" },

        { "TextureMinFilter", "MinFilter" },
        { "TextureMagFilter", "MagFilter" },
        { "BlitFramebufferFilter", "MagFilter" },

        { "GetMultisamplePNameNV", "MultisampleParameter" },

        { "PatchParameterName", "PatchParameter" },

        { "PipelineParameterName", "PipelineParameter" },

        { "PointParameterNameARB", "PointParameter" },

        { "GetPointervPName", "PointerParameter" },

        { "ProgramInterfacePName", "ProgramInterfaceParameter" },

        { "ProgramPropertyARB", "ProgramProperty" },

        { "ProgramParameterPName", "ProgramParameterParameter" },

        { "UseProgramStageMask", "ProgramStageMask" },

        { "ProgramStagePName", "ProgramStageParameter" },

        { "QueryObjectParameterName", "QueryObjectParameter" },

        { "QueryParameterName", "QueryParameter" },

        { "RenderbufferParameterName", "RenderbufferParameter" },

        { "SamplerParameterI", "SamplerParameter" },
        { "SamplerParameterF", "SamplerParameter" },

        { "ShaderParameterName", "ShaderParameter" },

        { "SubroutineParameterName", "SubroutineParameter" },

        { "SyncParameterName", "SyncParameter" },

        { "GetTextureParameter", "TextureParameter" },
        { "TextureParameterName", "TextureParameter" },

        { "TransformFeedbackPName", "TransformFeedbackParameter" },

        { "UniformPName", "UniformParameter" },

        { "UniformBlockPName", "UniformBlockParameter" },

        { "VertexArrayPName", "VertexArrayParameter" },

        { "VertexAttribEnum", "VertexAttribProperty" },
        { "VertexAttribPropertyARB", "VertexAttribProperty" },

        { "VertexAttribPointerPropertyARB", "VertexAttribPointerProperty" },

        { "VertexAttribPointerType", "VertexAttribType" },
        { "VertexAttribIType", "VertexAttribType" },
        { "VertexAttribLType", "VertexAttribType" },

        { "FrontFaceDirection", "WindingOrder" },

        { "TextureWrapMode", "WrapMode" },
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

    // types that are not explicitly required, but are actually needed
    public static readonly string[] AlwaysRequire = new[] { 
        "TextureMinFilter",
        "TextureWrapMode",
        "TextureCompareMode"
    };

    public static bool IsGroupBlacklisted(string name) => GroupBlacklist.Contains(name);

    public static bool IsPrototypeGroupBlacklisted(string name) => PrototypeGroupBlacklist.Contains(name);

    public static string GetGroupName(string groupName) => MergeGroups.ContainsKey(groupName) ? Resources.MergeGroups[groupName] : groupName;

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