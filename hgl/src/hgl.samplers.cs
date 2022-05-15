partial class hgl {
    public static void BindSampler(GLuint unit, GLsampler sampler) {
        unsafe { gl.Functions.glBindSampler(unit, sampler); }
    }

    public static void CreateSamplers(GLsampler[] samplers) {
        unsafe { fixed (GLsampler* ptr = samplers) gl.Functions.glCreateSamplers(samplers.Length, ptr); }
    }

    public static void CreateSamplers(out GLsampler sampler) {
        unsafe { fixed (GLsampler* ptr = &sampler) gl.Functions.glCreateSamplers(1, ptr); }
    }

    public static void DeleteSamplers(params GLsampler[] samplers) {
        unsafe { fixed (GLsampler* ptr = samplers) gl.Functions.glDeleteSamplers(samplers.Length, ptr); }
    }

    public static void GenSamplers(GLsampler[] samplers) {
        unsafe { fixed (GLsampler* ptr = samplers) gl.Functions.glGenSamplers(samplers.Length, ptr); }
    }

    public static void GenSampler(out GLsampler sampler) {
        unsafe { fixed (GLsampler* ptr = &sampler) gl.Functions.glGenSamplers(1, ptr); }
    }

    public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glGetSamplerParameterfv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, out float parameters) {
        unsafe { fixed (GLfloat* ptr = &parameters) gl.Functions.glGetSamplerParameterfv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameterI(GLsampler sampler, SamplerParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameterI(GLsampler sampler, SamplerParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, ptr); }
    }

    // public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, out MinFilter parameters) {
    //     unsafe { fixed (MinFilter* ptr = &parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, (GLint*)ptr); }
    // }

    public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, out MagFilter parameters) {
        unsafe { fixed (MagFilter* ptr = &parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, (GLint*)ptr); }
    }

    // public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, out SamplerWrapMode parameters) {
    //     unsafe { fixed (SamplerWrapMode* ptr = &parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, (GLint*)ptr); }
    // }

    // public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, out SamplerCompareMode parameters) {
    //     unsafe { fixed (SamplerCompareMode* ptr = &parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, (GLint*)ptr); }
    // }

    public static void GetSamplerParameter(GLsampler sampler, SamplerParameter pname, out CompareFunction parameters) {
        unsafe { fixed (CompareFunction* ptr = &parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, (GLint*)ptr); }
    }

    public static void GetSamplerParameterI(GLsampler sampler, SamplerParameter pname, uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glGetSamplerParameterIuiv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameterI(GLsampler sampler, SamplerParameter pname, out uint parameters) {
        unsafe { fixed (GLuint* ptr = &parameters) gl.Functions.glGetSamplerParameterIuiv(sampler, pname, ptr); }
    }

    public static GLboolean IsSampler(GLsampler sampler) {
        unsafe { return gl.Functions.glIsSampler(sampler); }
    }

    public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, int parameter) {
        unsafe { gl.Functions.glSamplerParameteri(sampler, pname, parameter); }
    }

    public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, float parameter) {
        unsafe { gl.Functions.glSamplerParameterf(sampler, pname, parameter); }
    }

    public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, params int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glSamplerParameteriv(sampler, pname, ptr); }
    }

    public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, params float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glSamplerParameterfv(sampler, pname, ptr); }
    }

    public static void SamplerParameterI(GLsampler sampler, SamplerParameter pname, params GLint[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glSamplerParameterIiv(sampler, pname, ptr); }
    }

    // public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, SamplerMinFilter parameters) {
    //     unsafe { gl.Functions.glSamplerParameterIiv(sampler, pname, (GLint*)&parameters); }
    // }

    public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, MagFilter parameters) {
        unsafe { gl.Functions.glSamplerParameterIiv(sampler, pname, (GLint*)&parameters); }
    }

    // public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, SamplerWrapMode parameters) {
    //     unsafe { gl.Functions.glSamplerParameterIiv(sampler, pname, (GLint*)&parameters); }
    // }

    // public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, SamplerCompareMode parameters) {
    //     unsafe { gl.Functions.glSamplerParameterIiv(sampler, pname, (GLint*)&parameters); }
    // }

    public static void SamplerParameter(GLsampler sampler, SamplerParameter pname, CompareFunction parameters) {
        unsafe { gl.Functions.glSamplerParameterIiv(sampler, pname, (GLint*)&parameters); }
    }

    public static void SamplerParameterI(GLsampler sampler, SamplerParameter pname, params uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glSamplerParameterIuiv(sampler, pname, ptr); }
    }
}