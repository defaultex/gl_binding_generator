#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_EXT_TESSELLATION_SHADER || GL_OES_TESSELLATION_SHADER || GL_VERSION_4_0 || GL_VERSION_3_2 || GL_NV_GPU_SHADER5 || GL_ARB_GEOMETRY_SHADER4 || GL_EXT_GEOMETRY_SHADER || GL_EXT_GEOMETRY_SHADER4 || GL_NV_GEOMETRY_PROGRAM4)

public enum PrimitiveType : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Points = gl.Constants.GL_POINTS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Lines = gl.Constants.GL_LINES, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LineLoop = gl.Constants.GL_LINE_LOOP, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LineStrip = gl.Constants.GL_LINE_STRIP, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_2_0 || GL_ES_VERSION_3_2 || GL_EXT_TESSELLATION_SHADER || GL_OES_TESSELLATION_SHADER || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Triangles = gl.Constants.GL_TRIANGLES, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TriangleStrip = gl.Constants.GL_TRIANGLE_STRIP, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TriangleFan = gl.Constants.GL_TRIANGLE_FAN, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_VERSION_1_0 || GL_VERSION_4_0)
    Quads = gl.Constants.GL_QUADS, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    LinesAdjacency = gl.Constants.GL_LINES_ADJACENCY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    LineStripAdjacency = gl.Constants.GL_LINE_STRIP_ADJACENCY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    TrianglesAdjacency = gl.Constants.GL_TRIANGLES_ADJACENCY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    TriangleStripAdjacency = gl.Constants.GL_TRIANGLE_STRIP_ADJACENCY, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_NV_GPU_SHADER5 || GL_VERSION_4_0)
    Patches = gl.Constants.GL_PATCHES, 
#endif

#if GL_VERSION_1_0
    QuadStrip = gl.Constants.GL_QUAD_STRIP, 
#endif

#if GL_VERSION_1_0
    Polygon = gl.Constants.GL_POLYGON, 
#endif

#if GL_ARB_GEOMETRY_SHADER4
    LinesAdjacencyArb = gl.Constants.GL_LINES_ADJACENCY_ARB, 
#endif

#if GL_ARB_GEOMETRY_SHADER4
    LineStripAdjacencyArb = gl.Constants.GL_LINE_STRIP_ADJACENCY_ARB, 
#endif

#if GL_ARB_GEOMETRY_SHADER4
    TrianglesAdjacencyArb = gl.Constants.GL_TRIANGLES_ADJACENCY_ARB, 
#endif

#if GL_ARB_GEOMETRY_SHADER4
    TriangleStripAdjacencyArb = gl.Constants.GL_TRIANGLE_STRIP_ADJACENCY_ARB, 
#endif

#if (GL_EXT_GEOMETRY_SHADER || GL_EXT_GEOMETRY_SHADER4 || GL_NV_GEOMETRY_PROGRAM4)
    LinesAdjacencyExt = gl.Constants.GL_LINES_ADJACENCY_EXT, 
#endif

#if (GL_EXT_GEOMETRY_SHADER || GL_EXT_GEOMETRY_SHADER4 || GL_NV_GEOMETRY_PROGRAM4)
    LineStripAdjacencyExt = gl.Constants.GL_LINE_STRIP_ADJACENCY_EXT, 
#endif

#if (GL_EXT_GEOMETRY_SHADER || GL_EXT_GEOMETRY_SHADER4 || GL_NV_GEOMETRY_PROGRAM4)
    TrianglesAdjacencyExt = gl.Constants.GL_TRIANGLES_ADJACENCY_EXT, 
#endif

#if (GL_EXT_GEOMETRY_SHADER || GL_EXT_GEOMETRY_SHADER4 || GL_NV_GEOMETRY_PROGRAM4)
    TriangleStripAdjacencyExt = gl.Constants.GL_TRIANGLE_STRIP_ADJACENCY_EXT, 
#endif

#if GL_EXT_TESSELLATION_SHADER
    QuadsExt = gl.Constants.GL_QUADS_EXT, 
#endif

#if GL_EXT_TESSELLATION_SHADER
    PatchesExt = gl.Constants.GL_PATCHES_EXT, 
#endif

}

#endif
