// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

#version 450 core

layout(location = 0) in vec3 input_position;
layout(location = 1) in vec2 input_uv;

out gl_PerVertex
{
    vec4 gl_Position;
};

layout(location = 0) out vec2 output_uv;

void main()
{
    gl_Position = vec4(input_position, 1.0);
    output_uv = input_uv;
}
