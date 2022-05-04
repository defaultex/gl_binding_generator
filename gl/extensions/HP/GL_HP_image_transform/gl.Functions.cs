#if (GL_HP_image_transform && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetImageTransformParameterfvHP(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLfloat*, void> glGetImageTransformParameterfvHP;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetImageTransformParameterivHP(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLint*, void> glGetImageTransformParameterivHP;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImageTransformParameterfHP(GLenum target, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLfloat, void> glImageTransformParameterfHP;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImageTransformParameterfvHP(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLfloat*, void> glImageTransformParameterfvHP;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImageTransformParameteriHP(GLenum target, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLint, void> glImageTransformParameteriHP;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImageTransformParameterivHP(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ImageTransformTargetHP, ImageTransformPNameHP, GLint*, void> glImageTransformParameterivHP;
#endif
    }
}
#endif