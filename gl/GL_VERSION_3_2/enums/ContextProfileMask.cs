#if GL_VERSION_3_2
[Flags]
public enum ContextProfileMask : GLbitfield { 
    None = 0,
#if GL_VERSION_3_2
    CoreProfile = gl.Constants.GL_CONTEXT_CORE_PROFILE_BIT, 
#endif

#if GL_VERSION_3_2
    CompatibilityProfile = gl.Constants.GL_CONTEXT_COMPATIBILITY_PROFILE_BIT, 
#endif

}

#endif
