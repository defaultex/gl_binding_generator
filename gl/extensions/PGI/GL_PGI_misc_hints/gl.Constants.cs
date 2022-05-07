#if (GL_PGI_misc_hints && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8;
        public const GLenum GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD;
        public const GLenum GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE;
        public const GLenum GL_NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202;
        public const GLenum GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203;
        public const GLenum GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204;
        public const GLenum GL_ALWAYS_FAST_HINT_PGI = 0x1A20C;
        public const GLenum GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D;
        public const GLenum GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E;
        public const GLenum GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F;
        public const GLenum GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210;
        public const GLenum GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211;
        public const GLenum GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216;
        public const GLenum GL_STRICT_LIGHTING_HINT_PGI = 0x1A217;
        public const GLenum GL_STRICT_SCISSOR_HINT_PGI = 0x1A218;
        public const GLenum GL_FULL_STIPPLE_HINT_PGI = 0x1A219;
        public const GLenum GL_CLIP_NEAR_HINT_PGI = 0x1A220;
        public const GLenum GL_CLIP_FAR_HINT_PGI = 0x1A221;
        public const GLenum GL_WIDE_LINE_HINT_PGI = 0x1A222;
        public const GLenum GL_BACK_NORMALS_HINT_PGI = 0x1A223;
    }
}
#endif