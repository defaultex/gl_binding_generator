#if (GL_EXT_fog_coord && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoorddEXT(GLdouble coord);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glFogCoorddEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoorddvEXT(GLdouble* coord);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glFogCoorddvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoordfEXT(GLfloat coord);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glFogCoordfEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoordfvEXT(GLfloat* coord);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glFogCoordfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoordPointerEXT(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPointerTypeEXT, GLsizei, void*, void> glFogCoordPointerEXT;
#endif
    }
}
#endif