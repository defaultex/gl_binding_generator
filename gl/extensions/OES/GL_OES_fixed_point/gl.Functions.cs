#if (GL_OES_fixed_point && (!gl || !gles1))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glAccumxOES(GLenum op, GLfixed value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLfixed, void> glAccumxOES;

        /// <summary>void glAlphaFuncxOES(GLenum func, GLfixed ref);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<AlphaFunction, GLfixed, void> glAlphaFuncxOES;

        /// <summary>void glBitmapxOES(GLsizei width, GLsizei height, GLfixed xorig, GLfixed yorig, GLfixed xmove, GLfixed ymove, GLubyte* bitmap);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, GLfixed, GLfixed, GLfixed, GLfixed, GLubyte*, void> glBitmapxOES;

        /// <summary>void glBlendColorxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glBlendColorxOES;

        /// <summary>void glClearAccumxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glClearAccumxOES;

        /// <summary>void glClearColorxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glClearColorxOES;

        /// <summary>void glClearDepthxOES(GLfixed depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glClearDepthxOES;

        /// <summary>void glClipPlanexOES(GLenum plane, GLfixed* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glClipPlanexOES;

        /// <summary>void glColor3xOES(GLfixed red, GLfixed green, GLfixed blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glColor3xOES;

        /// <summary>void glColor3xvOES(GLfixed* components);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glColor3xvOES;

        /// <summary>void glColor4xOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glColor4xOES;

        /// <summary>void glColor4xvOES(GLfixed* components);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glColor4xvOES;

        /// <summary>void glConvolutionParameterxOES(GLenum target, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfixed, void> glConvolutionParameterxOES;

        /// <summary>void glConvolutionParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ConvolutionTargetEXT, ConvolutionParameterEXT, GLfixed*, void> glConvolutionParameterxvOES;

        /// <summary>void glDepthRangexOES(GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glDepthRangexOES;

        /// <summary>void glEvalCoord1xOES(GLfixed u);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glEvalCoord1xOES;

        /// <summary>void glEvalCoord1xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glEvalCoord1xvOES;

        /// <summary>void glEvalCoord2xOES(GLfixed u, GLfixed v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glEvalCoord2xOES;

        /// <summary>void glEvalCoord2xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glEvalCoord2xvOES;

        /// <summary>void glFeedbackBufferxOES(GLsizei n, GLenum type, GLfixed* buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum, GLfixed*, void> glFeedbackBufferxOES;

        /// <summary>void glFogxOES(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPName, GLfixed, void> glFogxOES;

        /// <summary>void glFogxvOES(GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPName, GLfixed*, void> glFogxvOES;

        /// <summary>void glFrustumxOES(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glFrustumxOES;

        /// <summary>void glGetClipPlanexOES(GLenum plane, GLfixed* equation);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ClipPlaneName, GLfixed*, void> glGetClipPlanexOES;

        /// <summary>void glGetConvolutionParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, GLfixed*, void> glGetConvolutionParameterxvOES;

        /// <summary>void glGetFixedvOES(GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLfixed*, void> glGetFixedvOES;

        /// <summary>void glGetHistogramParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<HistogramTargetEXT, GetHistogramParameterPNameEXT, GLfixed*, void> glGetHistogramParameterxvOES;

        /// <summary>void glGetLightxOES(GLenum light, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glGetLightxOES;

        /// <summary>void glGetLightxvOES(GLenum light, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glGetLightxvOES;

        /// <summary>void glGetMapxvOES(GLenum target, GLenum query, GLfixed* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GetMapQuery, GLfixed*, void> glGetMapxvOES;

        /// <summary>void glGetMaterialxOES(GLenum face, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed, void> glGetMaterialxOES;

        /// <summary>void glGetMaterialxvOES(GLenum face, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed*, void> glGetMaterialxvOES;

        /// <summary>void glGetPixelMapxv(GLenum map, GLint size, GLfixed* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLint, GLfixed*, void> glGetPixelMapxv;

        /// <summary>void glGetTexEnvxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed*, void> glGetTexEnvxvOES;

        /// <summary>void glGetTexGenxvOES(GLenum coord, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed*, void> glGetTexGenxvOES;

        /// <summary>void glGetTexLevelParameterxvOES(GLenum target, GLint level, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GetTextureParameter, GLfixed*, void> glGetTexLevelParameterxvOES;

        /// <summary>void glGetTexParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed*, void> glGetTexParameterxvOES;

        /// <summary>void glIndexxOES(GLfixed component);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glIndexxOES;

        /// <summary>void glIndexxvOES(GLfixed* component);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glIndexxvOES;

        /// <summary>void glLightModelxOES(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfixed, void> glLightModelxOES;

        /// <summary>void glLightModelxvOES(GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightModelParameter, GLfixed*, void> glLightModelxvOES;

        /// <summary>void glLightxOES(GLenum light, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed, void> glLightxOES;

        /// <summary>void glLightxvOES(GLenum light, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<LightName, LightParameter, GLfixed*, void> glLightxvOES;

        /// <summary>void glLineWidthxOES(GLfixed width);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glLineWidthxOES;

        /// <summary>void glLoadMatrixxOES(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glLoadMatrixxOES;

        /// <summary>void glLoadTransposeMatrixxOES(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glLoadTransposeMatrixxOES;

        /// <summary>void glMap1xOES(GLenum target, GLfixed u1, GLfixed u2, GLint stride, GLint order, GLfixed points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLfixed, GLfixed, GLint, GLint, GLfixed, void> glMap1xOES;

        /// <summary>void glMap2xOES(GLenum target, GLfixed u1, GLfixed u2, GLint ustride, GLint uorder, GLfixed v1, GLfixed v2, GLint vstride, GLint vorder, GLfixed points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MapTarget, GLfixed, GLfixed, GLint, GLint, GLfixed, GLfixed, GLint, GLint, GLfixed, void> glMap2xOES;

        /// <summary>void glMapGrid1xOES(GLint n, GLfixed u1, GLfixed u2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfixed, GLfixed, void> glMapGrid1xOES;

        /// <summary>void glMapGrid2xOES(GLint n, GLfixed u1, GLfixed u2, GLfixed v1, GLfixed v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfixed, GLfixed, GLfixed, GLfixed, void> glMapGrid2xOES;

        /// <summary>void glMaterialxOES(GLenum face, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed, void> glMaterialxOES;

        /// <summary>void glMaterialxvOES(GLenum face, GLenum pname, GLfixed* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<MaterialFace, MaterialParameter, GLfixed*, void> glMaterialxvOES;

        /// <summary>void glMultiTexCoord1xOES(GLenum texture, GLfixed s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, void> glMultiTexCoord1xOES;

        /// <summary>void glMultiTexCoord1xvOES(GLenum texture, GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed*, void> glMultiTexCoord1xvOES;

        /// <summary>void glMultiTexCoord2xOES(GLenum texture, GLfixed s, GLfixed t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, GLfixed, void> glMultiTexCoord2xOES;

        /// <summary>void glMultiTexCoord2xvOES(GLenum texture, GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed*, void> glMultiTexCoord2xvOES;

        /// <summary>void glMultiTexCoord3xOES(GLenum texture, GLfixed s, GLfixed t, GLfixed r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, GLfixed, GLfixed, void> glMultiTexCoord3xOES;

        /// <summary>void glMultiTexCoord3xvOES(GLenum texture, GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed*, void> glMultiTexCoord3xvOES;

        /// <summary>void glMultiTexCoord4xOES(GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed, GLfixed, GLfixed, GLfixed, void> glMultiTexCoord4xOES;

        /// <summary>void glMultiTexCoord4xvOES(GLenum texture, GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, GLfixed*, void> glMultiTexCoord4xvOES;

        /// <summary>void glMultMatrixxOES(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glMultMatrixxOES;

        /// <summary>void glMultTransposeMatrixxOES(GLfixed* m);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glMultTransposeMatrixxOES;

        /// <summary>void glNormal3xOES(GLfixed nx, GLfixed ny, GLfixed nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glNormal3xOES;

        /// <summary>void glNormal3xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glNormal3xvOES;

        /// <summary>void glOrthoxOES(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, GLfixed, void> glOrthoxOES;

        /// <summary>void glPassThroughxOES(GLfixed token);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glPassThroughxOES;

        /// <summary>void glPixelMapx(GLenum map, GLint size, GLfixed* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelMap, GLint, GLfixed*, void> glPixelMapx;

        /// <summary>void glPixelStorex(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelStoreParameter, GLfixed, void> glPixelStorex;

        /// <summary>void glPixelTransferxOES(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PixelTransferParameter, GLfixed, void> glPixelTransferxOES;

        /// <summary>void glPixelZoomxOES(GLfixed xfactor, GLfixed yfactor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glPixelZoomxOES;

        /// <summary>void glPointParameterxOES(GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfixed, void> glPointParameterxOES;

        /// <summary>void glPointParameterxvOES(GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameterNameARB, GLfixed*, void> glPointParameterxvOES;

        /// <summary>void glPointSizexOES(GLfixed size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glPointSizexOES;

        /// <summary>void glPolygonOffsetxOES(GLfixed factor, GLfixed units);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glPolygonOffsetxOES;

        /// <summary>void glPrioritizeTexturesxOES(GLsizei n, GLuint* textures, GLfixed* priorities);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, GLfixed*, void> glPrioritizeTexturesxOES;

        /// <summary>void glRasterPos2xOES(GLfixed x, GLfixed y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glRasterPos2xOES;

        /// <summary>void glRasterPos2xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glRasterPos2xvOES;

        /// <summary>void glRasterPos3xOES(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glRasterPos3xOES;

        /// <summary>void glRasterPos3xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glRasterPos3xvOES;

        /// <summary>void glRasterPos4xOES(GLfixed x, GLfixed y, GLfixed z, GLfixed w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glRasterPos4xOES;

        /// <summary>void glRasterPos4xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glRasterPos4xvOES;

        /// <summary>void glRectxOES(GLfixed x1, GLfixed y1, GLfixed x2, GLfixed y2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glRectxOES;

        /// <summary>void glRectxvOES(GLfixed* v1, GLfixed* v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, GLfixed*, void> glRectxvOES;

        /// <summary>void glRotatexOES(GLfixed angle, GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glRotatexOES;

        /// <summary>void glSampleCoveragexOES(GLclampx value, GLboolean invert);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLclampx, GLboolean, void> glSampleCoveragexOES;

        /// <summary>void glScalexOES(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glScalexOES;

        /// <summary>void glTexCoord1xOES(GLfixed s);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glTexCoord1xOES;

        /// <summary>void glTexCoord1xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glTexCoord1xvOES;

        /// <summary>void glTexCoord2xOES(GLfixed s, GLfixed t);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glTexCoord2xOES;

        /// <summary>void glTexCoord2xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glTexCoord2xvOES;

        /// <summary>void glTexCoord3xOES(GLfixed s, GLfixed t, GLfixed r);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glTexCoord3xOES;

        /// <summary>void glTexCoord3xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glTexCoord3xvOES;

        /// <summary>void glTexCoord4xOES(GLfixed s, GLfixed t, GLfixed r, GLfixed q);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, GLfixed, void> glTexCoord4xOES;

        /// <summary>void glTexCoord4xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glTexCoord4xvOES;

        /// <summary>void glTexEnvxOES(GLenum target, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed, void> glTexEnvxOES;

        /// <summary>void glTexEnvxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureEnvTarget, TextureEnvParameter, GLfixed*, void> glTexEnvxvOES;

        /// <summary>void glTexGenxOES(GLenum coord, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed, void> glTexGenxOES;

        /// <summary>void glTexGenxvOES(GLenum coord, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureCoordName, TextureGenParameter, GLfixed*, void> glTexGenxvOES;

        /// <summary>void glTexParameterxOES(GLenum target, GLenum pname, GLfixed param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed, void> glTexParameterxOES;

        /// <summary>void glTexParameterxvOES(GLenum target, GLenum pname, GLfixed* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GetTextureParameter, GLfixed*, void> glTexParameterxvOES;

        /// <summary>void glTranslatexOES(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glTranslatexOES;

        /// <summary>void glVertex2xOES(GLfixed x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, void> glVertex2xOES;

        /// <summary>void glVertex2xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glVertex2xvOES;

        /// <summary>void glVertex3xOES(GLfixed x, GLfixed y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, void> glVertex3xOES;

        /// <summary>void glVertex3xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glVertex3xvOES;

        /// <summary>void glVertex4xOES(GLfixed x, GLfixed y, GLfixed z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed, GLfixed, GLfixed, void> glVertex4xOES;

        /// <summary>void glVertex4xvOES(GLfixed* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, void> glVertex4xvOES;
    }
}
#endif