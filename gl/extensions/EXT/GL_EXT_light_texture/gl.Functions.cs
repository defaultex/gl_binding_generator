#if (GL_EXT_light_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glApplyTextureEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightTextureModeEXT, void> glApplyTextureEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureLightEXT(GLenum pname);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightTexturePNameEXT, void> glTextureLightEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureMaterialEXT(GLenum face, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, void> glTextureMaterialEXT;
#endif
    }
}
#endif