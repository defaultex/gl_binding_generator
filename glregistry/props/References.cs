namespace glregistry;

public static partial class References {
    public static readonly string[] RemoveGroups = new string[] { 
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
}