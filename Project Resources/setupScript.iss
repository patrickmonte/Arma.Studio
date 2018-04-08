; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "ArmA.Studio"
#define MyAppVersion "0.2.6536.4317" 
#define MyAppPublisher "X39"
#define MyAppURL "https://x39.io/projects?project=ArmA.Studio"
#define MyAppExeName "ArmA.Studio.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputBaseFilename=setup
SetupIconFile=Logo_V1.ico
Compression=lzma
SolidCompression=yes
WizardSmallImageFile=Logo_V1.bmp

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]   
Source: "..\{#MyAppName}\bin\Release\{#MyAppName}.exe"; DestDir: "{app}"; Flags: ignoreversion    
Source: "..\{#MyAppName}\bin\Release\{#MyAppName}.exe.config"; DestDir: "{app}"; Flags: ignoreversion    
Source: "..\{#MyAppName}\bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion    
Source: "..\{#MyAppName}\bin\Release\SqfDefinition.xml"; DestDir: "{app}"; Flags: ignoreversion           
Source: "..\{#MyAppName}\bin\Release\Plugins\*"; DestDir: "{app}\Plugins\"; Flags: ignoreversion recursesubdirs       
Source: "..\{#MyAppName}\bin\Release\*.resources.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[UninstallDelete]
Type: filesandordirs; Name: "{userappdata}\ArmA.Studio\"

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

