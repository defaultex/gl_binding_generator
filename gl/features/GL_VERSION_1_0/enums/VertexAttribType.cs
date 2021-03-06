public enum VertexAttribType : GLenum {
    Byte = gl.Constants.GL_BYTE,
    UnsignedByte = gl.Constants.GL_UNSIGNED_BYTE,
    Short = gl.Constants.GL_SHORT,
    UnsignedShort = gl.Constants.GL_UNSIGNED_SHORT,
    Int = gl.Constants.GL_INT,
    UnsignedInt = gl.Constants.GL_UNSIGNED_INT,
    Float = gl.Constants.GL_FLOAT,
    Double = gl.Constants.GL_DOUBLE,
    UnsignedInt2101010Rev = gl.Constants.GL_UNSIGNED_INT_2_10_10_10_REV,
    UnsignedInt10f11f11fRev = gl.Constants.GL_UNSIGNED_INT_10F_11F_11F_REV,
    HalfFloat = gl.Constants.GL_HALF_FLOAT,
    Int2101010Rev = gl.Constants.GL_INT_2_10_10_10_REV,
    Fixed = gl.Constants.GL_FIXED,
#if GL_ARB_bindless_texture
    UnsignedInt64Arb = gl.Constants.GL_UNSIGNED_INT64_ARB,
#endif

#if GL_ARB_gpu_shader_int64
    Int64Arb = gl.Constants.GL_INT64_ARB,
#endif

#if GL_NV_gpu_shader5
    Int64Nv = gl.Constants.GL_INT64_NV,
#endif

#if GL_NV_gpu_shader5
    UnsignedInt64Nv = gl.Constants.GL_UNSIGNED_INT64_NV,
#endif
}
