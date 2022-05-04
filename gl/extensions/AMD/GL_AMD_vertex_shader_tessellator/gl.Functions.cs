#if (GL_AMD_vertex_shader_tessellator && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTessellationFactorAMD(GLfloat factor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glTessellationFactorAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTessellationModeAMD(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glTessellationModeAMD;
#endif
    }
}
#endif