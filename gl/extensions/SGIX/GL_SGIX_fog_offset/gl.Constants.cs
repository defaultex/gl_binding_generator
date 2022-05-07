#if (GL_SGIX_fog_offset && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FOG_OFFSET_SGIX = 0x8198;
        public const GLenum GL_FOG_OFFSET_VALUE_SGIX = 0x8199;
    }
}
#endif