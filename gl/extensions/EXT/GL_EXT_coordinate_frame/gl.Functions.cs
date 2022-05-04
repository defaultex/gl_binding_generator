#if (GL_EXT_coordinate_frame && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glBinormal3bEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3bvEXT(GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glBinormal3bvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glBinormal3dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3dvEXT(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glBinormal3dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glBinormal3fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3fvEXT(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glBinormal3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3iEXT(GLint bx, GLint by, GLint bz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glBinormal3iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3ivEXT(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glBinormal3ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3sEXT(GLshort bx, GLshort by, GLshort bz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glBinormal3sEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormal3svEXT(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glBinormal3svEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBinormalPointerEXT(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BinormalPointerTypeEXT, GLsizei, void*, void> glBinormalPointerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glTangent3bEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3bvEXT(GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glTangent3bvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glTangent3dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3dvEXT(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTangent3dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glTangent3fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3fvEXT(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTangent3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3iEXT(GLint tx, GLint ty, GLint tz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glTangent3iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3ivEXT(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTangent3ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3sEXT(GLshort tx, GLshort ty, GLshort tz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glTangent3sEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangent3svEXT(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTangent3svEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTangentPointerEXT(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TangentPointerTypeEXT, GLsizei, void*, void> glTangentPointerEXT;
#endif
    }
}
#endif