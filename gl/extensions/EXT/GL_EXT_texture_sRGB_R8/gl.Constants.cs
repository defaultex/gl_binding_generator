#if (GL_EXT_texture_sRGB_R8 && (GLES2_API || GL_API || GLCORE_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SR8_EXT = 0x8FBD;
#endif
    }
}
#endif