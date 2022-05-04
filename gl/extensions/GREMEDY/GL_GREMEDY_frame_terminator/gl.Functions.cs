#if (GL_GREMEDY_frame_terminator && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFrameTerminatorGREMEDY();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glFrameTerminatorGREMEDY;
#endif
    }
}
#endif