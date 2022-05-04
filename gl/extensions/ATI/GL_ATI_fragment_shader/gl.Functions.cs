#if (GL_ATI_fragment_shader && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAlphaFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, void> glAlphaFragmentOp1ATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAlphaFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glAlphaFragmentOp2ATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAlphaFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glAlphaFragmentOp3ATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginFragmentShaderATI();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBeginFragmentShaderATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindFragmentShaderATI(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBindFragmentShaderATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glColorFragmentOp1ATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glColorFragmentOp2ATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glColorFragmentOp3ATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteFragmentShaderATI(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDeleteFragmentShaderATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndFragmentShaderATI();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndFragmentShaderATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glGenFragmentShadersATI(GLuint range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint> glGenFragmentShadersATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPassTexCoordATI(GLuint dst, GLuint coord, GLenum swizzle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, SwizzleOpATI, void> glPassTexCoordATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSampleMapATI(GLuint dst, GLuint interp, GLenum swizzle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, SwizzleOpATI, void> glSampleMapATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSetFragmentShaderConstantATI(GLuint dst, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glSetFragmentShaderConstantATI;
#endif
    }
}
#endif