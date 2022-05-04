#if (GL_IBM_static_data && GL_API)
public partial class ibm { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALL_STATIC_DATA_IBM = 103060;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STATIC_VERTEX_ARRAY_IBM = 103061;
#endif
    }
}
#endif