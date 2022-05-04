#if (GL_SGIX_instruments && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glGetInstrumentsSGIX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint> glGetInstrumentsSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glInstrumentsBufferSGIX(GLsizei size, GLint* buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, void> glInstrumentsBufferSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glPollInstrumentsSGIX(GLint* marker_p);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLint> glPollInstrumentsSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReadInstrumentsSGIX(GLint marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glReadInstrumentsSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStartInstrumentsSGIX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glStartInstrumentsSGIX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glStopInstrumentsSGIX(GLint marker);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glStopInstrumentsSGIX;
#endif
    }
}
#endif