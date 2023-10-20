// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace ISBank_Assessment.UI.Controllers
{
    public partial class CustomerController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CustomerController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CustomerController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditCustomer()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditCustomer);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SaveEditCustomer()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveEditCustomer);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult CheckExistingIDNumber()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.CheckExistingIDNumber);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetEmploymentDetails()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetEmploymentDetails);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EmploymentDetails()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EmploymentDetails);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SaveEmploymentDetails()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveEmploymentDetails);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> DeleteEmploymentDetails()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteEmploymentDetails);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CustomerController Actions { get { return MVC.Customer; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Customer";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Customer";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string GetCustomers = "GetCustomers";
            public readonly string EditCustomer = "EditCustomer";
            public readonly string SaveEditCustomer = "SaveEditCustomer";
            public readonly string CheckExistingIDNumber = "CheckExistingIDNumber";
            public readonly string GetEmploymentDetails = "GetEmploymentDetails";
            public readonly string EmploymentDetails = "EmploymentDetails";
            public readonly string SaveEmploymentDetails = "SaveEmploymentDetails";
            public readonly string DeleteEmploymentDetails = "DeleteEmploymentDetails";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string GetCustomers = "GetCustomers";
            public const string EditCustomer = "EditCustomer";
            public const string SaveEditCustomer = "SaveEditCustomer";
            public const string CheckExistingIDNumber = "CheckExistingIDNumber";
            public const string GetEmploymentDetails = "GetEmploymentDetails";
            public const string EmploymentDetails = "EmploymentDetails";
            public const string SaveEmploymentDetails = "SaveEmploymentDetails";
            public const string DeleteEmploymentDetails = "DeleteEmploymentDetails";
        }


        static readonly ActionParamsClass_GetCustomers s_params_GetCustomers = new ActionParamsClass_GetCustomers();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetCustomers GetCustomersParams { get { return s_params_GetCustomers; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetCustomers
        {
            public readonly string SearchText = "SearchText";
        }
        static readonly ActionParamsClass_EditCustomer s_params_EditCustomer = new ActionParamsClass_EditCustomer();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditCustomer EditCustomerParams { get { return s_params_EditCustomer; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditCustomer
        {
            public readonly string CustomerId = "CustomerId";
        }
        static readonly ActionParamsClass_SaveEditCustomer s_params_SaveEditCustomer = new ActionParamsClass_SaveEditCustomer();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveEditCustomer SaveEditCustomerParams { get { return s_params_SaveEditCustomer; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveEditCustomer
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_CheckExistingIDNumber s_params_CheckExistingIDNumber = new ActionParamsClass_CheckExistingIDNumber();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CheckExistingIDNumber CheckExistingIDNumberParams { get { return s_params_CheckExistingIDNumber; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CheckExistingIDNumber
        {
            public readonly string IDNumber = "IDNumber";
            public readonly string CustomerId = "CustomerId";
        }
        static readonly ActionParamsClass_GetEmploymentDetails s_params_GetEmploymentDetails = new ActionParamsClass_GetEmploymentDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetEmploymentDetails GetEmploymentDetailsParams { get { return s_params_GetEmploymentDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetEmploymentDetails
        {
            public readonly string CustomerContactId = "CustomerContactId";
            public readonly string SearchText = "SearchText";
        }
        static readonly ActionParamsClass_EmploymentDetails s_params_EmploymentDetails = new ActionParamsClass_EmploymentDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EmploymentDetails EmploymentDetailsParams { get { return s_params_EmploymentDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EmploymentDetails
        {
            public readonly string EmploymentDetailsId = "EmploymentDetailsId";
        }
        static readonly ActionParamsClass_SaveEmploymentDetails s_params_SaveEmploymentDetails = new ActionParamsClass_SaveEmploymentDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveEmploymentDetails SaveEmploymentDetailsParams { get { return s_params_SaveEmploymentDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveEmploymentDetails
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_DeleteEmploymentDetails s_params_DeleteEmploymentDetails = new ActionParamsClass_DeleteEmploymentDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteEmploymentDetails DeleteEmploymentDetailsParams { get { return s_params_DeleteEmploymentDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteEmploymentDetails
        {
            public readonly string EmploymentDetailsId = "EmploymentDetailsId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CustomerController : ISBank_Assessment.UI.Controllers.CustomerController
    {
        public T4MVC_CustomerController() : base(Dummy.Instance) { }

        [NonAction]
        partial void GetCustomersOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string SearchText);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetCustomers(string SearchText)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetCustomers);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "SearchText", SearchText);
            GetCustomersOverride(callInfo, SearchText);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void EditCustomerOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? CustomerId);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditCustomer(int? CustomerId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditCustomer);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "CustomerId", CustomerId);
            EditCustomerOverride(callInfo, CustomerId);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void SaveEditCustomerOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, ISBank_Assessment.UI.Models.EditCustomerModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SaveEditCustomer(ISBank_Assessment.UI.Models.EditCustomerModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveEditCustomer);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SaveEditCustomerOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void CheckExistingIDNumberOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string IDNumber, int? CustomerId);

        [NonAction]
        public override System.Web.Mvc.JsonResult CheckExistingIDNumber(string IDNumber, int? CustomerId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.CheckExistingIDNumber);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "IDNumber", IDNumber);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "CustomerId", CustomerId);
            CheckExistingIDNumberOverride(callInfo, IDNumber, CustomerId);
            return callInfo;
        }

        [NonAction]
        partial void GetEmploymentDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int CustomerContactId, string SearchText);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetEmploymentDetails(int CustomerContactId, string SearchText)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetEmploymentDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "CustomerContactId", CustomerContactId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "SearchText", SearchText);
            GetEmploymentDetailsOverride(callInfo, CustomerContactId, SearchText);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void EmploymentDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? EmploymentDetailsId);

        [NonAction]
        public override System.Web.Mvc.ActionResult EmploymentDetails(int? EmploymentDetailsId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EmploymentDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "EmploymentDetailsId", EmploymentDetailsId);
            EmploymentDetailsOverride(callInfo, EmploymentDetailsId);
            return callInfo;
        }

        [NonAction]
        partial void SaveEmploymentDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, ISBank_Assessment.UI.Models.EditEmploymentDetailsModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SaveEmploymentDetails(ISBank_Assessment.UI.Models.EditEmploymentDetailsModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveEmploymentDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SaveEmploymentDetailsOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void DeleteEmploymentDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int EmploymentDetailsId);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> DeleteEmploymentDetails(int EmploymentDetailsId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteEmploymentDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "EmploymentDetailsId", EmploymentDetailsId);
            DeleteEmploymentDetailsOverride(callInfo, EmploymentDetailsId);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114