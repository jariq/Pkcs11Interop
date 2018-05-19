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

using System;
using System.Collections.Generic;
using Net.Pkcs11Interop.Common;

// Note: Code in this file is maintained manually.

namespace Net.Pkcs11Interop.HighLevelAPI.Factories
{
    /// <summary>
    /// Factory for creation of IObjectAttribute instances
    /// </summary>
    public interface IObjectAttributeFactory
    {
        /// <summary>
        /// Creates attribute of given type with no value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type);

        /// <summary>
        /// Creates attribute of given type with no value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type);

        /// <summary>
        /// Creates attribute of given type with ulong value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type, ulong value);

        /// <summary>
        /// Creates attribute of given type with ulong value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, ulong value);

        /// <summary>
        /// Creates attribute of given type with CKC value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, CKC value);

        /// <summary>
        /// Creates attribute of given type with CKK value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, CKK value);

        /// <summary>
        /// Creates attribute of given type with CKO value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, CKO value);

        /// <summary>
        /// Creates attribute of given type with bool value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type, bool value);

        /// <summary>
        /// Creates attribute of given type with bool value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, bool value);

        /// <summary>
        /// Creates attribute of given type with string value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type, string value);

        /// <summary>
        /// Creates attribute of given type with string value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, string value);

        /// <summary>
        /// Creates attribute of given type with byte array value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type, byte[] value);

        /// <summary>
        /// Creates attribute of given type with byte array value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, byte[] value);

        /// <summary>
        /// Creates attribute of given type with DateTime (CK_DATE) value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type, DateTime value);

        /// <summary>
        /// Creates attribute of given type with DateTime (CK_DATE) value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, DateTime value);

        /// <summary>
        /// Creates attribute of given type with attribute array value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type, List<IObjectAttribute> value);

        /// <summary>
        /// Creates attribute of given type with attribute array value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, List<IObjectAttribute> value);

        /// <summary>
        /// Creates attribute of given type with ulong array value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type, List<ulong> value);

        /// <summary>
        /// Creates attribute of given type with ulong array value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, List<ulong> value);

        /// <summary>
        /// Creates attribute of given type with mechanism array value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(ulong type, List<CKM> value);

        /// <summary>
        /// Creates attribute of given type with mechanism array value
        /// </summary>
        /// <param name="type">Attribute type</param>
        /// <param name="value">Attribute value</param>
        /// <returns>Attribute of cryptoki object</returns>
        IObjectAttribute CreateObjectAttribute(CKA type, List<CKM> value);
    }
}
