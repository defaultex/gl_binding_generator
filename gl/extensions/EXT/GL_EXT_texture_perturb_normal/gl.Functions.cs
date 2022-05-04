#if (GL_EXT_texture_perturb_normal && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureNormalEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureNormalModeEXT, void> glTextureNormalEXT;
#endif
    }
}
#endif