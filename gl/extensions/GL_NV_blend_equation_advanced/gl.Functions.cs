#if GL_NV_blend_equation_advanced

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBlendBarrierNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBlendBarrierNV;

        /// <summary>void glBlendParameteriNV(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLint, void> glBlendParameteriNV;
    }
}

#endif