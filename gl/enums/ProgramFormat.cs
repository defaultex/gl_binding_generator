#if (GL_ARB_FRAGMENT_PROGRAM || GL_ARB_VERTEX_PROGRAM)

public enum ProgramFormat : GLenum { 
#if (GL_ARB_FRAGMENT_PROGRAM || GL_ARB_VERTEX_PROGRAM)
    FormatAsciiArb = gl.Constants.GL_PROGRAM_FORMAT_ASCII_ARB, 
#endif

}

#endif
