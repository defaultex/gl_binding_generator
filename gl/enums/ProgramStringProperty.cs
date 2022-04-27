#if (GL_ARB_FRAGMENT_PROGRAM || GL_ARB_VERTEX_PROGRAM)

public enum ProgramStringProperty : GLenum { 
#if (GL_ARB_FRAGMENT_PROGRAM || GL_ARB_VERTEX_PROGRAM)
    Arb = gl.Constants.GL_PROGRAM_STRING_ARB, 
#endif

}

#endif
