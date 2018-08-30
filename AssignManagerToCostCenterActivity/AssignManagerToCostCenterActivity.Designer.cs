using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Reflection;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace FIM.AssignManagerToCostCenterActivity
{
    public partial class AssignManagerToCostCenterActivity
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("", "")]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            this.InitializeEnumUser = new System.Workflow.Activities.CodeActivity();
            this.readUser = new Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity();
            this.initializeReadCostCenter = new System.Workflow.Activities.CodeActivity();
            this.ReadCurrentRequest = new Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity();
            // 
            // InitializeEnumUser
            // 
            this.InitializeEnumUser.Name = "InitializeEnumUser";
            this.InitializeEnumUser.ExecuteCode += new System.EventHandler(this.InitializeEnumUser_ExecuteCode);
            // 
            // readUser
            // 
            activitybind1.Name = "AssignManagerToCostCenterActivity";
            activitybind1.Path = "readUser_ActorId1";
            this.readUser.Name = "readUser";
            activitybind2.Name = "AssignManagerToCostCenterActivity";
            activitybind2.Path = "readUser_Resource1";
            activitybind3.Name = "AssignManagerToCostCenterActivity";
            activitybind3.Path = "readUser_ResourceId1";
            activitybind4.Name = "AssignManagerToCostCenterActivity";
            activitybind4.Path = "readUser_SelectionAttributes1";
            this.readUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ActorIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.readUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ResourceProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.readUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ResourceIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.readUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.SelectionAttributesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            // 
            // initializeReadCostCenter
            // 
            this.initializeReadCostCenter.Name = "initializeReadCostCenter";
            this.initializeReadCostCenter.ExecuteCode += new System.EventHandler(this.initializeReadCostCenter_ExecuteCode);
            // 
            // ReadCurrentRequest
            // 
            activitybind5.Name = "AssignManagerToCostCenterActivity";
            activitybind5.Path = "ReadCurrentRequest_CurrentRequest1";
            this.ReadCurrentRequest.Name = "ReadCurrentRequest";
            this.ReadCurrentRequest.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity.CurrentRequestProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // AssignManagerToCostCenterActivity
            // 
            this.Activities.Add(this.ReadCurrentRequest);
            this.Activities.Add(this.initializeReadCostCenter);
            this.Activities.Add(this.readUser);
            this.Activities.Add(this.InitializeEnumUser);
            this.Name = "AssignManagerToCostCenterActivity";
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity initializeReadCostCenter;

        private Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity readUser;

        private CodeActivity InitializeEnumUser;

        private Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity ReadCurrentRequest;





    }
}
