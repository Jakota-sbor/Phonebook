﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phonebook
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PhonebookDB")]
	public partial class PhoneBookDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertAddresses(Addresses instance);
    partial void UpdateAddresses(Addresses instance);
    partial void DeleteAddresses(Addresses instance);
    partial void InsertPhones(Phones instance);
    partial void UpdatePhones(Phones instance);
    partial void DeletePhones(Phones instance);
    partial void InsertPersons(Persons instance);
    partial void UpdatePersons(Persons instance);
    partial void DeletePersons(Persons instance);
    #endregion
		
		public PhoneBookDataContext() : 
				base(global::Phonebook.Properties.Settings.Default.PhonebookDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PhoneBookDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PhoneBookDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PhoneBookDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PhoneBookDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Addresses> Addresses
		{
			get
			{
				return this.GetTable<Addresses>();
			}
		}
		
		public System.Data.Linq.Table<Phones> Phones
		{
			get
			{
				return this.GetTable<Phones>();
			}
		}
		
		public System.Data.Linq.Table<Persons> Persons
		{
			get
			{
				return this.GetTable<Persons>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SearchPerson")]
		public ISingleResult<SearchPersonResult> SearchPerson([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string lastname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string firstname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string middlename, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string city, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string street, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string house, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string flat, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string phone)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), lastname, firstname, middlename, city, street, house, flat, phone);
			return ((ISingleResult<SearchPersonResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertPerson")]
		public int InsertPerson([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string lastname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string firstname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string middlename, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> borndate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string city, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string street, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string house, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string flat, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string phone)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), lastname, firstname, middlename, borndate, city, street, house, flat, phone);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Addresses")]
	public partial class Addresses : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PersonId;
		
		private string _City;
		
		private string _Street;
		
		private string _House;
		
		private string _HouseBlock;
		
		private string _Flat;
		
		private EntityRef<Persons> _Persons;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonIdChanging(int value);
    partial void OnPersonIdChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    partial void OnHouseChanging(string value);
    partial void OnHouseChanged();
    partial void OnHouseBlockChanging(string value);
    partial void OnHouseBlockChanged();
    partial void OnFlatChanging(string value);
    partial void OnFlatChanged();
    #endregion
		
		public Addresses()
		{
			this._Persons = default(EntityRef<Persons>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PersonId
		{
			get
			{
				return this._PersonId;
			}
			set
			{
				if ((this._PersonId != value))
				{
					if (this._Persons.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPersonIdChanging(value);
					this.SendPropertyChanging();
					this._PersonId = value;
					this.SendPropertyChanged("PersonId");
					this.OnPersonIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_House", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string House
		{
			get
			{
				return this._House;
			}
			set
			{
				if ((this._House != value))
				{
					this.OnHouseChanging(value);
					this.SendPropertyChanging();
					this._House = value;
					this.SendPropertyChanged("House");
					this.OnHouseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HouseBlock", DbType="VarChar(10)")]
		public string HouseBlock
		{
			get
			{
				return this._HouseBlock;
			}
			set
			{
				if ((this._HouseBlock != value))
				{
					this.OnHouseBlockChanging(value);
					this.SendPropertyChanging();
					this._HouseBlock = value;
					this.SendPropertyChanged("HouseBlock");
					this.OnHouseBlockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Flat", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Flat
		{
			get
			{
				return this._Flat;
			}
			set
			{
				if ((this._Flat != value))
				{
					this.OnFlatChanging(value);
					this.SendPropertyChanging();
					this._Flat = value;
					this.SendPropertyChanged("Flat");
					this.OnFlatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Persons_Addresses", Storage="_Persons", ThisKey="PersonId", OtherKey="PersonId", IsForeignKey=true)]
		public Persons Persons
		{
			get
			{
				return this._Persons.Entity;
			}
			set
			{
				Persons previousValue = this._Persons.Entity;
				if (((previousValue != value) 
							|| (this._Persons.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Persons.Entity = null;
						previousValue.Addresses = null;
					}
					this._Persons.Entity = value;
					if ((value != null))
					{
						value.Addresses = this;
						this._PersonId = value.PersonId;
					}
					else
					{
						this._PersonId = default(int);
					}
					this.SendPropertyChanged("Persons");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phones")]
	public partial class Phones : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PersonId;
		
		private string _Phonenumber;
		
		private EntityRef<Persons> _Persons;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonIdChanging(int value);
    partial void OnPersonIdChanged();
    partial void OnPhonenumberChanging(string value);
    partial void OnPhonenumberChanged();
    #endregion
		
		public Phones()
		{
			this._Persons = default(EntityRef<Persons>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PersonId
		{
			get
			{
				return this._PersonId;
			}
			set
			{
				if ((this._PersonId != value))
				{
					if (this._Persons.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPersonIdChanging(value);
					this.SendPropertyChanging();
					this._PersonId = value;
					this.SendPropertyChanged("PersonId");
					this.OnPersonIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phonenumber", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Phonenumber
		{
			get
			{
				return this._Phonenumber;
			}
			set
			{
				if ((this._Phonenumber != value))
				{
					this.OnPhonenumberChanging(value);
					this.SendPropertyChanging();
					this._Phonenumber = value;
					this.SendPropertyChanged("Phonenumber");
					this.OnPhonenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Persons_Phones", Storage="_Persons", ThisKey="PersonId", OtherKey="PersonId", IsForeignKey=true)]
		public Persons Persons
		{
			get
			{
				return this._Persons.Entity;
			}
			set
			{
				Persons previousValue = this._Persons.Entity;
				if (((previousValue != value) 
							|| (this._Persons.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Persons.Entity = null;
						previousValue.Phones = null;
					}
					this._Persons.Entity = value;
					if ((value != null))
					{
						value.Phones = this;
						this._PersonId = value.PersonId;
					}
					else
					{
						this._PersonId = default(int);
					}
					this.SendPropertyChanged("Persons");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Persons")]
	public partial class Persons : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PersonId;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private System.DateTime _BornDate;
		
		private EntityRef<Addresses> _Addresses;
		
		private EntityRef<Phones> _Phones;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonIdChanging(int value);
    partial void OnPersonIdChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnMiddleNameChanging(string value);
    partial void OnMiddleNameChanged();
    partial void OnBornDateChanging(System.DateTime value);
    partial void OnBornDateChanged();
    #endregion
		
		public Persons()
		{
			this._Addresses = default(EntityRef<Addresses>);
			this._Phones = default(EntityRef<Phones>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PersonId
		{
			get
			{
				return this._PersonId;
			}
			set
			{
				if ((this._PersonId != value))
				{
					this.OnPersonIdChanging(value);
					this.SendPropertyChanging();
					this._PersonId = value;
					this.SendPropertyChanged("PersonId");
					this.OnPersonIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this.OnMiddleNameChanging(value);
					this.SendPropertyChanging();
					this._MiddleName = value;
					this.SendPropertyChanged("MiddleName");
					this.OnMiddleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BornDate", DbType="DateTime NOT NULL")]
		public System.DateTime BornDate
		{
			get
			{
				return this._BornDate;
			}
			set
			{
				if ((this._BornDate != value))
				{
					this.OnBornDateChanging(value);
					this.SendPropertyChanging();
					this._BornDate = value;
					this.SendPropertyChanged("BornDate");
					this.OnBornDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Persons_Addresses", Storage="_Addresses", ThisKey="PersonId", OtherKey="PersonId", IsUnique=true, IsForeignKey=false)]
		public Addresses Addresses
		{
			get
			{
				return this._Addresses.Entity;
			}
			set
			{
				Addresses previousValue = this._Addresses.Entity;
				if (((previousValue != value) 
							|| (this._Addresses.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Addresses.Entity = null;
						previousValue.Persons = null;
					}
					this._Addresses.Entity = value;
					if ((value != null))
					{
						value.Persons = this;
					}
					this.SendPropertyChanged("Addresses");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Persons_Phones", Storage="_Phones", ThisKey="PersonId", OtherKey="PersonId", IsUnique=true, IsForeignKey=false)]
		public Phones Phones
		{
			get
			{
				return this._Phones.Entity;
			}
			set
			{
				Phones previousValue = this._Phones.Entity;
				if (((previousValue != value) 
							|| (this._Phones.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phones.Entity = null;
						previousValue.Persons = null;
					}
					this._Phones.Entity = value;
					if ((value != null))
					{
						value.Persons = this;
					}
					this.SendPropertyChanged("Phones");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class SearchPersonResult
	{
		
		private int _PersonId;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private System.DateTime _BornDate;
		
		private System.Nullable<int> _PersonId1;
		
		private string _Phonenumber;
		
		private System.Nullable<int> _PersonId2;
		
		private string _City;
		
		private string _Street;
		
		private string _House;
		
		private string _Flat;
		
		public SearchPersonResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonId", DbType="Int NOT NULL")]
		public int PersonId
		{
			get
			{
				return this._PersonId;
			}
			set
			{
				if ((this._PersonId != value))
				{
					this._PersonId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this._MiddleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BornDate", DbType="DateTime NOT NULL")]
		public System.DateTime BornDate
		{
			get
			{
				return this._BornDate;
			}
			set
			{
				if ((this._BornDate != value))
				{
					this._BornDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonId1", DbType="Int")]
		public System.Nullable<int> PersonId1
		{
			get
			{
				return this._PersonId1;
			}
			set
			{
				if ((this._PersonId1 != value))
				{
					this._PersonId1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phonenumber", DbType="VarChar(20)")]
		public string Phonenumber
		{
			get
			{
				return this._Phonenumber;
			}
			set
			{
				if ((this._Phonenumber != value))
				{
					this._Phonenumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonId2", DbType="Int")]
		public System.Nullable<int> PersonId2
		{
			get
			{
				return this._PersonId2;
			}
			set
			{
				if ((this._PersonId2 != value))
				{
					this._PersonId2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="NVarChar(50)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this._Street = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_House", DbType="VarChar(10)")]
		public string House
		{
			get
			{
				return this._House;
			}
			set
			{
				if ((this._House != value))
				{
					this._House = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Flat", DbType="VarChar(10)")]
		public string Flat
		{
			get
			{
				return this._Flat;
			}
			set
			{
				if ((this._Flat != value))
				{
					this._Flat = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
