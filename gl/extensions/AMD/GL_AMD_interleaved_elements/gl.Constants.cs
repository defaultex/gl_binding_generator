#if (GL_AMD_interleaved_elements && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RED = 0x1903;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_GREEN = 0x1904;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLUE = 0x1905;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_ALPHA = 0x1906;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RG8UI = 0x8238;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RG16UI = 0x823A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8UI = 0x8D7C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ELEMENT_SWIZZLE_AMD = 0x91A4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ID_SWIZZLE_AMD = 0x91A5;
#endif
    }
}
#endif