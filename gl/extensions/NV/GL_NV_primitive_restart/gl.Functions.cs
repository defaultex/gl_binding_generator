#if (GL_NV_primitive_restart && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPrimitiveRestartIndexNV(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glPrimitiveRestartIndexNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPrimitiveRestartNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPrimitiveRestartNV;
#endif
    }
}
#endif