#if (GL_NV_path_rendering && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_CLOSE_PATH_NV = 0x00;
        public const GLenum GL_BOLD_BIT_NV = 0x01;
        public const GLenum GL_GLYPH_WIDTH_BIT_NV = 0x01;
        public const GLenum GL_GLYPH_HEIGHT_BIT_NV = 0x02;
        public const GLenum GL_ITALIC_BIT_NV = 0x02;
        public const GLenum GL_MOVE_TO_NV = 0x02;
        public const GLenum GL_RELATIVE_MOVE_TO_NV = 0x03;
        public const GLenum GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04;
        public const GLenum GL_LINE_TO_NV = 0x04;
        public const GLenum GL_RELATIVE_LINE_TO_NV = 0x05;
        public const GLenum GL_HORIZONTAL_LINE_TO_NV = 0x06;
        public const GLenum GL_RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07;
        public const GLenum GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08;
        public const GLenum GL_VERTICAL_LINE_TO_NV = 0x08;
        public const GLenum GL_RELATIVE_VERTICAL_LINE_TO_NV = 0x09;
        public const GLenum GL_QUADRATIC_CURVE_TO_NV = 0x0A;
        public const GLenum GL_RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B;
        public const GLenum GL_CUBIC_CURVE_TO_NV = 0x0C;
        public const GLenum GL_RELATIVE_CUBIC_CURVE_TO_NV = 0x0D;
        public const GLenum GL_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E;
        public const GLenum GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F;
        public const GLenum GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10;
        public const GLenum GL_SMOOTH_CUBIC_CURVE_TO_NV = 0x10;
        public const GLenum GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11;
        public const GLenum GL_SMALL_CCW_ARC_TO_NV = 0x12;
        public const GLenum GL_RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13;
        public const GLenum GL_SMALL_CW_ARC_TO_NV = 0x14;
        public const GLenum GL_RELATIVE_SMALL_CW_ARC_TO_NV = 0x15;
        public const GLenum GL_LARGE_CCW_ARC_TO_NV = 0x16;
        public const GLenum GL_RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17;
        public const GLenum GL_LARGE_CW_ARC_TO_NV = 0x18;
        public const GLenum GL_RELATIVE_LARGE_CW_ARC_TO_NV = 0x19;
        public const GLenum GL_CONIC_CURVE_TO_NV = 0x1A;
        public const GLenum GL_RELATIVE_CONIC_CURVE_TO_NV = 0x1B;
        public const GLenum GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20;
        public const GLenum GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40;
        public const GLenum GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80;
        public const GLenum GL_ROUNDED_RECT_NV = 0xE8;
        public const GLenum GL_RELATIVE_ROUNDED_RECT_NV = 0xE9;
        public const GLenum GL_ROUNDED_RECT2_NV = 0xEA;
        public const GLenum GL_RELATIVE_ROUNDED_RECT2_NV = 0xEB;
        public const GLenum GL_ROUNDED_RECT4_NV = 0xEC;
        public const GLenum GL_RELATIVE_ROUNDED_RECT4_NV = 0xED;
        public const GLenum GL_ROUNDED_RECT8_NV = 0xEE;
        public const GLenum GL_RELATIVE_ROUNDED_RECT8_NV = 0xEF;
        public const GLenum GL_RESTART_PATH_NV = 0xF0;
        public const GLenum GL_DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2;
        public const GLenum GL_DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4;
        public const GLenum GL_RECT_NV = 0xF6;
        public const GLenum GL_RELATIVE_RECT_NV = 0xF7;
        public const GLenum GL_CIRCULAR_CCW_ARC_TO_NV = 0xF8;
        public const GLenum GL_CIRCULAR_CW_ARC_TO_NV = 0xFA;
        public const GLenum GL_CIRCULAR_TANGENT_ARC_TO_NV = 0xFC;
        public const GLenum GL_ARC_TO_NV = 0xFE;
        public const GLenum GL_RELATIVE_ARC_TO_NV = 0xFF;
        public const GLenum GL_GLYPH_HAS_KERNING_BIT_NV = 0x100;
        public const GLenum GL_PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3;
        public const GLenum GL_PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4;
        public const GLenum GL_PATH_MODELVIEW_MATRIX_NV = 0x0BA6;
        public const GLenum GL_PATH_PROJECTION_MATRIX_NV = 0x0BA7;
        public const GLenum GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36;
        public const GLenum GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38;
        public const GLenum GL_2_BYTES_NV = 0x1407;
        public const GLenum GL_3_BYTES_NV = 0x1408;
        public const GLenum GL_4_BYTES_NV = 0x1409;
        public const GLenum GL_PATH_MODELVIEW_NV = 0x1700;
        public const GLenum GL_PATH_PROJECTION_NV = 0x1701;
        public const GLenum GL_EYE_LINEAR_NV = 0x2400;
        public const GLenum GL_OBJECT_LINEAR_NV = 0x2401;
        public const GLenum GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3;
        public const GLenum GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4;
        public const GLenum GL_PRIMARY_COLOR_NV = 0x852C;
        public const GLenum GL_SECONDARY_COLOR_NV = 0x852D;
        public const GLenum GL_CONSTANT_NV = 0x8576;
        public const GLenum GL_PRIMARY_COLOR = 0x8577;
        public const GLenum GL_PATH_FORMAT_SVG_NV = 0x9070;
        public const GLenum GL_PATH_FORMAT_PS_NV = 0x9071;
        public const GLenum GL_STANDARD_FONT_NAME_NV = 0x9072;
        public const GLenum GL_SYSTEM_FONT_NAME_NV = 0x9073;
        public const GLenum GL_FILE_NAME_NV = 0x9074;
        public const GLenum GL_PATH_STROKE_WIDTH_NV = 0x9075;
        public const GLenum GL_PATH_END_CAPS_NV = 0x9076;
        public const GLenum GL_PATH_INITIAL_END_CAP_NV = 0x9077;
        public const GLenum GL_PATH_TERMINAL_END_CAP_NV = 0x9078;
        public const GLenum GL_PATH_JOIN_STYLE_NV = 0x9079;
        public const GLenum GL_PATH_MITER_LIMIT_NV = 0x907A;
        public const GLenum GL_PATH_DASH_CAPS_NV = 0x907B;
        public const GLenum GL_PATH_INITIAL_DASH_CAP_NV = 0x907C;
        public const GLenum GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D;
        public const GLenum GL_PATH_DASH_OFFSET_NV = 0x907E;
        public const GLenum GL_PATH_CLIENT_LENGTH_NV = 0x907F;
        public const GLenum GL_PATH_FILL_MODE_NV = 0x9080;
        public const GLenum GL_PATH_FILL_MASK_NV = 0x9081;
        public const GLenum GL_PATH_FILL_COVER_MODE_NV = 0x9082;
        public const GLenum GL_PATH_STROKE_COVER_MODE_NV = 0x9083;
        public const GLenum GL_PATH_STROKE_MASK_NV = 0x9084;
        public const GLenum GL_COUNT_UP_NV = 0x9088;
        public const GLenum GL_COUNT_DOWN_NV = 0x9089;
        public const GLenum GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A;
        public const GLenum GL_CONVEX_HULL_NV = 0x908B;
        public const GLenum GL_BOUNDING_BOX_NV = 0x908D;
        public const GLenum GL_TRANSLATE_X_NV = 0x908E;
        public const GLenum GL_TRANSLATE_Y_NV = 0x908F;
        public const GLenum GL_TRANSLATE_2D_NV = 0x9090;
        public const GLenum GL_TRANSLATE_3D_NV = 0x9091;
        public const GLenum GL_AFFINE_2D_NV = 0x9092;
        public const GLenum GL_AFFINE_3D_NV = 0x9094;
        public const GLenum GL_TRANSPOSE_AFFINE_2D_NV = 0x9096;
        public const GLenum GL_TRANSPOSE_AFFINE_3D_NV = 0x9098;
        public const GLenum GL_UTF8_NV = 0x909A;
        public const GLenum GL_UTF16_NV = 0x909B;
        public const GLenum GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C;
        public const GLenum GL_PATH_COMMAND_COUNT_NV = 0x909D;
        public const GLenum GL_PATH_COORD_COUNT_NV = 0x909E;
        public const GLenum GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F;
        public const GLenum GL_PATH_COMPUTED_LENGTH_NV = 0x90A0;
        public const GLenum GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1;
        public const GLenum GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2;
        public const GLenum GL_SQUARE_NV = 0x90A3;
        public const GLenum GL_ROUND_NV = 0x90A4;
        public const GLenum GL_TRIANGULAR_NV = 0x90A5;
        public const GLenum GL_BEVEL_NV = 0x90A6;
        public const GLenum GL_MITER_REVERT_NV = 0x90A7;
        public const GLenum GL_MITER_TRUNCATE_NV = 0x90A8;
        public const GLenum GL_SKIP_MISSING_GLYPH_NV = 0x90A9;
        public const GLenum GL_USE_MISSING_GLYPH_NV = 0x90AA;
        public const GLenum GL_PATH_ERROR_POSITION_NV = 0x90AB;
        public const GLenum GL_PATH_FOG_GEN_MODE_NV = 0x90AC;
        public const GLenum GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD;
        public const GLenum GL_ADJACENT_PAIRS_NV = 0x90AE;
        public const GLenum GL_FIRST_TO_REST_NV = 0x90AF;
        public const GLenum GL_PATH_GEN_MODE_NV = 0x90B0;
        public const GLenum GL_PATH_GEN_COEFF_NV = 0x90B1;
        public const GLenum GL_PATH_GEN_COLOR_FORMAT_NV = 0x90B2;
        public const GLenum GL_PATH_GEN_COMPONENTS_NV = 0x90B3;
        public const GLenum GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4;
        public const GLenum GL_MOVE_TO_RESETS_NV = 0x90B5;
        public const GLenum GL_MOVE_TO_CONTINUES_NV = 0x90B6;
        public const GLenum GL_PATH_STENCIL_FUNC_NV = 0x90B7;
        public const GLenum GL_PATH_STENCIL_REF_NV = 0x90B8;
        public const GLenum GL_PATH_STENCIL_VALUE_MASK_NV = 0x90B9;
        public const GLenum GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;
        public const GLenum GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;
        public const GLenum GL_PATH_COVER_DEPTH_FUNC_NV = 0x90BF;
        public const GLenum GL_FONT_GLYPHS_AVAILABLE_NV = 0x9368;
        public const GLenum GL_FONT_TARGET_UNAVAILABLE_NV = 0x9369;
        public const GLenum GL_FONT_UNAVAILABLE_NV = 0x936A;
        public const GLenum GL_FONT_UNINTELLIGIBLE_NV = 0x936B;
        public const GLenum GL_STANDARD_FONT_FORMAT_NV = 0x936C;
        public const GLenum GL_FRAGMENT_INPUT_NV = 0x936D;
        public const GLenum GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000;
        public const GLenum GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000;
        public const GLenum GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000;
        public const GLenum GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000;
        public const GLenum GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000;
        public const GLenum GL_FONT_ASCENDER_BIT_NV = 0x00200000;
        public const GLenum GL_FONT_DESCENDER_BIT_NV = 0x00400000;
        public const GLenum GL_FONT_HEIGHT_BIT_NV = 0x00800000;
        public const GLenum GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000;
        public const GLenum GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000;
        public const GLenum GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000;
        public const GLenum GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000;
        public const GLenum GL_FONT_HAS_KERNING_BIT_NV = 0x10000000;
        public const GLenum GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000;
    }
}
#endif