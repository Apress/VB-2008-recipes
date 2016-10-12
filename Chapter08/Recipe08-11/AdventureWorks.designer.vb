﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1378
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


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="AdventureWorks")>  _
Partial Public Class AdventureWorksDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertContact(instance As Contact)
    End Sub
  Partial Private Sub UpdateContact(instance As Contact)
    End Sub
  Partial Private Sub DeleteContact(instance As Contact)
    End Sub
  Partial Private Sub InsertEmployee(instance As Employee)
    End Sub
  Partial Private Sub UpdateEmployee(instance As Employee)
    End Sub
  Partial Private Sub DeleteEmployee(instance As Employee)
    End Sub
  #End Region
	
	Shared Sub New()
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
	
	Public Sub New()
		MyBase.New(Global.My.MySettings.Default.AdventureWorksConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Contacts() As System.Data.Linq.Table(Of Contact)
		Get
			Return Me.GetTable(Of Contact)
		End Get
	End Property
	
	Public ReadOnly Property Employees() As System.Data.Linq.Table(Of Employee)
		Get
			Return Me.GetTable(Of Employee)
		End Get
	End Property
End Class

<Table(Name:="Person.Contact")>  _
Partial Public Class Contact
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ContactID As Integer
	
	Private _NameStyle As Boolean
	
	Private _Title As String
	
	Private _FirstName As String
	
	Private _MiddleName As String
	
	Private _LastName As String
	
	Private _Suffix As String
	
	Private _EmailAddress As String
	
	Private _EmailPromotion As Integer
	
	Private _Phone As String
	
	Private _PasswordHash As String
	
	Private _PasswordSalt As String
	
	Private _AdditionalContactInfo As System.Xml.Linq.XDocument
	
	Private _rowguid As System.Guid
	
	Private _ModifiedDate As Date
	
	Private _Employees As EntitySet(Of Employee)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate()
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnContactIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnContactIDChanged()
    End Sub
    Partial Private Sub OnNameStyleChanging(value As Boolean)
    End Sub
    Partial Private Sub OnNameStyleChanged()
    End Sub
    Partial Private Sub OnTitleChanging(value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnFirstNameChanging(value As String)
    End Sub
    Partial Private Sub OnFirstNameChanged()
    End Sub
    Partial Private Sub OnMiddleNameChanging(value As String)
    End Sub
    Partial Private Sub OnMiddleNameChanged()
    End Sub
    Partial Private Sub OnLastNameChanging(value As String)
    End Sub
    Partial Private Sub OnLastNameChanged()
    End Sub
    Partial Private Sub OnSuffixChanging(value As String)
    End Sub
    Partial Private Sub OnSuffixChanged()
    End Sub
    Partial Private Sub OnEmailAddressChanging(value As String)
    End Sub
    Partial Private Sub OnEmailAddressChanged()
    End Sub
    Partial Private Sub OnEmailPromotionChanging(value As Integer)
    End Sub
    Partial Private Sub OnEmailPromotionChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnPasswordHashChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordHashChanged()
    End Sub
    Partial Private Sub OnPasswordSaltChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordSaltChanged()
    End Sub
    Partial Private Sub OnAdditionalContactInfoChanging(value As System.Xml.Linq.XDocument)
    End Sub
    Partial Private Sub OnAdditionalContactInfoChanged()
    End Sub
    Partial Private Sub OnrowguidChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnrowguidChanged()
    End Sub
    Partial Private Sub OnModifiedDateChanging(value As Date)
    End Sub
    Partial Private Sub OnModifiedDateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
		Me._Employees = New EntitySet(Of Employee)(AddressOf Me.attach_Employees, AddressOf Me.detach_Employees)
	End Sub
	
	<Column(Storage:="_ContactID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ContactID() As Integer
		Get
			Return Me._ContactID
		End Get
		Set
			If ((Me._ContactID = value)  _
						= false) Then
				Me.OnContactIDChanging(value)
				Me.SendPropertyChanging
				Me._ContactID = value
				Me.SendPropertyChanged("ContactID")
				Me.OnContactIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_NameStyle", DbType:="Bit NOT NULL")>  _
	Public Property NameStyle() As Boolean
		Get
			Return Me._NameStyle
		End Get
		Set
			If ((Me._NameStyle = value)  _
						= false) Then
				Me.OnNameStyleChanging(value)
				Me.SendPropertyChanging
				Me._NameStyle = value
				Me.SendPropertyChanged("NameStyle")
				Me.OnNameStyleChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Title", DbType:="NVarChar(8)")>  _
	Public Property Title() As String
		Get
			Return Me._Title
		End Get
		Set
			If ((Me._Title = value)  _
						= false) Then
				Me.OnTitleChanging(value)
				Me.SendPropertyChanging
				Me._Title = value
				Me.SendPropertyChanged("Title")
				Me.OnTitleChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_FirstName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property FirstName() As String
		Get
			Return Me._FirstName
		End Get
		Set
			If ((Me._FirstName = value)  _
						= false) Then
				Me.OnFirstNameChanging(value)
				Me.SendPropertyChanging
				Me._FirstName = value
				Me.SendPropertyChanged("FirstName")
				Me.OnFirstNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_MiddleName", DbType:="NVarChar(50)")>  _
	Public Property MiddleName() As String
		Get
			Return Me._MiddleName
		End Get
		Set
			If ((Me._MiddleName = value)  _
						= false) Then
				Me.OnMiddleNameChanging(value)
				Me.SendPropertyChanging
				Me._MiddleName = value
				Me.SendPropertyChanged("MiddleName")
				Me.OnMiddleNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_LastName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property LastName() As String
		Get
			Return Me._LastName
		End Get
		Set
			If ((Me._LastName = value)  _
						= false) Then
				Me.OnLastNameChanging(value)
				Me.SendPropertyChanging
				Me._LastName = value
				Me.SendPropertyChanged("LastName")
				Me.OnLastNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Suffix", DbType:="NVarChar(10)")>  _
	Public Property Suffix() As String
		Get
			Return Me._Suffix
		End Get
		Set
			If ((Me._Suffix = value)  _
						= false) Then
				Me.OnSuffixChanging(value)
				Me.SendPropertyChanging
				Me._Suffix = value
				Me.SendPropertyChanged("Suffix")
				Me.OnSuffixChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_EmailAddress", DbType:="NVarChar(50)")>  _
	Public Property EmailAddress() As String
		Get
			Return Me._EmailAddress
		End Get
		Set
			If ((Me._EmailAddress = value)  _
						= false) Then
				Me.OnEmailAddressChanging(value)
				Me.SendPropertyChanging
				Me._EmailAddress = value
				Me.SendPropertyChanged("EmailAddress")
				Me.OnEmailAddressChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_EmailPromotion", DbType:="Int NOT NULL")>  _
	Public Property EmailPromotion() As Integer
		Get
			Return Me._EmailPromotion
		End Get
		Set
			If ((Me._EmailPromotion = value)  _
						= false) Then
				Me.OnEmailPromotionChanging(value)
				Me.SendPropertyChanging
				Me._EmailPromotion = value
				Me.SendPropertyChanged("EmailPromotion")
				Me.OnEmailPromotionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Phone", DbType:="NVarChar(25)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If ((Me._Phone = value)  _
						= false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PasswordHash", DbType:="VarChar(128) NOT NULL", CanBeNull:=false)>  _
	Public Property PasswordHash() As String
		Get
			Return Me._PasswordHash
		End Get
		Set
			If ((Me._PasswordHash = value)  _
						= false) Then
				Me.OnPasswordHashChanging(value)
				Me.SendPropertyChanging
				Me._PasswordHash = value
				Me.SendPropertyChanged("PasswordHash")
				Me.OnPasswordHashChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PasswordSalt", DbType:="VarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property PasswordSalt() As String
		Get
			Return Me._PasswordSalt
		End Get
		Set
			If ((Me._PasswordSalt = value)  _
						= false) Then
				Me.OnPasswordSaltChanging(value)
				Me.SendPropertyChanging
				Me._PasswordSalt = value
				Me.SendPropertyChanged("PasswordSalt")
				Me.OnPasswordSaltChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_AdditionalContactInfo", DbType:="Xml", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property AdditionalContactInfo() As System.Xml.Linq.XDocument
		Get
			Return Me._AdditionalContactInfo
		End Get
		Set
			If ((Me._AdditionalContactInfo Is value)  _
						= false) Then
				Me.OnAdditionalContactInfoChanging(value)
				Me.SendPropertyChanging
				Me._AdditionalContactInfo = value
				Me.SendPropertyChanged("AdditionalContactInfo")
				Me.OnAdditionalContactInfoChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_rowguid", DbType:="UniqueIdentifier NOT NULL")>  _
	Public Property rowguid() As System.Guid
		Get
			Return Me._rowguid
		End Get
		Set
			If ((Me._rowguid = value)  _
						= false) Then
				Me.OnrowguidChanging(value)
				Me.SendPropertyChanging
				Me._rowguid = value
				Me.SendPropertyChanged("rowguid")
				Me.OnrowguidChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ModifiedDate", DbType:="DateTime NOT NULL")>  _
	Public Property ModifiedDate() As Date
		Get
			Return Me._ModifiedDate
		End Get
		Set
			If ((Me._ModifiedDate = value)  _
						= false) Then
				Me.OnModifiedDateChanging(value)
				Me.SendPropertyChanging
				Me._ModifiedDate = value
				Me.SendPropertyChanged("ModifiedDate")
				Me.OnModifiedDateChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Contact_Employee", Storage:="_Employees", OtherKey:="ContactID")>  _
	Public Property Employees() As EntitySet(Of Employee)
		Get
			Return Me._Employees
		End Get
		Set
			Me._Employees.Assign(value)
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
	
	Private Sub attach_Employees(ByVal entity As Employee)
		Me.SendPropertyChanging
		entity.Contact = Me
		Me.SendPropertyChanged("Employees")
	End Sub
	
	Private Sub detach_Employees(ByVal entity As Employee)
		Me.SendPropertyChanging
		entity.Contact = Nothing
		Me.SendPropertyChanged("Employees")
	End Sub
End Class

<Table(Name:="HumanResources.Employee")>  _
Partial Public Class Employee
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _EmployeeID As Integer
	
	Private _NationalIDNumber As String
	
	Private _ContactID As Integer
	
	Private _LoginID As String
	
	Private _ManagerID As System.Nullable(Of Integer)
	
	Private _Title As String
	
	Private _BirthDate As Date
	
	Private _MaritalStatus As Char
	
	Private _Gender As Char
	
	Private _HireDate As Date
	
	Private _SalariedFlag As Boolean
	
	Private _VacationHours As Short
	
	Private _SickLeaveHours As Short
	
	Private _CurrentFlag As Boolean
	
	Private _rowguid As System.Guid
	
	Private _ModifiedDate As Date
	
	Private _Employees As EntitySet(Of Employee)
	
	Private _Contact As EntityRef(Of Contact)
	
	Private _Employee As EntityRef(Of Employee)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate()
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnEmployeeIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnEmployeeIDChanged()
    End Sub
    Partial Private Sub OnNationalIDNumberChanging(value As String)
    End Sub
    Partial Private Sub OnNationalIDNumberChanged()
    End Sub
    Partial Private Sub OnContactIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnContactIDChanged()
    End Sub
    Partial Private Sub OnLoginIDChanging(value As String)
    End Sub
    Partial Private Sub OnLoginIDChanged()
    End Sub
    Partial Private Sub OnManagerIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnManagerIDChanged()
    End Sub
    Partial Private Sub OnTitleChanging(value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnBirthDateChanging(value As Date)
    End Sub
    Partial Private Sub OnBirthDateChanged()
    End Sub
    Partial Private Sub OnMaritalStatusChanging(value As Char)
    End Sub
    Partial Private Sub OnMaritalStatusChanged()
    End Sub
    Partial Private Sub OnGenderChanging(value As Char)
    End Sub
    Partial Private Sub OnGenderChanged()
    End Sub
    Partial Private Sub OnHireDateChanging(value As Date)
    End Sub
    Partial Private Sub OnHireDateChanged()
    End Sub
    Partial Private Sub OnSalariedFlagChanging(value As Boolean)
    End Sub
    Partial Private Sub OnSalariedFlagChanged()
    End Sub
    Partial Private Sub OnVacationHoursChanging(value As Short)
    End Sub
    Partial Private Sub OnVacationHoursChanged()
    End Sub
    Partial Private Sub OnSickLeaveHoursChanging(value As Short)
    End Sub
    Partial Private Sub OnSickLeaveHoursChanged()
    End Sub
    Partial Private Sub OnCurrentFlagChanging(value As Boolean)
    End Sub
    Partial Private Sub OnCurrentFlagChanged()
    End Sub
    Partial Private Sub OnrowguidChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnrowguidChanged()
    End Sub
    Partial Private Sub OnModifiedDateChanging(value As Date)
    End Sub
    Partial Private Sub OnModifiedDateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
		Me._Employees = New EntitySet(Of Employee)(AddressOf Me.attach_Employees, AddressOf Me.detach_Employees)
		Me._Contact = CType(Nothing, EntityRef(Of Contact))
		Me._Employee = CType(Nothing, EntityRef(Of Employee))
	End Sub
	
	<Column(Storage:="_EmployeeID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property EmployeeID() As Integer
		Get
			Return Me._EmployeeID
		End Get
		Set
			If ((Me._EmployeeID = value)  _
						= false) Then
				Me.OnEmployeeIDChanging(value)
				Me.SendPropertyChanging
				Me._EmployeeID = value
				Me.SendPropertyChanged("EmployeeID")
				Me.OnEmployeeIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_NationalIDNumber", DbType:="NVarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property NationalIDNumber() As String
		Get
			Return Me._NationalIDNumber
		End Get
		Set
			If ((Me._NationalIDNumber = value)  _
						= false) Then
				Me.OnNationalIDNumberChanging(value)
				Me.SendPropertyChanging
				Me._NationalIDNumber = value
				Me.SendPropertyChanged("NationalIDNumber")
				Me.OnNationalIDNumberChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ContactID", DbType:="Int NOT NULL")>  _
	Public Property ContactID() As Integer
		Get
			Return Me._ContactID
		End Get
		Set
			If ((Me._ContactID = value)  _
						= false) Then
				If Me._Contact.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnContactIDChanging(value)
				Me.SendPropertyChanging
				Me._ContactID = value
				Me.SendPropertyChanged("ContactID")
				Me.OnContactIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_LoginID", DbType:="NVarChar(256) NOT NULL", CanBeNull:=false)>  _
	Public Property LoginID() As String
		Get
			Return Me._LoginID
		End Get
		Set
			If ((Me._LoginID = value)  _
						= false) Then
				Me.OnLoginIDChanging(value)
				Me.SendPropertyChanging
				Me._LoginID = value
				Me.SendPropertyChanged("LoginID")
				Me.OnLoginIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ManagerID", DbType:="Int")>  _
	Public Property ManagerID() As System.Nullable(Of Integer)
		Get
			Return Me._ManagerID
		End Get
		Set
			If (Me._ManagerID.Equals(value) = false) Then
				If Me._Employee.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnManagerIDChanging(value)
				Me.SendPropertyChanging
				Me._ManagerID = value
				Me.SendPropertyChanged("ManagerID")
				Me.OnManagerIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Title", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Title() As String
		Get
			Return Me._Title
		End Get
		Set
			If ((Me._Title = value)  _
						= false) Then
				Me.OnTitleChanging(value)
				Me.SendPropertyChanging
				Me._Title = value
				Me.SendPropertyChanged("Title")
				Me.OnTitleChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_BirthDate", DbType:="DateTime NOT NULL")>  _
	Public Property BirthDate() As Date
		Get
			Return Me._BirthDate
		End Get
		Set
			If ((Me._BirthDate = value)  _
						= false) Then
				Me.OnBirthDateChanging(value)
				Me.SendPropertyChanging
				Me._BirthDate = value
				Me.SendPropertyChanged("BirthDate")
				Me.OnBirthDateChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_MaritalStatus", DbType:="NChar(1) NOT NULL")>  _
	Public Property MaritalStatus() As Char
		Get
			Return Me._MaritalStatus
		End Get
		Set
			If ((Me._MaritalStatus = value)  _
						= false) Then
				Me.OnMaritalStatusChanging(value)
				Me.SendPropertyChanging
				Me._MaritalStatus = value
				Me.SendPropertyChanged("MaritalStatus")
				Me.OnMaritalStatusChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Gender", DbType:="NChar(1) NOT NULL")>  _
	Public Property Gender() As Char
		Get
			Return Me._Gender
		End Get
		Set
			If ((Me._Gender = value)  _
						= false) Then
				Me.OnGenderChanging(value)
				Me.SendPropertyChanging
				Me._Gender = value
				Me.SendPropertyChanged("Gender")
				Me.OnGenderChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_HireDate", DbType:="DateTime NOT NULL")>  _
	Public Property HireDate() As Date
		Get
			Return Me._HireDate
		End Get
		Set
			If ((Me._HireDate = value)  _
						= false) Then
				Me.OnHireDateChanging(value)
				Me.SendPropertyChanging
				Me._HireDate = value
				Me.SendPropertyChanged("HireDate")
				Me.OnHireDateChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_SalariedFlag", DbType:="Bit NOT NULL")>  _
	Public Property SalariedFlag() As Boolean
		Get
			Return Me._SalariedFlag
		End Get
		Set
			If ((Me._SalariedFlag = value)  _
						= false) Then
				Me.OnSalariedFlagChanging(value)
				Me.SendPropertyChanging
				Me._SalariedFlag = value
				Me.SendPropertyChanged("SalariedFlag")
				Me.OnSalariedFlagChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_VacationHours", DbType:="SmallInt NOT NULL")>  _
	Public Property VacationHours() As Short
		Get
			Return Me._VacationHours
		End Get
		Set
			If ((Me._VacationHours = value)  _
						= false) Then
				Me.OnVacationHoursChanging(value)
				Me.SendPropertyChanging
				Me._VacationHours = value
				Me.SendPropertyChanged("VacationHours")
				Me.OnVacationHoursChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_SickLeaveHours", DbType:="SmallInt NOT NULL")>  _
	Public Property SickLeaveHours() As Short
		Get
			Return Me._SickLeaveHours
		End Get
		Set
			If ((Me._SickLeaveHours = value)  _
						= false) Then
				Me.OnSickLeaveHoursChanging(value)
				Me.SendPropertyChanging
				Me._SickLeaveHours = value
				Me.SendPropertyChanged("SickLeaveHours")
				Me.OnSickLeaveHoursChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_CurrentFlag", DbType:="Bit NOT NULL")>  _
	Public Property CurrentFlag() As Boolean
		Get
			Return Me._CurrentFlag
		End Get
		Set
			If ((Me._CurrentFlag = value)  _
						= false) Then
				Me.OnCurrentFlagChanging(value)
				Me.SendPropertyChanging
				Me._CurrentFlag = value
				Me.SendPropertyChanged("CurrentFlag")
				Me.OnCurrentFlagChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_rowguid", DbType:="UniqueIdentifier NOT NULL")>  _
	Public Property rowguid() As System.Guid
		Get
			Return Me._rowguid
		End Get
		Set
			If ((Me._rowguid = value)  _
						= false) Then
				Me.OnrowguidChanging(value)
				Me.SendPropertyChanging
				Me._rowguid = value
				Me.SendPropertyChanged("rowguid")
				Me.OnrowguidChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ModifiedDate", DbType:="DateTime NOT NULL")>  _
	Public Property ModifiedDate() As Date
		Get
			Return Me._ModifiedDate
		End Get
		Set
			If ((Me._ModifiedDate = value)  _
						= false) Then
				Me.OnModifiedDateChanging(value)
				Me.SendPropertyChanging
				Me._ModifiedDate = value
				Me.SendPropertyChanged("ModifiedDate")
				Me.OnModifiedDateChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Employee_Employee", Storage:="_Employees", OtherKey:="ManagerID")>  _
	Public Property Employees() As EntitySet(Of Employee)
		Get
			Return Me._Employees
		End Get
		Set
			Me._Employees.Assign(value)
		End Set
	End Property
	
	<Association(Name:="Contact_Employee", Storage:="_Contact", ThisKey:="ContactID", IsForeignKey:=true)>  _
	Public Property Contact() As Contact
		Get
			Return Me._Contact.Entity
		End Get
		Set
			Dim previousValue As Contact = Me._Contact.Entity
			If (((previousValue Is value)  _
						= false)  _
						OrElse (Me._Contact.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Contact.Entity = Nothing
					previousValue.Employees.Remove(Me)
				End If
				Me._Contact.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Employees.Add(Me)
					Me._ContactID = value.ContactID
				Else
					Me._ContactID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Contact")
			End If
		End Set
	End Property
	
	<Association(Name:="Employee_Employee", Storage:="_Employee", ThisKey:="ManagerID", IsForeignKey:=true)>  _
	Public Property Employee() As Employee
		Get
			Return Me._Employee.Entity
		End Get
		Set
			Dim previousValue As Employee = Me._Employee.Entity
			If (((previousValue Is value)  _
						= false)  _
						OrElse (Me._Employee.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Employee.Entity = Nothing
					previousValue.Employees.Remove(Me)
				End If
				Me._Employee.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Employees.Add(Me)
					Me._ManagerID = value.EmployeeID
				Else
					Me._ManagerID = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("Employee")
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
	
	Private Sub attach_Employees(ByVal entity As Employee)
		Me.SendPropertyChanging
		entity.Employee = Me
		Me.SendPropertyChanged("Employees")
	End Sub
	
	Private Sub detach_Employees(ByVal entity As Employee)
		Me.SendPropertyChanging
		entity.Employee = Nothing
		Me.SendPropertyChanged("Employees")
	End Sub
End Class