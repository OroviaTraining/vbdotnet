﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Inventory")>  _
Partial Public Class InventoryDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertGraphic(instance As Graphic)
    End Sub
  Partial Private Sub UpdateGraphic(instance As Graphic)
    End Sub
  Partial Private Sub DeleteGraphic(instance As Graphic)
    End Sub
  Partial Private Sub InsertCustOrder(instance As CustOrder)
    End Sub
  Partial Private Sub UpdateCustOrder(instance As CustOrder)
    End Sub
  Partial Private Sub DeleteCustOrder(instance As CustOrder)
    End Sub
  Partial Private Sub InsertUKCustomer(instance As UKCustomer)
    End Sub
  Partial Private Sub UpdateUKCustomer(instance As UKCustomer)
    End Sub
  Partial Private Sub DeleteUKCustomer(instance As UKCustomer)
    End Sub
  Partial Private Sub InsertDbTable(instance As DbTable)
    End Sub
  Partial Private Sub UpdateDbTable(instance As DbTable)
    End Sub
  Partial Private Sub DeleteDbTable(instance As DbTable)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.InventorySystem.My.MySettings.Default.ConnStr, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Graphics() As System.Data.Linq.Table(Of Graphic)
		Get
			Return Me.GetTable(Of Graphic)
		End Get
	End Property
	
	Public ReadOnly Property CustOrders() As System.Data.Linq.Table(Of CustOrder)
		Get
			Return Me.GetTable(Of CustOrder)
		End Get
	End Property
	
	Public ReadOnly Property UKCustomers() As System.Data.Linq.Table(Of UKCustomer)
		Get
			Return Me.GetTable(Of UKCustomer)
		End Get
	End Property
	
	Public ReadOnly Property DbTables() As System.Data.Linq.Table(Of DbTable)
		Get
			Return Me.GetTable(Of DbTable)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Graphic")>  _
Partial Public Class Graphic
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _seqno As Integer
	
	Private _gname As String
	
	Private _credate As Date
	
	Private _creuser As String
	
	Private _amddate As System.Nullable(Of Date)
	
	Private _amduser As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnseqnoChanging(value As Integer)
    End Sub
    Partial Private Sub OnseqnoChanged()
    End Sub
    Partial Private Sub OngnameChanging(value As String)
    End Sub
    Partial Private Sub OngnameChanged()
    End Sub
    Partial Private Sub OncredateChanging(value As Date)
    End Sub
    Partial Private Sub OncredateChanged()
    End Sub
    Partial Private Sub OncreuserChanging(value As String)
    End Sub
    Partial Private Sub OncreuserChanged()
    End Sub
    Partial Private Sub OnamddateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnamddateChanged()
    End Sub
    Partial Private Sub OnamduserChanging(value As String)
    End Sub
    Partial Private Sub OnamduserChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_seqno", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property seqno() As Integer
		Get
			Return Me._seqno
		End Get
		Set
			If ((Me._seqno = value)  _
						= false) Then
				Me.OnseqnoChanging(value)
				Me.SendPropertyChanging
				Me._seqno = value
				Me.SendPropertyChanged("seqno")
				Me.OnseqnoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_gname", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property gname() As String
		Get
			Return Me._gname
		End Get
		Set
			If (String.Equals(Me._gname, value) = false) Then
				Me.OngnameChanging(value)
				Me.SendPropertyChanging
				Me._gname = value
				Me.SendPropertyChanged("gname")
				Me.OngnameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_credate", DbType:="DateTime NOT NULL")>  _
	Public Property credate() As Date
		Get
			Return Me._credate
		End Get
		Set
			If ((Me._credate = value)  _
						= false) Then
				Me.OncredateChanging(value)
				Me.SendPropertyChanging
				Me._credate = value
				Me.SendPropertyChanged("credate")
				Me.OncredateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_creuser", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property creuser() As String
		Get
			Return Me._creuser
		End Get
		Set
			If (String.Equals(Me._creuser, value) = false) Then
				Me.OncreuserChanging(value)
				Me.SendPropertyChanging
				Me._creuser = value
				Me.SendPropertyChanged("creuser")
				Me.OncreuserChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_amddate", DbType:="DateTime")>  _
	Public Property amddate() As System.Nullable(Of Date)
		Get
			Return Me._amddate
		End Get
		Set
			If (Me._amddate.Equals(value) = false) Then
				Me.OnamddateChanging(value)
				Me.SendPropertyChanging
				Me._amddate = value
				Me.SendPropertyChanged("amddate")
				Me.OnamddateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_amduser", DbType:="VarChar(25)")>  _
	Public Property amduser() As String
		Get
			Return Me._amduser
		End Get
		Set
			If (String.Equals(Me._amduser, value) = false) Then
				Me.OnamduserChanging(value)
				Me.SendPropertyChanging
				Me._amduser = value
				Me.SendPropertyChanged("amduser")
				Me.OnamduserChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.CustOrder")>  _
