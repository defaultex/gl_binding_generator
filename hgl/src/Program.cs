
class Program {
    static void Main(string[] args) {
        Test_ArrayToPointerCopy(10000);
    }

    static void Test_ArrayToPointerCopy(int iterations) {
#pragma warning disable CA2014 // warning to not use stackalloc inside a loop, we will be doing so anyway
        RunBenchmark<Action>(Technique_BufferMemoryCopy, iterations);
        RunBenchmark<Action>(Technique_ArrayCopy, iterations);
        RunBenchmark<Action>(Technique_MarshalCopy, iterations);
#pragma warning disable CA2014
    }

    static void Technique_BufferMemoryCopy() {
        int count = SampleSet.Length;
        unsafe {
            GLchar** ppArray = stackalloc GLchar*[count];
            for (int i = 0; i < count; i++) {
                string current = SampleSet[i];
                int length = current.Length;

                GLchar* pStr = stackalloc GLchar[length];
                byte[] bStr = Encoding.UTF8.GetBytes(current);
                fixed (GLchar* vStr = bStr) {
                    System.Buffer.MemoryCopy(vStr, pStr, bStr.Length, bStr.Length);
                }
            }
        }
    }

    static void Technique_ArrayCopy() {
        int count = SampleSet.Length;
        unsafe {
            GLchar** ppArray = stackalloc GLchar*[count];
            for (int i = 0; i < count; i++) {
                string current = SampleSet[i];
                int length = current.Length;

                GLchar* pStr = stackalloc GLchar[length];
                byte[] bStr = Encoding.UTF8.GetBytes(current);
                for (int j = 0; j < bStr.Length; j++) {
                    pStr[j] = bStr[j];
                }
            }
        }
    }

    static void Technique_MarshalCopy() {
        int count = SampleSet.Length;
        unsafe {
            GLchar** ppArray = stackalloc GLchar*[count];
            for (int i = 0; i < count; i++) {
                string current = SampleSet[i];
                int length = current.Length;

                GLchar* pStr = stackalloc GLchar[length];
                byte[] bStr = Encoding.UTF8.GetBytes(current);
                Marshal.Copy(bStr, 0, (IntPtr)pStr, bStr.Length);
            }
        }
    }

    static void RunBenchmark<T>(T function, int iterations) where T : Delegate {
        Action func = function as Action; // pre-cast since it cost about 3um to cast this

        Stopwatch sw = Stopwatch.StartNew();
        for (int i = 0; i < iterations; i++) {
            func();
        }
        sw.Stop();

        Console.WriteLine($"Test completed in {sw.ElapsedMilliseconds}ms for {iterations} number of iterations for {function.Method.Name}.");
        Console.WriteLine($"Average of {sw.ElapsedMilliseconds / (double)iterations}ms per iteration.");
    }

    // just random data to test
    static readonly string[] SampleSet = new[] {
        "Boolean",
        "handleARB",
        "String",
        "vdpauSurfaceNV",
        "Half16NV",
        "WinCoord",
        "CoordF",
        "ClampedFixed",
        "BufferOffset",
        "BufferSize",
        "BufferOffsetARB",
        "CoordD",
        "ColorF",
        "BufferSizeARB",
        "List",
        "DrawBufferName",
        "ClampedFloat32",
        "MaskedColorIndexValueF",
        "StencilValue",
        "ColorB",
        "ColorD",
        "ColorI",
        "ColorS",
        "ColorUB",
        "ColorUI",
        "ColorUS",
        "CheckedFloat32",
        "CheckedInt32",
        "CompressedTextureARB",
        "Path",
        "PathElement",
        "FenceNV",
        "ClampedFloat64",
        "BooleanPointer",
        "FeedbackElement",
        "PathCommand",
        "ProgramCharacterNV",
        "MaskedColorIndexValueI",
        "ColorIndexValueD",
        "ColorIndexValueF",
        "ColorIndexValueI",
        "ColorIndexValueS",
        "ColorIndexValueUB",
        "MaskedStencilValue",
        "LineStipple",
        "SelectName",
        "CoordI",
        "CoordS",
        "ClampedStencilValue",
        "ReplacementCodeSUN",
        "SampleMaskNV",
    };
}
