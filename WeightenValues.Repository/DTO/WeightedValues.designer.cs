﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeightenValues.Repository.DTO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="weightedvalues_db")]
	public partial class WeightedValuesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEducation(Education instance);
    partial void UpdateEducation(Education instance);
    partial void DeleteEducation(Education instance);
    partial void InsertEducationKeyword(EducationKeyword instance);
    partial void UpdateEducationKeyword(EducationKeyword instance);
    partial void DeleteEducationKeyword(EducationKeyword instance);
    partial void InsertKeyword(Keyword instance);
    partial void UpdateKeyword(Keyword instance);
    partial void DeleteKeyword(Keyword instance);
    #endregion
		
		public WeightedValuesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["weightedvalues_dbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WeightedValuesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeightedValuesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeightedValuesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeightedValuesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Education> Educations
		{
			get
			{
				return this.GetTable<Education>();
			}
		}
		
		public System.Data.Linq.Table<EducationKeyword> EducationKeywords
		{
			get
			{
				return this.GetTable<EducationKeyword>();
			}
		}
		
		public System.Data.Linq.Table<Keyword> Keywords
		{
			get
			{
				return this.GetTable<Keyword>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Education")]
	public partial class Education : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private EntitySet<EducationKeyword> _EducationKeywords;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Education()
		{
			this._EducationKeywords = new EntitySet<EducationKeyword>(new Action<EducationKeyword>(this.attach_EducationKeywords), new Action<EducationKeyword>(this.detach_EducationKeywords));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Education_EducationKeyword", Storage="_EducationKeywords", ThisKey="ID", OtherKey="EducationID")]
		public EntitySet<EducationKeyword> EducationKeywords
		{
			get
			{
				return this._EducationKeywords;
			}
			set
			{
				this._EducationKeywords.Assign(value);
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
		
		private void attach_EducationKeywords(EducationKeyword entity)
		{
			this.SendPropertyChanging();
			entity.Education = this;
		}
		
		private void detach_EducationKeywords(EducationKeyword entity)
		{
			this.SendPropertyChanging();
			entity.Education = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EducationKeyword")]
	public partial class EducationKeyword : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EducationID;
		
		private int _KeywordID;
		
		private int _Weight;
		
		private EntityRef<Education> _Education;
		
		private EntityRef<Keyword> _Keyword;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEducationIDChanging(int value);
    partial void OnEducationIDChanged();
    partial void OnKeywordIDChanging(int value);
    partial void OnKeywordIDChanged();
    partial void OnWeightChanging(int value);
    partial void OnWeightChanged();
    #endregion
		
		public EducationKeyword()
		{
			this._Education = default(EntityRef<Education>);
			this._Keyword = default(EntityRef<Keyword>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EducationID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EducationID
		{
			get
			{
				return this._EducationID;
			}
			set
			{
				if ((this._EducationID != value))
				{
					if (this._Education.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEducationIDChanging(value);
					this.SendPropertyChanging();
					this._EducationID = value;
					this.SendPropertyChanged("EducationID");
					this.OnEducationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeywordID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int KeywordID
		{
			get
			{
				return this._KeywordID;
			}
			set
			{
				if ((this._KeywordID != value))
				{
					if (this._Keyword.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKeywordIDChanging(value);
					this.SendPropertyChanging();
					this._KeywordID = value;
					this.SendPropertyChanged("KeywordID");
					this.OnKeywordIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Int NOT NULL")]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Education_EducationKeyword", Storage="_Education", ThisKey="EducationID", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Education Education
		{
			get
			{
				return this._Education.Entity;
			}
			set
			{
				Education previousValue = this._Education.Entity;
				if (((previousValue != value) 
							|| (this._Education.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Education.Entity = null;
						previousValue.EducationKeywords.Remove(this);
					}
					this._Education.Entity = value;
					if ((value != null))
					{
						value.EducationKeywords.Add(this);
						this._EducationID = value.ID;
					}
					else
					{
						this._EducationID = default(int);
					}
					this.SendPropertyChanged("Education");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyword_EducationKeyword", Storage="_Keyword", ThisKey="KeywordID", OtherKey="ID", IsForeignKey=true)]
		public Keyword Keyword
		{
			get
			{
				return this._Keyword.Entity;
			}
			set
			{
				Keyword previousValue = this._Keyword.Entity;
				if (((previousValue != value) 
							|| (this._Keyword.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Keyword.Entity = null;
						previousValue.EducationKeywords.Remove(this);
					}
					this._Keyword.Entity = value;
					if ((value != null))
					{
						value.EducationKeywords.Add(this);
						this._KeywordID = value.ID;
					}
					else
					{
						this._KeywordID = default(int);
					}
					this.SendPropertyChanged("Keyword");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Keyword")]
	public partial class Keyword : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private EntitySet<EducationKeyword> _EducationKeywords;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Keyword()
		{
			this._EducationKeywords = new EntitySet<EducationKeyword>(new Action<EducationKeyword>(this.attach_EducationKeywords), new Action<EducationKeyword>(this.detach_EducationKeywords));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyword_EducationKeyword", Storage="_EducationKeywords", ThisKey="ID", OtherKey="KeywordID")]
		public EntitySet<EducationKeyword> EducationKeywords
		{
			get
			{
				return this._EducationKeywords;
			}
			set
			{
				this._EducationKeywords.Assign(value);
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
		
		private void attach_EducationKeywords(EducationKeyword entity)
		{
			this.SendPropertyChanging();
			entity.Keyword = this;
		}
		
		private void detach_EducationKeywords(EducationKeyword entity)
		{
			this.SendPropertyChanging();
			entity.Keyword = null;
		}
	}
}
#pragma warning restore 1591
