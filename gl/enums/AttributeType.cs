#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_ANGLE_DEPTH_TEXTURE || GL_OES_DEPTH_TEXTURE || GL_OES_ELEMENT_INDEX_UINT || GL_ARB_VERTEX_SHADER || GL_OES_TEXTURE_FLOAT || GL_VERSION_ES_CM_1_0 || GL_VERSION_2_0 || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_2_1 || GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2 || GL_ARB_TEXTURE_MULTISAMPLE || GL_VERSION_3_2 || GL_ES_VERSION_3_2 || GL_VERSION_3_1 || GL_VERSION_4_0 || GL_ARB_GPU_SHADER_FP64 || GL_EXT_VERTEX_ATTRIB_64BIT || GL_VERSION_1_1 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_AMD_GPU_SHADER_INT64 || GL_NV_GPU_SHADER5 || GL_NV_VERTEX_ATTRIB_INTEGER_64BIT || GL_ARB_BINDLESS_TEXTURE || GL_ARB_GPU_SHADER_INT64 || GL_ARB_SHADER_OBJECTS || GL_EXT_SHADOW_SAMPLERS || GL_NV_NON_SQUARE_MATRICES || GL_OES_TEXTURE_3D)

public enum AttributeType : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0)
    Int = gl.Constants.GL_INT, 
#endif

#if (GL_ANGLE_DEPTH_TEXTURE || GL_ES_VERSION_2_0 || GL_OES_DEPTH_TEXTURE || GL_OES_ELEMENT_INDEX_UINT || GL_SC_VERSION_2_0 || GL_VERSION_1_0)
    UnsignedInt = gl.Constants.GL_UNSIGNED_INT, 
#endif

