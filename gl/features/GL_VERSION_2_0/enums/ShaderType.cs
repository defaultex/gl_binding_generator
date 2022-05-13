public enum ShaderType : GLenum {
    FragmentShader = gl.Constants.GL_FRAGMENT_SHADER,
    VertexShader = gl.Constants.GL_VERTEX_SHADER,
    GeometryShader = gl.Constants.GL_GEOMETRY_SHADER,
    TessEvaluationShader = gl.Constants.GL_TESS_EVALUATION_SHADER,
    TessControlShader = gl.Constants.GL_TESS_CONTROL_SHADER,
    ComputeShader = gl.Constants.GL_COMPUTE_SHADER,
}
