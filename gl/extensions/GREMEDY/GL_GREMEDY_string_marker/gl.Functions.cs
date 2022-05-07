#if (GL_GREMEDY_string_marker && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glStringMarkerGREMEDY(GLsizei len, void* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, void*, void> glStringMarkerGREMEDY;
    }
}
#endif