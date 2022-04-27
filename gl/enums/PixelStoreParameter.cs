#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_0 || GL_VERSION_1_2 || GL_EXT_TEXTURE3D || GL_EXT_UNPACK_SUBIMAGE || GL_OML_RESAMPLE || GL_SGIS_TEXTURE4D || GL_SGIX_PIXEL_TILES || GL_SGIX_RESAMPLE || GL_SGIX_SUBSAMPLE)

public enum PixelStoreParameter : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    UnpackAlignment = gl.Constants.GL_UNPACK_ALIGNMENT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    PackAlignment = gl.Constants.GL_PACK_ALIGNMENT, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    UnpackRowLength = gl.Constants.GL_UNPACK_ROW_LENGTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    UnpackSkipRows = gl.Constants.GL_UNPACK_SKIP_ROWS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    UnpackSkipPixels = gl.Constants.GL_UNPACK_SKIP_PIXELS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    PackRowLength = gl.Constants.GL_PACK_ROW_LENGTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    PackSkipRows = gl.Constants.GL_PACK_SKIP_ROWS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    PackSkipPixels = gl.Constants.GL_PACK_SKIP_PIXELS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    UnpackSkipImages = gl.Constants.GL_UNPACK_SKIP_IMAGES, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    UnpackImageHeight = gl.Constants.GL_UNPACK_IMAGE_HEIGHT, 
#endif

#if GL_VERSION_1_0
    UnpackSwapBytes = gl.Constants.GL_UNPACK_SWAP_BYTES, 
#endif

#if GL_VERSION_1_0
    UnpackLsbFirst = gl.Constants.GL_UNPACK_LSB_FIRST, 
#endif

#if GL_VERSION_1_0
    PackSwapBytes = gl.Constants.GL_PACK_SWAP_BYTES, 
#endif

#if GL_VERSION_1_0
    PackLsbFirst = gl.Constants.GL_PACK_LSB_FIRST, 
#endif

#if GL_VERSION_1_2
    PackSkipImages = gl.Constants.GL_PACK_SKIP_IMAGES, 
#endif

#if GL_VERSION_1_2
    PackImageHeight = gl.Constants.GL_PACK_IMAGE_HEIGHT, 
#endif

#if GL_EXT_TEXTURE3D
    PackSkipImagesExt = gl.Constants.GL_PACK_SKIP_IMAGES_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    PackImageHeightExt = gl.Constants.GL_PACK_IMAGE_HEIGHT_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    UnpackSkipImagesExt = gl.Constants.GL_UNPACK_SKIP_IMAGES_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    UnpackImageHeightExt = gl.Constants.GL_UNPACK_IMAGE_HEIGHT_EXT, 
#endif

#if GL_EXT_UNPACK_SUBIMAGE
    UnpackRowLengthExt = gl.Constants.GL_UNPACK_ROW_LENGTH_EXT, 
#endif

#if GL_EXT_UNPACK_SUBIMAGE
    UnpackSkipRowsExt = gl.Constants.GL_UNPACK_SKIP_ROWS_EXT, 
#endif

#if GL_EXT_UNPACK_SUBIMAGE
    UnpackSkipPixelsExt = gl.Constants.GL_UNPACK_SKIP_PIXELS_EXT, 
#endif

#if GL_OML_RESAMPLE
    PackResampleOml = gl.Constants.GL_PACK_RESAMPLE_OML, 
#endif

#if GL_OML_RESAMPLE
    UnpackResampleOml = gl.Constants.GL_UNPACK_RESAMPLE_OML, 
#endif

#if GL_SGIS_TEXTURE4D
    PackSkipVolumesSgis = gl.Constants.GL_PACK_SKIP_VOLUMES_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    PackImageDepthSgis = gl.Constants.GL_PACK_IMAGE_DEPTH_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    UnpackSkipVolumesSgis = gl.Constants.GL_UNPACK_SKIP_VOLUMES_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    UnpackImageDepthSgis = gl.Constants.GL_UNPACK_IMAGE_DEPTH_SGIS, 
#endif

#if GL_SGIX_PIXEL_TILES
    TileWidthSgix = gl.Constants.GL_PIXEL_TILE_WIDTH_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    TileHeightSgix = gl.Constants.GL_PIXEL_TILE_HEIGHT_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    TileGridWidthSgix = gl.Constants.GL_PIXEL_TILE_GRID_WIDTH_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    TileGridHeightSgix = gl.Constants.GL_PIXEL_TILE_GRID_HEIGHT_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    TileGridDepthSgix = gl.Constants.GL_PIXEL_TILE_GRID_DEPTH_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    TileCacheSizeSgix = gl.Constants.GL_PIXEL_TILE_CACHE_SIZE_SGIX, 
#endif

#if GL_SGIX_RESAMPLE
    PackResampleSgix = gl.Constants.GL_PACK_RESAMPLE_SGIX, 
#endif

#if GL_SGIX_RESAMPLE
    UnpackResampleSgix = gl.Constants.GL_UNPACK_RESAMPLE_SGIX, 
#endif

#if GL_SGIX_SUBSAMPLE
    PackSubsampleRateSgix = gl.Constants.GL_PACK_SUBSAMPLE_RATE_SGIX, 
#endif

#if GL_SGIX_SUBSAMPLE
    UnpackSubsampleRateSgix = gl.Constants.GL_UNPACK_SUBSAMPLE_RATE_SGIX, 
#endif

}

#endif
