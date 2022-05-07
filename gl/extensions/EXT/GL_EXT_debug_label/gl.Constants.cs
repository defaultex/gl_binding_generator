#if (GL_EXT_debug_label && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SAMPLER = 0x82E6;
        public const GLenum GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;
        public const GLenum GL_PROGRAM_OBJECT_EXT = 0x8B40;
        public const GLenum GL_SHADER_OBJECT_EXT = 0x8B48;
        public const GLenum GL_TRANSFORM_FEEDBACK = 0x8E22;
        public const GLenum GL_BUFFER_OBJECT_EXT = 0x9151;
        public const GLenum GL_QUERY_OBJECT_EXT = 0x9153;
        public const GLenum GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154;
    }
}
#endif