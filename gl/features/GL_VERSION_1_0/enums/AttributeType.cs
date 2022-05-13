public enum AttributeType : GLenum {
    Int = gl.Constants.GL_INT,
    UnsignedInt = gl.Constants.GL_UNSIGNED_INT,
    Float = gl.Constants.GL_FLOAT,
    Double = gl.Constants.GL_DOUBLE,
    FloatVec2 = gl.Constants.GL_FLOAT_VEC2,
    FloatVec3 = gl.Constants.GL_FLOAT_VEC3,
    FloatVec4 = gl.Constants.GL_FLOAT_VEC4,
    IntVec2 = gl.Constants.GL_INT_VEC2,
    IntVec3 = gl.Constants.GL_INT_VEC3,
    IntVec4 = gl.Constants.GL_INT_VEC4,
    Bool = gl.Constants.GL_BOOL,
    BoolVec2 = gl.Constants.GL_BOOL_VEC2,
    BoolVec3 = gl.Constants.GL_BOOL_VEC3,
    BoolVec4 = gl.Constants.GL_BOOL_VEC4,
    FloatMat2 = gl.Constants.GL_FLOAT_MAT2,
    FloatMat3 = gl.Constants.GL_FLOAT_MAT3,
    FloatMat4 = gl.Constants.GL_FLOAT_MAT4,
    Sampler1D = gl.Constants.GL_SAMPLER_1D,
    Sampler2D = gl.Constants.GL_SAMPLER_2D,
    Sampler3D = gl.Constants.GL_SAMPLER_3D,
    SamplerCube = gl.Constants.GL_SAMPLER_CUBE,
    Sampler1DShadow = gl.Constants.GL_SAMPLER_1D_SHADOW,
    Sampler2DShadow = gl.Constants.GL_SAMPLER_2D_SHADOW,
    FloatMat2x3 = gl.Constants.GL_FLOAT_MAT2x3,
    FloatMat2x4 = gl.Constants.GL_FLOAT_MAT2x4,
    FloatMat3x2 = gl.Constants.GL_FLOAT_MAT3x2,
    FloatMat3x4 = gl.Constants.GL_FLOAT_MAT3x4,
    FloatMat4x2 = gl.Constants.GL_FLOAT_MAT4x2,
    FloatMat4x3 = gl.Constants.GL_FLOAT_MAT4x3,
    Sampler1DArrayShadow = gl.Constants.GL_SAMPLER_1D_ARRAY_SHADOW,
    Sampler2DArrayShadow = gl.Constants.GL_SAMPLER_2D_ARRAY_SHADOW,
    SamplerCubeShadow = gl.Constants.GL_SAMPLER_CUBE_SHADOW,
    UnsignedIntVec2 = gl.Constants.GL_UNSIGNED_INT_VEC2,
    UnsignedIntVec3 = gl.Constants.GL_UNSIGNED_INT_VEC3,
    UnsignedIntVec4 = gl.Constants.GL_UNSIGNED_INT_VEC4,
    IntSampler1D = gl.Constants.GL_INT_SAMPLER_1D,
    IntSampler2D = gl.Constants.GL_INT_SAMPLER_2D,
    IntSampler3D = gl.Constants.GL_INT_SAMPLER_3D,
    IntSamplerCube = gl.Constants.GL_INT_SAMPLER_CUBE,
    IntSampler1DArray = gl.Constants.GL_INT_SAMPLER_1D_ARRAY,
    IntSampler2DArray = gl.Constants.GL_INT_SAMPLER_2D_ARRAY,
    UnsignedIntSampler1D = gl.Constants.GL_UNSIGNED_INT_SAMPLER_1D,
    UnsignedIntSampler2D = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D,
    UnsignedIntSampler3D = gl.Constants.GL_UNSIGNED_INT_SAMPLER_3D,
    UnsignedIntSamplerCube = gl.Constants.GL_UNSIGNED_INT_SAMPLER_CUBE,
    UnsignedIntSampler1DArray = gl.Constants.GL_UNSIGNED_INT_SAMPLER_1D_ARRAY,
    UnsignedIntSampler2DArray = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D_ARRAY,
    Sampler2DRect = gl.Constants.GL_SAMPLER_2D_RECT,
    Sampler2DRectShadow = gl.Constants.GL_SAMPLER_2D_RECT_SHADOW,
    SamplerBuffer = gl.Constants.GL_SAMPLER_BUFFER,
    IntSampler2DRect = gl.Constants.GL_INT_SAMPLER_2D_RECT,
    IntSamplerBuffer = gl.Constants.GL_INT_SAMPLER_BUFFER,
    UnsignedIntSampler2DRect = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D_RECT,
    UnsignedIntSamplerBuffer = gl.Constants.GL_UNSIGNED_INT_SAMPLER_BUFFER,
    Sampler2DMultisample = gl.Constants.GL_SAMPLER_2D_MULTISAMPLE,
    IntSampler2DMultisample = gl.Constants.GL_INT_SAMPLER_2D_MULTISAMPLE,
    UnsignedIntSampler2DMultisample = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE,
    Sampler2DMultisampleArray = gl.Constants.GL_SAMPLER_2D_MULTISAMPLE_ARRAY,
    IntSampler2DMultisampleArray = gl.Constants.GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY,
    UnsignedIntSampler2DMultisampleArray = gl.Constants.GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY,
    SamplerCubeMapArray = gl.Constants.GL_SAMPLER_CUBE_MAP_ARRAY,
    SamplerCubeMapArrayShadow = gl.Constants.GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW,
    IntSamplerCubeMapArray = gl.Constants.GL_INT_SAMPLER_CUBE_MAP_ARRAY,
    UnsignedIntSamplerCubeMapArray = gl.Constants.GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY,
    DoubleVec2 = gl.Constants.GL_DOUBLE_VEC2,
    DoubleVec3 = gl.Constants.GL_DOUBLE_VEC3,
    DoubleVec4 = gl.Constants.GL_DOUBLE_VEC4,
    DoubleMat2 = gl.Constants.GL_DOUBLE_MAT2,
    DoubleMat3 = gl.Constants.GL_DOUBLE_MAT3,
    DoubleMat4 = gl.Constants.GL_DOUBLE_MAT4,
    DoubleMat2x3 = gl.Constants.GL_DOUBLE_MAT2x3,
    DoubleMat2x4 = gl.Constants.GL_DOUBLE_MAT2x4,
    DoubleMat3x2 = gl.Constants.GL_DOUBLE_MAT3x2,
    DoubleMat3x4 = gl.Constants.GL_DOUBLE_MAT3x4,
    DoubleMat4x2 = gl.Constants.GL_DOUBLE_MAT4x2,
    DoubleMat4x3 = gl.Constants.GL_DOUBLE_MAT4x3,
    Image1D = gl.Constants.GL_IMAGE_1D,
    Image2D = gl.Constants.GL_IMAGE_2D,
    Image3D = gl.Constants.GL_IMAGE_3D,
    Image2DRect = gl.Constants.GL_IMAGE_2D_RECT,
    ImageCube = gl.Constants.GL_IMAGE_CUBE,
    ImageBuffer = gl.Constants.GL_IMAGE_BUFFER,
    Image1DArray = gl.Constants.GL_IMAGE_1D_ARRAY,
    Image2DArray = gl.Constants.GL_IMAGE_2D_ARRAY,
    ImageCubeMapArray = gl.Constants.GL_IMAGE_CUBE_MAP_ARRAY,
    Image2DMultisample = gl.Constants.GL_IMAGE_2D_MULTISAMPLE,
    Image2DMultisampleArray = gl.Constants.GL_IMAGE_2D_MULTISAMPLE_ARRAY,
    IntImage1D = gl.Constants.GL_INT_IMAGE_1D,
    IntImage2D = gl.Constants.GL_INT_IMAGE_2D,
    IntImage3D = gl.Constants.GL_INT_IMAGE_3D,
    IntImage2DRect = gl.Constants.GL_INT_IMAGE_2D_RECT,
    IntImageCube = gl.Constants.GL_INT_IMAGE_CUBE,
    IntImageBuffer = gl.Constants.GL_INT_IMAGE_BUFFER,
    IntImage1DArray = gl.Constants.GL_INT_IMAGE_1D_ARRAY,
    IntImage2DArray = gl.Constants.GL_INT_IMAGE_2D_ARRAY,
    IntImageCubeMapArray = gl.Constants.GL_INT_IMAGE_CUBE_MAP_ARRAY,
    IntImage2DMultisample = gl.Constants.GL_INT_IMAGE_2D_MULTISAMPLE,
    IntImage2DMultisampleArray = gl.Constants.GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY,
    UnsignedIntImage1D = gl.Constants.GL_UNSIGNED_INT_IMAGE_1D,
    UnsignedIntImage2D = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D,
    UnsignedIntImage3D = gl.Constants.GL_UNSIGNED_INT_IMAGE_3D,
    UnsignedIntImage2DRect = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D_RECT,
    UnsignedIntImageCube = gl.Constants.GL_UNSIGNED_INT_IMAGE_CUBE,
    UnsignedIntImageBuffer = gl.Constants.GL_UNSIGNED_INT_IMAGE_BUFFER,
    UnsignedIntImage1DArray = gl.Constants.GL_UNSIGNED_INT_IMAGE_1D_ARRAY,
    UnsignedIntImage2DArray = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D_ARRAY,
    UnsignedIntImageCubeMapArray = gl.Constants.GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY,
    UnsignedIntImage2DMultisample = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE,
    UnsignedIntImage2DMultisampleArray = gl.Constants.GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY,
#if GL_ARB_bindless_texture
    UnsignedInt64Arb = gl.Constants.GL_UNSIGNED_INT64_ARB,
#endif

#if GL_ARB_gpu_shader_int64
    Int64Arb = gl.Constants.GL_INT64_ARB,
#endif

#if GL_ARB_gpu_shader_int64
    Int64Vec2Arb = gl.Constants.GL_INT64_VEC2_ARB,
#endif

#if GL_ARB_gpu_shader_int64
    Int64Vec3Arb = gl.Constants.GL_INT64_VEC3_ARB,
#endif

#if GL_ARB_gpu_shader_int64
    Int64Vec4Arb = gl.Constants.GL_INT64_VEC4_ARB,
#endif

#if GL_ARB_gpu_shader_int64
    UnsignedInt64Vec2Arb = gl.Constants.GL_UNSIGNED_INT64_VEC2_ARB,
#endif

#if GL_ARB_gpu_shader_int64
    UnsignedInt64Vec3Arb = gl.Constants.GL_UNSIGNED_INT64_VEC3_ARB,
#endif

#if GL_ARB_gpu_shader_int64
    UnsignedInt64Vec4Arb = gl.Constants.GL_UNSIGNED_INT64_VEC4_ARB,
#endif

#if GL_NV_gpu_shader5
    Int64Nv = gl.Constants.GL_INT64_NV,
#endif

#if GL_NV_gpu_shader5
    UnsignedInt64Nv = gl.Constants.GL_UNSIGNED_INT64_NV,
#endif
}
