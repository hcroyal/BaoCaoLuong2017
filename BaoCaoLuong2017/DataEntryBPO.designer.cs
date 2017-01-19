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

namespace BaoCaoLuong2017
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DatabaseDataEntryBPO")]
	public partial class DataEntryBPODataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_User(tbl_User instance);
    partial void Updatetbl_User(tbl_User instance);
    partial void Deletetbl_User(tbl_User instance);
    #endregion
		
		public DataEntryBPODataContext() : 
				base(global::BaoCaoLuong2017.Properties.Settings.Default.DatabaseDataEntryBPOConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataEntryBPODataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEntryBPODataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEntryBPODataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEntryBPODataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Role> tbl_Roles
		{
			get
			{
				return this.GetTable<tbl_Role>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Version> tbl_Versions
		{
			get
			{
				return this.GetTable<tbl_Version>();
			}
		}
		
		public System.Data.Linq.Table<tbl_User> tbl_Users
		{
			get
			{
				return this.GetTable<tbl_User>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KiemTraLogin")]
		public int KiemTraLogin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(100)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertLoginTime")]
		public int InsertLoginTime([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(100)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeLogin", DbType="DateTime")] System.Nullable<System.DateTime> timeLogin, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WindowUser", DbType="NVarChar(100)")] string windowUser, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MachineName", DbType="NVarChar(100)")] string machineName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IPAddress", DbType="NVarChar(100)")] string iPAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Token", DbType="NVarChar(100)")] string token)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, timeLogin, windowUser, machineName, iPAddress, token);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetListUserToKiemDinh")]
		public ISingleResult<GetListUserToKiemDinhResult> GetListUserToKiemDinh()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetListUserToKiemDinhResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetListRole")]
		public ISingleResult<GetListRoleResult> GetListRole()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetListRoleResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteUsername")]
		public int DeleteUsername([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(100)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateUsername_BaoCaoLuong")]
		public int UpdateUsername_BaoCaoLuong([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(100)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRole", DbType="NVarChar(100)")] string iDRole, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDNhanVien", DbType="NVarChar(100)")] string iDNhanVien, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GroupLevel", DbType="NVarChar(100)")] string groupLevel)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password, iDRole, iDNhanVien, groupLevel);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertUsername_BapCaoLuong")]
		public int InsertUsername_BapCaoLuong([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(100)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRole", DbType="NVarChar(100)")] string iDRole, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NhanVien", DbType="NVarChar(100)")] string nhanVien, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GroupLevel", DbType="NVarChar(100)")] string groupLevel)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password, iDRole, nhanVien, groupLevel);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Role")]
	public partial class tbl_Role
	{
		
		private string _RoleID;
		
		private string _RoleName;
		
		private string _GhiChu;
		
		public tbl_Role()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					this._RoleID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NVarChar(100)")]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this._RoleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(100)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this._GhiChu = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Version")]
	public partial class tbl_Version
	{
		
		private string _IDProject;
		
		private string _IDVersion;
		
		private int _ID_int_auto;
		
		private string _MoTaChucNangMoi;
		
		public tbl_Version()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDProject", DbType="NVarChar(150)")]
		public string IDProject
		{
			get
			{
				return this._IDProject;
			}
			set
			{
				if ((this._IDProject != value))
				{
					this._IDProject = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDVersion", DbType="NVarChar(100)")]
		public string IDVersion
		{
			get
			{
				return this._IDVersion;
			}
			set
			{
				if ((this._IDVersion != value))
				{
					this._IDVersion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_int_auto", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID_int_auto
		{
			get
			{
				return this._ID_int_auto;
			}
			set
			{
				if ((this._ID_int_auto != value))
				{
					this._ID_int_auto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTaChucNangMoi", DbType="NVarChar(200)")]
		public string MoTaChucNangMoi
		{
			get
			{
				return this._MoTaChucNangMoi;
			}
			set
			{
				if ((this._MoTaChucNangMoi != value))
				{
					this._MoTaChucNangMoi = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_User")]
	public partial class tbl_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private string _IDRole;
		
		private string _IDNhanVien;
		
		private string _Group_Level;
		
		private string _FullName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnIDRoleChanging(string value);
    partial void OnIDRoleChanged();
    partial void OnIDNhanVienChanging(string value);
    partial void OnIDNhanVienChanged();
    partial void OnGroup_LevelChanging(string value);
    partial void OnGroup_LevelChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    #endregion
		
		public tbl_User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(100)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDRole", DbType="NVarChar(100)")]
		public string IDRole
		{
			get
			{
				return this._IDRole;
			}
			set
			{
				if ((this._IDRole != value))
				{
					this.OnIDRoleChanging(value);
					this.SendPropertyChanging();
					this._IDRole = value;
					this.SendPropertyChanged("IDRole");
					this.OnIDRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNhanVien", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string IDNhanVien
		{
			get
			{
				return this._IDNhanVien;
			}
			set
			{
				if ((this._IDNhanVien != value))
				{
					this.OnIDNhanVienChanging(value);
					this.SendPropertyChanging();
					this._IDNhanVien = value;
					this.SendPropertyChanged("IDNhanVien");
					this.OnIDNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_Level", DbType="NVarChar(100)")]
		public string Group_Level
		{
			get
			{
				return this._Group_Level;
			}
			set
			{
				if ((this._Group_Level != value))
				{
					this.OnGroup_LevelChanging(value);
					this.SendPropertyChanging();
					this._Group_Level = value;
					this.SendPropertyChanged("Group_Level");
					this.OnGroup_LevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(100)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
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
	
	public partial class GetListUserToKiemDinhResult
	{
		
		private string _Username;
		
		private string _FullName;
		
		private string _Password;
		
		private string _IDRole;
		
		private string _Group_Level;
		
		public GetListUserToKiemDinhResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(100)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(100)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDRole", DbType="NVarChar(100)")]
		public string IDRole
		{
			get
			{
				return this._IDRole;
			}
			set
			{
				if ((this._IDRole != value))
				{
					this._IDRole = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_Level", DbType="NVarChar(100)")]
		public string Group_Level
		{
			get
			{
				return this._Group_Level;
			}
			set
			{
				if ((this._Group_Level != value))
				{
					this._Group_Level = value;
				}
			}
		}
	}
	
	public partial class GetListRoleResult
	{
		
		private string _RoleID;
		
		private string _RoleName;
		
		private string _GhiChu;
		
		public GetListRoleResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					this._RoleID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NVarChar(100)")]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this._RoleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(100)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this._GhiChu = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
