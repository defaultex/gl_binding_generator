#if (GL_GREMEDY_string_marker && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStringMarkerGREMEDY(GLsizei len, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glStringMarkerGREMEDY;
#endif
    }
}
#endif