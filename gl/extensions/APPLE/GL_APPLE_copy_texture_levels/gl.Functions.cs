#if (GL_APPLE_copy_texture_levels && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCopyTextureLevelsAPPLE(GLuint destinationTexture, GLuint sourceTexture, GLint sourceBaseLevel, GLsizei sourceLevelCount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLint, GLsizei, void> glCopyTextureLevelsAPPLE;
#endif
    }
}
#endif