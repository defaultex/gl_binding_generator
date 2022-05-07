#if (GL_AMD_vertex_shader_tessellator && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTessellationFactorAMD(GLfloat factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glTessellationFactorAMD;

        /// <summary>void glTessellationModeAMD(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glTessellationModeAMD;
    }
}
#endif