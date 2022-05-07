#if (GL_EXT_index_material && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_INDEX_MATERIAL_EXT = 0x81B8;
        public const GLenum GL_INDEX_MATERIAL_PARAMETER_EXT = 0x81B9;
        public const GLenum GL_INDEX_MATERIAL_FACE_EXT = 0x81BA;
    }
}
#endif