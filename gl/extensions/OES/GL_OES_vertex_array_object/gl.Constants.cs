#if (GL_OES_vertex_array_object && (GLES1_API || GLES2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_BINDING_OES = 0x85B5;
#endif
    }
}
#endif