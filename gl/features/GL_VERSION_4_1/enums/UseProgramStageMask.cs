[Flags]
public enum UseProgramStageMask : GLbitfield {
    VertexShader = gl.Constants.GL_VERTEX_SHADER_BIT,
    FragmentShader = gl.Constants.GL_FRAGMENT_SHADER_BIT,
    GeometryShader = gl.Constants.GL_GEOMETRY_SHADER_BIT,
    TessControlShader = gl.Constants.GL_TESS_CONTROL_SHADER_BIT,
    TessEvaluationShader = gl.Constants.GL_TESS_EVALUATION_SHADER_BIT,
    AllShader = gl.Constants.GL_ALL_SHADER_BITS,
    ComputeShader = gl.Constants.GL_COMPUTE_SHADER_BIT,
#if GL_NV_mesh_shader
    MeshShaderBitNv = gl.Constants.GL_MESH_SHADER_BIT_NV,
#endif

#if GL_NV_mesh_shader
    TaskShaderBitNv = gl.Constants.GL_TASK_SHADER_BIT_NV,
#endif
}
