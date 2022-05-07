#if (GL_SGIX_flush_raster && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFlushRasterSGIX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFlushRasterSGIX;
    }
}
#endif