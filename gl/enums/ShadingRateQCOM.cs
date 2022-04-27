#if GL_QCOM_SHADING_RATE

public enum ShadingRateQCOM : GLenum { 
#if GL_QCOM_SHADING_RATE
    Rate1x1PixelsQcom = gl.Constants.GL_SHADING_RATE_1X1_PIXELS_QCOM, 
#endif

#if GL_QCOM_SHADING_RATE
    Rate1x2PixelsQcom = gl.Constants.GL_SHADING_RATE_1X2_PIXELS_QCOM, 
#endif

#if GL_QCOM_SHADING_RATE
    Rate2x1PixelsQcom = gl.Constants.GL_SHADING_RATE_2X1_PIXELS_QCOM, 
#endif

#if GL_QCOM_SHADING_RATE
    Rate2x2PixelsQcom = gl.Constants.GL_SHADING_RATE_2X2_PIXELS_QCOM, 
#endif

#if GL_QCOM_SHADING_RATE
    Rate4x2PixelsQcom = gl.Constants.GL_SHADING_RATE_4X2_PIXELS_QCOM, 
#endif

#if GL_QCOM_SHADING_RATE
    Rate4x4PixelsQcom = gl.Constants.GL_SHADING_RATE_4X4_PIXELS_QCOM, 
#endif

}

#endif
