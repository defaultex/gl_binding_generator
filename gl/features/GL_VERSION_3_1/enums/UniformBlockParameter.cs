public enum UniformBlockParameter : GLenum {
    UniformBlockBinding = gl.Constants.GL_UNIFORM_BLOCK_BINDING,
    UniformBlockDataSize = gl.Constants.GL_UNIFORM_BLOCK_DATA_SIZE,
    UniformBlockNameLength = gl.Constants.GL_UNIFORM_BLOCK_NAME_LENGTH,
    UniformBlockActiveUniforms = gl.Constants.GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS,
    UniformBlockActiveUniformIndices = gl.Constants.GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES,
    UniformBlockReferencedByVertexShader = gl.Constants.GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER,
    UniformBlockReferencedByGeometryShader = gl.Constants.GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER,
    UniformBlockReferencedByFragmentShader = gl.Constants.GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER,
    UniformBlockReferencedByTessControlShader = gl.Constants.GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER,
    UniformBlockReferencedByTessEvaluationShader = gl.Constants.GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER,
    UniformBlockReferencedByComputeShader = gl.Constants.GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER,
}
