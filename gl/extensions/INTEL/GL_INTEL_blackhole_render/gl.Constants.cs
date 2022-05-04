#if (GL_INTEL_blackhole_render && (GL_API || GLCORE_API || GLES2_API))
public partial class intel { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLACKHOLE_RENDER_INTEL = 0x83FC;
#endif
    }
}
#endif