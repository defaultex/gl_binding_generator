[Flags]
public enum MemoryBarrierMask : GLbitfield {
    VertexAttribArrayBarrier = gl.Constants.GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT,
    ElementArrayBarrier = gl.Constants.GL_ELEMENT_ARRAY_BARRIER_BIT,
    UniformBarrier = gl.Constants.GL_UNIFORM_BARRIER_BIT,
    TextureFetchBarrier = gl.Constants.GL_TEXTURE_FETCH_BARRIER_BIT,
    ShaderImageAccessBarrier = gl.Constants.GL_SHADER_IMAGE_ACCESS_BARRIER_BIT,
    CommandBarrier = gl.Constants.GL_COMMAND_BARRIER_BIT,
    PixelBufferBarrier = gl.Constants.GL_PIXEL_BUFFER_BARRIER_BIT,
    TextureUpdateBarrier = gl.Constants.GL_TEXTURE_UPDATE_BARRIER_BIT,
    BufferUpdateBarrier = gl.Constants.GL_BUFFER_UPDATE_BARRIER_BIT,
    FramebufferBarrier = gl.Constants.GL_FRAMEBUFFER_BARRIER_BIT,
    TransformFeedbackBarrier = gl.Constants.GL_TRANSFORM_FEEDBACK_BARRIER_BIT,
    AtomicCounterBarrier = gl.Constants.GL_ATOMIC_COUNTER_BARRIER_BIT,
    AllBarrier = gl.Constants.GL_ALL_BARRIER_BITS,
    ShaderStorageBarrier = gl.Constants.GL_SHADER_STORAGE_BARRIER_BIT,
    ClientMappedBufferBarrier = gl.Constants.GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT,
    QueryBufferBarrier = gl.Constants.GL_QUERY_BUFFER_BARRIER_BIT,
#if GL_NV_shader_buffer_store
    ShaderGlobalAccessBarrierBitNv = gl.Constants.GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV,
#endif
}
