#if (GL_ATI_meminfo && GL_API)
public partial class ati { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VBO_FREE_MEMORY_ATI = 0x87FB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FREE_MEMORY_ATI = 0x87FC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD;
#endif
    }
}
#endif