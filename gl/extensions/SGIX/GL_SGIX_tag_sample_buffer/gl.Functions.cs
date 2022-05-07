#if (GL_SGIX_tag_sample_buffer && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTagSampleBufferSGIX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glTagSampleBufferSGIX;
    }
}
#endif