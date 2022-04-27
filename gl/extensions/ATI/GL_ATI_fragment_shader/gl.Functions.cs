#if (GL_ATI_fragment_shader && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glAlphaFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, void> glAlphaFragmentOp1ATI;

        /// <summary>void glAlphaFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glAlphaFragmentOp2ATI;

        /// <summary>void glAlphaFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glAlphaFragmentOp3ATI;

        /// <summary>void glBeginFragmentShaderATI()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBeginFragmentShaderATI;

        /// <summary>void glBindFragmentShaderATI(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBindFragmentShaderATI;

        /// <summary>void glColorFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glColorFragmentOp1ATI;

        /// <summary>void glColorFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glColorFragmentOp2ATI;

        /// <summary>void glColorFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FragmentOpATI, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, GLuint, void> glColorFragmentOp3ATI;

        /// <summary>void glDeleteFragmentShaderATI(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDeleteFragmentShaderATI;

        /// <summary>void glEndFragmentShaderATI()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndFragmentShaderATI;

        /// <summary>GLuint glGenFragmentShadersATI(GLuint range)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint> glGenFragmentShadersATI;

        /// <summary>void glPassTexCoordATI(GLuint dst, GLuint coord, GLenum swizzle)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, SwizzleOpATI, void> glPassTexCoordATI;

        /// <summary>void glSampleMapATI(GLuint dst, GLuint interp, GLenum swizzle)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, SwizzleOpATI, void> glSampleMapATI;

        /// <summary>void glSetFragmentShaderConstantATI(GLuint dst, const GLfloat* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glSetFragmentShaderConstantATI;
    }
}
#endif