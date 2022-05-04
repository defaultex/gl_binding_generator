#if (GL_EXT_shader_image_load_store && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COMMAND_BARRIER_BIT_EXT = 0x00000040;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_IMAGE_UNITS_EXT = 0x8F38;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_BINDING_NAME_EXT = 0x8F3A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_BINDING_LEVEL_EXT = 0x8F3B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_BINDING_LAYERED_EXT = 0x8F3C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_BINDING_LAYER_EXT = 0x8F3D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_BINDING_ACCESS_EXT = 0x8F3E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_1D_EXT = 0x904C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_2D_EXT = 0x904D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_3D_EXT = 0x904E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_2D_RECT_EXT = 0x904F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_CUBE_EXT = 0x9050;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_BUFFER_EXT = 0x9051;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_1D_ARRAY_EXT = 0x9052;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_2D_ARRAY_EXT = 0x9053;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_2D_MULTISAMPLE_EXT = 0x9055;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_1D_EXT = 0x9057;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_2D_EXT = 0x9058;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_3D_EXT = 0x9059;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_2D_RECT_EXT = 0x905A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_CUBE_EXT = 0x905B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_BUFFER_EXT = 0x905C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_1D_ARRAY_EXT = 0x905D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_2D_ARRAY_EXT = 0x905E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_1D_EXT = 0x9062;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_EXT = 0x9063;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_3D_EXT = 0x9064;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_IMAGE_SAMPLES_EXT = 0x906D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_BINDING_FORMAT_EXT = 0x906E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF;
#endif
    }
}
#endif