#if (GL_NV_pixel_data_range && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFlushPixelDataRangeNV(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelDataRangeTargetNV, void> glFlushPixelDataRangeNV;

        /// <summary>void glPixelDataRangeNV(GLenum target, GLsizei length, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelDataRangeTargetNV, GLsizei, void*, void> glPixelDataRangeNV;
    }
}
#endif