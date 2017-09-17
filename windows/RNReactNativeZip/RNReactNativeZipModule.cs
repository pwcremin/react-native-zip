using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Zip.RNReactNativeZip
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeZipModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeZipModule"/>.
        /// </summary>
        internal RNReactNativeZipModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeZip";
            }
        }
    }
}
