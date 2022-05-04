#if (GL_OES_byte_coordinates && (GL_API || GLES1_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1bOES(GLenum texture, GLbyte s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLbyte, void> glMultiTexCoord1bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1bvOES(GLenum texture, GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLbyte*, void> glMultiTexCoord1bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2bOES(GLenum texture, GLbyte s, GLbyte t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLbyte, GLbyte, void> glMultiTexCoord2bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2bvOES(GLenum texture, GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLbyte*, void> glMultiTexCoord2bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3bOES(GLenum texture, GLbyte s, GLbyte t, GLbyte r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLbyte, GLbyte, GLbyte, void> glMultiTexCoord3bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3bvOES(GLenum texture, GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLbyte*, void> glMultiTexCoord3bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4bOES(GLenum texture, GLbyte s, GLbyte t, GLbyte r, GLbyte q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLbyte, GLbyte, GLbyte, GLbyte, void> glMultiTexCoord4bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4bvOES(GLenum texture, GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLbyte*, void> glMultiTexCoord4bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord1bOES(GLbyte s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, void> glTexCoord1bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord1bvOES(GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glTexCoord1bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2bOES(GLbyte s, GLbyte t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, void> glTexCoord2bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2bvOES(GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glTexCoord2bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord3bOES(GLbyte s, GLbyte t, GLbyte r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glTexCoord3bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord3bvOES(GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glTexCoord3bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4bOES(GLbyte s, GLbyte t, GLbyte r, GLbyte q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, GLbyte, void> glTexCoord4bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4bvOES(GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glTexCoord4bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex2bOES(GLbyte x, GLbyte y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, void> glVertex2bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex2bvOES(GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glVertex2bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex3bOES(GLbyte x, GLbyte y, GLbyte z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glVertex3bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex3bvOES(GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glVertex3bvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex4bOES(GLbyte x, GLbyte y, GLbyte z, GLbyte w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, GLbyte, void> glVertex4bOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex4bvOES(GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glVertex4bvOES;
#endif
    }
}
#endif