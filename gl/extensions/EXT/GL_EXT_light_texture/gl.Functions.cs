#if (GL_EXT_light_texture && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glApplyTextureEXT(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightTextureModeEXT, void> glApplyTextureEXT;

        /// <summary>void glTextureLightEXT(GLenum pname);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightTexturePNameEXT, void> glTextureLightEXT;

        /// <summary>void glTextureMaterialEXT(GLenum face, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, void> glTextureMaterialEXT;
    }
}
#endif