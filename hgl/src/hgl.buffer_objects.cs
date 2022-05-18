namespace HGL;

[StructLayout(LayoutKind.Explicit)]
public struct DrawArraysIndirectCommand {
    [FieldOffset(sizeof(uint) * 0)]
    public uint Count;

    [FieldOffset(sizeof(uint) * 1)]
    public uint PrimitiveCount; // used by glDrawArraysIndirect(...)

    [FieldOffset(sizeof(uint) * 1)]
    public uint InstanceCount; // used by glMultiDrawArraysIndirect(...)

    [FieldOffset(sizeof(uint) * 2)]
    public uint First;

    [FieldOffset(sizeof(uint) * 2)]
    public uint BaseInstance;

    public DrawArraysIndirectCommand() {
        Count = 0;
        PrimitiveCount = 0;
        InstanceCount = 0;
        First = 0;
        BaseInstance = 0;
    }
}

[StructLayout(LayoutKind.Explicit)]
public struct DrawElementsIndirectCommand {
    [FieldOffset(sizeof(uint) * 0)]
    public uint Count;

    [FieldOffset(sizeof(uint) * 1)]
    public uint PrimitiveCount; // used by glDrawElementsIndirect(...)

    [FieldOffset(sizeof(uint) * 1)]
    public uint InstanceCount; // used by glMultiDrawElementsIndirect(...)

    [FieldOffset(sizeof(uint) * 2)]
    public uint FirstIndex;

    [FieldOffset(sizeof(uint) * 3)]
    public uint BaseVertex;

    [FieldOffset(sizeof(uint) * 4)]
    public uint BaseInstance;

    public DrawElementsIndirectCommand() {
        Count = 0;
        PrimitiveCount = 0;
        InstanceCount = 0;
        FirstIndex = 0;
        BaseVertex = 0;
        BaseInstance = 0;
    }
}

partial class hgl {
    
    public static void BindBuffer(BufferTarget target, GLbuffer buffer) {
        unsafe { gl.Functions.glBindBuffer(target, buffer); }
    }

    public static void BindBufferBase(BufferTarget target, int index, GLbuffer buffer) {
        unsafe { gl.Functions.glBindBufferBase(target, (GLuint)index, buffer); }
    }

    public static void BindBufferRange(BufferTarget target, int index, GLbuffer buffer, int offset, int size) {
        unsafe { gl.Functions.glBindBufferRange(target, (GLuint)index, buffer, (GLintptr)offset, (GLsizeiptr)size); }
    }

    public static void BindBuffersBase(BufferTarget target, int index, GLbuffer[] buffers) {
        unsafe { fixed (GLbuffer* pBuffers = buffers) gl.Functions.glBindBuffersBase(target, (GLuint)index, buffers.Length, pBuffers); }
    }

    public static void BindBuffersRange(BufferTarget target, int index, GLbuffer[] buffers, int[] offsets, int[] sizes) {
        unsafe {
            fixed (GLbuffer* pBuffers = buffers)
            fixed (int* pOffsets = offsets)
            fixed (int* pSizes = sizes) {
                gl.Functions.glBindBuffersRange(target, (GLuint)index, buffers.Length, pBuffers, (GLintptr*)pOffsets, (GLsizeiptr*)pSizes);
            }
        }
    }

    public static void BindVertexBuffer(int bindingIndex, GLbuffer buffer, int offset, int size) {
        unsafe { gl.Functions.glBindVertexBuffer((GLuint)bindingIndex, buffer, (GLintptr)offset, size); }
    }

    public static void BindVertexBuffers(int bindingIndex, GLbuffer[] buffers, int[] offsets, int[] sizes) {
        unsafe {
            fixed (GLbuffer* pBuffers = buffers)
            fixed (int* pOffsets = offsets, pSizes = sizes) {
                gl.Functions.glBindVertexBuffers((GLuint)bindingIndex, buffers.Length, pBuffers, (GLintptr*)pOffsets, pSizes);
            }
        }
    }

