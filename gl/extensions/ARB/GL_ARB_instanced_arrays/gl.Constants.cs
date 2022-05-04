#if (GL_ARB_instanced_arrays && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;
#endif
    }
}
#endif