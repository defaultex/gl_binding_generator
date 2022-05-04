#if (GL_ATI_map_object_buffer && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void* glMapObjectBufferATI(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, void*> glMapObjectBufferATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUnmapObjectBufferATI(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, void> glUnmapObjectBufferATI;
#endif
    }
}
#endif