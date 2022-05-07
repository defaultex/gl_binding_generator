#if (GL_EXT_vertex_shader && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginVertexShaderEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glBeginVertexShaderEXT;

        /// <summary>GLuint glBindLightParameterEXT(GLenum light, GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLuint> glBindLightParameterEXT;

        /// <summary>GLuint glBindMaterialParameterEXT(GLenum face, GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLuint> glBindMaterialParameterEXT;

        /// <summary>GLuint glBindParameterEXT(GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexShaderParameterEXT, GLuint> glBindParameterEXT;

        /// <summary>GLuint glBindTexGenParameterEXT(GLenum unit, GLenum coord, GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TextureCoordName, TextureGenParameter, GLuint> glBindTexGenParameterEXT;

        /// <summary>GLuint glBindTextureUnitParameterEXT(GLenum unit, GLenum value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, VertexShaderTextureUnitParameter, GLuint> glBindTextureUnitParameterEXT;

        /// <summary>void glBindVertexShaderEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glBindVertexShaderEXT;

        /// <summary>void glDeleteVertexShaderEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDeleteVertexShaderEXT;

        /// <summary>void glDisableVariantClientStateEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVariantClientStateEXT;

        /// <summary>void glEnableVariantClientStateEXT(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVariantClientStateEXT;

        /// <summary>void glEndVertexShaderEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndVertexShaderEXT;

        /// <summary>void glExtractComponentEXT(GLuint res, GLuint src, GLuint num);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glExtractComponentEXT;

        /// <summary>GLuint glGenSymbolsEXT(GLenum datatype, GLenum storagetype, GLenum range, GLuint components);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<DataTypeEXT, VertexShaderStorageTypeEXT, ParameterRangeEXT, GLuint, GLuint> glGenSymbolsEXT;

        /// <summary>GLuint glGenVertexShadersEXT(GLuint range);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint> glGenVertexShadersEXT;

        /// <summary>void glGetInvariantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLboolean*, void> glGetInvariantBooleanvEXT;

        /// <summary>void glGetInvariantFloatvEXT(GLuint id, GLenum value, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLfloat*, void> glGetInvariantFloatvEXT;

        /// <summary>void glGetInvariantIntegervEXT(GLuint id, GLenum value, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLint*, void> glGetInvariantIntegervEXT;

        /// <summary>void glGetLocalConstantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLboolean*, void> glGetLocalConstantBooleanvEXT;

        /// <summary>void glGetLocalConstantFloatvEXT(GLuint id, GLenum value, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLfloat*, void> glGetLocalConstantFloatvEXT;

        /// <summary>void glGetLocalConstantIntegervEXT(GLuint id, GLenum value, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLint*, void> glGetLocalConstantIntegervEXT;

        /// <summary>void glGetVariantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLboolean*, void> glGetVariantBooleanvEXT;

        /// <summary>void glGetVariantFloatvEXT(GLuint id, GLenum value, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLfloat*, void> glGetVariantFloatvEXT;

        /// <summary>void glGetVariantIntegervEXT(GLuint id, GLenum value, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, GLint*, void> glGetVariantIntegervEXT;

        /// <summary>void glGetVariantPointervEXT(GLuint id, GLenum value, void** data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GetVariantValueEXT, void**, void> glGetVariantPointervEXT;

        /// <summary>void glInsertComponentEXT(GLuint res, GLuint src, GLuint num);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glInsertComponentEXT;

        /// <summary>GLboolean glIsVariantEnabledEXT(GLuint id, GLenum cap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VariantCapEXT, GLboolean> glIsVariantEnabledEXT;

        /// <summary>void glSetInvariantEXT(GLuint id, GLenum type, void* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ScalarType, void*, void> glSetInvariantEXT;

        /// <summary>void glSetLocalConstantEXT(GLuint id, GLenum type, void* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ScalarType, void*, void> glSetLocalConstantEXT;

        /// <summary>void glShaderOp1EXT(GLenum op, GLuint res, GLuint arg1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexShaderOpEXT, GLuint, GLuint, void> glShaderOp1EXT;

        /// <summary>void glShaderOp2EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexShaderOpEXT, GLuint, GLuint, GLuint, void> glShaderOp2EXT;

        /// <summary>void glShaderOp3EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexShaderOpEXT, GLuint, GLuint, GLuint, GLuint, void> glShaderOp3EXT;

        /// <summary>void glSwizzleEXT(GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, VertexShaderCoordOutEXT, VertexShaderCoordOutEXT, VertexShaderCoordOutEXT, VertexShaderCoordOutEXT, void> glSwizzleEXT;

        /// <summary>void glVariantbvEXT(GLuint id, GLbyte* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVariantbvEXT;

        /// <summary>void glVariantdvEXT(GLuint id, GLdouble* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVariantdvEXT;

        /// <summary>void glVariantfvEXT(GLuint id, GLfloat* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVariantfvEXT;

        /// <summary>void glVariantivEXT(GLuint id, GLint* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVariantivEXT;

        /// <summary>void glVariantPointerEXT(GLuint id, GLenum type, GLuint stride, void* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ScalarType, GLuint, void*, void> glVariantPointerEXT;

        /// <summary>void glVariantsvEXT(GLuint id, GLshort* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVariantsvEXT;

        /// <summary>void glVariantubvEXT(GLuint id, GLubyte* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVariantubvEXT;

        /// <summary>void glVariantuivEXT(GLuint id, GLuint* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVariantuivEXT;

        /// <summary>void glVariantusvEXT(GLuint id, GLushort* addr);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVariantusvEXT;

        /// <summary>void glWriteMaskEXT(GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, VertexShaderWriteMaskEXT, VertexShaderWriteMaskEXT, VertexShaderWriteMaskEXT, VertexShaderWriteMaskEXT, void> glWriteMaskEXT;
    }
}
#endif