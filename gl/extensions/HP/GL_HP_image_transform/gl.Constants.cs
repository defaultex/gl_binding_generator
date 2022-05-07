#if (GL_HP_image_transform && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_IMAGE_SCALE_X_HP = 0x8155;
        public const GLenum GL_IMAGE_SCALE_Y_HP = 0x8156;
        public const GLenum GL_IMAGE_TRANSLATE_X_HP = 0x8157;
        public const GLenum GL_IMAGE_TRANSLATE_Y_HP = 0x8158;
        public const GLenum GL_IMAGE_ROTATE_ANGLE_HP = 0x8159;
        public const GLenum GL_IMAGE_ROTATE_ORIGIN_X_HP = 0x815A;
        public const GLenum GL_IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B;
        public const GLenum GL_IMAGE_MAG_FILTER_HP = 0x815C;
        public const GLenum GL_IMAGE_MIN_FILTER_HP = 0x815D;
        public const GLenum GL_IMAGE_CUBIC_WEIGHT_HP = 0x815E;
        public const GLenum GL_CUBIC_HP = 0x815F;
        public const GLenum GL_AVERAGE_HP = 0x8160;
        public const GLenum GL_IMAGE_TRANSFORM_2D_HP = 0x8161;
        public const GLenum GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162;
        public const GLenum GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163;
    }
}
#endif