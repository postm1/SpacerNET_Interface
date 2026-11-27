@echo off
setlocal
where cl.exe >nul 2>&1
if errorlevel 1 (
  echo Run this script from an x86 Visual Studio Developer Command Prompt.
  exit /b 2
)
set "selection_net40_refs=%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0"
if defined NET40_REFERENCE_PATH set "selection_net40_refs=%NET40_REFERENCE_PATH%"
if not exist "%selection_net40_refs%\mscorlib.dll" (
  echo Install the .NET Framework 4.0 targeting pack or set NET40_REFERENCE_PATH to its reference assemblies.
  exit /b 2
)
pushd "%~dp0.."
if not exist SpacerNET_Interface\bin\x86\Release\SpacerUnionInterface.dll (
  echo Build the Release x86 interface first.
  popd
  exit /b 2
)
if not exist SpacerNET_Interface\bin\tests mkdir SpacerNET_Interface\bin\tests
cl /nologo /LD /EHsc /W4 /WX /Fo:SpacerNET_Interface\bin\tests\NativeSelectionStub.obj tests\NativeSelectionStub.cpp /link /DEF:tests\NativeSelectionStub.def /OUT:SpacerNET_Interface\bin\tests\SpacerUnionNet.dll /IMPLIB:SpacerNET_Interface\bin\tests\NativeSelectionStub.lib
if errorlevel 1 (popd & exit /b 1)
copy /Y SpacerNET_Interface\bin\x86\Release\SpacerUnionInterface.dll SpacerNET_Interface\bin\tests\ >nul
"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\csc.exe" /nologo /nostdlib+ /lib:"%selection_net40_refs%" /reference:mscorlib.dll /reference:System.dll /reference:System.Core.dll /platform:x86 /target:exe /out:SpacerNET_Interface\bin\tests\InterfaceSelectionTests.exe /reference:SpacerNET_Interface\bin\tests\SpacerUnionInterface.dll /reference:System.Windows.Forms.dll /reference:System.Drawing.dll tests\InterfaceSelectionTests.cs
if errorlevel 1 (popd & exit /b 1)
SpacerNET_Interface\bin\tests\InterfaceSelectionTests.exe
set test_result=%errorlevel%
popd
exit /b %test_result%
