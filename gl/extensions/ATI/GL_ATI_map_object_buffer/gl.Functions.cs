#if (GL_ATI_map_object_buffer && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void* glMapObjectBufferATI(GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, void*> glMapObjectBufferATI;

        /// <summary>void glUnmapObjectBufferATI(GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, void> glUnmapObjectBufferATI;
    }
}
#endif