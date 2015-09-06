Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Linq
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Model.Core
Imports DevExpress.ExpressApp.Model.DomainLogics
Imports DevExpress.ExpressApp.Model.NodeGenerators
Imports System.Data.Entity

' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppModuleBasetopic.
Public NotInheritable Class [demogitModule]
    Inherits ModuleBase
    ' Uncomment this code to delete and recreate the database each time the data model has changed.
    ' Do not use this code in a production environment to avoid data loss.
    ' #if DEBUG
    ' Shared Sub New()
    '     Database.SetInitializer(New DropCreateDatabaseIfModelChanges(Of demogitDbContext)())
    ' End Sub
    ' #endif 
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
        Dim updater As ModuleUpdater = New Updater(objectSpace, versionFromDB)
        Return New ModuleUpdater() {updater}
    End Function

    Public Overrides Sub Setup(application As XafApplication)
        MyBase.Setup(application)
        ' Manage various aspects of the application UI and behavior at the module level.
    End Sub
End Class
