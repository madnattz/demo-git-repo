Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Linq
Imports System.Data.Entity
Imports System.Data.Common
Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity.Infrastructure
Imports System.ComponentModel
Imports DevExpress.ExpressApp.EF.Updating
Imports DevExpress.Persistent.BaseImpl.EF

' Business Model Design with Entity Framework - https://help.devexpress.com/#Xaf/CustomDocument3462
' Use the Entity Framework Code First in XAF - https://help.devexpress.com/#Xaf/CustomDocument3466
Public Class demogitDbContext
	Inherits DbContext
	Public Sub New(connectionString As [String])
		MyBase.New(connectionString)
	End Sub
	Public Sub New(connection As DbConnection)
		MyBase.New(connection, False)
	End Sub
    Private m_ModulesInfo As DbSet(Of ModuleInfo)
    Public Property ModulesInfo() As DbSet(Of ModuleInfo)
        Get
            Return m_ModulesInfo
        End Get
        Set(value As DbSet(Of ModuleInfo))
            m_ModulesInfo = Value
        End Set
    End Property
End Class