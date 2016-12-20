﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Book.UI.AccountPayable.AcOtherShouldCollection
{
    public partial class ListForm : Settings.BasicData.BaseListForm
    {
        public ListForm()
        {
            InitializeComponent();
            this.manager = new BL.AcOtherShouldCollectionManager();
        }
        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <returns></returns>
        protected override Book.UI.Settings.BasicData.BaseEditForm GetEditForm()
        {
            return new AccountPayable.AcOtherShouldCollection.EditForm();
        }
        public Model.AcOtherShouldCollection SelectItem
        {
            get { return this.bindingSource1.Current as Model.AcOtherShouldCollection; }
        }
        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        protected override Book.UI.Settings.BasicData.BaseEditForm GetEditForm(object[] args)
        {
            Type type = typeof(EditForm);
            return (EditForm)type.Assembly.CreateInstance(type.FullName, false, System.Reflection.BindingFlags.CreateInstance, null, args, null, null);
        }
    }
}