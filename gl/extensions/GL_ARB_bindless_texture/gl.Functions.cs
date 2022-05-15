#if GL_ARB_bindless_texture

public partial class gl { 
    public partial class Functions { 

        /// <summary>GLuint64 glGetImageHandleARB(GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLboolean, GLint, PixelFormat, GLuint64> glGetImageHandleARB;

        /// <summary>GLuint64 glGetTextureHandleARB(GLuint texture);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLuint64> glGetTextureHandleARB;

        /// <summary>GLuint64 glGetTextureSamplerHandleARB(GLuint texture, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsampler, GLuint64> glGetTextureSamplerHandleARB;

        /// <summary>void glGetVertexAttribLui64vARB(GLuint index, GLenum pname, GLuint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribProperty, GLuint64EXT*, void> glGetVertexAttribLui64vARB;

        /// <summary>GLboolean glIsImageHandleResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsImageHandleResidentARB;

        /// <summary>GLboolean glIsTextureHandleResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsTextureHandleResidentARB;

        /// <summary>void glMakeImageHandleNonResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeImageHandleNonResidentARB;

        /// <summary>void glMakeImageHandleResidentARB(GLuint64 handle, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLenum, void> glMakeImageHandleResidentARB;

        /// <summary>void glMakeTextureHandleNonResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleNonResidentARB;

        /// <summary>void glMakeTextureHandleResidentARB(GLuint64 handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleResidentARB;

        /// <summary>void glProgramUniformHandleui64ARB(GLuint program, GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, void> glProgramUniformHandleui64ARB;

        /// <summary>void glProgramUniformHandleui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniformHandleui64vARB;

        /// <summary>void glUniformHandleui64ARB(GLint location, GLuint64 value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniformHandleui64ARB;

        /// <summary>void glUniformHandleui64vARB(GLint location, GLsizei count, GLuint64* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniformHandleui64vARB;

        /// <summary>void glVertexAttribL1ui64ARB(GLuint index, GLuint64EXT x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, void> glVertexAttribL1ui64ARB;

        /// <summary>void glVertexAttribL1ui64vARB(GLuint index, GLuint64EXT* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL1ui64vARB;
    }
}

#endif