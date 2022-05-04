#if (GL_PGI_misc_hints && GL_API)
public partial class pgi { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALWAYS_FAST_HINT_PGI = 0x1A20C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STRICT_LIGHTING_HINT_PGI = 0x1A217;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STRICT_SCISSOR_HINT_PGI = 0x1A218;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FULL_STIPPLE_HINT_PGI = 0x1A219;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_NEAR_HINT_PGI = 0x1A220;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLIP_FAR_HINT_PGI = 0x1A221;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WIDE_LINE_HINT_PGI = 0x1A222;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BACK_NORMALS_HINT_PGI = 0x1A223;
#endif
    }
}
#endif