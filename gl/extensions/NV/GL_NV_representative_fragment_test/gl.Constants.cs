#if (GL_NV_representative_fragment_test && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REPRESENTATIVE_FRAGMENT_TEST_NV = 0x937F;
#endif
    }
}
#endif