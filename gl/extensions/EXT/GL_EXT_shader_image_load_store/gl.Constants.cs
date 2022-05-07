#if (GL_EXT_shader_image_load_store && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;
        public const GLenum GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002;
        public const GLenum GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004;
        public const GLenum GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008;
        public const GLenum GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;
        public const GLenum GL_COMMAND_BARRIER_BIT_EXT = 0x00000040;
        public const GLenum GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080;
        public const GLenum GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;
        public const GLenum GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200;
        public const GLenum GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400;
        public const GLenum GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;
        public const GLenum GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;
        public const GLenum GL_MAX_IMAGE_UNITS_EXT = 0x8F38;
        public const GLenum GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;
        public const GLenum GL_IMAGE_BINDING_NAME_EXT = 0x8F3A;
        public const GLenum GL_IMAGE_BINDING_LEVEL_EXT = 0x8F3B;
        public const GLenum GL_IMAGE_BINDING_LAYERED_EXT = 0x8F3C;
        public const GLenum GL_IMAGE_BINDING_LAYER_EXT = 0x8F3D;
        public const GLenum GL_IMAGE_BINDING_ACCESS_EXT = 0x8F3E;
        public const GLenum GL_IMAGE_1D_EXT = 0x904C;
        public const GLenum GL_IMAGE_2D_EXT = 0x904D;
        public const GLenum GL_IMAGE_3D_EXT = 0x904E;
        public const GLenum GL_IMAGE_2D_RECT_EXT = 0x904F;
        public const GLenum GL_IMAGE_CUBE_EXT = 0x9050;
        public const GLenum GL_IMAGE_BUFFER_EXT = 0x9051;
        public const GLenum GL_IMAGE_1D_ARRAY_EXT = 0x9052;
        public const GLenum GL_IMAGE_2D_ARRAY_EXT = 0x9053;
        public const GLenum GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
        public const GLenum GL_IMAGE_2D_MULTISAMPLE_EXT = 0x9055;
        public const GLenum GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;
        public const GLenum GL_INT_IMAGE_1D_EXT = 0x9057;
        public const GLenum GL_INT_IMAGE_2D_EXT = 0x9058;
        public const GLenum GL_INT_IMAGE_3D_EXT = 0x9059;
        public const GLenum GL_INT_IMAGE_2D_RECT_EXT = 0x905A;
        public const GLenum GL_INT_IMAGE_CUBE_EXT = 0x905B;
        public const GLenum GL_INT_IMAGE_BUFFER_EXT = 0x905C;
        public const GLenum GL_INT_IMAGE_1D_ARRAY_EXT = 0x905D;
        public const GLenum GL_INT_IMAGE_2D_ARRAY_EXT = 0x905E;
        public const GLenum GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
        public const GLenum GL_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060;
        public const GLenum GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;
        public const GLenum GL_UNSIGNED_INT_IMAGE_1D_EXT = 0x9062;
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_EXT = 0x9063;
        public const GLenum GL_UNSIGNED_INT_IMAGE_3D_EXT = 0x9064;
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066;
        public const GLenum GL_UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;
        public const GLenum GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;
        public const GLenum GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;
        public const GLenum GL_MAX_IMAGE_SAMPLES_EXT = 0x906D;
        public const GLenum GL_IMAGE_BINDING_FORMAT_EXT = 0x906E;
        public const GLenum GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF;
    }
}
#endif