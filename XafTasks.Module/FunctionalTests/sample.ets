;#DropDB XafTasksEasyTest

#Application XafTasks.Win
#Application XafTasks.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef XafTasks.Win

*Action About...
 
*Action OK

#EndIf

#IfDef XafTasks.Web
*Action Navigation(My Details)
#EndIf
