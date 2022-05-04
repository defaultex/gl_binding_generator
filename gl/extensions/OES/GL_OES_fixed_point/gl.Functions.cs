#if (GL_OES_fixed_point && (GL_API || GLES1_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAccumxOES(GLenum op, GLfixed value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfixed, void> glAccumxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAlphaFuncxOES(GLenum func, GLfixed ref);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AlphaFunction, GLfixed, void> glAlphaFuncxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBitmapxOES(GLsizei width, GLsizei height, GLfixed xorig, GLfixed yorig, GLfixed xmove, GLfixed ymove, GLubyte* bitmap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, GLfixed, GLfixed, GLfixed, GLfixed, GLubyte*, void> glBitmapxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendColorxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glBlendColorxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearAccumxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glClearAccumxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearColorxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glClearColorxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearDepthxOES(GLfixed depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glClearDepthxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClipPlanexOES(GLenum plane, GLfixed* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glClipPlanexOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor3xOES(GLfixed red, GLfixed green, GLfixed blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glColor3xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor3xvOES(GLfixed* components);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glColor3xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4xOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glColor4xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColor4xvOES(GLfixed* components);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glColor4xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameterxOES(GLenum target, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfixed, void> glConvolutionParameterxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glConvolutionParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfixed*, void> glConvolutionParameterxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthRangexOES(GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glDepthRangexOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEvalCoord1xOES(GLfixed u);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glEvalCoord1xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEvalCoord1xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glEvalCoord1xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEvalCoord2xOES(GLfixed u, GLfixed v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glEvalCoord2xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEvalCoord2xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glEvalCoord2xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFeedbackBufferxOES(GLsizei n, GLenum type, GLfixed* buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum, GLfixed*, void> glFeedbackBufferxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogxOES(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPName, GLfixed, void> glFogxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogxvOES(GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPName, GLfixed*, void> glFogxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFrustumxOES(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glFrustumxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetClipPlanexOES(GLenum plane, GLfixed* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glGetClipPlanexOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetConvolutionParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLfixed*, void> glGetConvolutionParameterxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFixedvOES(GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfixed*, void> glGetFixedvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetHistogramParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, GLfixed*, void> glGetHistogramParameterxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetLightxOES(GLenum light, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glGetLightxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetLightxvOES(GLenum light, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glGetLightxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMapxvOES(GLenum target, GLenum query, GLfixed* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, GLfixed*, void> glGetMapxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMaterialxOES(GLenum face, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed, void> glGetMaterialxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMaterialxvOES(GLenum face, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed*, void> glGetMaterialxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetPixelMapxv(GLenum map, GLint size, GLfixed* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLint, GLfixed*, void> glGetPixelMapxv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexEnvxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed*, void> glGetTexEnvxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexGenxvOES(GLenum coord, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed*, void> glGetTexGenxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexLevelParameterxvOES(GLenum target, GLint level, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLfixed*, void> glGetTexLevelParameterxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed*, void> glGetTexParameterxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glIndexxOES(GLfixed component);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glIndexxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glIndexxvOES(GLfixed* component);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glIndexxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLightModelxOES(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfixed, void> glLightModelxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLightModelxvOES(GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfixed*, void> glLightModelxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLightxOES(GLenum light, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed, void> glLightxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLightxvOES(GLenum light, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glLightxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLineWidthxOES(GLfixed width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glLineWidthxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLoadMatrixxOES(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glLoadMatrixxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLoadTransposeMatrixxOES(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glLoadTransposeMatrixxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMap1xOES(GLenum target, GLfixed u1, GLfixed u2, GLint stride, GLint order, GLfixed points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLfixed, GLfixed, GLint, GLint, GLfixed, void> glMap1xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMap2xOES(GLenum target, GLfixed u1, GLfixed u2, GLint ustride, GLint uorder, GLfixed v1, GLfixed v2, GLint vstride, GLint vorder, GLfixed points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLfixed, GLfixed, GLint, GLint, GLfixed, GLfixed, GLint, GLint, GLfixed, void> glMap2xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapGrid1xOES(GLint n, GLfixed u1, GLfixed u2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfixed, GLfixed, void> glMapGrid1xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapGrid2xOES(GLint n, GLfixed u1, GLfixed u2, GLfixed v1, GLfixed v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfixed, GLfixed, GLfixed, GLfixed, void> glMapGrid2xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMaterialxOES(GLenum face, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed, void> glMaterialxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMaterialxvOES(GLenum face, GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed*, void> glMaterialxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1xOES(GLenum texture, GLfixed s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, void> glMultiTexCoord1xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord1xvOES(GLenum texture, GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed*, void> glMultiTexCoord1xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2xOES(GLenum texture, GLfixed s, GLfixed t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, GLfixed, void> glMultiTexCoord2xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord2xvOES(GLenum texture, GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed*, void> glMultiTexCoord2xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3xOES(GLenum texture, GLfixed s, GLfixed t, GLfixed r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, GLfixed, GLfixed, void> glMultiTexCoord3xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord3xvOES(GLenum texture, GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed*, void> glMultiTexCoord3xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4xOES(GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, GLfixed, GLfixed, GLfixed, void> glMultiTexCoord4xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultiTexCoord4xvOES(GLenum texture, GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed*, void> glMultiTexCoord4xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultMatrixxOES(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glMultMatrixxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMultTransposeMatrixxOES(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glMultTransposeMatrixxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormal3xOES(GLfixed nx, GLfixed ny, GLfixed nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glNormal3xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNormal3xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glNormal3xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glOrthoxOES(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glOrthoxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPassThroughxOES(GLfixed token);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glPassThroughxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelMapx(GLenum map, GLint size, GLfixed* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLint, GLfixed*, void> glPixelMapx;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelStorex(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLfixed, void> glPixelStorex;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelTransferxOES(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransferParameter, GLfixed, void> glPixelTransferxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPixelZoomxOES(GLfixed xfactor, GLfixed yfactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glPixelZoomxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterxOES(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfixed, void> glPointParameterxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointParameterxvOES(GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfixed*, void> glPointParameterxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPointSizexOES(GLfixed size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glPointSizexOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPolygonOffsetxOES(GLfixed factor, GLfixed units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glPolygonOffsetxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glPrioritizeTexturesxOES(GLsizei n, GLuint* textures, GLfixed* priorities);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, texture*, GLfixed*, void> glPrioritizeTexturesxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRasterPos2xOES(GLfixed x, GLfixed y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glRasterPos2xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRasterPos2xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glRasterPos2xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRasterPos3xOES(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glRasterPos3xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRasterPos3xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glRasterPos3xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRasterPos4xOES(GLfixed x, GLfixed y, GLfixed z, GLfixed w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glRasterPos4xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRasterPos4xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glRasterPos4xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRectxOES(GLfixed x1, GLfixed y1, GLfixed x2, GLfixed y2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glRectxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRectxvOES(GLfixed* v1, GLfixed* v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, GLfixed*, void> glRectxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRotatexOES(GLfixed angle, GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glRotatexOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSampleCoveragexOES(GLclampx value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampx, GLboolean, void> glSampleCoveragexOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScalexOES(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glScalexOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord1xOES(GLfixed s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glTexCoord1xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord1xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glTexCoord1xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2xOES(GLfixed s, GLfixed t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glTexCoord2xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord2xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glTexCoord2xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord3xOES(GLfixed s, GLfixed t, GLfixed r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glTexCoord3xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord3xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glTexCoord3xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4xOES(GLfixed s, GLfixed t, GLfixed r, GLfixed q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glTexCoord4xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexCoord4xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glTexCoord4xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexEnvxOES(GLenum target, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed, void> glTexEnvxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexEnvxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed*, void> glTexEnvxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexGenxOES(GLenum coord, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed, void> glTexGenxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexGenxvOES(GLenum coord, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed*, void> glTexGenxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexParameterxOES(GLenum target, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed, void> glTexParameterxOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed*, void> glTexParameterxvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTranslatexOES(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glTranslatexOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex2xOES(GLfixed x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glVertex2xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex2xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glVertex2xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex3xOES(GLfixed x, GLfixed y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glVertex3xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex3xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glVertex3xvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex4xOES(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glVertex4xOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertex4xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glVertex4xvOES;
#endif
    }
}
#endif