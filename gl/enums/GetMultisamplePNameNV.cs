#if ( && !(GL_VERSION_1_0 || GL_VERSION_1_1 || GL_VERSION_1_2 || GL_VERSION_1_3 || GL_VERSION_1_4 || GL_VERSION_1_5 || GL_VERSION_2_0 || GL_VERSION_2_1 || GL_VERSION_3_0 || GL_VERSION_3_1 || GL_VERSION_3_2 || GL_VERSION_3_3 || GL_VERSION_4_0 || GL_VERSION_4_1 || GL_VERSION_4_2 || GL_VERSION_4_3 || GL_VERSION_4_4 || GL_VERSION_4_5 || GL_VERSION_4_6 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_2_0 || GL_ES_VERSION_3_0 || GL_ES_VERSION_3_1 || GL_ES_VERSION_3_2 || GL_SC_VERSION_2_0 || GL_AMD_debug_output || GL_AMD_draw_buffers_blend || GL_AMD_framebuffer_multisample_advanced || GL_AMD_framebuffer_sample_positions || GL_AMD_multi_draw_indirect || GL_AMD_name_gen_delete || GL_AMD_occlusion_query_event || GL_AMD_performance_monitor || GL_AMD_sparse_texture || GL_AMD_stencil_operation_extended || GL_ANGLE_framebuffer_blit || GL_ANGLE_framebuffer_multisample || GL_ANGLE_instanced_arrays || GL_APPLE_element_array || GL_APPLE_fence || GL_APPLE_flush_buffer_range || GL_APPLE_framebuffer_multisample || GL_APPLE_sync || GL_APPLE_vertex_array_object || GL_APPLE_vertex_array_range || GL_APPLE_vertex_program_evaluators || GL_ARB_ES2_compatibility || GL_ARB_ES3_1_compatibility || GL_ARB_base_instance || GL_ARB_bindless_texture || GL_ARB_buffer_storage || GL_ARB_clear_buffer_object || GL_ARB_clear_texture || GL_ARB_clip_control || GL_ARB_color_buffer_float || GL_ARB_copy_buffer || GL_ARB_copy_image || GL_ARB_debug_output || GL_ARB_direct_state_access || GL_ARB_draw_buffers || GL_ARB_draw_buffers_blend || GL_ARB_draw_elements_base_vertex || GL_ARB_draw_indirect || GL_ARB_draw_instanced || GL_ARB_fragment_program || GL_ARB_framebuffer_no_attachments || GL_ARB_framebuffer_object || GL_ARB_geometry_shader4 || GL_ARB_get_program_binary || GL_ARB_get_texture_sub_image || GL_ARB_gpu_shader_fp64 || GL_ARB_imaging || GL_ARB_indirect_parameters || GL_ARB_internalformat_query || GL_ARB_internalformat_query2 || GL_ARB_invalidate_subdata || GL_ARB_map_buffer_range || GL_ARB_matrix_palette || GL_ARB_multi_bind || GL_ARB_multi_draw_indirect || GL_ARB_multisample || GL_ARB_multitexture || GL_ARB_occlusion_query || GL_ARB_point_parameters || GL_ARB_program_interface_query || GL_ARB_provoking_vertex || GL_ARB_robustness || GL_ARB_sample_locations || GL_ARB_sampler_objects || GL_ARB_separate_shader_objects || GL_ARB_shader_atomic_counters || GL_ARB_shader_image_load_store || GL_ARB_shader_objects || GL_ARB_shader_subroutine || GL_ARB_shading_language_include || GL_ARB_sparse_buffer || GL_ARB_sparse_texture || GL_ARB_sync || GL_ARB_tessellation_shader || GL_ARB_texture_buffer_object || GL_ARB_texture_buffer_range || GL_ARB_texture_compression || GL_ARB_texture_multisample || GL_ARB_texture_storage || GL_ARB_texture_storage_multisample || GL_ARB_texture_view || GL_ARB_timer_query || GL_ARB_transform_feedback2 || GL_ARB_transform_feedback3 || GL_ARB_transform_feedback_instanced || GL_ARB_uniform_buffer_object || GL_ARB_vertex_array_object || GL_ARB_vertex_attrib_64bit || GL_ARB_vertex_attrib_binding || GL_ARB_vertex_blend || GL_ARB_vertex_buffer_object || GL_ARB_vertex_program || GL_ARB_vertex_shader || GL_ARB_vertex_type_2_10_10_10_rev || GL_ARB_viewport_array || GL_ATI_draw_buffers || GL_ATI_element_array || GL_ATI_envmap_bumpmap || GL_ATI_fragment_shader || GL_ATI_pn_triangles || GL_ATI_separate_stencil || GL_ATI_vertex_array_object || GL_ATI_vertex_attrib_array_object || GL_ATI_vertex_streams || GL_EXT_base_instance || GL_EXT_blend_equation_separate || GL_EXT_blend_func_extended || GL_EXT_blend_func_separate || GL_EXT_blend_minmax || GL_EXT_buffer_storage || GL_EXT_clear_texture || GL_EXT_color_subtable || GL_EXT_convolution || GL_EXT_coordinate_frame || GL_EXT_copy_image || GL_EXT_copy_texture || GL_EXT_cull_vertex || GL_EXT_direct_state_access || GL_EXT_discard_framebuffer || GL_EXT_disjoint_timer_query || GL_EXT_draw_buffers2 || GL_EXT_draw_buffers_indexed || GL_EXT_draw_elements_base_vertex || GL_EXT_draw_instanced || GL_EXT_draw_range_elements || GL_EXT_draw_transform_feedback || GL_EXT_external_buffer || GL_EXT_fog_coord || GL_EXT_framebuffer_blit || GL_EXT_framebuffer_multisample || GL_EXT_framebuffer_object || GL_EXT_geometry_shader || GL_EXT_geometry_shader4 || GL_EXT_gpu_program_parameters || GL_EXT_gpu_shader4 || GL_EXT_histogram || GL_EXT_index_func || GL_EXT_index_material || GL_EXT_instanced_arrays || GL_EXT_light_texture || GL_EXT_map_buffer_range || GL_EXT_memory_object || GL_EXT_memory_object_fd || GL_EXT_memory_object_win32 || GL_EXT_multi_draw_arrays || GL_EXT_multi_draw_indirect || GL_EXT_multisample || GL_EXT_multisampled_render_to_texture || GL_EXT_multiview_draw_buffers || GL_EXT_occlusion_query_boolean || GL_EXT_paletted_texture || GL_EXT_pixel_transform || GL_EXT_point_parameters || GL_EXT_provoking_vertex || GL_EXT_raster_multisample || GL_EXT_robustness || GL_EXT_semaphore || GL_EXT_semaphore_fd || GL_EXT_semaphore_win32 || GL_EXT_secondary_color || GL_EXT_separate_shader_objects || GL_EXT_shader_image_load_store || GL_EXT_shader_pixel_local_storage2 || GL_EXT_sparse_texture || GL_EXT_stencil_two_side || GL_EXT_subtexture || GL_EXT_tessellation_shader || GL_EXT_texture3D || GL_EXT_texture_array || GL_EXT_texture_border_clamp || GL_EXT_texture_buffer || GL_EXT_texture_buffer_object || GL_EXT_texture_integer || GL_EXT_texture_object || GL_EXT_texture_perturb_normal || GL_EXT_texture_storage || GL_EXT_texture_storage_compression || GL_EXT_texture_view || GL_NV_timeline_semaphore || GL_EXT_timer_query || GL_EXT_transform_feedback || GL_EXT_vertex_array || GL_EXT_vertex_attrib_64bit || GL_EXT_vertex_shader || GL_EXT_vertex_weighting || GL_EXT_win32_keyed_mutex || GL_HP_image_transform || GL_IBM_multimode_draw_arrays || GL_IBM_vertex_array_lists || GL_IMG_framebuffer_downsample || GL_IMG_multisampled_render_to_texture || GL_IMG_user_clip_plane || GL_INGR_blend_func_separate || GL_INTEL_parallel_arrays || GL_KHR_debug || GL_KHR_robustness || GL_MESA_framebuffer_flip_y || GL_NV_bindless_multi_draw_indirect || GL_NV_bindless_multi_draw_indirect_count || GL_NV_bindless_texture || GL_NV_command_list || GL_NV_conditional_render || GL_NV_copy_buffer || GL_NV_copy_image || GL_NV_coverage_sample || GL_NV_draw_instanced || GL_NV_evaluators || GL_NV_explicit_multisample || GL_NV_fence || GL_NV_framebuffer_blit || GL_NV_framebuffer_mixed_samples || GL_NV_framebuffer_multisample || GL_NV_framebuffer_multisample_coverage || GL_NV_geometry_program4 || GL_NV_gpu_program4 || GL_NV_half_float || GL_NV_internalformat_sample_query || GL_NV_gpu_multicast || GL_NV_memory_attachment || GL_NV_memory_object_sparse || GL_NV_non_square_matrices || GL_NV_occlusion_query || GL_NV_parameter_buffer_object || GL_NV_path_rendering || GL_NV_pixel_data_range || GL_NV_point_sprite || GL_NV_polygon_mode || GL_NV_register_combiners || GL_NV_register_combiners2 || GL_NV_sample_locations || GL_NV_shader_buffer_load || GL_NV_shading_rate_image || GL_NV_texture_multisample || GL_NV_transform_feedback || GL_NV_transform_feedback2 || GL_NV_vdpau_interop || GL_NV_vdpau_interop2 || GL_NV_vertex_attrib_integer_64bit || GL_NV_vertex_buffer_unified_memory || GL_NV_vertex_program || GL_NV_vertex_program4 || GL_NV_viewport_array || GL_OES_blend_equation_separate || GL_OES_blend_func_separate || GL_OES_blend_subtract || GL_OES_byte_coordinates || GL_OES_copy_image || GL_OES_draw_buffers_indexed || GL_OES_draw_elements_base_vertex || GL_OES_fixed_point || GL_OES_framebuffer_object || GL_OES_geometry_shader || GL_OES_mapbuffer || GL_OES_matrix_palette || GL_OES_single_precision || GL_OES_tessellation_shader || GL_OES_texture_3D || GL_OES_texture_border_clamp || GL_OES_texture_buffer || GL_OES_texture_cube_map || GL_OES_texture_storage_multisample_2d_array || GL_OES_texture_view || GL_OES_vertex_array_object || GL_OES_viewport_array || GL_OVR_multiview || GL_OVR_multiview_multisampled_render_to_texture || GL_PGI_misc_hints || GL_QCOM_extended_get || GL_QCOM_extended_get2 || GL_QCOM_shading_rate || GL_QCOM_tiled_rendering || GL_SGIS_detail_texture || GL_SGIS_multisample || GL_SGIS_pixel_texture || GL_SGIS_point_parameters || GL_SGIS_sharpen_texture || GL_SGIS_texture4D || GL_SGIS_texture_color_mask || GL_SGIS_texture_filter4 || GL_SGIX_async || GL_SGIX_fragment_lighting || GL_SGIX_list_priority || GL_SGIX_pixel_texture || GL_SGIX_polynomial_ffd || GL_SGIX_sprite || GL_SGI_color_table || GL_SUN_mesh_array || GL_SUN_triangle_list))

public enum GetMultisamplePNameNV : GLenum {
    SamplePosition = .Constants.GL_SAMPLE_POSITION,
    SampleLocationArb = .Constants.GL_SAMPLE_LOCATION_ARB,
    ProgrammableSampleLocationArb = .Constants.GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB,
}

#endif
