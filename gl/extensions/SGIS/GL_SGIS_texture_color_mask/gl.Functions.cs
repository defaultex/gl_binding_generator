#if (GL_SGIS_texture_color_mask && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glTextureColorMaskSGIS(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLboolean, GLboolean, GLboolean, GLboolean, void> glTextureColorMaskSGIS;
    }
}
#endif