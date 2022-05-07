#if (GL_NV_vertex_program && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_PROGRAM_NV = 0x8620;
        public const GLenum GL_VERTEX_STATE_PROGRAM_NV = 0x8621;
        public const GLenum GL_ATTRIB_ARRAY_SIZE_NV = 0x8623;
        public const GLenum GL_ATTRIB_ARRAY_STRIDE_NV = 0x8624;
        public const GLenum GL_ATTRIB_ARRAY_TYPE_NV = 0x8625;
        public const GLenum GL_CURRENT_ATTRIB_NV = 0x8626;
        public const GLenum GL_PROGRAM_LENGTH_NV = 0x8627;
        public const GLenum GL_PROGRAM_STRING_NV = 0x8628;
        public const GLenum GL_MODELVIEW_PROJECTION_NV = 0x8629;
        public const GLenum GL_IDENTITY_NV = 0x862A;
        public const GLenum GL_INVERSE_NV = 0x862B;
        public const GLenum GL_TRANSPOSE_NV = 0x862C;
        public const GLenum GL_INVERSE_TRANSPOSE_NV = 0x862D;
        public const GLenum GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;
        public const GLenum GL_MAX_TRACK_MATRICES_NV = 0x862F;
        public const GLenum GL_MATRIX0_NV = 0x8630;
        public const GLenum GL_MATRIX1_NV = 0x8631;
        public const GLenum GL_MATRIX2_NV = 0x8632;
        public const GLenum GL_MATRIX3_NV = 0x8633;
        public const GLenum GL_MATRIX4_NV = 0x8634;
        public const GLenum GL_MATRIX5_NV = 0x8635;
        public const GLenum GL_MATRIX6_NV = 0x8636;
        public const GLenum GL_MATRIX7_NV = 0x8637;
        public const GLenum GL_CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640;
        public const GLenum GL_CURRENT_MATRIX_NV = 0x8641;
        public const GLenum GL_VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642;
        public const GLenum GL_VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643;
        public const GLenum GL_PROGRAM_PARAMETER_NV = 0x8644;
        public const GLenum GL_ATTRIB_ARRAY_POINTER_NV = 0x8645;
        public const GLenum GL_PROGRAM_TARGET_NV = 0x8646;
        public const GLenum GL_PROGRAM_RESIDENT_NV = 0x8647;
        public const GLenum GL_TRACK_MATRIX_NV = 0x8648;
        public const GLenum GL_TRACK_MATRIX_TRANSFORM_NV = 0x8649;
        public const GLenum GL_VERTEX_PROGRAM_BINDING_NV = 0x864A;
        public const GLenum GL_PROGRAM_ERROR_POSITION_NV = 0x864B;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY0_NV = 0x8650;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY1_NV = 0x8651;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY2_NV = 0x8652;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY3_NV = 0x8653;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY4_NV = 0x8654;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY5_NV = 0x8655;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY6_NV = 0x8656;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY7_NV = 0x8657;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY8_NV = 0x8658;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY9_NV = 0x8659;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY10_NV = 0x865A;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY11_NV = 0x865B;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY12_NV = 0x865C;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY13_NV = 0x865D;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY14_NV = 0x865E;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY15_NV = 0x865F;
        public const GLenum GL_MAP1_VERTEX_ATTRIB0_4_NV = 0x8660;
        public const GLenum GL_MAP1_VERTEX_ATTRIB1_4_NV = 0x8661;
        public const GLenum GL_MAP1_VERTEX_ATTRIB2_4_NV = 0x8662;
        public const GLenum GL_MAP1_VERTEX_ATTRIB3_4_NV = 0x8663;
        public const GLenum GL_MAP1_VERTEX_ATTRIB4_4_NV = 0x8664;
        public const GLenum GL_MAP1_VERTEX_ATTRIB5_4_NV = 0x8665;
        public const GLenum GL_MAP1_VERTEX_ATTRIB6_4_NV = 0x8666;
        public const GLenum GL_MAP1_VERTEX_ATTRIB7_4_NV = 0x8667;
        public const GLenum GL_MAP1_VERTEX_ATTRIB8_4_NV = 0x8668;
        public const GLenum GL_MAP1_VERTEX_ATTRIB9_4_NV = 0x8669;
        public const GLenum GL_MAP1_VERTEX_ATTRIB10_4_NV = 0x866A;
        public const GLenum GL_MAP1_VERTEX_ATTRIB11_4_NV = 0x866B;
        public const GLenum GL_MAP1_VERTEX_ATTRIB12_4_NV = 0x866C;
        public const GLenum GL_MAP1_VERTEX_ATTRIB13_4_NV = 0x866D;
        public const GLenum GL_MAP1_VERTEX_ATTRIB14_4_NV = 0x866E;
        public const GLenum GL_MAP1_VERTEX_ATTRIB15_4_NV = 0x866F;
        public const GLenum GL_MAP2_VERTEX_ATTRIB0_4_NV = 0x8670;
        public const GLenum GL_MAP2_VERTEX_ATTRIB1_4_NV = 0x8671;
        public const GLenum GL_MAP2_VERTEX_ATTRIB2_4_NV = 0x8672;
        public const GLenum GL_MAP2_VERTEX_ATTRIB3_4_NV = 0x8673;
        public const GLenum GL_MAP2_VERTEX_ATTRIB4_4_NV = 0x8674;
        public const GLenum GL_MAP2_VERTEX_ATTRIB5_4_NV = 0x8675;
        public const GLenum GL_MAP2_VERTEX_ATTRIB6_4_NV = 0x8676;
        public const GLenum GL_MAP2_VERTEX_ATTRIB7_4_NV = 0x8677;
        public const GLenum GL_MAP2_VERTEX_ATTRIB8_4_NV = 0x8678;
        public const GLenum GL_MAP2_VERTEX_ATTRIB9_4_NV = 0x8679;
        public const GLenum GL_MAP2_VERTEX_ATTRIB10_4_NV = 0x867A;
        public const GLenum GL_MAP2_VERTEX_ATTRIB11_4_NV = 0x867B;
        public const GLenum GL_MAP2_VERTEX_ATTRIB12_4_NV = 0x867C;
        public const GLenum GL_MAP2_VERTEX_ATTRIB13_4_NV = 0x867D;
        public const GLenum GL_MAP2_VERTEX_ATTRIB14_4_NV = 0x867E;
        public const GLenum GL_MAP2_VERTEX_ATTRIB15_4_NV = 0x867F;
    }
}
#endif