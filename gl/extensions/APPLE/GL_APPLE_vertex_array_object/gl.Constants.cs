#if (GL_APPLE_vertex_array_object && GL_API)
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_BINDING_APPLE = 0x85B5;
#endif
    }
}
#endif