Partial Public Class CustOrder
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _orderID As Integer
	
	Private _orderDate As Date
	
	Private _custID As String
	
	Private _orderTotal As Decimal
	
	Private _UKCustomer As EntityRef(Of UKCustomer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnorderIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnorderIDChanged()
    End Sub
    Partial Private Sub OnorderDateChanging(value As Date)
    End Sub
    Partial Private Sub OnorderDateChanged()
    End Sub
    Partial Private Sub OncustIDChanging(value As String)
    End Sub
    Partial Private Sub OncustIDChanged()
    End Sub
    Partial Private Sub OnorderTotalChanging(value As Decimal)
    End Sub
    Partial Private Sub OnorderTotalChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._UKCustomer = CType(Nothing, EntityRef(Of UKCustomer))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_orderID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property orderID() As Integer
		Get
			Return Me._orderID
		End Get
		Set
			If ((Me._orderID = value)  _
						= false) Then
				Me.OnorderIDChanging(value)
				Me.SendPropertyChanging
				Me._orderID = value
				Me.SendPropertyChanged("orderID")
				Me.OnorderIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_orderDate", DbType:="Date NOT NULL")>  _
	Public Property orderDate() As Date
		Get
			Return Me._orderDate
		End Get
		Set
			If ((Me._orderDate = value)  _
						= false) Then
				Me.OnorderDateChanging(value)
				Me.SendPropertyChanging
				Me._orderDate = value
				Me.SendPropertyChanged("orderDate")
				Me.OnorderDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_custID", DbType:="Char(10) NOT NULL", CanBeNull:=false)>  _
	Public Property custID() As String
		Get
			Return Me._custID
		End Get
		Set
			If (String.Equals(Me._custID, value) = false) Then
				If Me._UKCustomer.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OncustIDChanging(value)
				Me.SendPropertyChanging
				Me._custID = value
				Me.SendPropertyChanged("custID")
				Me.OncustIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_orderTotal", DbType:="Decimal(10,2) NOT NULL")>  _
	Public Property orderTotal() As Decimal
		Get
			Return Me._orderTotal
		End Get
		Set
			If ((Me._orderTotal = value)  _
						= false) Then
				Me.OnorderTotalChanging(value)
				Me.SendPropertyChanging
				Me._orderTotal = value
				Me.SendPropertyChanged("orderTotal")
				Me.OnorderTotalChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="UKCustomer_CustOrder", Storage:="_UKCustomer", ThisKey:="custID", OtherKey:="custID", IsForeignKey:=true, DeleteOnNull:=true, DeleteRule:="CASCADE")>  _
	Public Property UKCustomer() As UKCustomer
		Get
			Return Me._UKCustomer.Entity
		End Get
		Set
			Dim previousValue As UKCustomer = Me._UKCustomer.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._UKCustomer.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._UKCustomer.Entity = Nothing
					previousValue.CustOrders.Remove(Me)
				End If
				Me._UKCustomer.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.CustOrders.Add(Me)
					Me._custID = value.custID
				Else
					Me._custID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("UKCustomer")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Customer")>  _
Partial Public Class UKCustomer
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _custID As String
	
	Private _custName As String
	
	Private _custCity As String
	
	Private _CustOrders As EntitySet(Of CustOrder)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OncustIDChanging(value As String)
    End Sub
    Partial Private Sub OncustIDChanged()
    End Sub
    Partial Private Sub OncustNameChanging(value As String)
    End Sub
    Partial Private Sub OncustNameChanged()
    End Sub
    Partial Private Sub OncustCityChanging(value As String)
    End Sub
    Partial Private Sub OncustCityChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._CustOrders = New EntitySet(Of CustOrder)(AddressOf Me.attach_CustOrders, AddressOf Me.detach_CustOrders)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_custID", DbType:="Char(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property custID() As String
		Get
			Return Me._custID
		End Get
		Set
			If (String.Equals(Me._custID, value) = false) Then
				Me.OncustIDChanging(value)
				Me.SendPropertyChanging
				Me._custID = value
				Me.SendPropertyChanged("custID")
				Me.OncustIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_custName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property custName() As String
		Get
			Return Me._custName
		End Get
		Set
			If (String.Equals(Me._custName, value) = false) Then
				Me.OncustNameChanging(value)
				Me.SendPropertyChanging
				Me._custName = value
				Me.SendPropertyChanged("custName")
				Me.OncustNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_custCity", DbType:="VarChar(25)")>  _
	Public Property custCity() As String
		Get
			Return Me._custCity
		End Get
		Set
			If (String.Equals(Me._custCity, value) = false) Then
				Me.OncustCityChanging(value)
				Me.SendPropertyChanging
				Me._custCity = value
				Me.SendPropertyChanged("custCity")
				Me.OncustCityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="UKCustomer_CustOrder", Storage:="_CustOrders", ThisKey:="custID", OtherKey:="custID")>  _
	Public Property CustOrders() As EntitySet(Of CustOrder)
		Get
			Return Me._CustOrders
		End Get
		Set
			Me._CustOrders.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_CustOrders(ByVal entity As CustOrder)
		Me.SendPropertyChanging
		entity.UKCustomer = Me
	End Sub
	
	Private Sub detach_CustOrders(ByVal entity As CustOrder)
		Me.SendPropertyChanging
		entity.UKCustomer = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.DbTable")>  _