#if (GL_ARB_VERTEX_SHADER || GL_ES_VERSION_2_0 || GL_OES_TEXTURE_FLOAT || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Float = gl.Constants.GL_FLOAT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    FloatVec2 = gl.Constants.GL_FLOAT_VEC2, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    FloatVec3 = gl.Constants.GL_FLOAT_VEC3, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    FloatVec4 = gl.Constants.GL_FLOAT_VEC4, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    IntVec2 = gl.Constants.GL_INT_VEC2, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    IntVec3 = gl.Constants.GL_INT_VEC3, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    IntVec4 = gl.Constants.GL_INT_VEC4, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    Bool = gl.Constants.GL_BOOL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    BoolVec2 = gl.Constants.GL_BOOL_VEC2, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    BoolVec3 = gl.Constants.GL_BOOL_VEC3, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    BoolVec4 = gl.Constants.GL_BOOL_VEC4, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    FloatMat2 = gl.Constants.GL_FLOAT_MAT2, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    FloatMat3 = gl.Constants.GL_FLOAT_MAT3, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    FloatMat4 = gl.Constants.GL_FLOAT_MAT4, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    Sampler2D = gl.Constants.GL_SAMPLER_2D, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    SamplerCube = gl.Constants.GL_SAMPLER_CUBE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Sampler2DArrayShadow = gl.Constants.GL_SAMPLER_2D_ARRAY_SHADOW, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    SamplerCubeShadow = gl.Constants.GL_SAMPLER_CUBE_SHADOW, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    UnsignedIntVec2 = gl.Constants.GL_UNSIGNED_INT_VEC2, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    UnsignedIntVec3 = gl.Constants.GL_UNSIGNED_INT_VEC3, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    UnsignedIntVec4 = gl.Constants.GL_UNSIGNED_INT_VEC4, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    IntSampler2D = gl.Constants.GL_INT_SAMPLER_2D, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    IntSampler3D = gl.Constants.GL_INT_SAMPLER_3D, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    IntSamplerCube = gl.Constants.GL_INT_SAMPLER_CUBE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    IntSampler2DArray = gl.Constants.GL_INT_SAMPLER_2D_ARRAY, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    UnsignedIntSampler2D = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    UnsignedIntSampler3D = gl.Constants.GL_UNSIGNED_INT_SAMPLER_3D, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    UnsignedIntSamplerCube = gl.Constants.GL_UNSIGNED_INT_SAMPLER_CUBE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    UnsignedIntSampler2DArray = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D_ARRAY, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_0)
    Sampler3D = gl.Constants.GL_SAMPLER_3D, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_0)
    Sampler2DShadow = gl.Constants.GL_SAMPLER_2D_SHADOW, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    FloatMat2x3 = gl.Constants.GL_FLOAT_MAT2x3, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    FloatMat2x4 = gl.Constants.GL_FLOAT_MAT2x4, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    FloatMat3x2 = gl.Constants.GL_FLOAT_MAT3x2, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    FloatMat3x4 = gl.Constants.GL_FLOAT_MAT3x4, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    FloatMat4x2 = gl.Constants.GL_FLOAT_MAT4x2, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    FloatMat4x3 = gl.Constants.GL_FLOAT_MAT4x3, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    Image2D = gl.Constants.GL_IMAGE_2D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    Image3D = gl.Constants.GL_IMAGE_3D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    ImageCube = gl.Constants.GL_IMAGE_CUBE, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    Image2DArray = gl.Constants.GL_IMAGE_2D_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    IntImage2D = gl.Constants.GL_INT_IMAGE_2D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    IntImage3D = gl.Constants.GL_INT_IMAGE_3D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    IntImageCube = gl.Constants.GL_INT_IMAGE_CUBE, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    IntImage2DArray = gl.Constants.GL_INT_IMAGE_2D_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    UnsignedIntImage2D = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    UnsignedIntImage3D = gl.Constants.GL_UNSIGNED_INT_IMAGE_3D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    UnsignedIntImageCube = gl.Constants.GL_UNSIGNED_INT_IMAGE_CUBE, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    UnsignedIntImage2DArray = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D_ARRAY, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    Sampler2DMultisample = gl.Constants.GL_SAMPLER_2D_MULTISAMPLE, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    IntSampler2DMultisample = gl.Constants.GL_INT_SAMPLER_2D_MULTISAMPLE, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    UnsignedIntSampler2DMultisample = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_1)
    SamplerBuffer = gl.Constants.GL_SAMPLER_BUFFER, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_1)
    IntSamplerBuffer = gl.Constants.GL_INT_SAMPLER_BUFFER, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_1)
    UnsignedIntSamplerBuffer = gl.Constants.GL_UNSIGNED_INT_SAMPLER_BUFFER, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    SamplerCubeMapArray = gl.Constants.GL_SAMPLER_CUBE_MAP_ARRAY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    SamplerCubeMapArrayShadow = gl.Constants.GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    IntSamplerCubeMapArray = gl.Constants.GL_INT_SAMPLER_CUBE_MAP_ARRAY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    UnsignedIntSamplerCubeMapArray = gl.Constants.GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    ImageBuffer = gl.Constants.GL_IMAGE_BUFFER, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    ImageCubeMapArray = gl.Constants.GL_IMAGE_CUBE_MAP_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    IntImageBuffer = gl.Constants.GL_INT_IMAGE_BUFFER, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    IntImageCubeMapArray = gl.Constants.GL_INT_IMAGE_CUBE_MAP_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    UnsignedIntImageBuffer = gl.Constants.GL_UNSIGNED_INT_IMAGE_BUFFER, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    UnsignedIntImageCubeMapArray = gl.Constants.GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    Sampler2DMultisampleArray = gl.Constants.GL_SAMPLER_2D_MULTISAMPLE_ARRAY, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    IntSampler2DMultisampleArray = gl.Constants.GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    UnsignedIntSampler2DMultisampleArray = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_EXT_VERTEX_ATTRIB_64BIT || GL_VERSION_1_1)
    Double = gl.Constants.GL_DOUBLE, 
#endif

#if GL_VERSION_2_0
    Sampler1D = gl.Constants.GL_SAMPLER_1D, 
#endif

#if GL_VERSION_2_0
    Sampler1DShadow = gl.Constants.GL_SAMPLER_1D_SHADOW, 
#endif

#if GL_VERSION_3_0
    Sampler1DArrayShadow = gl.Constants.GL_SAMPLER_1D_ARRAY_SHADOW, 
#endif

#if GL_VERSION_3_0
    IntSampler1D = gl.Constants.GL_INT_SAMPLER_1D, 
#endif

#if GL_VERSION_3_0
    IntSampler1DArray = gl.Constants.GL_INT_SAMPLER_1D_ARRAY, 
#endif

#if GL_VERSION_3_0
    UnsignedIntSampler1D = gl.Constants.GL_UNSIGNED_INT_SAMPLER_1D, 
#endif

#if GL_VERSION_3_0
    UnsignedIntSampler1DArray = gl.Constants.GL_UNSIGNED_INT_SAMPLER_1D_ARRAY, 
