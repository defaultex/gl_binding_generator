#if (GL_SGIX_pixel_texture && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glPixelTexGenSGIX(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTexGenModeSGIX, void> glPixelTexGenSGIX;
    }
}
#endif