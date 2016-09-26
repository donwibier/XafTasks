using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;
namespace XafTasks.Module.BusinessObjects.XafTasksDB
{
    [NavigationItem("Default")]
    [DefaultProperty("Name")]
    public partial class Group
    {
        public Group(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

    }

}
