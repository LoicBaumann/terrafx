// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using TerraFX.Graphics;
using TerraFX.Interop;
using static TerraFX.Interop.Vulkan;

namespace TerraFX.Provider.Vulkan.Graphics
{
    /// <summary>Represents a graphics adapter.</summary>
    public sealed unsafe class GraphicsAdapter : IGraphicsAdapter
    {
        #region Fields
        /// <summary>The <see cref="GraphicsManager" /> for the instance.</summary>
        internal readonly GraphicsManager _graphicsManager;

        /// <summary>The Vulkan device for the instance.</summary>
        internal IntPtr _physicalDevice;

        /// <summary>The name of the device.</summary>
        internal string _deviceName;

        /// <summary>The PCI ID of the vendor.</summary>
        internal uint _vendorId;

        /// <summary>The PCI ID of the device.</summary>
        internal uint _deviceId;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="GraphicsAdapter" /> class.</summary>
        /// <param name="graphicsManager">The <see cref="GraphicsManager" /> for the instance.</param>
        /// <param name="physicalDevice">The Vulkan device for the instance.</param>
        internal GraphicsAdapter(GraphicsManager graphicsManager, IntPtr physicalDevice)
        {
            _graphicsManager = graphicsManager;
            _physicalDevice = physicalDevice;

            VkPhysicalDeviceProperties properties;
            vkGetPhysicalDeviceProperties(physicalDevice, &properties);

            _deviceName = Marshal.PtrToStringAnsi((IntPtr)(properties.deviceName));
            _vendorId = properties.vendorID;
            _deviceId = properties.deviceID;
        }
        #endregion

        #region TerraFX.Graphics.IGraphicsAdapter Properties
        /// <summary>Gets the name of the device.</summary>
        public string DeviceName
        {
            get
            {
                return _deviceName;
            }
        }

        /// <summary>Gets the PCI ID of the vendor.</summary>
        public uint VendorId
        {
            get
            {
                return _vendorId;
            }
        }

        /// <summary>Gets the PCI ID of the device.</summary>
        public uint DeviceId
        {
            get
            {
                return _deviceId;
            }
        }
        #endregion
    }
}