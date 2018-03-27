﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("db_the_recsModel", "FK_tb_the_comments_tb_the_recs", "tb_the_recs", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DAL.tb_the_recs), "tb_the_comments", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DAL.tb_the_comments), true)]

#endregion

namespace DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class db_the_recsEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new db_the_recsEntities object using the connection string found in the 'db_the_recsEntities' section of the application configuration file.
        /// </summary>
        public db_the_recsEntities() : base("name=db_the_recsEntities", "db_the_recsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new db_the_recsEntities object.
        /// </summary>
        public db_the_recsEntities(string connectionString) : base(connectionString, "db_the_recsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new db_the_recsEntities object.
        /// </summary>
        public db_the_recsEntities(EntityConnection connection) : base(connection, "db_the_recsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tb_the_comments> tb_the_comments
        {
            get
            {
                if ((_tb_the_comments == null))
                {
                    _tb_the_comments = base.CreateObjectSet<tb_the_comments>("tb_the_comments");
                }
                return _tb_the_comments;
            }
        }
        private ObjectSet<tb_the_comments> _tb_the_comments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tb_the_recs> tb_the_recs
        {
            get
            {
                if ((_tb_the_recs == null))
                {
                    _tb_the_recs = base.CreateObjectSet<tb_the_recs>("tb_the_recs");
                }
                return _tb_the_recs;
            }
        }
        private ObjectSet<tb_the_recs> _tb_the_recs;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tb_the_comments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_the_comments(tb_the_comments tb_the_comments)
        {
            base.AddObject("tb_the_comments", tb_the_comments);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tb_the_recs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_the_recs(tb_the_recs tb_the_recs)
        {
            base.AddObject("tb_the_recs", tb_the_recs);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="db_the_recsModel", Name="tb_the_comments")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_the_comments : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tb_the_comments object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="rec_the_Id">Initial value of the rec_the_Id property.</param>
        /// <param name="comments">Initial value of the comments property.</param>
        public static tb_the_comments Createtb_the_comments(global::System.Int64 id, global::System.Int64 rec_the_Id, global::System.String comments)
        {
            tb_the_comments tb_the_comments = new tb_the_comments();
            tb_the_comments.ID = id;
            tb_the_comments.rec_the_Id = rec_the_Id;
            tb_the_comments.comments = comments;
            return tb_the_comments;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 rec_the_Id
        {
            get
            {
                return _rec_the_Id;
            }
            set
            {
                Onrec_the_IdChanging(value);
                ReportPropertyChanging("rec_the_Id");
                _rec_the_Id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rec_the_Id");
                Onrec_the_IdChanged();
            }
        }
        private global::System.Int64 _rec_the_Id;
        partial void Onrec_the_IdChanging(global::System.Int64 value);
        partial void Onrec_the_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String comments
        {
            get
            {
                return _comments;
            }
            set
            {
                OncommentsChanging(value);
                ReportPropertyChanging("comments");
                _comments = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("comments");
                OncommentsChanged();
            }
        }
        private global::System.String _comments;
        partial void OncommentsChanging(global::System.String value);
        partial void OncommentsChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("db_the_recsModel", "FK_tb_the_comments_tb_the_recs", "tb_the_recs")]
        public tb_the_recs tb_the_recs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_the_recs>("db_the_recsModel.FK_tb_the_comments_tb_the_recs", "tb_the_recs").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_the_recs>("db_the_recsModel.FK_tb_the_comments_tb_the_recs", "tb_the_recs").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tb_the_recs> tb_the_recsReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_the_recs>("db_the_recsModel.FK_tb_the_comments_tb_the_recs", "tb_the_recs");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tb_the_recs>("db_the_recsModel.FK_tb_the_comments_tb_the_recs", "tb_the_recs", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="db_the_recsModel", Name="tb_the_recs")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_the_recs : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tb_the_recs object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static tb_the_recs Createtb_the_recs(global::System.Int64 id)
        {
            tb_the_recs tb_the_recs = new tb_the_recs();
            tb_the_recs.ID = id;
            return tb_the_recs;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String rec
        {
            get
            {
                return _rec;
            }
            set
            {
                OnrecChanging(value);
                ReportPropertyChanging("rec");
                _rec = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("rec");
                OnrecChanged();
            }
        }
        private global::System.String _rec;
        partial void OnrecChanging(global::System.String value);
        partial void OnrecChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("db_the_recsModel", "FK_tb_the_comments_tb_the_recs", "tb_the_comments")]
        public EntityCollection<tb_the_comments> tb_the_comments
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tb_the_comments>("db_the_recsModel.FK_tb_the_comments_tb_the_recs", "tb_the_comments");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tb_the_comments>("db_the_recsModel.FK_tb_the_comments_tb_the_recs", "tb_the_comments", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
