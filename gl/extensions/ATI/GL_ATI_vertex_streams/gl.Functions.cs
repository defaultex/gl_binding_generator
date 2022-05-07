#if (GL_ATI_vertex_streams && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glClientActiveVertexStreamATI(GLenum stream);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, void> glClientActiveVertexStreamATI;

        /// <summary>void glNormalStream3bATI(GLenum stream, GLbyte nx, GLbyte ny, GLbyte nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLbyte, GLbyte, GLbyte, void> glNormalStream3bATI;

        /// <summary>void glNormalStream3bvATI(GLenum stream, GLbyte* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLbyte*, void> glNormalStream3bvATI;

        /// <summary>void glNormalStream3dATI(GLenum stream, GLdouble nx, GLdouble ny, GLdouble nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble, GLdouble, GLdouble, void> glNormalStream3dATI;

        /// <summary>void glNormalStream3dvATI(GLenum stream, GLdouble* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble*, void> glNormalStream3dvATI;

        /// <summary>void glNormalStream3fATI(GLenum stream, GLfloat nx, GLfloat ny, GLfloat nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat, GLfloat, GLfloat, void> glNormalStream3fATI;

        /// <summary>void glNormalStream3fvATI(GLenum stream, GLfloat* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat*, void> glNormalStream3fvATI;

        /// <summary>void glNormalStream3iATI(GLenum stream, GLint nx, GLint ny, GLint nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint, GLint, GLint, void> glNormalStream3iATI;

        /// <summary>void glNormalStream3ivATI(GLenum stream, GLint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint*, void> glNormalStream3ivATI;

        /// <summary>void glNormalStream3sATI(GLenum stream, GLshort nx, GLshort ny, GLshort nz);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort, GLshort, GLshort, void> glNormalStream3sATI;

        /// <summary>void glNormalStream3svATI(GLenum stream, GLshort* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort*, void> glNormalStream3svATI;

        /// <summary>void glVertexBlendEnvfATI(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat, void> glVertexBlendEnvfATI;

        /// <summary>void glVertexBlendEnviATI(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint, void> glVertexBlendEnviATI;

        /// <summary>void glVertexStream1dATI(GLenum stream, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble, void> glVertexStream1dATI;

        /// <summary>void glVertexStream1dvATI(GLenum stream, GLdouble* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble*, void> glVertexStream1dvATI;

        /// <summary>void glVertexStream1fATI(GLenum stream, GLfloat x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat, void> glVertexStream1fATI;

        /// <summary>void glVertexStream1fvATI(GLenum stream, GLfloat* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat*, void> glVertexStream1fvATI;

        /// <summary>void glVertexStream1iATI(GLenum stream, GLint x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint, void> glVertexStream1iATI;

        /// <summary>void glVertexStream1ivATI(GLenum stream, GLint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint*, void> glVertexStream1ivATI;

        /// <summary>void glVertexStream1sATI(GLenum stream, GLshort x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort, void> glVertexStream1sATI;

        /// <summary>void glVertexStream1svATI(GLenum stream, GLshort* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort*, void> glVertexStream1svATI;

        /// <summary>void glVertexStream2dATI(GLenum stream, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble, GLdouble, void> glVertexStream2dATI;

        /// <summary>void glVertexStream2dvATI(GLenum stream, GLdouble* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble*, void> glVertexStream2dvATI;

        /// <summary>void glVertexStream2fATI(GLenum stream, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat, GLfloat, void> glVertexStream2fATI;

        /// <summary>void glVertexStream2fvATI(GLenum stream, GLfloat* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat*, void> glVertexStream2fvATI;

        /// <summary>void glVertexStream2iATI(GLenum stream, GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint, GLint, void> glVertexStream2iATI;

        /// <summary>void glVertexStream2ivATI(GLenum stream, GLint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint*, void> glVertexStream2ivATI;

        /// <summary>void glVertexStream2sATI(GLenum stream, GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort, GLshort, void> glVertexStream2sATI;

        /// <summary>void glVertexStream2svATI(GLenum stream, GLshort* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort*, void> glVertexStream2svATI;

        /// <summary>void glVertexStream3dATI(GLenum stream, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble, GLdouble, GLdouble, void> glVertexStream3dATI;

        /// <summary>void glVertexStream3dvATI(GLenum stream, GLdouble* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble*, void> glVertexStream3dvATI;

        /// <summary>void glVertexStream3fATI(GLenum stream, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat, GLfloat, GLfloat, void> glVertexStream3fATI;

        /// <summary>void glVertexStream3fvATI(GLenum stream, GLfloat* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat*, void> glVertexStream3fvATI;

        /// <summary>void glVertexStream3iATI(GLenum stream, GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint, GLint, GLint, void> glVertexStream3iATI;

        /// <summary>void glVertexStream3ivATI(GLenum stream, GLint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint*, void> glVertexStream3ivATI;

        /// <summary>void glVertexStream3sATI(GLenum stream, GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort, GLshort, GLshort, void> glVertexStream3sATI;

        /// <summary>void glVertexStream3svATI(GLenum stream, GLshort* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort*, void> glVertexStream3svATI;

        /// <summary>void glVertexStream4dATI(GLenum stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexStream4dATI;

        /// <summary>void glVertexStream4dvATI(GLenum stream, GLdouble* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLdouble*, void> glVertexStream4dvATI;

        /// <summary>void glVertexStream4fATI(GLenum stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexStream4fATI;

        /// <summary>void glVertexStream4fvATI(GLenum stream, GLfloat* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLfloat*, void> glVertexStream4fvATI;

        /// <summary>void glVertexStream4iATI(GLenum stream, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint, GLint, GLint, GLint, void> glVertexStream4iATI;

        /// <summary>void glVertexStream4ivATI(GLenum stream, GLint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLint*, void> glVertexStream4ivATI;

        /// <summary>void glVertexStream4sATI(GLenum stream, GLshort x, GLshort y, GLshort z, GLshort w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort, GLshort, GLshort, GLshort, void> glVertexStream4sATI;

        /// <summary>void glVertexStream4svATI(GLenum stream, GLshort* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexStreamATI, GLshort*, void> glVertexStream4svATI;
    }
}
#endif