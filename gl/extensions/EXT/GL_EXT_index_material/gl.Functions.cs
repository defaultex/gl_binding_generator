#if (GL_EXT_index_material && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glIndexMaterialEXT(GLenum face, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, IndexMaterialParameterEXT, void> glIndexMaterialEXT;
    }
}
#endif