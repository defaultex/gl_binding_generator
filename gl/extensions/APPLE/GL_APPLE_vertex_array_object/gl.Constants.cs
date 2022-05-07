#if (GL_APPLE_vertex_array_object && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_ARRAY_BINDING_APPLE = 0x85B5;
    }
}
#endif