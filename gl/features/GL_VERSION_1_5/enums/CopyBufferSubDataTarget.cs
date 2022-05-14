public enum CopyBufferSubDataTarget : GLenum {
    ArrayBuffer = gl.Constants.GL_ARRAY_BUFFER,
    ElementArrayBuffer = gl.Constants.GL_ELEMENT_ARRAY_BUFFER,
    PixelPackBuffer = gl.Constants.GL_PIXEL_PACK_BUFFER,
    PixelUnpackBuffer = gl.Constants.GL_PIXEL_UNPACK_BUFFER,
    TransformFeedbackBuffer = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER,
    TextureBuffer = gl.Constants.GL_TEXTURE_BUFFER,
    CopyReadBuffer = gl.Constants.GL_COPY_READ_BUFFER,
    CopyWriteBuffer = gl.Constants.GL_COPY_WRITE_BUFFER,
    UniformBuffer = gl.Constants.GL_UNIFORM_BUFFER,
    DrawIndirectBuffer = gl.Constants.GL_DRAW_INDIRECT_BUFFER,
    AtomicCounterBuffer = gl.Constants.GL_ATOMIC_COUNTER_BUFFER,
    DispatchIndirectBuffer = gl.Constants.GL_DISPATCH_INDIRECT_BUFFER,
    ShaderStorageBuffer = gl.Constants.GL_SHADER_STORAGE_BUFFER,
    QueryBuffer = gl.Constants.GL_QUERY_BUFFER,
}