set WshShell = WScript.CreateObject("WScript.Shell")
strDesktop = WshShell.SpecialFolders("Desktop") '�������Ŀ¼
set oShellLink = WshShell.CreateShortcut(strDesktop & "\����.lnk") '��ݷ�ʽ���Ŀ¼������
oShellLink.TargetPath =createobject("Scripting.FileSystemObject").GetFile(Wscript.ScriptFullName).ParentFolder.Path & "\����.exe"   'ָ��Ŀ�ִ���ļ�
oShellLink.WindowStyle = 1 '���з�ʽ(����򿪵ķ�ʽ)
oShellLink.Hotkey = "CTRL+SHIFT+M"    '��ݼ�
oShellLink.IconLocation =createobject("Scripting.FileSystemObject").GetFile(Wscript.ScriptFullName).ParentFolder.Path & "\����.exe, 0" 'ͼ��(ͬ���ɲ�ָ��)
oShellLink.Description = "Made by ifwz1729"    '��ע��Ϣ
oShellLink.WorkingDirectory = createobject("Scripting.FileSystemObject").GetFile(Wscript.ScriptFullName).ParentFolder.Path 
oShellLink.Save '�����ݷ�ʽ