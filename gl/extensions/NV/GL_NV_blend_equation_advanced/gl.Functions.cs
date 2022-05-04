#if (GL_NV_blend_equation_advanced && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendBarrierNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBlendBarrierNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendParameteriNV(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, void> glBlendParameteriNV;
#endif
    }
}
#endif