using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Linq;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.ResourceManagement.WebServices.WSResourceManagement;
using System.Collections.ObjectModel;
using Microsoft.ResourceManagement.Workflow.Activities;

namespace FIM.AssignManagerToCostCenterActivity
{
    public partial class AssignManagerToCostCenterActivity : SequenceActivity
    {
        private static readonly Guid FIMADMGUID = new Guid("4074f258-a177-42df-b8ca-cba1a0cefb25");

        private Guid _requestor;
        private Guid _target;
        private string _managerSamAccount;
        private Guid _managerGUID;
        private bool _managerExists;

        #region ReadCurrentRequest
        public static DependencyProperty ReadCurrentRequest_CurrentRequest1Property = DependencyProperty.Register("ReadCurrentRequest_CurrentRequest1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType ReadCurrentRequest_CurrentRequest1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCurrentRequest_CurrentRequest1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCurrentRequest_CurrentRequest1Property, value);
            }
        }
        #endregion
        #region ReadCostCenter
        public static DependencyProperty ReadCostCenter_ActorId1Property = DependencyProperty.Register("ReadCostCenter_ActorId1", typeof(System.Guid), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid ReadCostCenter_ActorId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCostCenter_ActorId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCostCenter_ActorId1Property, value);
            }
        }

        public static DependencyProperty ReadCostCenter_Resource1Property = DependencyProperty.Register("ReadCostCenter_Resource1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public ResourceType ReadCostCenter_Resource1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCostCenter_Resource1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCostCenter_Resource1Property, value);
            }
        }

        public static DependencyProperty ReadCostCenter_ResourceId1Property = DependencyProperty.Register("ReadCostCenter_ResourceId1", typeof(System.Guid), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid ReadCostCenter_ResourceId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCostCenter_ResourceId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCostCenter_ResourceId1Property, value);
            }
        }

        public static DependencyProperty ReadCostCenter_SelectionAttributes1Property = DependencyProperty.Register("ReadCostCenter_SelectionAttributes1", typeof(System.String[]), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public String[] ReadCostCenter_SelectionAttributes1
        {
            get
            {
                return ((string[])(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCostCenter_SelectionAttributes1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.ReadCostCenter_SelectionAttributes1Property, value);
            }
        }
        #endregion
        #region EnumManager
        public static DependencyProperty enumManager_ActorId1Property = DependencyProperty.Register("enumManager_ActorId1", typeof(System.Guid), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Guid enumManager_ActorId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_ActorId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_ActorId1Property, value);
            }
        }

        public static DependencyProperty enumManager_PageSize1Property = DependencyProperty.Register("enumManager_PageSize1", typeof(System.Int32), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Int32 enumManager_PageSize1
        {
            get
            {
                return ((int)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_PageSize1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_PageSize1Property, value);
            }
        }

        public static DependencyProperty enumManager_Selection1Property = DependencyProperty.Register("enumManager_Selection1", typeof(System.String[]), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public String[] enumManager_Selection1
        {
            get
            {
                return ((string[])(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_Selection1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_Selection1Property, value);
            }
        }

        public static DependencyProperty enumManager_SortingAttributes1Property = DependencyProperty.Register("enumManager_SortingAttributes1", typeof(Microsoft.ResourceManagement.WebServices.WSEnumeration.SortingAttribute[]), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Microsoft.ResourceManagement.WebServices.WSEnumeration.SortingAttribute[] enumManager_SortingAttributes1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSEnumeration.SortingAttribute[])(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_SortingAttributes1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_SortingAttributes1Property, value);
            }
        }

        public static DependencyProperty enumManager_TotalResultsCount1Property = DependencyProperty.Register("enumManager_TotalResultsCount1", typeof(System.Int32), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Int32 enumManager_TotalResultsCount1
        {
            get
            {
                return ((int)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_TotalResultsCount1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_TotalResultsCount1Property, value);
            }
        }

        public static DependencyProperty enumManager_XPathFilter1Property = DependencyProperty.Register("enumManager_XPathFilter1", typeof(System.String), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public String enumManager_XPathFilter1
        {
            get
            {
                return ((string)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_XPathFilter1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.enumManager_XPathFilter1Property, value);
            }
        }
        #endregion
        #region ReadUser
        public static DependencyProperty readUser_ActorId1Property = DependencyProperty.Register("readUser_ActorId1", typeof(System.Guid), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid readUser_ActorId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.readUser_ActorId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.readUser_ActorId1Property, value);
            }
        }

        public static DependencyProperty readUser_Resource1Property = DependencyProperty.Register("readUser_Resource1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType readUser_Resource1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.readUser_Resource1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.readUser_Resource1Property, value);
            }
        }

        public static DependencyProperty readUser_ResourceId1Property = DependencyProperty.Register("readUser_ResourceId1", typeof(System.Guid), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid readUser_ResourceId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.readUser_ResourceId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.readUser_ResourceId1Property, value);
            }
        }

        public static DependencyProperty readUser_SelectionAttributes1Property = DependencyProperty.Register("readUser_SelectionAttributes1", typeof(System.String[]), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public String[] readUser_SelectionAttributes1
        {
            get
            {
                return ((string[])(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.readUser_SelectionAttributes1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.readUser_SelectionAttributes1Property, value);
            }
        }
        #endregion
        #region UpdateCostCenter
        public static DependencyProperty updateCostCenter_ActorId1Property = DependencyProperty.Register("updateCostCenter_ActorId1", typeof(System.Guid), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid updateCostCenter_ActorId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_ActorId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_ActorId1Property, value);
            }
        }

        public static DependencyProperty updateCostCenter_ApplyAuthorizationPolicy1Property = DependencyProperty.Register("updateCostCenter_ApplyAuthorizationPolicy1", typeof(System.Boolean), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Boolean updateCostCenter_ApplyAuthorizationPolicy1
        {
            get
            {
                return ((bool)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_ApplyAuthorizationPolicy1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_ApplyAuthorizationPolicy1Property, value);
            }
        }

        public static DependencyProperty updateCostCenter_ResourceId1Property = DependencyProperty.Register("updateCostCenter_ResourceId1", typeof(System.Guid), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid updateCostCenter_ResourceId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_ResourceId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_ResourceId1Property, value);
            }
        }

        public static DependencyProperty updateCostCenter_UpdateParameters1Property = DependencyProperty.Register("updateCostCenter_UpdateParameters1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.UpdateRequestParameter[]), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public UpdateRequestParameter[] updateCostCenter_UpdateParameters1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.UpdateRequestParameter[])(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_UpdateParameters1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_UpdateParameters1Property, value);
            }
        }

        public static DependencyProperty updateCostCenter_AuthorizationWaitTimeInSeconds1Property = DependencyProperty.Register("updateCostCenter_AuthorizationWaitTimeInSeconds1", typeof(System.Int32), typeof(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Int32 updateCostCenter_AuthorizationWaitTimeInSeconds1
        {
            get
            {
                return ((int)(base.GetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_AuthorizationWaitTimeInSeconds1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignManagerToCostCenterActivity.AssignManagerToCostCenterActivity.updateCostCenter_AuthorizationWaitTimeInSeconds1Property, value);
            }
        }
        #endregion

        public AssignManagerToCostCenterActivity()
        {
            InitializeComponent();
        }

        private void initializeReadCostCenter_ExecuteCode(object sender, EventArgs e)
        {
            RequestType currentRequest = this.ReadCurrentRequest.CurrentRequest;
            ReadOnlyCollection<CreateRequestParameter> requestParameters = currentRequest.ParseParameters<CreateRequestParameter>();

            // Retrieve current workflow
            SequentialWorkflow workflow = null;
            if (!SequentialWorkflow.TryGetContainingWorkflow(this, out workflow))
            {
                throw new InvalidOperationException();
            }

            // Save information
            _requestor = workflow.ActorId;
            _target = workflow.TargetId;

            // Init ReadUser activity
            this.ReadCostCenter_ActorId1 = FIMADMGUID;
            this.ReadCostCenter_ResourceId1 = _target;
        }

        private void InitializeEnumManager_ExecuteCode(object sender, EventArgs e)
        {
            _managerSamAccount = (ReadCostCenter.Resource["LAB-CostCenterManager"] != null) ? ReadCostCenter.Resource["LAB-CostCenterManager"].ToString() : null;

            this.enumManager_ActorId1 = FIMADMGUID;
            this.enumManager_PageSize1 = 100;
            this.enumManager_XPathFilter1 = "/labCostCenter[LAB-CostCenterManager ='" + _managerSamAccount + "']";
        }

        private void IterateEnumManager_ExecuteCode(object sender, EventArgs e)
        {
            ResourceType managerResource = EnumerateResourcesActivity.GetCurrentIterationItem((CodeActivity)sender) as ResourceType;
            _managerGUID = managerResource.ObjectID.GetGuid();
        }

        private void IfCondition_ExecuteCode(object sender, EventArgs e)
        {
            _managerExists = (enumManager.TotalResultsCount == 1);
        }

        private void InitializeUpdate_ExecuteCode(object sender, EventArgs e)
        {
            this.updateCostCenter_ActorId1 = _requestor;
            this.updateCostCenter_ResourceId1 = _target;
            this.updateCostCenter_UpdateParameters1 = new UpdateRequestParameter[]{
                new UpdateRequestParameter("Manager",UpdateMode.Modify,_managerGUID)
            };
        }
    }
}
