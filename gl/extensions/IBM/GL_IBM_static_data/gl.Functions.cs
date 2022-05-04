#if (GL_IBM_static_data && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFlushStaticDataIBM(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glFlushStaticDataIBM;
#endif
    }
}
#endif