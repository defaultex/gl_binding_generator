#if (GL_EXT_vertex_shader && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginVertexShaderEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBeginVertexShaderEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glBindLightParameterEXT(GLenum light, GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLuint> glBindLightParameterEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glBindMaterialParameterEXT(GLenum face, GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLuint> glBindMaterialParameterEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glBindParameterEXT(GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexShaderParameterEXT, GLuint> glBindParameterEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glBindTexGenParameterEXT(GLenum unit, GLenum coord, GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLuint> glBindTexGenParameterEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glBindTextureUnitParameterEXT(GLenum unit, GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, VertexShaderTextureUnitParameter, GLuint> glBindTextureUnitParameterEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindVertexShaderEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBindVertexShaderEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteVertexShaderEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDeleteVertexShaderEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableVariantClientStateEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVariantClientStateEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableVariantClientStateEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVariantClientStateEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndVertexShaderEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndVertexShaderEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExtractComponentEXT(GLuint res, GLuint src, GLuint num);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glExtractComponentEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glGenSymbolsEXT(GLenum datatype, GLenum storagetype, GLenum range, GLuint components);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DataTypeEXT, VertexShaderStorageTypeEXT, ParameterRangeEXT, GLuint, GLuint> glGenSymbolsEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glGenVertexShadersEXT(GLuint range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint> glGenVertexShadersEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetInvariantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLboolean*, void> glGetInvariantBooleanvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetInvariantFloatvEXT(GLuint id, GLenum value, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLfloat*, void> glGetInvariantFloatvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetInvariantIntegervEXT(GLuint id, GLenum value, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLint*, void> glGetInvariantIntegervEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetLocalConstantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLboolean*, void> glGetLocalConstantBooleanvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetLocalConstantFloatvEXT(GLuint id, GLenum value, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLfloat*, void> glGetLocalConstantFloatvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetLocalConstantIntegervEXT(GLuint id, GLenum value, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLint*, void> glGetLocalConstantIntegervEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVariantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLboolean*, void> glGetVariantBooleanvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVariantFloatvEXT(GLuint id, GLenum value, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLfloat*, void> glGetVariantFloatvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVariantIntegervEXT(GLuint id, GLenum value, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLint*, void> glGetVariantIntegervEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVariantPointervEXT(GLuint id, GLenum value, void** data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, void**, void> glGetVariantPointervEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glInsertComponentEXT(GLuint res, GLuint src, GLuint num);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glInsertComponentEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsVariantEnabledEXT(GLuint id, GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VariantCapEXT, GLboolean> glIsVariantEnabledEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSetInvariantEXT(GLuint id, GLenum type, void* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ScalarType, void*, void> glSetInvariantEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSetLocalConstantEXT(GLuint id, GLenum type, void* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ScalarType, void*, void> glSetLocalConstantEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glShaderOp1EXT(GLenum op, GLuint res, GLuint arg1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexShaderOpEXT, GLuint, GLuint, void> glShaderOp1EXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glShaderOp2EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexShaderOpEXT, GLuint, GLuint, GLuint, void> glShaderOp2EXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glShaderOp3EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexShaderOpEXT, GLuint, GLuint, GLuint, GLuint, void> glShaderOp3EXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSwizzleEXT(GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, VertexShaderCoordOutEXT, VertexShaderCoordOutEXT, VertexShaderCoordOutEXT, VertexShaderCoordOutEXT, void> glSwizzleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantbvEXT(GLuint id, GLbyte* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVariantbvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantdvEXT(GLuint id, GLdouble* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVariantdvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantfvEXT(GLuint id, GLfloat* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVariantfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantivEXT(GLuint id, GLint* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVariantivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantPointerEXT(GLuint id, GLenum type, GLuint stride, void* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ScalarType, GLuint, void*, void> glVariantPointerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantsvEXT(GLuint id, GLshort* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVariantsvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantubvEXT(GLuint id, GLubyte* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVariantubvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantuivEXT(GLuint id, GLuint* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVariantuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVariantusvEXT(GLuint id, GLushort* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVariantusvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWriteMaskEXT(GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, VertexShaderWriteMaskEXT, VertexShaderWriteMaskEXT, VertexShaderWriteMaskEXT, VertexShaderWriteMaskEXT, void> glWriteMaskEXT;
#endif
    }
}
#endif