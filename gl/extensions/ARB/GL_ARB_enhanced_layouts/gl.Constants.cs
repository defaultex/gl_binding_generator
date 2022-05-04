#if (GL_ARB_enhanced_layouts && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_LOCATION_COMPONENT = 0x934A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
#endif
    }
}
#endif