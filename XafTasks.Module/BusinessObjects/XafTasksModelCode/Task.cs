using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace XafTasks.Module.BusinessObjects.XafTasksDB
{
    [NavigationItem("Default")]
    [DefaultProperty("Title")]
    public partial class Task
    {
        public Task(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


    }

}
