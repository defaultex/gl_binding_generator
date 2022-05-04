#if (GL_EXT_index_material && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INDEX_MATERIAL_EXT = 0x81B8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INDEX_MATERIAL_PARAMETER_EXT = 0x81B9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INDEX_MATERIAL_FACE_EXT = 0x81BA;
#endif
    }
}
#endif