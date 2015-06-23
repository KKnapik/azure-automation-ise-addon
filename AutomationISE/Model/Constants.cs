﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace AutomationAzure
{
    public class Constants
    {
        public const String authority = "https://login.windows.net/common";
        public const String appIdURI = "https://management.core.windows.net/";
        public const String clientID = "1950a258-227b-4e31-a9cf-717495945fc2";
        public const String tenant = "f0316def-610c-40f6-abf2-f0ab2296b483";
        public const String redirectURI = "urn:ietf:wg:oauth:2.0:oob";

        // Runbook values
        public const String notExist = "N/A";

        // Assets values

        public class Status
        {
            public const String LocalOnly = "LocalOnly";
            public const String InSync = "InSync";
            public const String CloudOnly = "CloudOnly";
        }

        public const bool encryptedTrue = true;

        public const String assetCredential = "Credentials";
        public const String assetVariable = "Variables";
        public const String assetCertificate = "Certificates";
        public const String assetConnection = "Connections";
        public const String assetModule = "Modules";

        public class RunbookType
        {
            public const String Script = "Script";

            public const String Graphical = "Graphical";
        }

        public class AutomationAccountState
        {
            public const string Ready = "Ready";

            public const string Suspended = "Suspended";
        }

    }
}