#endif

#if GL_VERSION_3_1
    IntSampler2DRect = gl.Constants.GL_INT_SAMPLER_2D_RECT, 
#endif

#if GL_VERSION_3_1
    UnsignedIntSampler2DRect = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D_RECT, 
#endif

#if GL_VERSION_3_1
    Sampler2DRect = gl.Constants.GL_SAMPLER_2D_RECT, 
#endif

#if GL_VERSION_3_1
    Sampler2DRectShadow = gl.Constants.GL_SAMPLER_2D_RECT_SHADOW, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat2 = gl.Constants.GL_DOUBLE_MAT2, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat3 = gl.Constants.GL_DOUBLE_MAT3, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat4 = gl.Constants.GL_DOUBLE_MAT4, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat2x3 = gl.Constants.GL_DOUBLE_MAT2x3, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat2x4 = gl.Constants.GL_DOUBLE_MAT2x4, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat3x2 = gl.Constants.GL_DOUBLE_MAT3x2, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat3x4 = gl.Constants.GL_DOUBLE_MAT3x4, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat4x2 = gl.Constants.GL_DOUBLE_MAT4x2, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleMat4x3 = gl.Constants.GL_DOUBLE_MAT4x3, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleVec2 = gl.Constants.GL_DOUBLE_VEC2, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleVec3 = gl.Constants.GL_DOUBLE_VEC3, 
#endif

#if (GL_ARB_GPU_SHADER_FP64 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_VERSION_4_0)
    DoubleVec4 = gl.Constants.GL_DOUBLE_VEC4, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    Image1D = gl.Constants.GL_IMAGE_1D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    Image2DRect = gl.Constants.GL_IMAGE_2D_RECT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    Image1DArray = gl.Constants.GL_IMAGE_1D_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    Image2DMultisample = gl.Constants.GL_IMAGE_2D_MULTISAMPLE, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    Image2DMultisampleArray = gl.Constants.GL_IMAGE_2D_MULTISAMPLE_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    IntImage1D = gl.Constants.GL_INT_IMAGE_1D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    IntImage2DRect = gl.Constants.GL_INT_IMAGE_2D_RECT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    IntImage1DArray = gl.Constants.GL_INT_IMAGE_1D_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    IntImage2DMultisample = gl.Constants.GL_INT_IMAGE_2D_MULTISAMPLE, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    IntImage2DMultisampleArray = gl.Constants.GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    UnsignedIntImage1D = gl.Constants.GL_UNSIGNED_INT_IMAGE_1D, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    UnsignedIntImage2DRect = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D_RECT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    UnsignedIntImage1DArray = gl.Constants.GL_UNSIGNED_INT_IMAGE_1D_ARRAY, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    UnsignedIntImage2DMultisample = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_4_2)
    UnsignedIntImage2DMultisampleArray = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY, 
#endif

#if (GL_AMD_GPU_SHADER_INT64 || GL_NV_GPU_SHADER5 || GL_NV_VERTEX_ATTRIB_INTEGER_64BIT)
    Int64Nv = gl.Constants.GL_INT64_NV, 
#endif

#if (GL_AMD_GPU_SHADER_INT64 || GL_NV_GPU_SHADER5 || GL_NV_VERTEX_ATTRIB_INTEGER_64BIT)
    UnsignedInt64Nv = gl.Constants.GL_UNSIGNED_INT64_NV, 
#endif

#if (GL_ARB_BINDLESS_TEXTURE || GL_ARB_GPU_SHADER_INT64)
    UnsignedInt64Arb = gl.Constants.GL_UNSIGNED_INT64_ARB, 
#endif

#if GL_ARB_GPU_SHADER_INT64
    Int64Arb = gl.Constants.GL_INT64_ARB, 
#endif

#if GL_ARB_GPU_SHADER_INT64
    Int64Vec2Arb = gl.Constants.GL_INT64_VEC2_ARB, 
#endif

#if GL_ARB_GPU_SHADER_INT64
    Int64Vec3Arb = gl.Constants.GL_INT64_VEC3_ARB, 
#endif

#if GL_ARB_GPU_SHADER_INT64
    Int64Vec4Arb = gl.Constants.GL_INT64_VEC4_ARB, 
#endif

#if GL_ARB_GPU_SHADER_INT64
    UnsignedInt64Vec2Arb = gl.Constants.GL_UNSIGNED_INT64_VEC2_ARB, 
