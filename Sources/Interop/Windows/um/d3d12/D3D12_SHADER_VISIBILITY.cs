// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_SHADER_VISIBILITY
    {
        D3D12_SHADER_VISIBILITY_ALL = 0,

        D3D12_SHADER_VISIBILITY_VERTEX = 1,

        D3D12_SHADER_VISIBILITY_HULL = 2,

        D3D12_SHADER_VISIBILITY_DOMAIN = 3,

        D3D12_SHADER_VISIBILITY_GEOMETRY = 4,

        D3D12_SHADER_VISIBILITY_PIXEL = 5
    }
}