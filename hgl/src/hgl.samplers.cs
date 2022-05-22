namespace HGL;

public static partial class hgl {
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

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glGetSamplerParameterfv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, out float parameters) {
        unsafe { fixed (GLfloat* ptr = &parameters) gl.Functions.glGetSamplerParameterfv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, out MinFilter parameters) {
        unsafe { fixed (MinFilter* ptr = &parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, (GLint*)ptr); }
    }

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, out MagFilter parameters) {
        unsafe { fixed (MagFilter* ptr = &parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, (GLint*)ptr); }
    }

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, out WrapMode parameters) {
        unsafe { fixed (WrapMode* ptr = &parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, (GLint*)ptr); }
    }

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, out CompareMode parameters) {
        unsafe { fixed (CompareMode* ptr = &parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, (GLint*)ptr); }
    }

    public static void GetSamplerParameter(this GLsampler sampler, SamplerParameter pname, out CompareFunction parameters) {
        unsafe { fixed (CompareFunction* ptr = &parameters) gl.Functions.glGetSamplerParameteriv(sampler, pname, (GLint*)ptr); }
    }

    public static void GetSamplerParameterI(this GLsampler sampler, SamplerParameter pname, int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameterI(this GLsampler sampler, SamplerParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetSamplerParameterIiv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameterI(this GLsampler sampler, SamplerParameter pname, uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glGetSamplerParameterIuiv(sampler, pname, ptr); }
    }

    public static void GetSamplerParameterI(this GLsampler sampler, SamplerParameter pname, out uint parameters) {
        unsafe { fixed (GLuint* ptr = &parameters) gl.Functions.glGetSamplerParameterIuiv(sampler, pname, ptr); }
    }

    public static bool IsSampler(this GLsampler sampler) {
        unsafe { return (gl.Functions.glIsSampler(sampler) != gl.Constants.GL_FALSE); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, int parameter) {
        unsafe { gl.Functions.glSamplerParameteri(sampler, pname, parameter); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, float parameter) {
        unsafe { gl.Functions.glSamplerParameterf(sampler, pname, parameter); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, params int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glSamplerParameteriv(sampler, pname, ptr); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, params float[] parameters) {
        unsafe { fixed (GLfloat* ptr = parameters) gl.Functions.glSamplerParameterfv(sampler, pname, ptr); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, MinFilter parameters) {
        unsafe { gl.Functions.glSamplerParameteri(sampler, pname, (GLint)parameters); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, MagFilter parameters) {
        unsafe { gl.Functions.glSamplerParameteri(sampler, pname, (GLint)parameters); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, WrapMode parameters) {
        unsafe { gl.Functions.glSamplerParameteri(sampler, pname, (GLint)parameters); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, CompareMode parameters) {
        unsafe { gl.Functions.glSamplerParameteri(sampler, pname, (GLint)parameters); }
    }

    public static void SamplerParameter(this GLsampler sampler, SamplerParameter pname, CompareFunction parameters) {
        unsafe { gl.Functions.glSamplerParameteri(sampler, pname, (GLint)parameters); }
    }

    public static void SamplerParameterI(this GLsampler sampler, SamplerParameter pname, params int[] parameters) {
        unsafe { fixed (GLint* ptr = parameters) gl.Functions.glSamplerParameterIiv(sampler, pname, ptr); }
    }

    public static void SamplerParameterI(this GLsampler sampler, SamplerParameter pname, params uint[] parameters) {
        unsafe { fixed (GLuint* ptr = parameters) gl.Functions.glSamplerParameterIuiv(sampler, pname, ptr); }
    }
}