#endif

#if GL_ARB_GPU_SHADER_INT64
    UnsignedInt64Vec3Arb = gl.Constants.GL_UNSIGNED_INT64_VEC3_ARB, 
#endif

#if GL_ARB_GPU_SHADER_INT64
    UnsignedInt64Vec4Arb = gl.Constants.GL_UNSIGNED_INT64_VEC4_ARB, 
#endif

#if (GL_ARB_SHADER_OBJECTS || GL_ARB_VERTEX_SHADER)
    FloatVec2Arb = gl.Constants.GL_FLOAT_VEC2_ARB, 
#endif

#if (GL_ARB_SHADER_OBJECTS || GL_ARB_VERTEX_SHADER)
    FloatVec3Arb = gl.Constants.GL_FLOAT_VEC3_ARB, 
#endif

#if (GL_ARB_SHADER_OBJECTS || GL_ARB_VERTEX_SHADER)
    FloatVec4Arb = gl.Constants.GL_FLOAT_VEC4_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    IntVec2Arb = gl.Constants.GL_INT_VEC2_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    IntVec3Arb = gl.Constants.GL_INT_VEC3_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    IntVec4Arb = gl.Constants.GL_INT_VEC4_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    BoolArb = gl.Constants.GL_BOOL_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    BoolVec2Arb = gl.Constants.GL_BOOL_VEC2_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    BoolVec3Arb = gl.Constants.GL_BOOL_VEC3_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    BoolVec4Arb = gl.Constants.GL_BOOL_VEC4_ARB, 
#endif

#if (GL_ARB_SHADER_OBJECTS || GL_ARB_VERTEX_SHADER)
    FloatMat2Arb = gl.Constants.GL_FLOAT_MAT2_ARB, 
#endif

#if (GL_ARB_SHADER_OBJECTS || GL_ARB_VERTEX_SHADER)
    FloatMat3Arb = gl.Constants.GL_FLOAT_MAT3_ARB, 
#endif

#if (GL_ARB_SHADER_OBJECTS || GL_ARB_VERTEX_SHADER)
    FloatMat4Arb = gl.Constants.GL_FLOAT_MAT4_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    Sampler1DArb = gl.Constants.GL_SAMPLER_1D_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    Sampler2DArb = gl.Constants.GL_SAMPLER_2D_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    Sampler3DArb = gl.Constants.GL_SAMPLER_3D_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    SamplerCubeArb = gl.Constants.GL_SAMPLER_CUBE_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    Sampler1DShadowArb = gl.Constants.GL_SAMPLER_1D_SHADOW_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    Sampler2DShadowArb = gl.Constants.GL_SAMPLER_2D_SHADOW_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    Sampler2DRectArb = gl.Constants.GL_SAMPLER_2D_RECT_ARB, 
#endif

#if GL_ARB_SHADER_OBJECTS
    Sampler2DRectShadowArb = gl.Constants.GL_SAMPLER_2D_RECT_SHADOW_ARB, 
#endif

#if GL_EXT_SHADOW_SAMPLERS
    Sampler2DShadowExt = gl.Constants.GL_SAMPLER_2D_SHADOW_EXT, 
#endif

#if GL_NV_NON_SQUARE_MATRICES
    FloatMat2x3Nv = gl.Constants.GL_FLOAT_MAT2x3_NV, 
#endif

#if GL_NV_NON_SQUARE_MATRICES
    FloatMat2x4Nv = gl.Constants.GL_FLOAT_MAT2x4_NV, 
#endif

#if GL_NV_NON_SQUARE_MATRICES
    FloatMat3x2Nv = gl.Constants.GL_FLOAT_MAT3x2_NV, 
#endif

#if GL_NV_NON_SQUARE_MATRICES
    FloatMat3x4Nv = gl.Constants.GL_FLOAT_MAT3x4_NV, 
#endif

#if GL_NV_NON_SQUARE_MATRICES
    FloatMat4x2Nv = gl.Constants.GL_FLOAT_MAT4x2_NV, 
#endif

#if GL_NV_NON_SQUARE_MATRICES
    FloatMat4x3Nv = gl.Constants.GL_FLOAT_MAT4x3_NV, 
#endif

#if GL_OES_TEXTURE_3D
    Sampler3DOes = gl.Constants.GL_SAMPLER_3D_OES, 
#endif

}

#endif
