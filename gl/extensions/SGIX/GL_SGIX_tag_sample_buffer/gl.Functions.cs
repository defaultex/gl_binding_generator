#if (GL_SGIX_tag_sample_buffer && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTagSampleBufferSGIX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glTagSampleBufferSGIX;
#endif
    }
}
#endif