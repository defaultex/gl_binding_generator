#if (GL_ARB_vertex_type_2_10_10_10_rev && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glColorP3ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glColorP3ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glColorP3uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glColorP3uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glColorP4ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glColorP4ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glColorP4uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glColorP4uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP1ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP1ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP1uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP1uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP2ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP2ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP2uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP2uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP3ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP3ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP3uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP3uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP4ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP4ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP4uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP4uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNormalP3ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLuint, void> glNormalP3ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glNormalP3uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLuint*, void> glNormalP3uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glSecondaryColorP3ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glSecondaryColorP3ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glSecondaryColorP3uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glSecondaryColorP3uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP1ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP1ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP1uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP1uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP2ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP2ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP2uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP2uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP3ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP3ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP3uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP3uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP4ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP4ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP4uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP4uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP1ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP1ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP1uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP1uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP2ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP2ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP2uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP2uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP3ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP3ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP3uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP3uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP4ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP4ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP4uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP4uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexP2ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP2ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexP2uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP2uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexP3ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP3ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexP3uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP3uiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexP4ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP4ui;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glVertexP4uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP4uiv;
#endif
    }
}
#endif