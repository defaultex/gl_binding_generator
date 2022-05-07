#if (GL_ARB_vertex_type_2_10_10_10_rev && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glColorP3ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glColorP3ui;

        /// <summary>void glColorP3uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glColorP3uiv;

        /// <summary>void glColorP4ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glColorP4ui;

        /// <summary>void glColorP4uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glColorP4uiv;

        /// <summary>void glMultiTexCoordP1ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP1ui;

        /// <summary>void glMultiTexCoordP1uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP1uiv;

        /// <summary>void glMultiTexCoordP2ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP2ui;

        /// <summary>void glMultiTexCoordP2uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP2uiv;

        /// <summary>void glMultiTexCoordP3ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP3ui;

        /// <summary>void glMultiTexCoordP3uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP3uiv;

        /// <summary>void glMultiTexCoordP4ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP4ui;

        /// <summary>void glMultiTexCoordP4uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP4uiv;

        /// <summary>void glNormalP3ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLuint, void> glNormalP3ui;

        /// <summary>void glNormalP3uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLuint*, void> glNormalP3uiv;

        /// <summary>void glSecondaryColorP3ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glSecondaryColorP3ui;

        /// <summary>void glSecondaryColorP3uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glSecondaryColorP3uiv;

        /// <summary>void glTexCoordP1ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP1ui;

        /// <summary>void glTexCoordP1uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP1uiv;

        /// <summary>void glTexCoordP2ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP2ui;

        /// <summary>void glTexCoordP2uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP2uiv;

        /// <summary>void glTexCoordP3ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP3ui;

        /// <summary>void glTexCoordP3uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP3uiv;

        /// <summary>void glTexCoordP4ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP4ui;

        /// <summary>void glTexCoordP4uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP4uiv;

        /// <summary>void glVertexAttribP1ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP1ui;

        /// <summary>void glVertexAttribP1uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP1uiv;

        /// <summary>void glVertexAttribP2ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP2ui;

        /// <summary>void glVertexAttribP2uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP2uiv;

        /// <summary>void glVertexAttribP3ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP3ui;

        /// <summary>void glVertexAttribP3uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP3uiv;

        /// <summary>void glVertexAttribP4ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP4ui;

        /// <summary>void glVertexAttribP4uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP4uiv;

        /// <summary>void glVertexP2ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP2ui;

        /// <summary>void glVertexP2uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP2uiv;

        /// <summary>void glVertexP3ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP3ui;

        /// <summary>void glVertexP3uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP3uiv;

        /// <summary>void glVertexP4ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP4ui;

        /// <summary>void glVertexP4uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP4uiv;
    }
}
#endif