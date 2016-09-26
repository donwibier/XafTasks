using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace XafTasks.Module.BusinessObjects.XafTasksDB
{
    [DefaultProperty("Name")]
    public partial class TaskFile
    {
        public TaskFile(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private FileData _Document;
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        [FileTypeFilter("DocumentFiles", 1, "*.txt", "*.doc", "*.pdf")]
        [FileTypeFilter("AllFiles", 2, "*.*")]
        public FileData Document
        {
            get { return _Document; }
            set { SetPropertyValue("Document", ref _Document, value); }
        }
    }

}
