#if (GL_EXT_draw_buffers2 && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glColorMaskIndexedEXT(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaskIndexedEXT;
    }
}
#endif