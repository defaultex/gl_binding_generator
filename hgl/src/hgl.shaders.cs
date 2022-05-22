namespace HGL;

public static partial class hgl {

    public static void AttachShader(this GLprogram program, GLshader shader) {
        unsafe { gl.Functions.glAttachShader(program, shader); }
    }

    public static void BindAttribLocation(this GLprogram program, int index, string name) {
        unsafe { fixed (GLchar* ptr = Encoding.UTF8.GetBytes(name)) gl.Functions.glBindAttribLocation(program, (GLuint)index, ptr); }
    }

    public static void BindFragDataLocation(this GLprogram program, int color, string name) {
        unsafe { fixed (GLchar* ptr = Encoding.UTF8.GetBytes(name)) gl.Functions.glBindFragDataLocation(program, (GLuint)color, ptr); }
    }

    public static void BindFragDataLocationIndexed(this GLprogram program, int colorNumber, int index, string name) {
        unsafe {
            fixed (GLchar* pName = Encoding.UTF8.GetBytes(name)) {
                gl.Functions.glBindFragDataLocationIndexed(program, (GLuint)colorNumber, (GLuint)index, pName);
            }
        }
    }

    public static void CompileShader(this GLshader shader) {
        unsafe { gl.Functions.glCompileShader(shader); }
    }

    public static GLprogram CreateProgram() {
        unsafe { return gl.Functions.glCreateProgram(); }
    }

    public static GLshader CreateShader(ShaderType type) {
        unsafe { return gl.Functions.glCreateShader(type); }
    }

    public static void DeleteProgram(GLprogram program) {
        unsafe { gl.Functions.glDeleteProgram(program); }
    }

    public static void DeleteShader(GLshader shader) {
        unsafe { gl.Functions.glDeleteShader(shader); }
    }

    public static void DetachShader(this GLprogram program, GLshader shader) {
        unsafe { gl.Functions.glDetachShader(program, shader); }
    }

    public static void GetActiveAtomicCounterBuffer(this GLprogram program, int index, AtomicCounterBufferParameter pname, out int parameter) {
        unsafe { fixed (GLint* pParam = &parameter) gl.Functions.glGetActiveAtomicCounterBufferiv(program, (GLuint)index, pname, pParam); }
    }

    public static void GetActiveAttrib(this GLprogram program, int index, int bufSize, out GLint size, out AttributeType type, out string name) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            fixed (int* pSize = &size) fixed (AttributeType* pType = &type) {
                gl.Functions.glGetActiveAttrib(program, (GLuint)index, bufSize, &length, pSize, pType, cstring);
            }
            name = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetActiveSubroutineName(this GLprogram program, ShaderType shaderType, int index, int bufSize, out string name) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            gl.Functions.glGetActiveSubroutineName(program, shaderType, (GLuint)index, bufSize, &length, cstring);
            name = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetActiveSubroutineUniform(this GLprogram program, ShaderType shaderType, int index, SubroutineParameter pname, int[] values) {
        unsafe { fixed (int* pValues = values) gl.Functions.glGetActiveSubroutineUniformiv(program, shaderType, (GLuint)index, pname, pValues); }
    }

    public static void GetActiveSubroutineUniform(this GLprogram program, ShaderType shaderType, int index, SubroutineParameter pname, out int value) {
        unsafe { fixed (int* pValues = &value) gl.Functions.glGetActiveSubroutineUniformiv(program, shaderType, (GLuint)index, pname, pValues); }
    }

    public static void GetActiveSubroutineUniformName(this GLprogram program, ShaderType shaderType, int index, int bufSize, out string name) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            gl.Functions.glGetActiveSubroutineUniformName(program, shaderType, (GLuint)index, bufSize, &length, cstring);
            name = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetActiveUniform(this GLprogram program, int index, int bufSize, out GLint size, out UniformType type, out string name) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            fixed (int* psize = &size)
            fixed (UniformType* ptype = &type) {
                gl.Functions.glGetActiveUniform(program, (GLuint)index, bufSize, &length, psize, ptype, cstring);
            }
            name = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetActiveUniformBlock(this GLprogram program, int uniformBlockIndex, UniformBlockParameter pname, GLint[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetActiveUniformBlockiv(program, (GLuint)uniformBlockIndex, pname, ptr); }
    }

