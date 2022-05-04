#if (GL_NV_half_float && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glColor3hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor3hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glColor3hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glColor4hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glColor4hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoordhNV(GLhalfNV fog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, void> glFogCoordhNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogCoordhvNV(GLhalfNV* fog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glFogCoordhvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1hNV(GLenum target, GLhalfNV s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV, void> glMultiTexCoord1hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1hvNV(GLenum target, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV*, void> glMultiTexCoord1hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2hNV(GLenum target, GLhalfNV s, GLhalfNV t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV, GLhalfNV, void> glMultiTexCoord2hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2hvNV(GLenum target, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV*, void> glMultiTexCoord2hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3hNV(GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV, GLhalfNV, GLhalfNV, void> glMultiTexCoord3hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3hvNV(GLenum target, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV*, void> glMultiTexCoord3hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4hNV(GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glMultiTexCoord4hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4hvNV(GLenum target, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV*, void> glMultiTexCoord4hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormal3hNV(GLhalfNV nx, GLhalfNV ny, GLhalfNV nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glNormal3hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormal3hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glNormal3hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glSecondaryColor3hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glSecondaryColor3hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord1hNV(GLhalfNV s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, void> glTexCoord1hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord1hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glTexCoord1hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2hNV(GLhalfNV s, GLhalfNV t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, void> glTexCoord2hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glTexCoord2hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord3hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glTexCoord3hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord3hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glTexCoord3hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glTexCoord4hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glTexCoord4hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex2hNV(GLhalfNV x, GLhalfNV y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, void> glVertex2hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex2hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glVertex2hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex3hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glVertex3hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex3hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glVertex3hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex4hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glVertex4hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex4hvNV(GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glVertex4hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1hNV(GLuint index, GLhalfNV x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV, void> glVertexAttrib1hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1hvNV(GLuint index, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV*, void> glVertexAttrib1hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2hNV(GLuint index, GLhalfNV x, GLhalfNV y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV, GLhalfNV, void> glVertexAttrib2hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2hvNV(GLuint index, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV*, void> glVertexAttrib2hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV, GLhalfNV, GLhalfNV, void> glVertexAttrib3hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3hvNV(GLuint index, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV*, void> glVertexAttrib3hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glVertexAttrib4hNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4hvNV(GLuint index, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV*, void> glVertexAttrib4hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs1hvNV(GLuint index, GLsizei n, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLhalfNV*, void> glVertexAttribs1hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs2hvNV(GLuint index, GLsizei n, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLhalfNV*, void> glVertexAttribs2hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs3hvNV(GLuint index, GLsizei n, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLhalfNV*, void> glVertexAttribs3hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs4hvNV(GLuint index, GLsizei n, GLhalfNV* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLhalfNV*, void> glVertexAttribs4hvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexWeighthNV(GLhalfNV weight);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, void> glVertexWeighthNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexWeighthvNV(GLhalfNV* weight);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glVertexWeighthvNV;
#endif
    }
}
#endif