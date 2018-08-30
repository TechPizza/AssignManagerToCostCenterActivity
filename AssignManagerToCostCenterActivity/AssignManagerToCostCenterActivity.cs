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
            this.readUser_ActorId1 = FIMADMGUID;
            this.readUser_ResourceId1 = _target;
        }

        private void InitializeEnumUser_ExecuteCode(object sender, EventArgs e)
        {

        }

    }
}
