// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ unsafe struct VkSubpassDescription
    {
        #region Fields
        [ComAliasName("VkSubpassDescriptionFlags")]
        public uint flags;

        public VkPipelineBindPoint pipelineBindPoint;

        public uint inputAttachmentCount;

        [ComAliasName("VkAttachmentReference[]")]
        public VkAttachmentReference* pInputAttachments;

        public uint colorAttachmentCount;

        [ComAliasName("VkAttachmentReference[]")]
        public VkAttachmentReference* pColorAttachments;

        [ComAliasName("VkAttachmentReference[]")]
        public VkAttachmentReference* pResolveAttachments;

        public VkAttachmentReference* pDepthStencilAttachment;

        public uint preserveAttachmentCount;

        [ComAliasName("uint[]")]
        public uint* pPreserveAttachments;
        #endregion
    }
}
