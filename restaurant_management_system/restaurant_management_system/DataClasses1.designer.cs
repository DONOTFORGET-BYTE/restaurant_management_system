﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace restaurant_management_system
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="newtryx")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertrestaurant(restaurant instance);
    partial void Updaterestaurant(restaurant instance);
    partial void Deleterestaurant(restaurant instance);
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertreservation(reservation instance);
    partial void Updatereservation(reservation instance);
    partial void Deletereservation(reservation instance);
    partial void Insertorder(order instance);
    partial void Updateorder(order instance);
    partial void Deleteorder(order instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["newtryxConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<restaurant> restaurants
		{
			get
			{
				return this.GetTable<restaurant>();
			}
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<reservation> reservations
		{
			get
			{
				return this.GetTable<reservation>();
			}
		}
		
		public System.Data.Linq.Table<order> orders
		{
			get
			{
				return this.GetTable<order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.restaurants")]
	public partial class restaurant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _restaurant_id;
		
		private string _restaurant_name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onrestaurant_idChanging(int value);
    partial void Onrestaurant_idChanged();
    partial void Onrestaurant_nameChanging(string value);
    partial void Onrestaurant_nameChanged();
    #endregion
		
		public restaurant()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_restaurant_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int restaurant_id
		{
			get
			{
				return this._restaurant_id;
			}
			set
			{
				if ((this._restaurant_id != value))
				{
					this.Onrestaurant_idChanging(value);
					this.SendPropertyChanging();
					this._restaurant_id = value;
					this.SendPropertyChanged("restaurant_id");
					this.Onrestaurant_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_restaurant_name", DbType="VarChar(50)")]
		public string restaurant_name
		{
			get
			{
				return this._restaurant_name;
			}
			set
			{
				if ((this._restaurant_name != value))
				{
					this.Onrestaurant_nameChanging(value);
					this.SendPropertyChanging();
					this._restaurant_name = value;
					this.SendPropertyChanged("restaurant_name");
					this.Onrestaurant_nameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customers")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _customer_id;
		
		private string _customer_email;
		
		private System.Nullable<int> _restaurant_id;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncustomer_idChanging(int value);
    partial void Oncustomer_idChanged();
    partial void Oncustomer_emailChanging(string value);
    partial void Oncustomer_emailChanged();
    partial void Onrestaurant_idChanging(System.Nullable<int> value);
    partial void Onrestaurant_idChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_email", DbType="VarChar(50)")]
		public string customer_email
		{
			get
			{
				return this._customer_email;
			}
			set
			{
				if ((this._customer_email != value))
				{
					this.Oncustomer_emailChanging(value);
					this.SendPropertyChanging();
					this._customer_email = value;
					this.SendPropertyChanged("customer_email");
					this.Oncustomer_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_restaurant_id", DbType="Int")]
		public System.Nullable<int> restaurant_id
		{
			get
			{
				return this._restaurant_id;
			}
			set
			{
				if ((this._restaurant_id != value))
				{
					this.Onrestaurant_idChanging(value);
					this.SendPropertyChanging();
					this._restaurant_id = value;
					this.SendPropertyChanged("restaurant_id");
					this.Onrestaurant_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reservation")]
	public partial class reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _reservation_id;
		
		private string _purpose;
		
		private string _type_of_table;
		
		private System.Nullable<System.DateTime> _startdatetime;
		
		private string _description;
		
		private System.Nullable<int> _customer_id;
		
		private string _reservation_status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onreservation_idChanging(int value);
    partial void Onreservation_idChanged();
    partial void OnpurposeChanging(string value);
    partial void OnpurposeChanged();
    partial void Ontype_of_tableChanging(string value);
    partial void Ontype_of_tableChanged();
    partial void OnstartdatetimeChanging(System.Nullable<System.DateTime> value);
    partial void OnstartdatetimeChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void Oncustomer_idChanging(System.Nullable<int> value);
    partial void Oncustomer_idChanged();
    partial void Onreservation_statusChanging(string value);
    partial void Onreservation_statusChanged();
    #endregion
		
		public reservation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reservation_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int reservation_id
		{
			get
			{
				return this._reservation_id;
			}
			set
			{
				if ((this._reservation_id != value))
				{
					this.Onreservation_idChanging(value);
					this.SendPropertyChanging();
					this._reservation_id = value;
					this.SendPropertyChanged("reservation_id");
					this.Onreservation_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purpose", DbType="VarChar(50)")]
		public string purpose
		{
			get
			{
				return this._purpose;
			}
			set
			{
				if ((this._purpose != value))
				{
					this.OnpurposeChanging(value);
					this.SendPropertyChanging();
					this._purpose = value;
					this.SendPropertyChanged("purpose");
					this.OnpurposeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_of_table", DbType="VarChar(50)")]
		public string type_of_table
		{
			get
			{
				return this._type_of_table;
			}
			set
			{
				if ((this._type_of_table != value))
				{
					this.Ontype_of_tableChanging(value);
					this.SendPropertyChanging();
					this._type_of_table = value;
					this.SendPropertyChanged("type_of_table");
					this.Ontype_of_tableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_startdatetime", DbType="DateTime")]
		public System.Nullable<System.DateTime> startdatetime
		{
			get
			{
				return this._startdatetime;
			}
			set
			{
				if ((this._startdatetime != value))
				{
					this.OnstartdatetimeChanging(value);
					this.SendPropertyChanging();
					this._startdatetime = value;
					this.SendPropertyChanged("startdatetime");
					this.OnstartdatetimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(50)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int")]
		public System.Nullable<int> customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reservation_status", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string reservation_status
		{
			get
			{
				return this._reservation_status;
			}
			set
			{
				if ((this._reservation_status != value))
				{
					this.Onreservation_statusChanging(value);
					this.SendPropertyChanging();
					this._reservation_status = value;
					this.SendPropertyChanged("reservation_status");
					this.Onreservation_statusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[order]")]
	public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _order_id;
		
		private string _order_name;
		
		private System.Nullable<decimal> _order_price;
		
		private System.Nullable<int> _customer_id;
		
		private System.Nullable<int> _restaurant_id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onorder_idChanging(int value);
    partial void Onorder_idChanged();
    partial void Onorder_nameChanging(string value);
    partial void Onorder_nameChanged();
    partial void Onorder_priceChanging(System.Nullable<decimal> value);
    partial void Onorder_priceChanged();
    partial void Oncustomer_idChanging(System.Nullable<int> value);
    partial void Oncustomer_idChanged();
    partial void Onrestaurant_idChanging(System.Nullable<int> value);
    partial void Onrestaurant_idChanged();
    #endregion
		
		public order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int order_id
		{
			get
			{
				return this._order_id;
			}
			set
			{
				if ((this._order_id != value))
				{
					this.Onorder_idChanging(value);
					this.SendPropertyChanging();
					this._order_id = value;
					this.SendPropertyChanged("order_id");
					this.Onorder_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_name", DbType="VarChar(50)")]
		public string order_name
		{
			get
			{
				return this._order_name;
			}
			set
			{
				if ((this._order_name != value))
				{
					this.Onorder_nameChanging(value);
					this.SendPropertyChanging();
					this._order_name = value;
					this.SendPropertyChanged("order_name");
					this.Onorder_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_price", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> order_price
		{
			get
			{
				return this._order_price;
			}
			set
			{
				if ((this._order_price != value))
				{
					this.Onorder_priceChanging(value);
					this.SendPropertyChanging();
					this._order_price = value;
					this.SendPropertyChanged("order_price");
					this.Onorder_priceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int")]
		public System.Nullable<int> customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_restaurant_id", DbType="Int")]
		public System.Nullable<int> restaurant_id
		{
			get
			{
				return this._restaurant_id;
			}
			set
			{
				if ((this._restaurant_id != value))
				{
					this.Onrestaurant_idChanging(value);
					this.SendPropertyChanging();
					this._restaurant_id = value;
					this.SendPropertyChanged("restaurant_id");
					this.Onrestaurant_idChanged();
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
}
#pragma warning restore 1591