    public static void GetActiveUniformBlock(this GLprogram program, int uniformBlockIndex, UniformBlockParameter pname, out GLint parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetActiveUniformBlockiv(program, (GLuint)uniformBlockIndex, pname, ptr); }
    }

    public static void GetActiveUniformBlockName(this GLprogram program, int uniformBlockIndex, int bufSize, out string uniformBlockName) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            gl.Functions.glGetActiveUniformBlockName(program, (GLuint)uniformBlockIndex, bufSize, &length, cstring);
            uniformBlockName = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetActiveUniformName(this GLprogram program, int uniformIndex, int bufSize, out string uniformName) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            gl.Functions.glGetActiveUniformName(program, (GLuint)uniformIndex, bufSize, &length, cstring);
            uniformName = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetActiveUniforms(this GLprogram program, GLuint[] uniformIndices, UniformParameter pname, GLint[] parameters) {
        int uniformCount = Math.Min(uniformIndices.Length, parameters.Length);
        unsafe {
            fixed (GLuint* pIndices = uniformIndices) fixed (GLint* pParams = parameters) {
                gl.Functions.glGetActiveUniformsiv(program, uniformCount, pIndices, pname, pParams);
            }
        }
    }

    public static void GetAttachedShaders(this GLprogram program, out GLsizei count, GLshader[] shaders) {
        unsafe {
            fixed (GLshader* ptr = shaders) fixed (GLsizei* pcount = &count) {
                gl.Functions.glGetAttachedShaders(program, shaders.Length, pcount, ptr);
            }
        }
    }

    public static GLint GetAttribLocation(this GLprogram program, string name) {
        unsafe { fixed (GLchar* ptr = Encoding.UTF8.GetBytes(name)) return gl.Functions.glGetAttribLocation(program, ptr); }
    }

    public static GLint GetFragDataIndex(this GLprogram program, string name) {
        unsafe { fixed (GLchar* pName = Encoding.UTF8.GetBytes(name)) return gl.Functions.glGetFragDataIndex(program, pName); }
    }

    public static GLint GetFragDataLocation(this GLprogram program, string name) {
        unsafe { fixed (GLchar* ptr = Encoding.UTF8.GetBytes(name)) return gl.Functions.glGetFragDataLocation(program, ptr); }
    }

    public static void GetProgram(this GLprogram program, ProgramProperty pname, out GLint parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetProgramiv(program, pname, ptr); }
    }

    public static void GetProgramBinary(this GLprogram program, out int length, out GLenum binaryFormat, byte[] binary) {
        unsafe {
            fixed (int* pLength = &length)
            fixed (GLenum* pFormat = &binaryFormat)
            fixed (void* pBinary = binary) {
                gl.Functions.glGetProgramBinary(program, binary.Length, pLength, pFormat, pBinary);
            }
        }
    }

    public static void GetProgramInfoLog(this GLprogram program, int maxLength, out string infoLog) {
        unsafe {
            GLsizei length = maxLength;
            GLchar* cstring = stackalloc GLchar[maxLength];
            gl.Functions.glGetProgramInfoLog(program, (GLsizei)maxLength, &length, cstring);
            infoLog = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetProgramResource(this GLprogram program, ProgramInterface programInterface, int index, int propCount, out ProgramResourceProperty props, int[] parameters) {
        int length;
        unsafe {
            fixed (ProgramResourceProperty* pProps = &props)
            fixed (int* pParams = parameters) {
                gl.Functions.glGetProgramResourceiv(program, programInterface, (GLuint)index, propCount, pProps, parameters.Length, &length, pParams);
            }
        }
    }

    public static void GetProgramResource(this GLprogram program, ProgramInterface programInterface, int index, int propCount, out ProgramResourceProperty props, out int parameter) {
        int length;
        unsafe {
            fixed (ProgramResourceProperty* pProps = &props)
            fixed (int* pParams = &parameter) {
                gl.Functions.glGetProgramResourceiv(program, programInterface, (GLuint)index, propCount, pProps, 1, &length, pParams);
            }
        }
    }

    public static int GetProgramResourceIndex(this GLprogram program, ProgramInterface programInterface, string name) {
        unsafe {
            byte[] cstring = Encoding.UTF8.GetBytes(name);
            fixed (GLchar* pName = cstring) return (int)gl.Functions.glGetProgramResourceIndex(program, programInterface, pName);
        }
    }

    public static int GetProgramResourceLocation(this GLprogram program, ProgramInterface programInterface, string name) {
        unsafe {
            byte[] cstring = Encoding.UTF8.GetBytes(name);
            fixed (GLchar* pName = cstring) return (int)gl.Functions.glGetProgramResourceLocation(program, programInterface, pName);
        }
    }

    public static int GetProgramResourceLocationIndex(this GLprogram program, ProgramInterface programInterface, string name) {
        unsafe {
            byte[] cstring = Encoding.UTF8.GetBytes(name);
            fixed (GLchar* pName = cstring) return (int)gl.Functions.glGetProgramResourceLocationIndex(program, programInterface, pName);
        }
    }

    public static void GetProgramResourceName(this GLprogram program, ProgramInterface programInterface, int index, int bufSize, out string name) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            gl.Functions.glGetProgramResourceName(program, programInterface, (GLuint)index, bufSize, &length, cstring);
            name = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetProgramStage(this GLprogram program, ShaderType shaderType, ProgramStageParameter pname, int[] values) {
        unsafe { fixed (GLint* pValues = values) gl.Functions.glGetProgramStageiv(program, shaderType, pname, pValues); }
    }

    public static void GetShader(this GLshader shader, ShaderParameter pname, out GLint parameter) {
        unsafe { fixed (GLint* ptr = &parameter) gl.Functions.glGetShaderiv(shader, pname, ptr); }
    }

    public static void GetShaderInfoLog(this GLshader shader, int maxLength, out string infoLog) {
        unsafe {
            GLsizei length = maxLength;
            GLchar* cstring = stackalloc GLchar[maxLength];
            gl.Functions.glGetShaderInfoLog(shader, maxLength, &length, cstring);
            infoLog = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static void GetShaderPrecisionFormat(ShaderType shaderType, PrecisionType precisionType, out ValueTuple<int, int> range, out int precision) {
        range = new();
        unsafe { fixed (int* pRng = &range.Item1, pPrc = &precision) gl.Functions.glGetShaderPrecisionFormat(shaderType, precisionType, pRng, pPrc); }
    }

    public static void GetShaderSource(this GLshader shader, int maxLength, out string source) {
        unsafe {
            GLsizei length = maxLength;
            GLchar* cstring = stackalloc GLchar[maxLength];
            gl.Functions.glGetShaderSource(shader, maxLength, &length, cstring);
            source = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static int GetSubroutineIndex(this GLprogram program, ShaderType shaderType, string name) {
        unsafe {
            GLchar[] cstring = Encoding.UTF8.GetBytes(name);
            fixed (GLchar* pStr = cstring) return (int)gl.Functions.glGetSubroutineIndex(program, shaderType, pStr);
        }
    }

    public static int GetSubroutineUniformLocation(this GLprogram program, ShaderType shaderType, string name) {
        unsafe {
            GLchar[] cstring = Encoding.UTF8.GetBytes(name);
            fixed (GLchar* pStr = cstring) return gl.Functions.glGetSubroutineUniformLocation(program, shaderType, pStr);
        }
    }

    public static void GetUniform(this GLprogram program, int location, double[] parameters) {
        unsafe { fixed (GLdouble* ptr = parameters) gl.Functions.glGetUniformdv(program, location, ptr); }
    }

    public static void GetUniform(this GLprogram program, int location, int count, double[] parameters) {
        int bufSize = sizeof(double) * count;
        unsafe { fixed (GLdouble* ptr = parameters) gl.Functions.glGetnUniformdv(program, location, bufSize, ptr); }
    }

    public static void GetUniform(this GLprogram program, int location, float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glGetUniformfv(program, location, ptr); }
    }

    public static void GetUniform(this GLprogram program, int location, int count, float[] parameters) {
        int bufSize = sizeof(float) * count;
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glGetnUniformfv(program, location, bufSize, ptr); }
    }

    public static void GetUniform(this GLprogram program, int location, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetUniformiv(program, location, ptr); }
    }

    public static void GetUniform(this GLprogram program, int location, int count, int[] parameters) {
        int bufSize = sizeof(int) * count;
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetnUniformiv(program, location, bufSize, ptr); }
    }

    public static void GetUniform(this GLprogram program, int location, uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glGetUniformuiv(program, location, ptr); }
    }

    public static void GetUniform(this GLprogram program, int location, int count, uint[] parameters) {
        int bufSize = sizeof(uint) * count;
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glGetnUniformuiv(program, location, bufSize, ptr); }
    }

    public unsafe static void GetUniform(this GLprogram program, int location, double* parameters) => gl.Functions.glGetUniformdv(program, location, parameters);

    public unsafe static void GetUniform(this GLprogram program, int location, int count, double* parameters) {
        int bufSize = sizeof(double) * count;
        gl.Functions.glGetnUniformdv(program, location, bufSize, parameters);
    }

    public unsafe static void GetUniform(this GLprogram program, int location, float* parameters) => gl.Functions.glGetUniformfv(program, location, parameters);

    public unsafe static void GetUniform(this GLprogram program, int location, int count, float* parameters) {
        int bufSize = sizeof(float) * count;
        gl.Functions.glGetnUniformfv(program, location, bufSize, parameters);
    }

    public unsafe static void GetUniform(this GLprogram program, int location, int* parameters) => gl.Functions.glGetUniformiv(program, location, parameters);

    public unsafe static void GetUniform(this GLprogram program, int location, int count, int* parameters) {
        int bufSize = sizeof(int) * count;
        gl.Functions.glGetnUniformiv(program, location, bufSize, parameters);
    }

    public unsafe static void GetUniform(this GLprogram program, int location, uint* parameters) => gl.Functions.glGetUniformuiv(program, location, parameters);

    public unsafe static void GetUniform(this GLprogram program, int location, int count, uint* parameters) {
        int bufSize = sizeof(uint) * count;
        gl.Functions.glGetnUniformuiv(program, location, bufSize, parameters);
    }

    public static GLuint GetUniformBlockIndex(this GLprogram program, string uniformBlockName) {
        unsafe { fixed (GLchar* ptr = Encoding.UTF8.GetBytes(uniformBlockName)) return gl.Functions.glGetUniformBlockIndex(program, ptr); }
    }

    public static void GetUniformIndices(this GLprogram program, string[] uniformNames, GLuint[] uniformIndices) {
        int uniformCount = Math.Min(uniformNames.Length, uniformIndices.Length);
        unsafe {
            GLchar** pNames = stackalloc GLchar*[uniformCount];
            for (int i = 0; i < uniformCount; i++) {
                fixed (GLchar* pName = Encoding.UTF8.GetBytes(uniformNames[i])) {
                    pNames[i] = pName;
                }
            }
            fixed (GLuint* pIndices = uniformIndices) {
                gl.Functions.glGetUniformIndices(program, uniformCount, pNames, pIndices);
            }
        }
    }

    public static GLint GetUniformLocation(this GLprogram program, string name) {
        unsafe { fixed (GLchar* ptr = Encoding.UTF8.GetBytes(name)) return gl.Functions.glGetUniformLocation(program, ptr); }
    }

    public static void GetUniformSubroutine(ShaderType shaderType, int location, int[] values) {
        unsafe { fixed (int* pValues = values) gl.Functions.glGetUniformSubroutineuiv(shaderType, location, (GLuint*)pValues); }
    }

    public static bool IsProgram(this GLprogram program) {
        unsafe { return (gl.Functions.glIsProgram(program) != gl.Constants.GL_FALSE); }
    }

    public static bool IsShader(this GLshader shader) {
        unsafe { return (gl.Functions.glIsShader(shader) != gl.Constants.GL_FALSE); }
    }

    public static void LinkProgram(this GLprogram program) {
        unsafe { gl.Functions.glLinkProgram(program); }
    }

    public static void MinSampleShading(float value) {
        unsafe { gl.Functions.glMinSampleShading(value); }
    }

    public static void ProgramBinary(this GLprogram program, GLenum binaryFormat, byte[] binary) {
        unsafe { fixed (void* pBinary = binary) gl.Functions.glProgramBinary(program, binaryFormat, pBinary, binary.Length); }
    }

    public static void ProgramParameter(this GLprogram program, ProgramParameterParameter pname, int value) {
        unsafe { gl.Functions.glProgramParameteri(program, pname, value); }
    }

    #region ProgramUniform (float)

    public static void ProgramUniform1(this GLprogram program, int location, float v0) { unsafe { gl.Functions.glProgramUniform1f(program, location, v0); } }

    public static void ProgramUniform2(this GLprogram program, int location, float v0, float v1) { unsafe { gl.Functions.glProgramUniform2f(program, location, v0, v1); } }

    public static void ProgramUniform3(this GLprogram program, int location, float v0, float v1, float v2) { unsafe { gl.Functions.glProgramUniform3f(program, location, v0, v1, v2); } }

    public static void ProgramUniform4(this GLprogram program, int location, float v0, float v1, float v2, float v3) { unsafe { gl.Functions.glProgramUniform4f(program, location, v0, v1, v2, v3); } }

    public static void ProgramUniform1(this GLprogram program, int location, int count, float[] value) { unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniform1fv(program, location, count, ptr); } }

    public static void ProgramUniform2(this GLprogram program, int location, int count, float[] value) { unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniform2fv(program, location, count, ptr); } }

    public static void ProgramUniform3(this GLprogram program, int location, int count, float[] value) { unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniform3fv(program, location, count, ptr); } }

    public static void ProgramUniform4(this GLprogram program, int location, int count, float[] value) { unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniform4fv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform1(this GLprogram program, int location, int count, float* ptr) { unsafe { gl.Functions.glProgramUniform1fv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform2(this GLprogram program, int location, int count, float* ptr) { unsafe { gl.Functions.glProgramUniform2fv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform3(this GLprogram program, int location, int count, float* ptr) { unsafe { gl.Functions.glProgramUniform3fv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform4(this GLprogram program, int location, int count, float* ptr) { unsafe { gl.Functions.glProgramUniform4fv(program, location, count, ptr); } }

    public static void ProgramUniformMatrix2(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix2fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix3(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix3fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix4(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix4fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix2x3(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix2fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix2x4(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix2fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix3x2(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix3fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix3x4(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix3fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix4x2(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix4x2fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix4x3(this GLprogram program, int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glProgramUniformMatrix4x3fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix2(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix2fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix3(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix3fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix4(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix4fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix2x3(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix2fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix2x4(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix2fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix3x2(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix3fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix3x4(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix3fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix4x2(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix4x2fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix4x3(this GLprogram program, int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix4x3fv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    #endregion ProgramUniform (float)

    #region ProgramUniform (int)

    public static void ProgramUniform1(this GLprogram program, int location, int v0) { unsafe { gl.Functions.glProgramUniform1i(program, location, v0); } }

    public static void ProgramUniform2(this GLprogram program, int location, int v0, int v1) { unsafe { gl.Functions.glProgramUniform2i(program, location, v0, v1); } }

    public static void ProgramUniform3(this GLprogram program, int location, int v0, int v1, int v2) { unsafe { gl.Functions.glProgramUniform3i(program, location, v0, v1, v2); } }

    public static void ProgramUniform4(this GLprogram program, int location, int v0, int v1, int v2, int v3) { unsafe { gl.Functions.glProgramUniform4i(program, location, v0, v1, v2, v3); } }

    public static void ProgramUniform1(this GLprogram program, int location, int count, int[] value) { unsafe { fixed (int* ptr = value) gl.Functions.glProgramUniform1iv(program, location, count, ptr); } }

    public static void ProgramUniform2(this GLprogram program, int location, int count, int[] value) { unsafe { fixed (int* ptr = value) gl.Functions.glProgramUniform2iv(program, location, count, ptr); } }

    public static void ProgramUniform3(this GLprogram program, int location, int count, int[] value) { unsafe { fixed (int* ptr = value) gl.Functions.glProgramUniform3iv(program, location, count, ptr); } }

    public static void ProgramUniform4(this GLprogram program, int location, int count, int[] value) { unsafe { fixed (int* ptr = value) gl.Functions.glProgramUniform4iv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform1(this GLprogram program, int location, int count, int* ptr) { unsafe { gl.Functions.glProgramUniform1iv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform2(this GLprogram program, int location, int count, int* ptr) { unsafe { gl.Functions.glProgramUniform2iv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform3(this GLprogram program, int location, int count, int* ptr) { unsafe { gl.Functions.glProgramUniform3iv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform4(this GLprogram program, int location, int count, int* ptr) { unsafe { gl.Functions.glProgramUniform4iv(program, location, count, ptr); } }

    #endregion ProgramUniform (int)

    #region ProgramUniform (uint)

    public static void ProgramUniform1(this GLprogram program, int location, uint v0) { unsafe { gl.Functions.glProgramUniform1ui(program, location, v0); } }

    public static void ProgramUniform2(this GLprogram program, int location, uint v0, uint v1) { unsafe { gl.Functions.glProgramUniform2ui(program, location, v0, v1); } }

    public static void ProgramUniform3(this GLprogram program, int location, uint v0, uint v1, uint v2) { unsafe { gl.Functions.glProgramUniform3ui(program, location, v0, v1, v2); } }

    public static void ProgramUniform4(this GLprogram program, int location, uint v0, uint v1, uint v2, uint v3) { unsafe { gl.Functions.glProgramUniform4ui(program, location, v0, v1, v2, v3); } }

    public static void ProgramUniform1(this GLprogram program, int location, int count, uint[] value) { unsafe { fixed (uint* ptr = value) gl.Functions.glProgramUniform1uiv(program, location, count, ptr); } }

    public static void ProgramUniform2(this GLprogram program, int location, int count, uint[] value) { unsafe { fixed (uint* ptr = value) gl.Functions.glProgramUniform2uiv(program, location, count, ptr); } }

    public static void ProgramUniform3(this GLprogram program, int location, int count, uint[] value) { unsafe { fixed (uint* ptr = value) gl.Functions.glProgramUniform3uiv(program, location, count, ptr); } }

    public static void ProgramUniform4(this GLprogram program, int location, int count, uint[] value) { unsafe { fixed (uint* ptr = value) gl.Functions.glProgramUniform4uiv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform1(this GLprogram program, int location, int count, uint* ptr) { gl.Functions.glProgramUniform1uiv(program, location, count, ptr); }

    public unsafe static void ProgramUniform2(this GLprogram program, int location, int count, uint* ptr) { gl.Functions.glProgramUniform2uiv(program, location, count, ptr); }

    public unsafe static void ProgramUniform3(this GLprogram program, int location, int count, uint* ptr) { gl.Functions.glProgramUniform3uiv(program, location, count, ptr); }

    public unsafe static void ProgramUniform4(this GLprogram program, int location, int count, uint* ptr) { gl.Functions.glProgramUniform4uiv(program, location, count, ptr); }

    #endregion ProgramUniform (uint)

    #region ProgramUniform (double)

    public static void ProgramUniform1(this GLprogram program, int location, double v0) { unsafe { gl.Functions.glProgramUniform1d(program, location, v0); } }

    public static void ProgramUniform2(this GLprogram program, int location, double v0, double v1) { unsafe { gl.Functions.glProgramUniform2d(program, location, v0, v1); } }

    public static void ProgramUniform3(this GLprogram program, int location, double v0, double v1, double v2) { unsafe { gl.Functions.glProgramUniform3d(program, location, v0, v1, v2); } }

    public static void ProgramUniform4(this GLprogram program, int location, double v0, double v1, double v2, double v3) { unsafe { gl.Functions.glProgramUniform4d(program, location, v0, v1, v2, v3); } }

    public static void ProgramUniform1(this GLprogram program, int location, int count, double[] value) { unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniform1dv(program, location, count, ptr); } }

    public static void ProgramUniform2(this GLprogram program, int location, int count, double[] value) { unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniform2dv(program, location, count, ptr); } }

    public static void ProgramUniform3(this GLprogram program, int location, int count, double[] value) { unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniform3dv(program, location, count, ptr); } }

    public static void ProgramUniform4(this GLprogram program, int location, int count, double[] value) { unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniform4dv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform1(this GLprogram program, int location, int count, double* ptr) { unsafe { gl.Functions.glProgramUniform1dv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform2(this GLprogram program, int location, int count, double* ptr) { unsafe { gl.Functions.glProgramUniform2dv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform3(this GLprogram program, int location, int count, double* ptr) { unsafe { gl.Functions.glProgramUniform3dv(program, location, count, ptr); } }

    public unsafe static void ProgramUniform4(this GLprogram program, int location, int count, double* ptr) { unsafe { gl.Functions.glProgramUniform4dv(program, location, count, ptr); } }

    public static void ProgramUniformMatrix2(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix2dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix3(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix3dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix4(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix4dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix2x3(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix2dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix2x4(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix2dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix3x2(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix3dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix3x4(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix3dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix4x2(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix4x2dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void ProgramUniformMatrix4x3(this GLprogram program, int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glProgramUniformMatrix4x3dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix2(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix2dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix3(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix3dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix4(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix4dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix2x3(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix2dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix2x4(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix2dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix3x2(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix3dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix3x4(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix3dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix4x2(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix4x2dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void ProgramUniformMatrix4x3(this GLprogram program, int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glProgramUniformMatrix4x3dv(program, location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    #endregion ProgramUniform (double)

    public static void ReleaseShaderCompiler() {
        unsafe { gl.Functions.glReleaseShaderCompiler(); }
    }

    public static void ShaderBinary(GLshader[] shaders, ShaderBinaryFormat binaryFormat, byte[] binary) {
        unsafe {
            fixed (GLshader* pShaders = shaders)
            fixed (void* pBinary = binary)
                gl.Functions.glShaderBinary(shaders.Length, pShaders, binaryFormat, pBinary, binary.Length);
        }
    }

    public static void ShaderSource(this GLshader shader, string source) {
        unsafe { fixed (GLchar* cstring = Encoding.UTF8.GetBytes(source)) gl.Functions.glShaderSource(shader, 1, (GLchar**)&cstring, null); }
    }

    public static void ShaderStorageBlockBinding(this GLprogram program, int storageBlockIndex, int storageBlockBinding) {
        unsafe { gl.Functions.glShaderStorageBlockBinding(program, (GLuint)storageBlockIndex, (GLuint)storageBlockBinding); }
    }

    #region Uniform (float)

    public static void Uniform1(int location, float v0) { unsafe { gl.Functions.glUniform1f(location, v0); } }

    public static void Uniform2(int location, float v0, float v1) { unsafe { gl.Functions.glUniform2f(location, v0, v1); } }

    public static void Uniform3(int location, float v0, float v1, float v2) { unsafe { gl.Functions.glUniform3f(location, v0, v1, v2); } }

    public static void Uniform4(int location, float v0, float v1, float v2, float v3) { unsafe { gl.Functions.glUniform4f(location, v0, v1, v2, v3); } }

    public static void Uniform1(int location, int count, float[] value) { unsafe { fixed (float* ptr = value) gl.Functions.glUniform1fv(location, count, ptr); } }

    public static void Uniform2(int location, int count, float[] value) { unsafe { fixed (float* ptr = value) gl.Functions.glUniform2fv(location, count, ptr); } }

    public static void Uniform3(int location, int count, float[] value) { unsafe { fixed (float* ptr = value) gl.Functions.glUniform3fv(location, count, ptr); } }

    public static void Uniform4(int location, int count, float[] value) { unsafe { fixed (float* ptr = value) gl.Functions.glUniform4fv(location, count, ptr); } }

    public unsafe static void Uniform1(int location, int count, float* ptr) { unsafe { gl.Functions.glUniform1fv(location, count, ptr); } }

    public unsafe static void Uniform2(int location, int count, float* ptr) { unsafe { gl.Functions.glUniform2fv(location, count, ptr); } }

    public unsafe static void Uniform3(int location, int count, float* ptr) { unsafe { gl.Functions.glUniform3fv(location, count, ptr); } }

    public unsafe static void Uniform4(int location, int count, float* ptr) { unsafe { gl.Functions.glUniform4fv(location, count, ptr); } }

    public static void UniformMatrix2(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix2fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix3(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix3fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix4(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix4fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix2x3(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix2fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix2x4(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix2fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix3x2(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix3fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix3x4(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix3fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix4x2(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix4x2fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix4x3(int location, int count, bool transpose, float[] value) {
        unsafe { fixed (float* ptr = value) gl.Functions.glUniformMatrix4x3fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix2(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix2fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix3(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix3fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix4(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix4fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix2x3(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix2fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix2x4(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix2fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix3x2(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix3fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix3x4(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix3fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix4x2(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix4x2fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix4x3(int location, int count, bool transpose, float* ptr) {
        unsafe { gl.Functions.glUniformMatrix4x3fv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    #endregion Uniform (float)

    #region Uniform (int)

    public static void Uniform1(int location, int v0) { unsafe { gl.Functions.glUniform1i(location, v0); } }

    public static void Uniform2(int location, int v0, int v1) { unsafe { gl.Functions.glUniform2i(location, v0, v1); } }

    public static void Uniform3(int location, int v0, int v1, int v2) { unsafe { gl.Functions.glUniform3i(location, v0, v1, v2); } }

    public static void Uniform4(int location, int v0, int v1, int v2, int v3) { unsafe { gl.Functions.glUniform4i(location, v0, v1, v2, v3); } }

    public static void Uniform1(int location, int count, int[] value) { unsafe { fixed (int* ptr = value) gl.Functions.glUniform1iv(location, count, ptr); } }

    public static void Uniform2(int location, int count, int[] value) { unsafe { fixed (int* ptr = value) gl.Functions.glUniform2iv(location, count, ptr); } }

    public static void Uniform3(int location, int count, int[] value) { unsafe { fixed (int* ptr = value) gl.Functions.glUniform3iv(location, count, ptr); } }

    public static void Uniform4(int location, int count, int[] value) { unsafe { fixed (int* ptr = value) gl.Functions.glUniform4iv(location, count, ptr); } }

    public unsafe static void Uniform1(int location, int count, int* ptr) { unsafe { gl.Functions.glUniform1iv(location, count, ptr); } }

    public unsafe static void Uniform2(int location, int count, int* ptr) { unsafe { gl.Functions.glUniform2iv(location, count, ptr); } }

    public unsafe static void Uniform3(int location, int count, int* ptr) { unsafe { gl.Functions.glUniform3iv((int)location, (GLsizei)count, ptr); } }

    public unsafe static void Uniform4(int location, int count, int* ptr) { unsafe { gl.Functions.glUniform4iv(location, count, ptr); } }

    #endregion Uniform (int)

    #region Uniform (uint)

    public static void Uniform1(int location, uint v0) { unsafe { gl.Functions.glUniform1ui(location, v0); } }

    public static void Uniform2(int location, uint v0, uint v1) { unsafe { gl.Functions.glUniform2ui(location, v0, v1); } }

    public static void Uniform3(int location, uint v0, uint v1, uint v2) { unsafe { gl.Functions.glUniform3ui(location, v0, v1, v2); } }

    public static void Uniform4(int location, uint v0, uint v1, uint v2, uint v3) { unsafe { gl.Functions.glUniform4ui(location, v0, v1, v2, v3); } }

    public static void Uniform1(int location, int count, uint[] value) { unsafe { fixed (uint* ptr = value) gl.Functions.glUniform1uiv(location, count, ptr); } }

    public static void Uniform2(int location, int count, uint[] value) { unsafe { fixed (uint* ptr = value) gl.Functions.glUniform2uiv(location, count, ptr); } }

    public static void Uniform3(int location, int count, uint[] value) { unsafe { fixed (uint* ptr = value) gl.Functions.glUniform3uiv(location, count, ptr); } }

    public static void Uniform4(int location, int count, uint[] value) { unsafe { fixed (uint* ptr = value) gl.Functions.glUniform4uiv(location, count, ptr); } }

    public unsafe static void Uniform1(int location, int count, uint* ptr) { gl.Functions.glUniform1uiv(location, count, ptr); }

    public unsafe static void Uniform2(int location, int count, uint* ptr) { gl.Functions.glUniform2uiv(location, count, ptr); }

    public unsafe static void Uniform3(int location, int count, uint* ptr) { gl.Functions.glUniform3uiv(location, count, ptr); }

    public unsafe static void Uniform4(int location, int count, uint* ptr) { gl.Functions.glUniform4uiv(location, count, ptr); }

    #endregion Uniform (uint)

    #region Uniform (double)

    public static void Uniform1(int location, double v0) { unsafe { gl.Functions.glUniform1d(location, v0); } }

    public static void Uniform2(int location, double v0, double v1) { unsafe { gl.Functions.glUniform2d(location, v0, v1); } }

    public static void Uniform3(int location, double v0, double v1, double v2) { unsafe { gl.Functions.glUniform3d(location, v0, v1, v2); } }

    public static void Uniform4(int location, double v0, double v1, double v2, double v3) { unsafe { gl.Functions.glUniform4d(location, v0, v1, v2, v3); } }

    public static void Uniform1(int location, int count, double[] value) { unsafe { fixed (double* ptr = value) gl.Functions.glUniform1dv(location, count, ptr); } }

    public static void Uniform2(int location, int count, double[] value) { unsafe { fixed (double* ptr = value) gl.Functions.glUniform2dv(location, count, ptr); } }

    public static void Uniform3(int location, int count, double[] value) { unsafe { fixed (double* ptr = value) gl.Functions.glUniform3dv(location, count, ptr); } }

    public static void Uniform4(int location, int count, double[] value) { unsafe { fixed (double* ptr = value) gl.Functions.glUniform4dv(location, count, ptr); } }

    public unsafe static void Uniform1(int location, int count, double* ptr) { unsafe { gl.Functions.glUniform1dv(location, count, ptr); } }

    public unsafe static void Uniform2(int location, int count, double* ptr) { unsafe { gl.Functions.glUniform2dv(location, count, ptr); } }

    public unsafe static void Uniform3(int location, int count, double* ptr) { unsafe { gl.Functions.glUniform3dv(location, count, ptr); } }

    public unsafe static void Uniform4(int location, int count, double* ptr) { unsafe { gl.Functions.glUniform4dv(location, count, ptr); } }

    public static void UniformMatrix2(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix2dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix3(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix3dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix4(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix4dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix2x3(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix2dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix2x4(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix2dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix3x2(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix3dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix3x4(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix3dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix4x2(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix4x2dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public static void UniformMatrix4x3(int location, int count, bool transpose, double[] value) {
        unsafe { fixed (double* ptr = value) gl.Functions.glUniformMatrix4x3dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix2(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix2dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix3(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix3dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix4(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix4dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix2x3(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix2dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix2x4(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix2dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix3x2(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix3dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix3x4(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix3dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix4x2(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix4x2dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    public unsafe static void UniformMatrix4x3(int location, int count, bool transpose, double* ptr) {
        unsafe { gl.Functions.glUniformMatrix4x3dv(location, count, (GLboolean)(transpose ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), ptr); }
    }

    #endregion Uniform (double)

    public static void UniformBlockBinding(this GLprogram program, int uniformBlockIndex, int uniformBlockBinding) {
        unsafe { gl.Functions.glUniformBlockBinding(program, (GLuint)uniformBlockIndex, (GLuint)uniformBlockBinding); }
    }

    public static void UniformSubroutines(ShaderType shaderType, int[] indices) {
        unsafe { fixed (int* pIndices = indices) gl.Functions.glUniformSubroutinesuiv(shaderType, indices.Length, (GLuint*)pIndices); }
    }

    public static void UseProgram(this GLprogram program) {
        unsafe { gl.Functions.glUseProgram(program); }
    }

    public static void UseProgramStages(this GLprogrampipeline pipeline, ProgramStageMask stages, GLprogram program) {
        unsafe { gl.Functions.glUseProgramStages(pipeline, stages, program); }
    }

    public static void ValidateProgram(this GLprogram program) {
        unsafe { gl.Functions.glValidateProgram(program); }
    }
}