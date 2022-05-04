#if (GL_NVX_cross_process_interop && DISABLED_API)
public partial class nvx { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EXTERNAL_STORAGE_BIT_NVX = 0x2000;
#endif
    }
}
#endif