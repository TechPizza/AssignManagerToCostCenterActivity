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
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind13 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind14 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind15 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind16 = new System.Workflow.ComponentModel.ActivityBind();
            this.updateCostCenter = new Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity();
            this.initializeUpdate = new System.Workflow.Activities.CodeActivity();
            this.ifElseBranchActivity2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ManagerFound = new System.Workflow.Activities.IfElseBranchActivity();
            this.IterateEnumManager = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.initIfElse = new System.Workflow.Activities.CodeActivity();
            this.enumManager = new Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity();
            this.InitializeEnumManager = new System.Workflow.Activities.CodeActivity();
            this.ReadCostCenter = new Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity();
            this.initializeReadCostCenter = new System.Workflow.Activities.CodeActivity();
            this.ReadCurrentRequest = new Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity();
            // 
            // updateCostCenter
            // 
            activitybind1.Name = "AssignManagerToCostCenterActivity";
            activitybind1.Path = "updateCostCenter_ActorId1";
            activitybind2.Name = "AssignManagerToCostCenterActivity";
            activitybind2.Path = "updateCostCenter_ApplyAuthorizationPolicy1";
            activitybind3.Name = "AssignManagerToCostCenterActivity";
            activitybind3.Path = "updateCostCenter_AuthorizationWaitTimeInSeconds1";
            this.updateCostCenter.Name = "updateCostCenter";
            activitybind4.Name = "AssignManagerToCostCenterActivity";
            activitybind4.Path = "updateCostCenter_ResourceId1";
            activitybind5.Name = "AssignManagerToCostCenterActivity";
            activitybind5.Path = "updateCostCenter_UpdateParameters1";
            this.updateCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.ActorIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.updateCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.ApplyAuthorizationPolicyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.updateCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.ResourceIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.updateCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.UpdateParametersProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.updateCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.AuthorizationWaitTimeInSecondsProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // initializeUpdate
            // 
            this.initializeUpdate.Name = "initializeUpdate";
            this.initializeUpdate.ExecuteCode += new System.EventHandler(this.InitializeUpdate_ExecuteCode);
            // 
            // ifElseBranchActivity2
            // 
            this.ifElseBranchActivity2.Name = "ifElseBranchActivity2";
            // 
            // ManagerFound
            // 
            this.ManagerFound.Activities.Add(this.initializeUpdate);
            this.ManagerFound.Activities.Add(this.updateCostCenter);
            ruleconditionreference1.ConditionName = "Condition1";
            this.ManagerFound.Condition = ruleconditionreference1;
            this.ManagerFound.Name = "ManagerFound";
            // 
            // IterateEnumManager
            // 
            this.IterateEnumManager.Name = "IterateEnumManager";
            this.IterateEnumManager.ExecuteCode += new System.EventHandler(this.IterateEnumManager_ExecuteCode);
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.ManagerFound);
            this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity2);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // initIfElse
            // 
            this.initIfElse.Name = "initIfElse";
            this.initIfElse.ExecuteCode += new System.EventHandler(this.IfCondition_ExecuteCode);
            // 
            // enumManager
            // 
            this.enumManager.Activities.Add(this.IterateEnumManager);
            activitybind6.Name = "AssignManagerToCostCenterActivity";
            activitybind6.Path = "enumManager_ActorId1";
            this.enumManager.Name = "enumManager";
            activitybind7.Name = "AssignManagerToCostCenterActivity";
            activitybind7.Path = "enumManager_PageSize1";
            activitybind8.Name = "AssignManagerToCostCenterActivity";
            activitybind8.Path = "enumManager_Selection1";
            activitybind9.Name = "AssignManagerToCostCenterActivity";
            activitybind9.Path = "enumManager_SortingAttributes1";
            activitybind10.Name = "AssignManagerToCostCenterActivity";
            activitybind10.Path = "enumManager_TotalResultsCount1";
            activitybind11.Name = "AssignManagerToCostCenterActivity";
            activitybind11.Path = "enumManager_XPathFilter1";
            this.enumManager.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.ActorIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.enumManager.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.PageSizeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.enumManager.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.SelectionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            this.enumManager.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.SortingAttributesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            this.enumManager.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.TotalResultsCountProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
            this.enumManager.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.XPathFilterProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
            // 
            // InitializeEnumManager
            // 
            this.InitializeEnumManager.Name = "InitializeEnumManager";
            this.InitializeEnumManager.ExecuteCode += new System.EventHandler(this.InitializeEnumManager_ExecuteCode);
            // 
            // ReadCostCenter
            // 
            activitybind12.Name = "AssignManagerToCostCenterActivity";
            activitybind12.Path = "ReadCostCenter_ActorId1";
            this.ReadCostCenter.Name = "ReadCostCenter";
            activitybind13.Name = "AssignManagerToCostCenterActivity";
            activitybind13.Path = "ReadCostCenter_Resource1";
            activitybind14.Name = "AssignManagerToCostCenterActivity";
            activitybind14.Path = "ReadCostCenter_ResourceId1";
            activitybind15.Name = "AssignManagerToCostCenterActivity";
            activitybind15.Path = "ReadCostCenter_SelectionAttributes1";
            this.ReadCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ActorIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
            this.ReadCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ResourceProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind13)));
            this.ReadCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ResourceIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind14)));
            this.ReadCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.SelectionAttributesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind15)));
            // 
            // initializeReadCostCenter
            // 
            this.initializeReadCostCenter.Name = "initializeReadCostCenter";
            this.initializeReadCostCenter.ExecuteCode += new System.EventHandler(this.initializeReadCostCenter_ExecuteCode);
            // 
            // ReadCurrentRequest
            // 
            activitybind16.Name = "AssignManagerToCostCenterActivity";
            activitybind16.Path = "ReadCurrentRequest_CurrentRequest1";
            this.ReadCurrentRequest.Name = "ReadCurrentRequest";
            this.ReadCurrentRequest.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity.CurrentRequestProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind16)));
            // 
            // AssignManagerToCostCenterActivity
            // 
            this.Activities.Add(this.ReadCurrentRequest);
            this.Activities.Add(this.initializeReadCostCenter);
            this.Activities.Add(this.ReadCostCenter);
            this.Activities.Add(this.InitializeEnumManager);
            this.Activities.Add(this.enumManager);
            this.Activities.Add(this.initIfElse);
            this.Activities.Add(this.ifElseActivity1);
            this.Name = "AssignManagerToCostCenterActivity";
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity initIfElse;

        private IfElseBranchActivity ifElseBranchActivity2;

        private IfElseBranchActivity ManagerFound;

        private IfElseActivity ifElseActivity1;

        private CodeActivity initializeUpdate;

        private Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity updateCostCenter;

        private Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity enumManager;

        private Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity ReadCostCenter;

        private CodeActivity initializeReadCostCenter;

        private CodeActivity InitializeEnumManager;

        private Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity ReadCurrentRequest;

        private CodeActivity IterateEnumManager;



















    }
}
