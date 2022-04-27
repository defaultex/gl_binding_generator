#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_1 || GL_VERSION_4_1 || GL_ARB_COMPUTE_SHADER || GL_VERSION_4_3 || GL_ES_VERSION_3_2 || GL_EXT_GEOMETRY_SHADER || GL_EXT_SEPARATE_SHADER_OBJECTS || GL_EXT_TESSELLATION_SHADER || GL_NV_MESH_SHADER || GL_OES_GEOMETRY_SHADER || GL_OES_TESSELLATION_SHADER)
[Flags]
public enum UseProgramStageMask : GLbitfield { 
    None = 0,
#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_1 || GL_VERSION_4_1)
    VertexShader = gl.Constants.GL_VERTEX_SHADER_BIT, 
#endif

#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_1 || GL_VERSION_4_1)
    FragmentShader = gl.Constants.GL_FRAGMENT_SHADER_BIT, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ComputeShader = gl.Constants.GL_COMPUTE_SHADER_BIT, 
#endif

#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_1 || GL_VERSION_4_1)
    AllShader = gl.Constants.GL_ALL_SHADER_BITS, 
#endif

#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_2 || GL_VERSION_4_1)
    GeometryShader = gl.Constants.GL_GEOMETRY_SHADER_BIT, 
#endif

#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_2 || GL_VERSION_4_1)
    TessControlShader = gl.Constants.GL_TESS_CONTROL_SHADER_BIT, 
#endif

#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_2 || GL_VERSION_4_1)
    TessEvaluationShader = gl.Constants.GL_TESS_EVALUATION_SHADER_BIT, 
#endif

#if GL_EXT_GEOMETRY_SHADER
    GeometryShaderBitExt = gl.Constants.GL_GEOMETRY_SHADER_BIT_EXT, 
#endif

#if GL_EXT_SEPARATE_SHADER_OBJECTS
    VertexShaderBitExt = gl.Constants.GL_VERTEX_SHADER_BIT_EXT, 
#endif

#if GL_EXT_SEPARATE_SHADER_OBJECTS
    FragmentShaderBitExt = gl.Constants.GL_FRAGMENT_SHADER_BIT_EXT, 
#endif

#if GL_EXT_SEPARATE_SHADER_OBJECTS
    AllShaderBitsExt = gl.Constants.GL_ALL_SHADER_BITS_EXT, 
#endif

#if GL_EXT_TESSELLATION_SHADER
    TessControlShaderBitExt = gl.Constants.GL_TESS_CONTROL_SHADER_BIT_EXT, 
#endif

#if GL_EXT_TESSELLATION_SHADER
    TessEvaluationShaderBitExt = gl.Constants.GL_TESS_EVALUATION_SHADER_BIT_EXT, 
#endif

#if GL_NV_MESH_SHADER
    MeshShaderBitNv = gl.Constants.GL_MESH_SHADER_BIT_NV, 
#endif

#if GL_NV_MESH_SHADER
    TaskShaderBitNv = gl.Constants.GL_TASK_SHADER_BIT_NV, 
#endif

#if GL_OES_GEOMETRY_SHADER
    GeometryShaderBitOes = gl.Constants.GL_GEOMETRY_SHADER_BIT_OES, 
#endif

#if GL_OES_TESSELLATION_SHADER
    TessControlShaderBitOes = gl.Constants.GL_TESS_CONTROL_SHADER_BIT_OES, 
#endif

#if GL_OES_TESSELLATION_SHADER
    TessEvaluationShaderBitOes = gl.Constants.GL_TESS_EVALUATION_SHADER_BIT_OES, 
#endif

}

#endif
