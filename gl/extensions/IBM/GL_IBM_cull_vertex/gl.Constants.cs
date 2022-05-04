#if (GL_IBM_cull_vertex && GL_API)
public partial class ibm { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CULL_VERTEX_IBM = 103050;
#endif
    }
}
#endif