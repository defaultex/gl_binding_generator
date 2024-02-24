namespace HGL;

public static partial class hgl {

    public static void DebugMessageCallback(GLDEBUGPROC callback, IntPtr userParam) {
        unsafe { gl.Functions.glDebugMessageCallback(callback, (void*)userParam); }
    }

    public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, GLuint[] ids, bool enabled) {
        byte isEnabled = (GLboolean)(enabled ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE);
        if (ids != null) {
            unsafe { fixed (GLuint* pIds = ids) gl.Functions.glDebugMessageControl(source, type, severity, ids.Length, pIds, isEnabled); }
        } else {
            unsafe { gl.Functions.glDebugMessageControl(source, type, severity, 0, null, isEnabled); }
        }
    }

    public static void DebugMessageInsert(DebugSource source, DebugType type, GLuint id, DebugSeverity severity, string message) {
        byte[] msg = Encoding.UTF8.GetBytes(message);
        unsafe { fixed (GLchar* pMsg = msg) gl.Functions.glDebugMessageInsert(source, type, id, severity, message.Length, pMsg); }
    }

    public static GLuint GetDebugMessageLog(int count, int bufSize, DebugSource[] sources, DebugType[] types, GLuint[] ids, DebugSeverity[] severities, string[] messageLog) {
        if (count < 0) {
            count = Math.Min(Math.Min(Math.Min(Math.Min(sources.Length, types.Length), ids.Length), severities.Length), messageLog.Length);
        }
        GLuint result;
        unsafe {
            GLchar* pLog = stackalloc GLchar[bufSize];
            GLsizei* pLens = stackalloc GLsizei[count];
            fixed (DebugSource* pSrcs = sources)
            fixed (DebugType* pTypes = types)
            fixed (GLuint* pIds = ids)
            fixed (DebugSeverity* pSevs = severities) {
                result = gl.Functions.glGetDebugMessageLog((GLuint)count, bufSize, pSrcs, pTypes, pIds, pSevs, pLens, pLog);
            }
            for (int i = 0; i < result; i++) {
                messageLog[i] = Encoding.UTF8.GetString(pLog + pLens[i], pLens[i]);
            }
        }
        return result;
    }

    public static void GetObjectLabel(ObjectIdentifier identifier, GLuint name, int bufSize, out string label) {
        unsafe {
            GLchar* pLbl = stackalloc GLchar[bufSize];
            int length;
            gl.Functions.glGetObjectLabel(identifier, name, bufSize, &length, pLbl);
            label = Encoding.UTF8.GetString(pLbl, length);
        }
    }

    public static void GetObjectLabel(GLbuffer buffer, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.Buffer, (GLuint)buffer, bufSize, out label);

    public static void GetObjectLabel(GLframebuffer buffer, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.Framebuffer, (GLuint)buffer, bufSize, out label);

    public static void GetObjectLabel(GLprogram program, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.Program, (GLuint)program, bufSize, out label);

    public static void GetObjectLabel(GLprogrampipeline pipeline, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.ProgramPipeline, (GLuint)pipeline, bufSize, out label);

    public static void GetObjectLabel(GLquery query, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.Query, (GLuint)query, bufSize, out label);

    public static void GetObjectLabel(GLrenderbuffer buffer, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.Renderbuffer, (GLuint)buffer, bufSize, out label);

    public static void GetObjectLabel(GLsampler sampler, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.Sampler, (GLuint)sampler, bufSize, out label);

    public static void GetObjectLabel(GLtexture texture, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.Texture, (GLuint)texture, bufSize, out label);

    public static void GetObjectLabel(GLtransformfeedback buffer, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.TransformFeedback, (GLuint)buffer, bufSize, out label);

    public static void GetObjectLabel(GLvertexarray vaobj, int bufSize, out string label) => GetObjectLabel(ObjectIdentifier.VertexArray, (GLuint)vaobj, bufSize, out label);

    public static void GetObjectPtrLabel(IntPtr ptr, int bufSize, out string label) {
        unsafe {
            GLchar* pLbl = stackalloc GLchar[bufSize];
            int length;
            gl.Functions.glGetObjectPtrLabel((void*)ptr, bufSize, &length, pLbl);
            label = Encoding.UTF8.GetString(pLbl, length);
        }
    }

    public static void GetPointer(PointerParameter pname, IntPtr[] parameters) {
        unsafe { fixed (IntPtr* pParams = parameters) gl.Functions.glGetPointerv(pname, (void**)pParams); }
    }

    public static void GetPointer(PointerParameter pname, out IntPtr parameters) {
        unsafe { fixed (IntPtr* pParams = &parameters) gl.Functions.glGetPointerv(pname, (void**)pParams); }
    }

    public static void GetProgramInterface(GLprogram program, ProgramInterface programInterface, ProgramInterfaceParameter pname, int[] parameters) {
        unsafe { fixed (GLint* pParam = parameters) gl.Functions.glGetProgramInterfaceiv(program, programInterface, pname, pParam); }
    }

    public static void GetProgramInterface(GLprogram program, ProgramInterface programInterface, ProgramInterfaceParameter pname, out int parameter) {
        unsafe { fixed (GLint* pParam = &parameter) gl.Functions.glGetProgramInterfaceiv(program, programInterface, pname, pParam); }
    }

    public static void ObjectLabel(ObjectIdentifier identifier, GLuint name, string label) {
        byte[] lbl = Encoding.UTF8.GetBytes(label);
        unsafe { fixed (GLchar* pLabel = lbl) gl.Functions.glObjectLabel(identifier, name, lbl.Length, pLabel); }
    }

    public static void ObjectLabel(GLbuffer buffer, string label) => ObjectLabel(ObjectIdentifier.Buffer, (GLuint)buffer, label);

    public static void ObjectLabel(GLframebuffer buffer, string label) => ObjectLabel(ObjectIdentifier.Framebuffer, (GLuint)buffer, label);

    public static void ObjectLabel(GLprogram program, string label) => ObjectLabel(ObjectIdentifier.Program, (GLuint)program, label);

    public static void ObjectLabel(GLprogrampipeline pipeline, string label) => ObjectLabel(ObjectIdentifier.ProgramPipeline, (GLuint)pipeline, label);

    public static void ObjectLabel(GLquery query, string label) => ObjectLabel(ObjectIdentifier.Query, (GLuint)query, label);

    public static void ObjectLabel(GLrenderbuffer buffer, string label) => ObjectLabel(ObjectIdentifier.Renderbuffer, (GLuint)buffer, label);

    public static void ObjectLabel(GLsampler sampler, string label) => ObjectLabel(ObjectIdentifier.Sampler, (GLuint)sampler, label);

    public static void ObjectLabel(GLshader shader, string label) => ObjectLabel(ObjectIdentifier.Shader, (GLuint)shader, label);

    public static void ObjectLabel(GLtexture texture, string label) => ObjectLabel(ObjectIdentifier.Texture, (GLuint)texture, label);

    public static void ObjectLabel(GLtransformfeedback buffer, string label) => ObjectLabel(ObjectIdentifier.TransformFeedback, (GLuint)buffer, label);

    public static void ObjectLabel(GLvertexarray vaobj, string label) => ObjectLabel(ObjectIdentifier.VertexArray, (GLuint)vaobj, label);

    public static void ObjectPtrLabel(IntPtr ptr, string label) {
        byte[] lbl = Encoding.UTF8.GetBytes(label);
        unsafe { fixed (GLchar* pLabel = lbl) gl.Functions.glObjectPtrLabel((void*)ptr, lbl.Length, pLabel); }
    }

    public static void PopDebugGroup() {
        unsafe { gl.Functions.glPopDebugGroup(); }
    }

    public static void PushDebugGroup(DebugSource source, GLuint id, string message) {
        unsafe { fixed (GLchar* pMsg = Encoding.UTF8.GetBytes(message)) gl.Functions.glPushDebugGroup(source, id, message.Length, pMsg); }
    }
}