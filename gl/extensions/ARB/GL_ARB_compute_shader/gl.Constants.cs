#if (GL_ARB_compute_shader && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLbitfield GL_COMPUTE_SHADER_BIT = 0x00000020;
        public const GLenum GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
        public const GLenum GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
        public const GLenum GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
        public const GLenum GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
        public const GLenum GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
        public const GLenum GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
        public const GLenum GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
        public const GLenum GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
        public const GLenum GL_COMPUTE_SHADER = 0x91B9;
        public const GLenum GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
        public const GLenum GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
        public const GLenum GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
    }
}
#endif