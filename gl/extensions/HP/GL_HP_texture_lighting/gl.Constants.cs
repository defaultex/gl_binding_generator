#if (GL_HP_texture_lighting && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_LIGHTING_MODE_HP = 0x8167;
        public const GLenum GL_TEXTURE_POST_SPECULAR_HP = 0x8168;
        public const GLenum GL_TEXTURE_PRE_SPECULAR_HP = 0x8169;
    }
}
#endif