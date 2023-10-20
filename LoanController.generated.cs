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
    public partial class LoanController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LoanController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected LoanController(Dummy d) { }

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
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetLoans()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetLoans);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult LoanDetails()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LoanDetails);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SaveLoan()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveLoan);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> DeleteLoan()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteLoan);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LoanController Actions { get { return MVC.Loan; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Loan";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Loan";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string GetLoans = "GetLoans";
            public readonly string LoanDetails = "LoanDetails";
            public readonly string SaveLoan = "SaveLoan";
            public readonly string DeleteLoan = "DeleteLoan";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string GetLoans = "GetLoans";
            public const string LoanDetails = "LoanDetails";
            public const string SaveLoan = "SaveLoan";
            public const string DeleteLoan = "DeleteLoan";
        }


        static readonly ActionParamsClass_GetLoans s_params_GetLoans = new ActionParamsClass_GetLoans();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetLoans GetLoansParams { get { return s_params_GetLoans; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetLoans
        {
            public readonly string CustomerId = "CustomerId";
            public readonly string SearchText = "SearchText";
        }
        static readonly ActionParamsClass_LoanDetails s_params_LoanDetails = new ActionParamsClass_LoanDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_LoanDetails LoanDetailsParams { get { return s_params_LoanDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_LoanDetails
        {
            public readonly string LoanId = "LoanId";
        }
        static readonly ActionParamsClass_SaveLoan s_params_SaveLoan = new ActionParamsClass_SaveLoan();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveLoan SaveLoanParams { get { return s_params_SaveLoan; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveLoan
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_DeleteLoan s_params_DeleteLoan = new ActionParamsClass_DeleteLoan();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteLoan DeleteLoanParams { get { return s_params_DeleteLoan; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteLoan
        {
            public readonly string LoanId = "LoanId";
            public readonly string CustomerId = "CustomerId";
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
    public partial class T4MVC_LoanController : ISBank_Assessment.UI.Controllers.LoanController
    {
        public T4MVC_LoanController() : base(Dummy.Instance) { }

        [NonAction]
        partial void GetLoansOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int CustomerId, string SearchText);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetLoans(int CustomerId, string SearchText)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetLoans);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "CustomerId", CustomerId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "SearchText", SearchText);
            GetLoansOverride(callInfo, CustomerId, SearchText);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void LoanDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? LoanId);

        [NonAction]
        public override System.Web.Mvc.ActionResult LoanDetails(int? LoanId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LoanDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "LoanId", LoanId);
            LoanDetailsOverride(callInfo, LoanId);
            return callInfo;
        }

        [NonAction]
        partial void SaveLoanOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, ISBank_Assessment.UI.Models.EditLoanModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SaveLoan(ISBank_Assessment.UI.Models.EditLoanModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveLoan);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SaveLoanOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void DeleteLoanOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int LoanId, int CustomerId);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> DeleteLoan(int LoanId, int CustomerId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteLoan);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "LoanId", LoanId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "CustomerId", CustomerId);
            DeleteLoanOverride(callInfo, LoanId, CustomerId);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