    public static void BufferData<T>(BufferTarget target, int size, T[] data, BufferUsage usage) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glBufferData(target, (GLsizeiptr)size, pData, usage); }
    }

    public static void BufferData<T>(this GLbuffer buffer, int size, T[] data, BufferUsage usage) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glNamedBufferData(buffer, (GLsizeiptr)size, pData, usage); }
    }

    public static void BufferStorage<T>(BufferTarget target, int size, T[] data, BufferStorageMask flags) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glBufferStorage(target, (GLsizeiptr)size, pData, flags); }
    }

    public static void BufferStorage<T>(this GLbuffer buffer, int size, T[] data, BufferStorageMask flags) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glNamedBufferStorage(buffer, (GLsizeiptr)size, pData, flags); }
    }

    public static void BufferSubData<T>(BufferTarget target, int offset, int size, T[] data) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glBufferSubData(target, (GLintptr)offset, (GLsizeiptr)size, pData); }
    }

    public static void BufferSubData<T>(this GLbuffer buffer, int offset, int size, T[] data) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glNamedBufferSubData(buffer, (GLintptr)offset, (GLsizeiptr)size, pData); }
    }

    public static void ClearBufferData<T>(BufferTarget target, SizedInternalFormat internalFormat, PixelFormat format, PixelType type, T[] data) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glClearBufferData(target, internalFormat, format, type, pData); }
    }

    public static void ClearBufferData<T>(this GLbuffer buffer, SizedInternalFormat internalFormat, PixelFormat format, PixelType type, T[] data) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glClearNamedBufferData(buffer, internalFormat, format, type, pData); }
    }

    public static void ClearBufferSubData<T>(BufferTarget target, SizedInternalFormat internalFormat, int offset, int size, PixelFormat format, PixelType type, T[] data) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glClearBufferSubData(target, internalFormat, (GLintptr)offset, (GLsizeiptr)size, format, type, pData); }
    }

    public static void ClearBufferSubData<T>(this GLbuffer buffer, SizedInternalFormat internalFormat, int offset, int size, PixelFormat format, PixelType type, T[] data) where T : unmanaged {
        unsafe { fixed (T* pData = data) gl.Functions.glClearNamedBufferSubData(buffer, internalFormat, (GLintptr)offset, (GLsizeiptr)size, format, type, pData); }
    }

    public static void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, int readOffset, int writeOffset, int size) {
        unsafe { gl.Functions.glCopyBufferSubData(readTarget, writeTarget, (GLintptr)readOffset, (GLintptr)writeOffset, (GLsizeiptr)size); }
    }

    public static void CopyBufferSubData(GLbuffer readBuffer, GLbuffer writeBuffer, int readOffset, int writeOffset, int size) {
        unsafe { gl.Functions.glCopyNamedBufferSubData(readBuffer, writeBuffer, (GLintptr)readOffset, (GLintptr)writeOffset, (GLsizeiptr)size); }
    }

    public static void CreateBuffers(GLbuffer[] buffers) {
        unsafe { fixed (GLbuffer* pBuffers = buffers) gl.Functions.glCreateBuffers(buffers.Length, pBuffers); }
    }

    public static void CreateBuffer(out GLbuffer buffer) {
        unsafe { fixed (GLbuffer* pBuffers = &buffer) gl.Functions.glCreateBuffers(1, pBuffers); }
    }

    public static void DeleteBuffers(params GLbuffer[] buffers) {
        unsafe { fixed (GLbuffer* pBuffer = buffers) gl.Functions.glDeleteBuffers(buffers.Length, pBuffer); }
    }

    public static void DisableVertexAttribArray(int index) {
        unsafe { gl.Functions.glDisableVertexAttribArray((GLuint)index); }
    }

    public static void DrawArrays(PrimitiveType mode, int first, int count) {
        unsafe { gl.Functions.glDrawArrays(mode, first, count); }
    }

    public static void DrawArraysIndirect(PrimitiveType mode, DrawArraysIndirectCommand indirect) {
        unsafe { gl.Functions.glDrawArraysIndirect(mode, &indirect); }
    }

    public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instanceCount) {
        unsafe { gl.Functions.glDrawArraysInstanced(mode, first, count, instanceCount); }
    }

    public static void DrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instanceCount, int baseInstance) {
        unsafe { gl.Functions.glDrawArraysInstancedBaseInstance(mode, first, count, instanceCount, (GLuint)baseInstance); }
    }

    public static void DrawElements(PrimitiveType mode, int count, ElementType type, int offset) {
        unsafe { gl.Functions.glDrawElements(mode, count, type, (void*)offset); }
    }

    public static void DrawElementsBaseVertex(PrimitiveType mode, int count, ElementType type, int offset, int baseVertex) {
        unsafe { gl.Functions.glDrawElementsBaseVertex(mode, count, type, (void*)offset, baseVertex); }
    }

    public static void DrawElementsIndirect(PrimitiveType mode, ElementType type, DrawElementsIndirectCommand indirect) {
        unsafe { gl.Functions.glDrawElementsIndirect(mode, type, &indirect); }
    }

    public static void DrawElementsInstanced(PrimitiveType mode, int count, ElementType type, int offset, int instanceCount) {
        unsafe { gl.Functions.glDrawElementsInstanced(mode, count, type, (void*)offset, instanceCount); }
    }

    public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, ElementType type, int offset, int instanceCount, int baseInstance) {
        unsafe { gl.Functions.glDrawElementsInstancedBaseInstance(mode, count, type, (void*)offset, instanceCount, (GLuint)baseInstance); }
    }

    public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, ElementType type, int offset, int instanceCount, int baseVertex) {
        unsafe { gl.Functions.glDrawElementsInstancedBaseVertex(mode, count, type, (void*)offset, instanceCount, baseVertex); }
    }

    public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, ElementType type, int offset, int instanceCount, int baseVertex, int baseInstance) {
        unsafe { gl.Functions.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, (void*)offset, instanceCount, baseVertex, (GLuint)baseInstance); }
    }

    public static void DrawRangeElements(PrimitiveType mode, int start, int end, int count, ElementType type, int offset) {
        unsafe { gl.Functions.glDrawRangeElements(mode, (GLuint)start, (GLuint)end, count, type, (void*)offset); }
    }

    public static void DrawRangeElementsBaseVertex(PrimitiveType mode, int start, int end, int count, ElementType type, int offsets, int baseVertex) {
        unsafe { gl.Functions.glDrawRangeElementsBaseVertex(mode, (GLuint)start, (GLuint)end, count, type, (void*)offsets, baseVertex); }
    }

    public static void EnableVertexAttribArray(int index) {
        unsafe { gl.Functions.glEnableVertexAttribArray((GLuint)index); }
    }

    public static void FlushMappedBufferRange(BufferTarget target, int offset, int length) {
        unsafe { gl.Functions.glFlushMappedBufferRange(target, (GLintptr)offset, (GLsizeiptr)length); }
    }

    public static void FlushMappedBufferRange(this GLbuffer buffer, int offset, int length) {
        unsafe { gl.Functions.glFlushMappedNamedBufferRange(buffer, (GLintptr)offset, (GLsizeiptr)length); }
    }

    public static void GenBuffers(GLbuffer[] buffers) {
        unsafe { fixed (GLbuffer* ptr = buffers) gl.Functions.glGenBuffers(buffers.Length, ptr); }
    }

    public static void GenBuffer(out GLbuffer buffer) {
        unsafe { fixed (GLbuffer* ptr = &buffer) gl.Functions.glGenBuffers(1, ptr); }
    }

    public static void GetBufferParameter(BufferTarget target, BufferParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetBufferParameteriv(target, pname, ptr); }
    }

    public static void GetBufferParameter(BufferTarget target, BufferParameter pname, out long parameters) {
        unsafe { fixed (GLint64* ptr = &parameters) gl.Functions.glGetBufferParameteri64v(target, pname, ptr); }
    }

    public static void GetBufferParameter(this GLbuffer buffer, BufferParameter pname, out int parameters) {
        unsafe { fixed (GLint* ptr = &parameters) gl.Functions.glGetNamedBufferParameteriv(buffer, pname, ptr); }
    }

    public static void GetBufferParameter(this GLbuffer buffer, BufferParameter pname, out long parameters) {
        unsafe { fixed (GLint64* ptr = &parameters) gl.Functions.glGetNamedBufferParameteri64v(buffer, pname, ptr); }
    }

    public static void GetBufferPointer(BufferTarget target, out IntPtr parameters) {
        unsafe { fixed (void* ptr = &parameters) gl.Functions.glGetBufferPointerv(target, BufferPointerParameter.BufferMapPointer, (void**)&ptr); }
    }

    public static void GetBufferPointer<T>(BufferTarget target, out T parameters) where T : unmanaged {
        unsafe { fixed (void* pData = &parameters) gl.Functions.glGetBufferPointerv(target, BufferPointerParameter.BufferMapPointer, (void**)&pData); }
    }

    public static void GetBufferPointer<T>(BufferTarget target, out T[] parameters) where T : unmanaged {
        unsafe { fixed (void* pData = parameters) gl.Functions.glGetBufferPointerv(target, BufferPointerParameter.BufferMapPointer, (void**)&pData); }
    }

    public static void GetBufferPointer(this GLbuffer buffer, out IntPtr parameters) {
        unsafe { fixed (void* pData = &parameters) gl.Functions.glGetNamedBufferPointerv(buffer, BufferPointerParameter.BufferMapPointer, (void**)&pData); }
    }

    public static void GetBufferPointer<T>(this GLbuffer buffer, out T parameters) where T : unmanaged {
        unsafe { fixed (void* pData = &parameters) gl.Functions.glGetNamedBufferPointerv(buffer, BufferPointerParameter.BufferMapPointer, (void**)&pData); }
    }

    public static void GetBufferPointer<T>(this GLbuffer buffer, out T[] parameters) where T : unmanaged {
        unsafe { fixed (void* pData = parameters) gl.Functions.glGetNamedBufferPointerv(buffer, BufferPointerParameter.BufferMapPointer, (void**)&pData); }
    }

    public static void GetBufferSubData<TData>(BufferTarget target, int offset, int size, TData[] data) where TData : unmanaged {
        unsafe { fixed (void* pData = data) gl.Functions.glGetBufferSubData(target, (GLintptr)offset, (GLsizeiptr)size, pData); }
    }

    public static void GetBufferSubData<TData>(this GLbuffer buffer, int offset, int size, TData[] data) where TData : unmanaged {
        unsafe { fixed (void* pData = data) gl.Functions.glGetNamedBufferSubData(buffer, (GLintptr)offset, (GLsizeiptr)size, pData); }
    }

    public static void GetVertexAttrib(int index, VertexAttribProperty pname, double[] parameters) {
        unsafe { fixed (GLdouble* pParam = parameters) gl.Functions.glGetVertexAttribdv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttrib(int index, VertexAttribProperty pname, out double parameters) {
        unsafe { fixed (GLdouble* pParam = &parameters) gl.Functions.glGetVertexAttribdv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttrib(int index, VertexAttribProperty pname, float[] parameters) {
        unsafe { fixed (GLfloat* pParam = parameters) gl.Functions.glGetVertexAttribfv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttrib(int index, VertexAttribProperty pname, out float parameters) {
        unsafe { fixed (GLfloat* pParam = &parameters) gl.Functions.glGetVertexAttribfv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttrib(int index, VertexAttribProperty pname, int[] parameters) {
        unsafe { fixed (GLint* pParam = parameters) gl.Functions.glGetVertexAttribiv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttrib(int index, VertexAttribProperty pname, out int parameters) {
        unsafe { fixed (GLint* pParam = &parameters) gl.Functions.glGetVertexAttribiv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttribI(int index, VertexAttribProperty pname, int[] parameters) {
        unsafe { fixed (GLint* pParam = parameters) gl.Functions.glGetVertexAttribIiv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttribI(int index, VertexAttribProperty pname, out int parameters) {
        unsafe { fixed (GLint* pParam = &parameters) gl.Functions.glGetVertexAttribIiv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttribI(int index, VertexAttribProperty pname, uint[] parameters) {
        unsafe { fixed (GLuint* pParam = parameters) gl.Functions.glGetVertexAttribIuiv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttribI(int index, VertexAttribProperty pname, out uint parameters) {
        unsafe { fixed (GLuint* pParam = &parameters) gl.Functions.glGetVertexAttribIuiv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttribL(int index, VertexAttribProperty pname, double[] parameters) {
        unsafe { fixed (GLdouble* pParam = parameters) gl.Functions.glGetVertexAttribLdv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttribL(int index, VertexAttribProperty pname, out double parameters) {
        unsafe { fixed (GLdouble* pParam = &parameters) gl.Functions.glGetVertexAttribLdv((GLuint)index, pname, pParam); }
    }

    public static void GetVertexAttribPointerv<T>(int index, out T pointer) where T : unmanaged {
        unsafe { fixed (void* ptr = &pointer) gl.Functions.glGetVertexAttribPointerv((GLuint)index, VertexAttribPointerProperty.VertexAttribArrayPointer, (void**)&ptr); }
    }

    public static void GetVertexAttribPointerv<T>(int index, T[] pointer) where T : unmanaged {
        unsafe { fixed (void* ptr = pointer) gl.Functions.glGetVertexAttribPointerv((GLuint)index, VertexAttribPointerProperty.VertexAttribArrayPointer, (void**)&ptr); }
    }

    public static void InvalidateBufferData(this GLbuffer buffer) {
        unsafe { gl.Functions.glInvalidateBufferData(buffer); }
    }

    public static void InvalidateBufferSubData(this GLbuffer buffer, int offset, int length) {
        unsafe { gl.Functions.glInvalidateBufferSubData(buffer, (GLintptr)offset, (GLsizeiptr)length); }
    }

    public static bool IsBuffer(this GLbuffer buffer) {
        unsafe { return (gl.Functions.glIsBuffer(buffer) != gl.Constants.GL_FALSE); }
    }

    // TODO : determine a generic mapping for these, consider => https://hacksoflife.blogspot.com/2015/06/glmapbuffer-no-longer-cool.html
    public static IntPtr MapBuffer(BufferTarget target, BufferAccess access) {
        unsafe { return (IntPtr)gl.Functions.glMapBuffer(target, access); }
    }

    public static IntPtr MapBuffer(this GLbuffer buffer, BufferAccess access) {
        unsafe { return (IntPtr)gl.Functions.glMapNamedBuffer(buffer, access); }
    }

    public static IntPtr MapBufferRange(BufferTarget target, int offset, int length, MapBufferAccessMask access) {
        unsafe { return (IntPtr)gl.Functions.glMapBufferRange(target, (GLintptr)offset, (GLsizeiptr)length, access); }
    }

    public static IntPtr MapBufferRange(this GLbuffer buffer, int offset, int length, MapBufferAccessMask access) {
        unsafe { return (IntPtr)gl.Functions.glMapNamedBufferRange(buffer, (GLintptr)offset, (GLsizeiptr)length, access); }
    }

    public static void MultiDrawArrays(PrimitiveType mode, int[] first, int[] count, int drawCount) {
        unsafe { fixed (GLint* pFirst = first, pCount = count) gl.Functions.glMultiDrawArrays(mode, pFirst, pCount, drawCount); }
    }

    public static void MultiDrawArraysIndirect(PrimitiveType mode, DrawArraysIndirectCommand[] indirect, int drawCount, int stride) {
        unsafe { fixed (DrawArraysIndirectCommand* pIndirect = indirect) gl.Functions.glMultiDrawArraysIndirect(mode, pIndirect, drawCount, stride); }
    }

    public static void MultiDrawElements<T>(PrimitiveType mode, int[] count, ElementType type, T[] indices, int drawCount) where T : unmanaged {
        unsafe { fixed (int* pCount = count) fixed (T* pIndices = indices) gl.Functions.glMultiDrawElements(mode, pCount, type, (void**)pIndices, drawCount); }
    }

    public static void MultiDrawElementsBaseVertex<T>(PrimitiveType mode, int[] count, ElementType type, T[] indices, int drawCount, int[] baseVertex) where T : unmanaged {
        unsafe {
            fixed (int* pCount = count, pBaseVertex = baseVertex)
            fixed (T* pIndices = indices) {
                gl.Functions.glMultiDrawElementsBaseVertex(mode, pCount, type, (void**)pIndices, drawCount, pBaseVertex);
            }
        }
    }

    public static void MultiDrawElementsIndirect<T>(PrimitiveType mode, ElementType type, DrawElementsIndirectCommand[] indirect, int drawCount, int stride) where T : unmanaged {
        unsafe { fixed (DrawElementsIndirectCommand* pIndirect = indirect) gl.Functions.glMultiDrawElementsIndirect(mode, type, pIndirect, drawCount, stride); }
    }

    public static void PatchParameter(PatchParameter pname, int value) {
        unsafe { gl.Functions.glPatchParameteri(pname, value); }
    }

    public static void PatchParameter(PatchParameter pname, float[] value) {
        unsafe { fixed (GLfloat* pValue = value) gl.Functions.glPatchParameterfv(pname, pValue); }
    }

    public static void PrimitiveRestartIndex(int index) {
        unsafe { gl.Functions.glPrimitiveRestartIndex((GLuint)index); }
    }

    public static void ProvokingVertex(VertexProvokingMode mode) {
        unsafe { gl.Functions.glProvokingVertex(mode); }
    }

    public static bool UnmapBuffer(BufferTarget target) {
        unsafe { return (gl.Functions.glUnmapBuffer(target) != gl.Constants.GL_FALSE); }
    }

    public static bool UnmapBuffer(this GLbuffer buffer) {
        unsafe { return (gl.Functions.glUnmapNamedBuffer(buffer) != gl.Constants.GL_FALSE); }
    }

    public static void VertexAttrib1(int index, double x) {
        unsafe { gl.Functions.glVertexAttrib1d((GLuint)index, x); }
    }

    public static void VertexAttrib2(int index, double x, double y) {
        unsafe { gl.Functions.glVertexAttrib2d((GLuint)index, x, y); }
    }

    public static void VertexAttrib3(int index, double x, double y, double z) {
        unsafe { gl.Functions.glVertexAttrib3d((GLuint)index, x, y, z); }
    }

    public static void VertexAttrib4(int index, double x, double y, double z, double w) {
        unsafe { gl.Functions.glVertexAttrib4d((GLuint)index, x, y, z, w); }
    }

    public static void VertexAttrib1(int index, float x) {
        unsafe { gl.Functions.glVertexAttrib1f((GLuint)index, x); }
    }

    public static void VertexAttrib2(int index, float x, float y) {
        unsafe { gl.Functions.glVertexAttrib2f((GLuint)index, x, y); }
    }

    public static void VertexAttrib3(int index, float x, float y, float z) {
        unsafe { gl.Functions.glVertexAttrib3f((GLuint)index, x, y, z); }
    }

    public static void VertexAttrib4(int index, float x, float y, float z, float w) {
        unsafe { gl.Functions.glVertexAttrib4f((GLuint)index, x, y, z, w); }
    }

    public static void VertexAttrib1(int index, short x) {
        unsafe { gl.Functions.glVertexAttrib1s((GLuint)index, x); }
    }

    public static void VertexAttrib2(int index, short x, short y) {
        unsafe { gl.Functions.glVertexAttrib2s((GLuint)index, x, y); }
    }

    public static void VertexAttrib3(int index, short x, short y, short z) {
        unsafe { gl.Functions.glVertexAttrib3s((GLuint)index, x, y, z); }
    }

    public static void VertexAttrib4(int index, short x, short y, short z, short w) {
        unsafe { gl.Functions.glVertexAttrib4s((GLuint)index, x, y, z, w); }
    }

    public static void VertexAttrib4N(int index, byte x, byte y, byte z, byte w) {
        unsafe { gl.Functions.glVertexAttrib4Nub((GLuint)index, x, y, z, w); }
    }

    public static void VertexAttrib1(int index, double[] v) {
        unsafe { fixed (GLdouble* ptr = v) gl.Functions.glVertexAttrib1dv((GLuint)index, ptr); }
    }

    public static void VertexAttrib2(int index, double[] v) {
        unsafe { fixed (GLdouble* ptr = v) gl.Functions.glVertexAttrib2dv((GLuint)index, ptr); }
    }

    public static void VertexAttrib3(int index, double[] v) {
        unsafe { fixed (GLdouble* ptr = v) gl.Functions.glVertexAttrib3dv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4(int index, double[] v) {
        unsafe { fixed (GLdouble* ptr = v) gl.Functions.glVertexAttrib4dv((GLuint)index, ptr); }
    }

    public static void VertexAttrib1(int index, float[] v) {
        unsafe { fixed (GLfloat* ptr = v) gl.Functions.glVertexAttrib1fv((GLuint)index, ptr); }
    }

    public static void VertexAttrib2(int index, float[] v) {
        unsafe { fixed (GLfloat* ptr = v) gl.Functions.glVertexAttrib2fv((GLuint)index, ptr); }
    }

    public static void VertexAttrib3(int index, float[] v) {
        unsafe { fixed (GLfloat* ptr = v) gl.Functions.glVertexAttrib3fv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4(int index, float[] v) {
        unsafe { fixed (GLfloat* ptr = v) gl.Functions.glVertexAttrib4fv((GLuint)index, ptr); }
    }

    public static void VertexAttrib1(int index, short[] v) {
        unsafe { fixed (GLshort* ptr = v) gl.Functions.glVertexAttrib1sv((GLuint)index, ptr); }
    }

    public static void VertexAttrib2(int index, short[] v) {
        unsafe { fixed (GLshort* ptr = v) gl.Functions.glVertexAttrib2sv((GLuint)index, ptr); }
    }

    public static void VertexAttrib3(int index, short[] v) {
        unsafe { fixed (GLshort* ptr = v) gl.Functions.glVertexAttrib3sv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4(int index, short[] v) {
        unsafe { fixed (GLshort* ptr = v) gl.Functions.glVertexAttrib4sv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4N(int index, sbyte[] v) {
        unsafe { fixed (GLbyte* ptr = v) gl.Functions.glVertexAttrib4Nbv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4N(int index, int[] v) {
        unsafe { fixed (GLint* ptr = v) gl.Functions.glVertexAttrib4Niv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4N(int index, short[] v) {
        unsafe { fixed (GLshort* ptr = v) gl.Functions.glVertexAttrib4Nsv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4N(int index, byte[] v) {
        unsafe { fixed (GLubyte* ptr = v) gl.Functions.glVertexAttrib4Nubv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4N(int index, uint[] v) {
        unsafe { fixed (GLuint* ptr = v) gl.Functions.glVertexAttrib4Nuiv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4N(int index, ushort[] v) {
        unsafe { fixed (GLushort* ptr = v) gl.Functions.glVertexAttrib4Nusv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4(int index, sbyte[] v) {
        unsafe { fixed (GLbyte* ptr = v) gl.Functions.glVertexAttrib4bv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4(int index, int[] v) {
        unsafe { fixed (GLint* ptr = v) gl.Functions.glVertexAttrib4iv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4(int index, byte[] v) {
        unsafe { fixed (GLubyte* ptr = v) gl.Functions.glVertexAttrib4ubv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4(int index, uint[] v) {
        unsafe { fixed (GLuint* ptr = v) gl.Functions.glVertexAttrib4uiv((GLuint)index, ptr); }
    }

    public static void VertexAttrib4(int index, ushort[] v) {
        unsafe { fixed (GLushort* ptr = v) gl.Functions.glVertexAttrib4usv((GLuint)index, ptr); }
    }

    public static void VertexAttribI1(int index, int x) {
        unsafe { gl.Functions.glVertexAttribI1i((GLuint)index, x); }
    }

    public static void VertexAttribI2(int index, int x, int y) {
        unsafe { gl.Functions.glVertexAttribI2i((GLuint)index, x, y); }
    }

    public static void VertexAttribI3(int index, int x, int y, int z) {
        unsafe { gl.Functions.glVertexAttribI3i((GLuint)index, x, y, z); }
    }

    public static void VertexAttribI4(int index, int x, int y, int z, int w) {
        unsafe { gl.Functions.glVertexAttribI4i((GLuint)index, x, y, z, w); }
    }

    public static void VertexAttribI1(int index, uint x) {
        unsafe { gl.Functions.glVertexAttribI1ui((GLuint)index, x); }
    }

    public static void VertexAttribI2(int index, uint x, uint y) {
        unsafe { gl.Functions.glVertexAttribI2ui((GLuint)index, x, y); }
    }

    public static void VertexAttribI3(int index, uint x, uint y, uint z) {
        unsafe { gl.Functions.glVertexAttribI3ui((GLuint)index, x, y, z); }
    }

    public static void VertexAttribI4(int index, uint x, uint y, uint z, uint w) {
        unsafe { gl.Functions.glVertexAttribI4ui((GLuint)index, x, y, z, w); }
    }

    public static void VertexAttribI1(int index, int[] v) {
        unsafe { fixed (GLint* ptr = v) gl.Functions.glVertexAttribI1iv((GLuint)index, ptr); }
    }

    public static void VertexAttribI2(int index, int[] v) {
        unsafe { fixed (GLint* ptr = v) gl.Functions.glVertexAttribI2iv((GLuint)index, ptr); }
    }

    public static void VertexAttribI3(int index, int[] v) {
        unsafe { fixed (GLint* ptr = v) gl.Functions.glVertexAttribI3iv((GLuint)index, ptr); }
    }

    public static void VertexAttribI4(int index, int[] v) {
        unsafe { fixed (GLint* ptr = v) gl.Functions.glVertexAttribI4iv((GLuint)index, ptr); }
    }

    public static void VertexAttribI1(int index, uint[] v) {
        unsafe { fixed (GLuint* ptr = v) gl.Functions.glVertexAttribI1uiv((GLuint)index, ptr); }
    }

    public static void VertexAttribI2(int index, uint[] v) {
        unsafe { fixed (GLuint* ptr = v) gl.Functions.glVertexAttribI2uiv((GLuint)index, ptr); }
    }

    public static void VertexAttribI3(int index, uint[] v) {
        unsafe { fixed (GLuint* ptr = v) gl.Functions.glVertexAttribI3uiv((GLuint)index, ptr); }
    }

    public static void VertexAttribI4(int index, uint[] v) {
        unsafe { fixed (GLuint* ptr = v) gl.Functions.glVertexAttribI4uiv((GLuint)index, ptr); }
    }

    public static void VertexAttribI4(int index, sbyte[] v) {
        unsafe { fixed (GLbyte* ptr = v) gl.Functions.glVertexAttribI4bv((GLuint)index, ptr); }
    }

    public static void VertexAttribI4(int index, byte[] v) {
        unsafe { fixed (GLubyte* ptr = v) gl.Functions.glVertexAttribI4ubv((GLuint)index, ptr); }
    }

    public static void VertexAttribI4(int index, short[] v) {
        unsafe { fixed (GLshort* ptr = v) gl.Functions.glVertexAttribI4sv((GLuint)index, ptr); }
    }

    public static void VertexAttribI4(int index, ushort[] v) {
        unsafe { fixed (GLushort* ptr = v) gl.Functions.glVertexAttribI4usv((GLuint)index, ptr); }
    }

    public static void VertexAttribP1(int index, VertexAttribType type, bool normalized, uint value) {
        unsafe { gl.Functions.glVertexAttribP1ui((GLuint)index, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), value); }
    }

    public static void VertexAttribP2(int index, VertexAttribType type, bool normalized, uint value) {
        unsafe { gl.Functions.glVertexAttribP2ui((GLuint)index, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), value); }
    }

    public static void VertexAttribP3(int index, VertexAttribType type, bool normalized, uint value) {
        unsafe { gl.Functions.glVertexAttribP3ui((GLuint)index, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), value); }
    }

    public static void VertexAttribP4(int index, VertexAttribType type, bool normalized, uint value) {
        unsafe { gl.Functions.glVertexAttribP4ui((GLuint)index, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), value); }
    }

    public static void VertexAttribP1(int index, VertexAttribType type, bool normalized, uint[] value) {
        unsafe { fixed (GLuint* pValue = value) gl.Functions.glVertexAttribP1uiv((GLuint)index, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), pValue); }
    }

    public static void VertexAttribP2(int index, VertexAttribType type, bool normalized, uint[] value) {
        unsafe { fixed (GLuint* pValue = value) gl.Functions.glVertexAttribP2uiv((GLuint)index, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), pValue); }
    }

    public static void VertexAttribP3(int index, VertexAttribType type, bool normalized, uint[] value) {
        unsafe { fixed (GLuint* pValue = value) gl.Functions.glVertexAttribP3uiv((GLuint)index, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), pValue); }
    }

    public static void VertexAttribP4(int index, VertexAttribType type, bool normalized, uint[] value) {
        unsafe { fixed (GLuint* pValue = value) gl.Functions.glVertexAttribP4uiv((GLuint)index, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), pValue); }
    }

    public static void VertexAttribBinding(int attribIndex, int bindingIndex) {
        unsafe { gl.Functions.glVertexAttribBinding((GLuint)attribIndex, (GLuint)bindingIndex); }
    }

    public static void VertexAttribDivisor(int index, int divisor) {
        unsafe { gl.Functions.glVertexAttribDivisor((GLuint)index, (GLuint)divisor); }
    }

    public static void VertexAttribFormat(int attribIndex, int size, VertexAttribType type, bool normalized, int relOffset) {
        unsafe { gl.Functions.glVertexAttribFormat((GLuint)attribIndex, size, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), (GLuint)relOffset); }
    }

    public static void VertexAttribIFormat(int attribIndex, int size, VertexAttribType type, int relOffset) {
        unsafe { gl.Functions.glVertexAttribIFormat((GLuint)attribIndex, size, type, (GLuint)relOffset); }
    }

    public static void VertexAttribLFormat(int attribIndex, int size, VertexAttribType type, int relOffset) {
        unsafe { gl.Functions.glVertexAttribLFormat((GLuint)attribIndex, size, type, (GLuint)relOffset); }
    }

    public static void VertexAttribPointer(int index, int size, VertexAttribType type, bool normalized, int stride, int offset) {
        unsafe { gl.Functions.glVertexAttribPointer((GLuint)index, size, type, (GLboolean)(normalized ? gl.Constants.GL_TRUE : gl.Constants.GL_FALSE), stride, (void*)offset); }
    }

    public static void VertexAttribIPointer(int index, int size, VertexAttribType type, int stride, int offset) {
        unsafe { gl.Functions.glVertexAttribIPointer((GLuint)index, size, type, stride, (void*)offset); }
    }

    public static void VertexAttribLPointer(int index, int size, VertexAttribType type, int stride, int offset) {
        unsafe { gl.Functions.glVertexAttribLPointer((GLuint)index, size, type, stride, (void*)offset); }
    }

    public static void VertexBindingDivisor(int index, int divisor) {
        unsafe { gl.Functions.glVertexBindingDivisor((GLuint)index, (GLuint)divisor); }
    }
}