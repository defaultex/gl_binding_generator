#if (GL_APPLE_copy_texture_levels && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glCopyTextureLevelsAPPLE(GLuint destinationTexture, GLuint sourceTexture, GLint sourceBaseLevel, GLsizei sourceLevelCount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLint, GLsizei, void> glCopyTextureLevelsAPPLE;
    }
}
#endif