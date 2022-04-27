#if (GL_NV_half_float && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glColor3hNV;

        /// <summary>void glColor3hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glColor3hvNV;

        /// <summary>void glColor4hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glColor4hNV;

        /// <summary>void glColor4hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glColor4hvNV;

        /// <summary>void glFogCoordhNV(GLhalfNV fog)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, void> glFogCoordhNV;

        /// <summary>void glFogCoordhvNV(const GLhalfNV* fog)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glFogCoordhvNV;

        /// <summary>void glMultiTexCoord1hNV(GLenum target, GLhalfNV s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV, void> glMultiTexCoord1hNV;

        /// <summary>void glMultiTexCoord1hvNV(GLenum target, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV*, void> glMultiTexCoord1hvNV;

        /// <summary>void glMultiTexCoord2hNV(GLenum target, GLhalfNV s, GLhalfNV t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV, GLhalfNV, void> glMultiTexCoord2hNV;

        /// <summary>void glMultiTexCoord2hvNV(GLenum target, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV*, void> glMultiTexCoord2hvNV;

        /// <summary>void glMultiTexCoord3hNV(GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV, GLhalfNV, GLhalfNV, void> glMultiTexCoord3hNV;

        /// <summary>void glMultiTexCoord3hvNV(GLenum target, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV*, void> glMultiTexCoord3hvNV;

        /// <summary>void glMultiTexCoord4hNV(GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glMultiTexCoord4hNV;

        /// <summary>void glMultiTexCoord4hvNV(GLenum target, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLhalfNV*, void> glMultiTexCoord4hvNV;

        /// <summary>void glNormal3hNV(GLhalfNV nx, GLhalfNV ny, GLhalfNV nz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glNormal3hNV;

        /// <summary>void glNormal3hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glNormal3hvNV;

        /// <summary>void glSecondaryColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glSecondaryColor3hNV;

        /// <summary>void glSecondaryColor3hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glSecondaryColor3hvNV;

        /// <summary>void glTexCoord1hNV(GLhalfNV s)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, void> glTexCoord1hNV;

        /// <summary>void glTexCoord1hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glTexCoord1hvNV;

        /// <summary>void glTexCoord2hNV(GLhalfNV s, GLhalfNV t)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, void> glTexCoord2hNV;

        /// <summary>void glTexCoord2hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glTexCoord2hvNV;

        /// <summary>void glTexCoord3hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glTexCoord3hNV;

        /// <summary>void glTexCoord3hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glTexCoord3hvNV;

        /// <summary>void glTexCoord4hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glTexCoord4hNV;

        /// <summary>void glTexCoord4hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glTexCoord4hvNV;

        /// <summary>void glVertex2hNV(GLhalfNV x, GLhalfNV y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, void> glVertex2hNV;

        /// <summary>void glVertex2hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glVertex2hvNV;

        /// <summary>void glVertex3hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, void> glVertex3hNV;

        /// <summary>void glVertex3hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glVertex3hvNV;

        /// <summary>void glVertex4hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glVertex4hNV;

        /// <summary>void glVertex4hvNV(const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glVertex4hvNV;

        /// <summary>void glVertexAttrib1hNV(GLuint index, GLhalfNV x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV, void> glVertexAttrib1hNV;

        /// <summary>void glVertexAttrib1hvNV(GLuint index, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV*, void> glVertexAttrib1hvNV;

        /// <summary>void glVertexAttrib2hNV(GLuint index, GLhalfNV x, GLhalfNV y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV, GLhalfNV, void> glVertexAttrib2hNV;

        /// <summary>void glVertexAttrib2hvNV(GLuint index, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV*, void> glVertexAttrib2hvNV;

        /// <summary>void glVertexAttrib3hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV, GLhalfNV, GLhalfNV, void> glVertexAttrib3hNV;

        /// <summary>void glVertexAttrib3hvNV(GLuint index, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV*, void> glVertexAttrib3hvNV;

        /// <summary>void glVertexAttrib4hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV, GLhalfNV, GLhalfNV, GLhalfNV, void> glVertexAttrib4hNV;

        /// <summary>void glVertexAttrib4hvNV(GLuint index, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLhalfNV*, void> glVertexAttrib4hvNV;

        /// <summary>void glVertexAttribs1hvNV(GLuint index, GLsizei n, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLhalfNV*, void> glVertexAttribs1hvNV;

        /// <summary>void glVertexAttribs2hvNV(GLuint index, GLsizei n, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLhalfNV*, void> glVertexAttribs2hvNV;

        /// <summary>void glVertexAttribs3hvNV(GLuint index, GLsizei n, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLhalfNV*, void> glVertexAttribs3hvNV;

        /// <summary>void glVertexAttribs4hvNV(GLuint index, GLsizei n, const GLhalfNV* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLhalfNV*, void> glVertexAttribs4hvNV;

        /// <summary>void glVertexWeighthNV(GLhalfNV weight)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV, void> glVertexWeighthNV;

        /// <summary>void glVertexWeighthvNV(const GLhalfNV* weight)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhalfNV*, void> glVertexWeighthvNV;
    }
}
#endif