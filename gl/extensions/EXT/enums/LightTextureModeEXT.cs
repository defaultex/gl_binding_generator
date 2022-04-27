#if (GL_EXT_FOG_COORD || GL_EXT_LIGHT_TEXTURE)

public enum LightTextureModeEXT : GLenum { 
#if (GL_EXT_FOG_COORD || GL_EXT_LIGHT_TEXTURE)
    FragmentDepthExt = gl.Constants.GL_FRAGMENT_DEPTH_EXT, 
#endif

#if GL_EXT_LIGHT_TEXTURE
    FragmentMaterialExt = gl.Constants.GL_FRAGMENT_MATERIAL_EXT, 
#endif

#if GL_EXT_LIGHT_TEXTURE
    FragmentNormalExt = gl.Constants.GL_FRAGMENT_NORMAL_EXT, 
#endif

#if GL_EXT_LIGHT_TEXTURE
    FragmentColorExt = gl.Constants.GL_FRAGMENT_COLOR_EXT, 
#endif

}

#endif
