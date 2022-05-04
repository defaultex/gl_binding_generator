#if (GL_NV_fill_rectangle && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FILL_RECTANGLE_NV = 0x933C;
#endif
    }
}
#endif