#if (GL_ANGLE_instanced_arrays && GLES2_API)
public partial class angle { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE = 0x88FE;
#endif
    }
}
#endif