#if (GL_EXT_index_material && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glIndexMaterialEXT(GLenum face, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, IndexMaterialParameterEXT, void> glIndexMaterialEXT;
#endif
    }
}
#endif