#if GL_PGI_VERTEX_HINTS

public enum HintTargetPGI : GLenum { 
#if GL_PGI_VERTEX_HINTS
    VertexDataHintPgi = gl.Constants.GL_VERTEX_DATA_HINT_PGI, 
#endif

#if GL_PGI_VERTEX_HINTS
    VertexConsistentHintPgi = gl.Constants.GL_VERTEX_CONSISTENT_HINT_PGI, 
#endif

#if GL_PGI_VERTEX_HINTS
    MaterialSideHintPgi = gl.Constants.GL_MATERIAL_SIDE_HINT_PGI, 
#endif

#if GL_PGI_VERTEX_HINTS
    MaxVertexHintPgi = gl.Constants.GL_MAX_VERTEX_HINT_PGI, 
#endif

}

#endif