Partial Public Class DbTable
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _seqNo As Integer
	
	Private _tblName As String
	
	Private _type1 As Boolean
	
	Private _type2 As Boolean
	
	Private _type3 As Boolean
	
	Private _creDate As Date
	
	Private _creUser As String
	
	Private _amdDate As System.Nullable(Of Date)
	
	Private _amdUser As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnseqNoChanging(value As Integer)
    End Sub
    Partial Private Sub OnseqNoChanged()
    End Sub
    Partial Private Sub OntblNameChanging(value As String)
    End Sub
    Partial Private Sub OntblNameChanged()
    End Sub
    Partial Private Sub Ontype1Changing(value As Boolean)
    End Sub
    Partial Private Sub Ontype1Changed()
    End Sub
    Partial Private Sub Ontype2Changing(value As Boolean)
    End Sub
    Partial Private Sub Ontype2Changed()
    End Sub
    Partial Private Sub Ontype3Changing(value As Boolean)
    End Sub
    Partial Private Sub Ontype3Changed()
    End Sub
    Partial Private Sub OncreDateChanging(value As Date)
    End Sub
    Partial Private Sub OncreDateChanged()
    End Sub
    Partial Private Sub OncreUserChanging(value As String)
    End Sub
    Partial Private Sub OncreUserChanged()
    End Sub
    Partial Private Sub OnamdDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnamdDateChanged()
    End Sub
    Partial Private Sub OnamdUserChanging(value As String)
    End Sub
    Partial Private Sub OnamdUserChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_seqNo", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property seqNo() As Integer
		Get
			Return Me._seqNo
		End Get
		Set
			If ((Me._seqNo = value)  _
						= false) Then
				Me.OnseqNoChanging(value)
				Me.SendPropertyChanging
				Me._seqNo = value
				Me.SendPropertyChanged("seqNo")
				Me.OnseqNoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tblName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property tblName() As String
		Get
			Return Me._tblName
		End Get
		Set
			If (String.Equals(Me._tblName, value) = false) Then
				Me.OntblNameChanging(value)
				Me.SendPropertyChanging
				Me._tblName = value
				Me.SendPropertyChanged("tblName")
				Me.OntblNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_type1", DbType:="Bit NOT NULL")>  _
	Public Property type1() As Boolean
		Get
			Return Me._type1
		End Get
		Set
			If ((Me._type1 = value)  _
						= false) Then
				Me.Ontype1Changing(value)
				Me.SendPropertyChanging
				Me._type1 = value
				Me.SendPropertyChanged("type1")
				Me.Ontype1Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_type2", DbType:="Bit NOT NULL")>  _
	Public Property type2() As Boolean
		Get
			Return Me._type2
		End Get
		Set
			If ((Me._type2 = value)  _
						= false) Then
				Me.Ontype2Changing(value)
				Me.SendPropertyChanging
				Me._type2 = value
				Me.SendPropertyChanged("type2")
				Me.Ontype2Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_type3", DbType:="Bit NOT NULL")>  _
	Public Property type3() As Boolean
		Get
			Return Me._type3
		End Get
		Set
			If ((Me._type3 = value)  _
						= false) Then
				Me.Ontype3Changing(value)
				Me.SendPropertyChanging
				Me._type3 = value
				Me.SendPropertyChanged("type3")
				Me.Ontype3Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_creDate", DbType:="Date NOT NULL")>  _
	Public Property creDate() As Date
		Get
			Return Me._creDate
		End Get
		Set
			If ((Me._creDate = value)  _
						= false) Then
				Me.OncreDateChanging(value)
				Me.SendPropertyChanging
				Me._creDate = value
				Me.SendPropertyChanged("creDate")
				Me.OncreDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_creUser", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property creUser() As String
		Get
			Return Me._creUser
		End Get
		Set
			If (String.Equals(Me._creUser, value) = false) Then
				Me.OncreUserChanging(value)
				Me.SendPropertyChanging
				Me._creUser = value
				Me.SendPropertyChanged("creUser")
				Me.OncreUserChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_amdDate", DbType:="Date")>  _
	Public Property amdDate() As System.Nullable(Of Date)
		Get
			Return Me._amdDate
		End Get
		Set
			If (Me._amdDate.Equals(value) = false) Then
				Me.OnamdDateChanging(value)
				Me.SendPropertyChanging
				Me._amdDate = value
				Me.SendPropertyChanged("amdDate")
				Me.OnamdDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_amdUser", DbType:="VarChar(50)")>  _
	Public Property amdUser() As String
		Get
			Return Me._amdUser
		End Get
		Set
			If (String.Equals(Me._amdUser, value) = false) Then
				Me.OnamdUserChanging(value)
				Me.SendPropertyChanging
				Me._amdUser = value
				Me.SendPropertyChanged("amdUser")
				Me.OnamdUserChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
