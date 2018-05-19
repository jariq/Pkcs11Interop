﻿/*
 *  Copyright 2012-2017 The Pkcs11Interop Project
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

/*
 *  Written for the Pkcs11Interop project by:
 *  Jaroslav IMRICH <jimrich@jimrich.sk>
 */

using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using Net.Pkcs11Interop.HighLevelAPI.Factories;

// Note: Code in this file is maintained manually.

namespace Net.Pkcs11Interop.Mock.HighLevelAPI.Factories
{
    /// <summary>
    /// Factory for creation of IPkcs11 instances
    /// </summary>
    public class MockPkcs11Factory : IPkcs11Factory
    {
        /// <summary>
        /// Platform specific factory for creation of IPkcs11 instances
        /// </summary>
        private IPkcs11Factory _factory = null;

        /// <summary>
        /// Initializes a new instance of the MockPkcs11Factory class
        /// </summary>
        public MockPkcs11Factory()
        {
            if (Platform.UnmanagedLongSize == 4)
            {
                if (Platform.StructPackingSize == 0)
                    _factory = new HighLevelAPI40.Factories.MockPkcs11Factory();
                else
                    _factory = new HighLevelAPI41.Factories.MockPkcs11Factory();
            }
            else
            {
                if (Platform.StructPackingSize == 0)
                    _factory = new HighLevelAPI80.Factories.MockPkcs11Factory();
                else
                    _factory = new HighLevelAPI81.Factories.MockPkcs11Factory();
            }
        }

        /// <summary>
        /// Loads and initializes PCKS#11 library
        /// </summary>
        /// <param name="factories">Factories to be used by Developer and Pkcs11Interop library</param>
        /// <param name="libraryPath">Library name or path</param>
        /// <param name="appType">Type of application that will be using PKCS#11 library</param>
        /// <returns>High level PKCS#11 wrapper</returns>
        public IPkcs11 CreatePkcs11(Pkcs11Factories factories, string libraryPath, AppType appType)
        {
            return _factory.CreatePkcs11(factories, libraryPath, appType);
        }

        /// <summary>
        /// Loads and initializes PCKS#11 library
        /// </summary>
        /// <param name="factories">Factories to be used by Developer and Pkcs11Interop library</param>
        /// <param name="libraryPath">Library name or path</param>
        /// <param name="appType">Type of application that will be using PKCS#11 library</param>
        /// <param name="initType">Source of PKCS#11 function pointers</param>
        /// <returns>High level PKCS#11 wrapper</returns>
        public IPkcs11 CreatePkcs11(Pkcs11Factories factories, string libraryPath, AppType appType, InitType initType)
        {
            return _factory.CreatePkcs11(factories, libraryPath, appType, initType);
        }
    }
}
