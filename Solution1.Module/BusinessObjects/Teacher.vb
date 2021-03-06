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

<DefaultClassOptions()> _
Public Class Teacher ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
    End Sub

    Private _TeacherID As String
    Public Property TeacherID() As String
        Get
            Return _TeacherID
        End Get
        Set(ByVal value As String)
            SetPropertyValue("TeacherID", _TeacherID, value)
        End Set
    End Property

    Private _TeacherName As String
    Public Property TeacherName() As String
        Get
            Return _TeacherName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("TeacherName", _TeacherName, value)
        End Set
    End Property

    Private _Address As String
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            SetPropertyValue("Address", _Address, value)
        End Set
    End Property

    Private _Street As String
    Public Property Street() As String
        Get
            Return _Street
        End Get
        Set(ByVal value As String)
            SetPropertyValue("Street", _Street, value)
        End Set
    End Property

    Private _Moo As String
    Public Property Moo() As String
        Get
            Return _Moo
        End Get
        Set(ByVal value As String)
            SetPropertyValue("Moo", _Moo, value)
        End Set
    End Property

    Private _Age As String
    Public Property Age() As String
        Get
            Return _Age
        End Get
        Set(ByVal value As String)
            SetPropertyValue("Age", _Age, value)
        End Set
    End Property

    Private _SubDistrict As String
    Public Property SubDistrict() As String
        Get
            Return _SubDistrict
        End Get
        Set(ByVal value As String)
            SetPropertyValue("SubDistrict", _SubDistrict, value)
        End Set
    End Property

    Private _District As String
    Public Property District() As String
        Get
            Return _District
        End Get
        Set(ByVal value As String)
            SetPropertyValue("District", _District, value)
        End Set
    End Property

    Private _Province As String
    Public Property Province() As String
        Get
            Return _Province
        End Get
        Set(ByVal value As String)
            SetPropertyValue("Province", _Province, value)
        End Set
    End Property



End Class
