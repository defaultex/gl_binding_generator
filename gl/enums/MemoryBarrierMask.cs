#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2 || GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_VERSION_4_3 || GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4 || GL_ARB_QUERY_BUFFER_OBJECT || GL_EXT_BUFFER_STORAGE || GL_EXT_SHADER_IMAGE_LOAD_STORE || GL_NV_SHADER_BUFFER_STORE)
[Flags]
public enum MemoryBarrierMask : GLbitfield { 
    None = 0,
#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    VertexAttribArrayBarrier = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    ElementArrayBarrier = gl.Constants.GL_ELEMENT_ARRAY_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    UniformBarrier = gl.Constants.GL_UNIFORM_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    TextureFetchBarrier = gl.Constants.GL_TEXTURE_FETCH_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    ShaderImageAccessBarrier = gl.Constants.GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    CommandBarrier = gl.Constants.GL_COMMAND_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    PixelBufferBarrier = gl.Constants.GL_PIXEL_BUFFER_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    TextureUpdateBarrier = gl.Constants.GL_TEXTURE_UPDATE_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    BufferUpdateBarrier = gl.Constants.GL_BUFFER_UPDATE_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    FramebufferBarrier = gl.Constants.GL_FRAMEBUFFER_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    TransformFeedbackBarrier = gl.Constants.GL_TRANSFORM_FEEDBACK_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    AtomicCounterBarrier = gl.Constants.GL_ATOMIC_COUNTER_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ShaderStorageBarrier = gl.Constants.GL_SHADER_STORAGE_BARRIER_BIT, 
#endif

#if (GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    AllBarrier = gl.Constants.GL_ALL_BARRIER_BITS, 
#endif

#if (GL_ARB_BUFFER_STORAGE || GL_VERSION_4_4)
    ClientMappedBufferBarrier = gl.Constants.GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT, 
#endif

#if (GL_ARB_QUERY_BUFFER_OBJECT || GL_VERSION_4_4)
    QueryBufferBarrier = gl.Constants.GL_QUERY_BUFFER_BARRIER_BIT, 
#endif

#if GL_EXT_BUFFER_STORAGE
    ClientMappedBufferBarrierBitExt = gl.Constants.GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    VertexAttribArrayBarrierBitExt = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    ElementArrayBarrierBitExt = gl.Constants.GL_ELEMENT_ARRAY_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    UniformBitExt = gl.Constants.GL_UNIFORM_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    TextureFetchBarrierBitExt = gl.Constants.GL_TEXTURE_FETCH_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    ShaderImageAccessBarrierBitExt = gl.Constants.GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    CommandBitExt = gl.Constants.GL_COMMAND_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    PixelBufferBarrierBitExt = gl.Constants.GL_PIXEL_BUFFER_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    TextureUpdateBarrierBitExt = gl.Constants.GL_TEXTURE_UPDATE_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    BufferUpdateBarrierBitExt = gl.Constants.GL_BUFFER_UPDATE_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    FramebufferBitExt = gl.Constants.GL_FRAMEBUFFER_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    TransformFeedbackBarrierBitExt = gl.Constants.GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    AtomicCounterBarrierBitExt = gl.Constants.GL_ATOMIC_COUNTER_BARRIER_BIT_EXT, 
#endif

#if GL_EXT_SHADER_IMAGE_LOAD_STORE
    AllBitsExt = gl.Constants.GL_ALL_BARRIER_BITS_EXT, 
#endif

#if GL_NV_SHADER_BUFFER_STORE
    ShaderGlobalAccessBarrierBitNv = gl.Constants.GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV, 
#endif

}

#endif
