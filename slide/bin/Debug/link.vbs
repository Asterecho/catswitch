set WshShell = WScript.CreateObject("WScript.Shell")
strDesktop = WshShell.SpecialFolders("Desktop") '获得桌面目录
set oShellLink = WshShell.CreateShortcut(strDesktop & "\喵切.lnk") '快捷方式存放目录及名称
oShellLink.TargetPath =createobject("Scripting.FileSystemObject").GetFile(Wscript.ScriptFullName).ParentFolder.Path & "\喵切.exe"   '指向的可执行文件
oShellLink.WindowStyle = 1 '运行方式(窗体打开的方式)
oShellLink.Hotkey = "CTRL+SHIFT+M"    '快捷键
oShellLink.IconLocation =createobject("Scripting.FileSystemObject").GetFile(Wscript.ScriptFullName).ParentFolder.Path & "\喵切.exe, 0" '图标(同样可不指定)
oShellLink.Description = "Made by ifwz1729"    '备注信息
oShellLink.WorkingDirectory = createobject("Scripting.FileSystemObject").GetFile(Wscript.ScriptFullName).ParentFolder.Path 
oShellLink.Save '保存快捷方式