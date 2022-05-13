public enum PrimitiveType : GLenum {
    Points = gl.Constants.GL_POINTS,
    Lines = gl.Constants.GL_LINES,
    LineLoop = gl.Constants.GL_LINE_LOOP,
    LineStrip = gl.Constants.GL_LINE_STRIP,
    Triangles = gl.Constants.GL_TRIANGLES,
    TriangleStrip = gl.Constants.GL_TRIANGLE_STRIP,
    TriangleFan = gl.Constants.GL_TRIANGLE_FAN,
    Quads = gl.Constants.GL_QUADS,
    LinesAdjacency = gl.Constants.GL_LINES_ADJACENCY,
    LineStripAdjacency = gl.Constants.GL_LINE_STRIP_ADJACENCY,
    TrianglesAdjacency = gl.Constants.GL_TRIANGLES_ADJACENCY,
    TriangleStripAdjacency = gl.Constants.GL_TRIANGLE_STRIP_ADJACENCY,
    Patches = gl.Constants.GL_PATCHES,
#if GL_ARB_geometry_shader4
    LinesAdjacencyArb = gl.Constants.GL_LINES_ADJACENCY_ARB,
#endif

#if GL_ARB_geometry_shader4
    LineStripAdjacencyArb = gl.Constants.GL_LINE_STRIP_ADJACENCY_ARB,
#endif

#if GL_ARB_geometry_shader4
    TrianglesAdjacencyArb = gl.Constants.GL_TRIANGLES_ADJACENCY_ARB,
#endif

#if GL_ARB_geometry_shader4
    TriangleStripAdjacencyArb = gl.Constants.GL_TRIANGLE_STRIP_ADJACENCY_ARB,
#endif
}
