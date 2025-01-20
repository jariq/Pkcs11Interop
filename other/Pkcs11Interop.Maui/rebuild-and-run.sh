#!/bin/bash

set -e

dotnet clean
dotnet restore
dotnet build
dotnet build Pkcs11Interop.Maui.csproj -t:Run -f net8.0-maccatalyst