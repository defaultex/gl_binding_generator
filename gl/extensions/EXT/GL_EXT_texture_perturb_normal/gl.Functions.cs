#if (GL_EXT_texture_perturb_normal && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTextureNormalEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureNormalModeEXT, void> glTextureNormalEXT;
    }
}
#endif