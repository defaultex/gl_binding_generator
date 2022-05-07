#if (GL_EXT_draw_range_elements && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawRangeElementsEXT(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, void> glDrawRangeElementsEXT;
    }
}
#endif