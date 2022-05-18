namespace HGL;

partial class hgl {
    
    public static void BlendColor(float red, float green, float blue, float alpha) {
        unsafe { gl.Functions.glBlendColor(red, green, blue, alpha); }
    }

    public static void BlendEquation(BlendEquationMode mode) {
        unsafe { gl.Functions.glBlendEquation(mode); }
    }

    public static void BlendEquation(int bufferIndex, BlendEquationMode mode) {
        unsafe { gl.Functions.glBlendEquationi((GLuint)bufferIndex, mode); }
    }

    public static void BlendEquationSeparate(BlendEquationMode modeRGB, BlendEquationMode modeAlpha) {
        unsafe { gl.Functions.glBlendEquationSeparate(modeRGB, modeAlpha); }
    }

    public static void BlendEquationSeparate(int bufferIndex, BlendEquationMode modeRGB, BlendEquationMode modeAlpha) {
        unsafe { gl.Functions.glBlendEquationSeparatei((GLuint)bufferIndex, modeRGB, modeAlpha); }
    }

    public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) {
        unsafe { gl.Functions.glBlendFunc(sfactor, dfactor); }
    }

    public static void BlendFunc(int bufferIndex, BlendingFactor sfactor, BlendingFactor dfactor) {
        unsafe { gl.Functions.glBlendFunci((GLuint)bufferIndex, sfactor, dfactor); }
    }

    public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) {
        unsafe { gl.Functions.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha); }
    }

    public static void BlendFuncSeparate(int bufferIndex, BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) {
        unsafe { gl.Functions.glBlendFuncSeparatei((GLuint)bufferIndex, sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha); }
    }

    public static void ClampColor(ClampColorMode clamp) {
        unsafe { gl.Functions.glClampColor(ClampColorTarget.ClampReadColor, clamp); }
    }

    public static void ClipControl(ClipControlOrigin origin, ClipControlDepth depth) {
        unsafe { gl.Functions.glClipControl(origin, depth); }
    }

    public static void ColorMask(bool red, bool green, bool blue, bool alpha) {
        unsafe {
            gl.Functions.glColorMask(
                (GLboolean)(red ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE),
                (GLboolean)(green ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE),
                (GLboolean)(blue ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE),
                (GLboolean)(alpha ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)
            );
        }
    }

    public static void ColorMask(int buffer, bool red, bool green, bool blue, bool alpha) {
        unsafe {
            gl.Functions.glColorMaski(
                (GLuint)buffer,
                (GLboolean)(red ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE),
                (GLboolean)(green ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE),
                (GLboolean)(blue ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE),
                (GLboolean)(alpha ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)
            );
        }
    }

    public static void CullFace(FaceDirection mode) {
        unsafe { gl.Functions.glCullFace(mode); }
    }

    public static void DepthFunc(CompareFunction func) {
        unsafe { gl.Functions.glDepthFunc(func); }
    }

    public static void DepthMask(bool flag) {
        unsafe { gl.Functions.glDepthMask((GLboolean)(flag ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)); }
    }

    public static void DepthRange(double near, double far) {
        unsafe { gl.Functions.glDepthRange(near, far); }
    }

    public static void DepthRange(float near, float far) {
        unsafe { gl.Functions.glDepthRangef(near, far); }
    }

    public static void DepthRangeArray(int first, double[] values) {
        unsafe { fixed (GLdouble* pValues = values) gl.Functions.glDepthRangeArrayv((GLuint)first, values.Length, pValues); }
    }

    public static void DepthRangeIndexed(int index, double near, double far) {
        unsafe { gl.Functions.glDepthRangeIndexed((GLuint)index, near, far); }
    }

    public static void Disable(GLCapability cap) {
        unsafe { gl.Functions.glDisable(cap); }
    }

    public static void Disable(GLCapability cap, int index) {
        unsafe { gl.Functions.glDisablei(cap, (GLuint)index); }
    }

    public static void Enable(GLCapability cap) {
        unsafe { gl.Functions.glEnable(cap); }
    }

    public static void Enable(GLCapability cap, int index) {
        unsafe { gl.Functions.glEnablei(cap, (GLuint)index); }
    }

    public static void FrontFace(WindingOrder mode) {
        unsafe { gl.Functions.glFrontFace(mode); }
    }

    public static void Get(GLParameter pname, bool[] parameters) {
        unsafe {
            GLboolean* ptr = stackalloc GLboolean[parameters.Length];
            gl.Functions.glGetBooleanv(pname, ptr);
            for (int i = 0; i < parameters.Length; i++) {
                ptr[i] = (GLboolean)(parameters[i] ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE);
            }
        }
    }

    public static void Get(GLParameter pname, out bool parameter) {
        unsafe {
            GLboolean* ptr = stackalloc GLboolean[1];
            gl.Functions.glGetBooleanv(pname, ptr);
            parameter = (ptr[0] != gl.Constants.GL_FALSE);
        }
    }

    public static void Get(GLParameter pname, double[] parameters) {
        unsafe { fixed (GLdouble* ptr = parameters) gl.Functions.glGetDoublev(pname, ptr); }
    }

    public static void Get(GLParameter pname, out double parameter) {
        unsafe { fixed (GLdouble* ptr = &parameter) gl.Functions.glGetDoublev(pname, ptr); }
    }

    public static void Get(GLParameter pname, float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glGetFloatv(pname, ptr); }
    }

    public static void Get(GLParameter pname, out float parameter) {
        unsafe { fixed (GLfloat* ptr = &parameter) gl.Functions.glGetFloatv(pname, ptr); }
    }

    public static void Get(GLParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetIntegerv(pname, ptr); }
    }

    public static void Get(GLParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetIntegerv(pname, ptr); }
    }

    public static void Get(GLParameter pname, long[] parameters) {
        unsafe { fixed (GLint64* ptr = parameters) gl.Functions.glGetInteger64v(pname, ptr); }
    }

    public static void Get(GLParameter pname, out long parameter) {
        unsafe { fixed (GLint64* ptr = &parameter) gl.Functions.glGetInteger64v(pname, ptr); }
    }

    public static void Get(BufferTarget pname, int index, bool[] parameters) {
        unsafe {
            GLboolean* ptr = stackalloc GLboolean[parameters.Length];
            gl.Functions.glGetBooleani_v(pname, (GLuint)index, ptr);
            for (int i = 0; i < parameters.Length; i++) {
                ptr[i] = (GLboolean)(parameters[i] ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE);
            }
        }
    }

    public static void Get(BufferTarget pname, int index, out bool parameter) {
        unsafe {
            GLboolean* ptr = stackalloc GLboolean[1];
            gl.Functions.glGetBooleani_v(pname, (GLuint)index, ptr);
            parameter = (ptr[0] != gl.Constants.GL_FALSE);
        }
    }

    public static void Get(GLParameter pname, int index, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetIntegeri_v(pname, (GLuint)index, ptr); }
    }

    public static void Get(GLParameter pname, int index, out GLint parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetIntegeri_v(pname, (GLuint)index, ptr); }
    }

    public static void Get(GLParameter pname, int index, long[] parameters) {
        unsafe { fixed (GLint64* ptr = parameters) gl.Functions.glGetInteger64i_v(pname, (GLuint)index, ptr); }
    }

    public static void Get(GLParameter pname, int index, out long parameter) {
        unsafe { fixed (GLint64* ptr = &parameter) gl.Functions.glGetInteger64i_v(pname, (GLuint)index, ptr); }
    }

    public static GLError GetError() {
        unsafe { return gl.Functions.glGetError(); }
    }

    public static void Hint(HintTarget target, HintMode mode) {
        unsafe { gl.Functions.glHint(target, mode); }
    }

    public static bool IsEnabled(GLCapability cap) {
        unsafe { return gl.Functions.glIsEnabled(cap) != gl.Constants.GL_FALSE; }
    }

    public static bool IsEnabled(GLCapability cap, int index) {
        unsafe { return gl.Functions.glIsEnabledi(cap, (GLuint)index) != gl.Constants.GL_FALSE; }
    }

    public static void LineWidth(GLfloat width) {
        unsafe { gl.Functions.glLineWidth(width); }
    }

    public static void LogicOp(LogicOp opcode) {
        unsafe { gl.Functions.glLogicOp(opcode); }
    }

    public static void PixelStore(PixelStoreParameter pname, float param) {
        unsafe { gl.Functions.glPixelStoref(pname, param); }
    }

    public static void PixelStore(PixelStoreParameter pname, int param) {
        unsafe { gl.Functions.glPixelStorei(pname, param); }
    }

    public static void PointParameter(float param) {
        unsafe { gl.Functions.glPointParameterf(gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE, param); }
    }

    public static void PointParameter(ref float param) {
        unsafe { fixed (GLfloat* ptr = &param) gl.Functions.glPointParameterfv(gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE, ptr); }
    }

    public static void PointParameter(ClipControlOrigin param) {
        unsafe { gl.Functions.glPointParameteri(gl.Constants.GL_POINT_SPRITE_COORD_ORIGIN, (GLint)param); }
    }

    public static void PointParameter(ref ClipControlOrigin param) {
        unsafe { fixed (ClipControlOrigin* ptr = &param) gl.Functions.glPointParameteriv(gl.Constants.GL_POINT_SPRITE_COORD_ORIGIN, (GLint*)ptr); }
    }

    public static void PointSize(float size) {
        unsafe { gl.Functions.glPointSize(size); }
    }

    public static void PolygonMode(FaceDirection face, PolygonMode mode) {
        unsafe { gl.Functions.glPolygonMode(face, mode); }
    }

    public static void PolygonOffset(float factor, float units) {
        unsafe { gl.Functions.glPolygonOffset(factor, units); }
    }

    public static void SampleCoverage(float value, bool invert) {
        unsafe { gl.Functions.glSampleCoverage(value, (GLboolean)(invert ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE)); }
    }

    public static void Scissor(int x, int y, int width, int height) {
        unsafe { gl.Functions.glScissor(x, y, width, height); }
    }

    public static void Scissor(int first, int[] values) {
        unsafe { fixed (int* pValues = values) gl.Functions.glScissorArrayv((GLuint)first, values.Length, pValues); }
    }

    public static void ScissorIndexed(int index, int x, int y, int width, int height) {
        unsafe { gl.Functions.glScissorIndexed((GLuint)index, x, y, width, height); }
    }

    public static void ScissorIndexed(int index, int[] values) {
        unsafe { fixed (int* pValues = values) gl.Functions.glScissorIndexedv((GLuint)index, pValues); }
    }

    public static void StencilFunc(StencilFunction func, int reference, int mask) {
        unsafe { gl.Functions.glStencilFunc(func, reference, (GLuint)mask); }
    }

    public static void StencilFuncSeparate(FaceDirection face, StencilFunction func, int reference, int mask) {
        unsafe { gl.Functions.glStencilFuncSeparate(face, func, reference, (GLuint)mask); }
    }

    public static void StencilMask(int mask) {
        unsafe { gl.Functions.glStencilMask((GLuint)mask); }
    }

    public static void StencilMaskSeparate(FaceDirection face, int mask) {
        unsafe { gl.Functions.glStencilMaskSeparate(face, (GLuint)mask); }
    }

    public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) {
        unsafe { gl.Functions.glStencilOp(fail, zfail, zpass); }
    }

    public static void StencilOpSeparate(FaceDirection face, StencilOp fail, StencilOp zfail, StencilOp zpass) {
        unsafe { gl.Functions.glStencilOpSeparate(face, fail, zfail, zpass); }
    }

    public static void Viewport(int x, int y, int width, int height) {
        unsafe { gl.Functions.glViewport(x, y, width, height); }
    }

    public static void Viewport(int first, float[] values) {
        unsafe { fixed (GLfloat* pValues = values) gl.Functions.glViewportArrayv((GLuint)first, values.Length, pValues); }
    }

    public static void ViewportIndexed(int index, float x, float y, float width, float height) {
        unsafe { gl.Functions.glViewportIndexedf((GLuint)index, x, y, width, height); }
    }

    public static void ViewportIndexed(int index, float[] values) {
        unsafe { fixed (GLfloat* pValues = values) gl.Functions.glViewportIndexedfv((GLuint)index, pValues); }
    }
}