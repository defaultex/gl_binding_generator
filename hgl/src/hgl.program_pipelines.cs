partial class hgl {

    public static void ActiveShaderProgram(this GLprogrampipeline pipeline, GLprogram program) {
        unsafe { gl.Functions.glActiveShaderProgram(pipeline, program); }
    }

    public static void BindProgramPipeline(this GLprogrampipeline pipeline) {
        unsafe { gl.Functions.glBindProgramPipeline(pipeline); }
    }

    public static void CreateProgramPipelines(GLprogrampipeline[] pipelines) {
        unsafe { fixed (GLprogrampipeline* pPipelines = pipelines) gl.Functions.glCreateProgramPipelines(pipelines.Length, pPipelines); }
    }

    public static void CreateProgramPipeline(out GLprogrampipeline pipelines) {
        unsafe { fixed (GLprogrampipeline* pPipelines = &pipelines) gl.Functions.glCreateProgramPipelines(1, pPipelines); }
    }

    public static void DeleteProgramPipelines(params GLprogrampipeline[] pipelines) {
        unsafe { fixed (GLprogrampipeline* pPipelines = pipelines) gl.Functions.glDeleteProgramPipelines(pipelines.Length, pPipelines); }
    }

    public static void GenProgramPipelines(GLprogrampipeline[] pipelines) {
        unsafe { fixed (GLprogrampipeline* pPipelines = pipelines) gl.Functions.glGenProgramPipelines(pipelines.Length, pPipelines); }
    }

    public static void GenProgramPipeline(out GLprogrampipeline pipelines) {
        unsafe { fixed (GLprogrampipeline* pPipelines = &pipelines) gl.Functions.glGenProgramPipelines(1, pPipelines); }
    }

    public static void GetProgramPipeline(this GLprogrampipeline pipeline, PipelineParameter pname, out int parameter) {
        unsafe { fixed (int* pParam = &parameter) gl.Functions.glGetProgramPipelineiv(pipeline, pname, pParam); }
    }

    public static void GetProgramPipelineInfoLog(this GLprogrampipeline pipeline, int bufSize, out string infoLog) {
        unsafe {
            GLsizei length = bufSize;
            GLchar* cstring = stackalloc GLchar[bufSize];
            gl.Functions.glGetProgramPipelineInfoLog(pipeline, (GLsizei)bufSize, &length, cstring);
            infoLog = Encoding.UTF8.GetString(cstring, length);
        }
    }

    public static bool IsProgramPipeline(this GLprogrampipeline pipeline) {
        unsafe { return (gl.Functions.glIsProgramPipeline(pipeline) != gl.Constants.GL_FALSE); }
    }

    public static void ValidateProgramPipeline(this GLprogrampipeline pipeline) {
        unsafe { gl.Functions.glValidateProgramPipeline(pipeline); }
    }
}