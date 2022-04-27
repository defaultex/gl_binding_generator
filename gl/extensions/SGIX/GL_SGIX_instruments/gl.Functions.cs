#if (GL_SGIX_instruments && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLint glGetInstrumentsSGIX()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint> glGetInstrumentsSGIX;

        /// <summary>void glInstrumentsBufferSGIX(GLsizei size, GLint* buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, void> glInstrumentsBufferSGIX;

        /// <summary>GLint glPollInstrumentsSGIX(GLint* marker_p)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, GLint> glPollInstrumentsSGIX;

        /// <summary>void glReadInstrumentsSGIX(GLint marker)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glReadInstrumentsSGIX;

        /// <summary>void glStartInstrumentsSGIX()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glStartInstrumentsSGIX;

        /// <summary>void glStopInstrumentsSGIX(GLint marker)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, void> glStopInstrumentsSGIX;
    }
}
#endif