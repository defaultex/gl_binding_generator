#if (GL_NV_pixel_data_range && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFlushPixelDataRangeNV(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelDataRangeTargetNV, void> glFlushPixelDataRangeNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelDataRangeNV(GLenum target, GLsizei length, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelDataRangeTargetNV, GLsizei, void*, void> glPixelDataRangeNV;
#endif
    }
}
#endif