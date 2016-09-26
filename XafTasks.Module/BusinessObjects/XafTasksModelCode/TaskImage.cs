using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Base;

namespace XafTasks.Module.BusinessObjects.XafTasksDB
{
    [DefaultProperty("Name")]
    public partial class TaskImage
    {
        public TaskImage(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [Size(SizeAttribute.Unlimited), Delayed(), VisibleInListViewAttribute(true)]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PopupPictureEdit, 
            DetailViewImageEditorMode = ImageEditorMode.DropDownPictureEdit)]
        public byte[] Image
        {
            get { return GetDelayedPropertyValue<byte[]>("Image"); }
            set { SetDelayedPropertyValue<byte[]>("Image", value); }
        }

    }

}
