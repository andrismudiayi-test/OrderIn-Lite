@echo off

REM install coverage tool

dotnet tool install --global minicover

REM Clean & Test
dotnet clean
dotnet build /p:DebugType=Full

dotnet minicover instrument --workdir ../ --assemblies */OrderInLite.Tests/**/bin/**/*.dll --sources OrderInLite/**/*.cs --exclude-sources OrderInLite/*.cs

dotnet minicover reset --workdir ../

dotnet test --no-build

dotnet minicover uninstrument --workdir ../

dotnet minicover report --workdir ../ --threshold 70