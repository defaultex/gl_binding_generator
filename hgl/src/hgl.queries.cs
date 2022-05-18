namespace HGL;

partial class hgl {
    public static void BeginConditionalRender(this GLquery id, ConditionalRenderMode mode) {
        unsafe { gl.Functions.glBeginConditionalRender(id, mode); }
    }

    public static void BeginQuery(QueryTarget target, GLquery id) {
        unsafe { gl.Functions.glBeginQuery(target, id); }
    }

    public static void BeginQuery(QueryTarget target, int index, GLquery id) {
        unsafe { gl.Functions.glBeginQueryIndexed(target, (GLuint)index, id); }
    }

    public static void CreateQueries(QueryTarget target, int index, GLquery[] ids) {
        unsafe { fixed (GLquery* ptr = ids) gl.Functions.glCreateQueries(target, index, ptr); }
    }

    public static void CreateQueries(QueryTarget target, int index, out GLquery ids) {
        unsafe { fixed (GLquery* ptr = &ids) gl.Functions.glCreateQueries(target, index, ptr); }
    }

    public static void DeleteQueries(params GLquery[] ids) {
        unsafe { fixed (GLquery* ptr = ids) gl.Functions.glDeleteQueries(ids.Length, ptr); }
    }

    public static void EndConditionalRender() {
        unsafe { gl.Functions.glEndConditionalRender(); }
    }

    public static void EndQuery(QueryTarget target) {
        unsafe { gl.Functions.glEndQuery(target); }
    }

    public static void EndQuery(QueryTarget target, int index) {
        unsafe { gl.Functions.glEndQueryIndexed(target, (GLuint)index); }
    }

    public static void GenQueries(GLquery[] ids) {
        unsafe { fixed (GLquery* ptr = ids) gl.Functions.glGenQueries(ids.Length, ptr); }
    }

    public static void GenQueries(out GLquery id) {
        unsafe { fixed (GLquery* ptr = &id) gl.Functions.glGenQueries(1, ptr); }
    }

    public static void GetQueryObjectResultAvailable(this GLquery id, out bool result) {
        unsafe { fixed (bool* ptr = &result) gl.Functions.glGetQueryObjectuiv(id, QueryObjectParameter.QueryResultAvailable, (GLuint*)ptr); }
    }

    public static void GetQueryObjectResult(this GLquery id, out int result) {
        unsafe { fixed (GLint* ptr = &result) gl.Functions.glGetQueryObjectiv(id, QueryObjectParameter.QueryResult, ptr); }
    }

    public static void GetQueryObjectResult(this GLquery id, out uint result) {
        unsafe { fixed (GLuint* ptr = &result) gl.Functions.glGetQueryObjectuiv(id, QueryObjectParameter.QueryResult, ptr); }
    }

    public static void GetQueryObjectResult(this GLquery id, out long result) {
        unsafe { fixed (GLint64* ptr = &result) gl.Functions.glGetQueryObjecti64v(id, QueryObjectParameter.QueryResult, ptr); }
    }

    public static void GetQueryObjectResult(this GLquery id, out ulong result) {
        unsafe { fixed (GLuint64* ptr = &result) gl.Functions.glGetQueryObjectui64v(id, QueryObjectParameter.QueryResult, ptr); }
    }

    public static void GetQuery(QueryTarget target, QueryParameter pname, out int result) {
        unsafe { fixed (GLint* ptr = &result) gl.Functions.glGetQueryiv(target, pname, ptr); }
    }

    public static void GetQuery(QueryTarget target, int index, QueryParameter pname, out int result) {
        unsafe { fixed (GLint* ptr = &result) gl.Functions.glGetQueryIndexediv(target, (GLuint)index, pname, ptr); }
    }

    public static GLboolean IsQuery(this GLquery id) {
        unsafe { return gl.Functions.glIsQuery(id); }
    }

    public static void QueryCounter(this GLquery id) {
        unsafe { gl.Functions.glQueryCounter(id, QueryCounterTarget.Timestamp); }
    }
}