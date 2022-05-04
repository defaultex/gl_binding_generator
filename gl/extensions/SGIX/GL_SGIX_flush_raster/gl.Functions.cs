#if (GL_SGIX_flush_raster && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFlushRasterSGIX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlushRasterSGIX;
#endif
    }
}
#endif