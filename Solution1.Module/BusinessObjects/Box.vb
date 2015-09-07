Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

<XafDisplayName("กล่อง")> _
<DefaultClassOptions()> _
Public Class Box ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub

    Private fBoxNo As String
    <XafDisplayName("เลขที่")> _
    Public Property BoxNo() As String
        Get
            Return fBoxNo
        End Get
        Set(ByVal value As String)
            SetPropertyValue("BoxNo", fBoxNo, value)
        End Set
    End Property

    Private fBoxName As String
    <XafDisplayName("ชื่อ")> _
    Public Property BoxName() As String
        Get
            Return fBoxName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("BoxName", fBoxName, value)
        End Set
    End Property

    Private fBoxType As String
    <XafDisplayName("ประเภท")> _
    Public Property BoxType() As String
        Get
            Return fBoxType
        End Get
        Set(ByVal value As String)
            SetPropertyValue("BoxType ", fBoxType, value)
        End Set
    End Property
End Class
