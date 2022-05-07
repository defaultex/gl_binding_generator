#if (GL_NV_primitive_restart && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPrimitiveRestartIndexNV(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glPrimitiveRestartIndexNV;

        /// <summary>void glPrimitiveRestartNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPrimitiveRestartNV;
    }
}
#endif