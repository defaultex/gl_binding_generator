#if (GL_VERSION_3_0 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_CLIP_DISTANCES = 0x0D32;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HALF_FLOAT = 0x140B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIP_DISTANCE0 = 0x3000;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIP_DISTANCE1 = 0x3001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIP_DISTANCE2 = 0x3002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIP_DISTANCE3 = 0x3003;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIP_DISTANCE4 = 0x3004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIP_DISTANCE5 = 0x3005;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIP_DISTANCE6 = 0x3006;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLIP_DISTANCE7 = 0x3007;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_DEFAULT = 0x8218;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_UNDEFINED = 0x8219;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAJOR_VERSION = 0x821B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MINOR_VERSION = 0x821C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_EXTENSIONS = 0x821D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_FLAGS = 0x821E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INDEX = 0x8222;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RED = 0x8225;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RG = 0x8226;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG = 0x8227;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG_INTEGER = 0x8228;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R8 = 0x8229;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R16 = 0x822A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG8 = 0x822B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG16 = 0x822C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R16F = 0x822D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R32F = 0x822E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG16F = 0x822F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG32F = 0x8230;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R8I = 0x8231;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R8UI = 0x8232;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R16I = 0x8233;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R16UI = 0x8234;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R32I = 0x8235;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R32UI = 0x8236;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG8I = 0x8237;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG8UI = 0x8238;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG16I = 0x8239;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG16UI = 0x823A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG32I = 0x823B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG32UI = 0x823C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_STENCIL = 0x84F9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_24_8 = 0x84FA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ARRAY_BINDING = 0x85B5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA32F = 0x8814;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB32F = 0x8815;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA16F = 0x881A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB16F = 0x881B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPARE_REF_TO_TEXTURE = 0x884E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH24_STENCIL8 = 0x88F0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_STENCIL_SIZE = 0x88F1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLAMP_VERTEX_COLOR = 0x891A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLAMP_FRAGMENT_COLOR = 0x891B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLAMP_READ_COLOR = 0x891C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FIXED_ONLY = 0x891D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VARYING_COMPONENTS = 0x8B4B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_RED_TYPE = 0x8C10;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_GREEN_TYPE = 0x8C11;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BLUE_TYPE = 0x8C12;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_ALPHA_TYPE = 0x8C13;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_LUMINANCE_TYPE = 0x8C14;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_INTENSITY_TYPE = 0x8C15;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_DEPTH_TYPE = 0x8C16;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_NORMALIZED = 0x8C17;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_1D_ARRAY = 0x8C18;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_ARRAY = 0x8C1A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R11F_G11F_B10F = 0x8C3A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB9_E5 = 0x8C3D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_SHARED_SIZE = 0x8C3F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVES_GENERATED = 0x8C87;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RASTERIZER_DISCARD = 0x8C89;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INTERLEAVED_ATTRIBS = 0x8C8C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SEPARATE_ATTRIBS = 0x8C8D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_BINDING = 0x8CA6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_BINDING = 0x8CA7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_READ_FRAMEBUFFER = 0x8CA8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_FRAMEBUFFER = 0x8CA9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_SAMPLES = 0x8CAB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_COMPONENT32F = 0x8CAC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH32F_STENCIL8 = 0x8CAD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT0 = 0x8CE0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT1 = 0x8CE1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT2 = 0x8CE2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT3 = 0x8CE3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT4 = 0x8CE4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT5 = 0x8CE5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT6 = 0x8CE6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT7 = 0x8CE7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT8 = 0x8CE8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT9 = 0x8CE9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT10 = 0x8CEA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT11 = 0x8CEB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT12 = 0x8CEC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT13 = 0x8CED;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT14 = 0x8CEE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT15 = 0x8CEF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT16 = 0x8CF0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT17 = 0x8CF1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT18 = 0x8CF2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT19 = 0x8CF3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT20 = 0x8CF4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT21 = 0x8CF5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT22 = 0x8CF6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT23 = 0x8CF7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT24 = 0x8CF8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT25 = 0x8CF9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT26 = 0x8CFA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT27 = 0x8CFB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT28 = 0x8CFC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT29 = 0x8CFD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT30 = 0x8CFE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT31 = 0x8CFF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_ATTACHMENT = 0x8D00;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_ATTACHMENT = 0x8D20;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER = 0x8D40;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER = 0x8D41;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_WIDTH = 0x8D42;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_HEIGHT = 0x8D43;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX1 = 0x8D46;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX4 = 0x8D47;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX8 = 0x8D48;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX16 = 0x8D49;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_RED_SIZE = 0x8D50;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_SAMPLES = 0x8D57;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA32UI = 0x8D70;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB32UI = 0x8D71;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA16UI = 0x8D76;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB16UI = 0x8D77;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8UI = 0x8D7C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8UI = 0x8D7D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA32I = 0x8D82;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB32I = 0x8D83;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA16I = 0x8D88;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB16I = 0x8D89;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8I = 0x8D8E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8I = 0x8D8F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RED_INTEGER = 0x8D94;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GREEN_INTEGER = 0x8D95;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BLUE_INTEGER = 0x8D96;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ALPHA_INTEGER = 0x8D97;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB_INTEGER = 0x8D98;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA_INTEGER = 0x8D99;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BGR_INTEGER = 0x8D9A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BGRA_INTEGER = 0x8D9B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_SRGB = 0x8DB9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_1D_ARRAY = 0x8DC0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_ARRAY = 0x8DC1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_VEC2 = 0x8DC6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_VEC3 = 0x8DC7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_VEC4 = 0x8DC8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_1D = 0x8DC9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_2D = 0x8DCA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_3D = 0x8DCB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_CUBE = 0x8DCC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_1D_ARRAY = 0x8DCE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_WAIT = 0x8E13;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_NO_WAIT = 0x8E14;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_BY_REGION_WAIT = 0x8E15;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_BY_REGION_NO_WAIT = 0x8E16;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_ACCESS_FLAGS = 0x911F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_MAP_LENGTH = 0x9120;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_MAP_OFFSET = 0x9121;
#endif
    }
}
#endif