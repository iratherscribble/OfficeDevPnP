#Remove-SPOList
*Topic automatically generated on: 2015-04-02*

Deletes a list
##Syntax
```powershell
Remove-SPOList [-Force [<SwitchParameter>]] [-Web [<WebPipeBind>]] -Identity [<ListPipeBind>]
```
&nbsp;

##Parameters
Parameter|Type|Required|Description
---------|----|--------|-----------
Force|SwitchParameter|False|
Identity|ListPipeBind|True|The ID or Title of the list.
Web|WebPipeBind|False|The web to apply the command to. Leave empty to use the current web.
