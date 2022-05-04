#if (GL_NV_command_list && (GL_API || GLCORE_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TERMINATE_SEQUENCE_COMMAND_NV = 0x0000;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_NOP_COMMAND_NV = 0x0001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_ELEMENTS_COMMAND_NV = 0x0002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_ARRAYS_COMMAND_NV = 0x0003;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ELEMENT_ADDRESS_COMMAND_NV = 0x0008;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_ADDRESS_COMMAND_NV = 0x000A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_COLOR_COMMAND_NV = 0x000B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_STENCIL_REF_COMMAND_NV = 0x000C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LINE_WIDTH_COMMAND_NV = 0x000D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POLYGON_OFFSET_COMMAND_NV = 0x000E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_REF_COMMAND_NV = 0x000F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEWPORT_COMMAND_NV = 0x0010;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SCISSOR_COMMAND_NV = 0x0011;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRONT_FACE_COMMAND_NV = 0x0012;
#endif
    }
}
#endif