#if (GL_SGIX_list_priority && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LIST_PRIORITY_SGIX = 0x8182;
#endif
    }
}
#endif