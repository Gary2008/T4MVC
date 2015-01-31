// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
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
namespace T4MVCHostMvcApp.Controllers
{
    public partial class ModelUnbinderController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ModelUnbinderController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ModelUnbinderController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult TestUnbindModel()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestUnbindModel);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult TestBaseClass()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestBaseClass);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult TestChildClass1()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestChildClass1);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult TestChildClass2()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestChildClass2);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult TestComplexModel()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestComplexModel);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult TestComplexModelWithEnumerable()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestComplexModelWithEnumerable);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ModelUnbinderController Actions { get { return MVC.ModelUnbinder; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "ModelUnbinder";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "ModelUnbinder";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string TestUnbindModel = "TestUnbindModel";
            public readonly string TestBaseClass = "TestBaseClass";
            public readonly string TestChildClass1 = "TestChildClass1";
            public readonly string TestChildClass2 = "TestChildClass2";
            public readonly string TestComplexModel = "TestComplexModel";
            public readonly string TestComplexModelWithEnumerable = "TestComplexModelWithEnumerable";
            public readonly string ParameterlessAction = "ParameterlessAction";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string TestUnbindModel = "TestUnbindModel";
            public const string TestBaseClass = "TestBaseClass";
            public const string TestChildClass1 = "TestChildClass1";
            public const string TestChildClass2 = "TestChildClass2";
            public const string TestComplexModel = "TestComplexModel";
            public const string TestComplexModelWithEnumerable = "TestComplexModelWithEnumerable";
            public const string ParameterlessAction = "ParameterlessAction";
        }


        static readonly ActionParamsClass_TestUnbindModel s_params_TestUnbindModel = new ActionParamsClass_TestUnbindModel();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_TestUnbindModel TestUnbindModelParams { get { return s_params_TestUnbindModel; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TestUnbindModel
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_TestBaseClass s_params_TestBaseClass = new ActionParamsClass_TestBaseClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_TestBaseClass TestBaseClassParams { get { return s_params_TestBaseClass; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TestBaseClass
        {
            public readonly string entity = "entity";
        }
        static readonly ActionParamsClass_TestChildClass1 s_params_TestChildClass1 = new ActionParamsClass_TestChildClass1();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_TestChildClass1 TestChildClass1Params { get { return s_params_TestChildClass1; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TestChildClass1
        {
            public readonly string user = "user";
        }
        static readonly ActionParamsClass_TestChildClass2 s_params_TestChildClass2 = new ActionParamsClass_TestChildClass2();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_TestChildClass2 TestChildClass2Params { get { return s_params_TestChildClass2; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TestChildClass2
        {
            public readonly string child = "child";
        }
        static readonly ActionParamsClass_TestComplexModel s_params_TestComplexModel = new ActionParamsClass_TestComplexModel();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_TestComplexModel TestComplexModelParams { get { return s_params_TestComplexModel; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TestComplexModel
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_TestComplexModelWithEnumerable s_params_TestComplexModelWithEnumerable = new ActionParamsClass_TestComplexModelWithEnumerable();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_TestComplexModelWithEnumerable TestComplexModelWithEnumerableParams { get { return s_params_TestComplexModelWithEnumerable; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TestComplexModelWithEnumerable
        {
            public readonly string model = "model";
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
    public partial class T4MVC_ModelUnbinderController : T4MVCHostMvcApp.Controllers.ModelUnbinderController
    {
        public T4MVC_ModelUnbinderController() : base(Dummy.Instance) { }

        [NonAction]
        partial void TestUnbindModelOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, T4MVCHostMvcApp.Controllers.UnbindModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult TestUnbindModel(T4MVCHostMvcApp.Controllers.UnbindModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestUnbindModel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            TestUnbindModelOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void TestBaseClassOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, T4MVCHostMvcApp.Controllers.BaseEntity entity);

        [NonAction]
        public override System.Web.Mvc.ActionResult TestBaseClass(T4MVCHostMvcApp.Controllers.BaseEntity entity)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestBaseClass);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "entity", entity);
            TestBaseClassOverride(callInfo, entity);
            return callInfo;
        }

        [NonAction]
        partial void TestChildClass1Override(T4MVC_System_Web_Mvc_ActionResult callInfo, T4MVCHostMvcApp.Controllers.UserEntity user);

        [NonAction]
        public override System.Web.Mvc.ActionResult TestChildClass1(T4MVCHostMvcApp.Controllers.UserEntity user)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestChildClass1);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "user", user);
            TestChildClass1Override(callInfo, user);
            return callInfo;
        }

        [NonAction]
        partial void TestChildClass2Override(T4MVC_System_Web_Mvc_ActionResult callInfo, T4MVCHostMvcApp.Controllers.AnotherChildEntity child);

        [NonAction]
        public override System.Web.Mvc.ActionResult TestChildClass2(T4MVCHostMvcApp.Controllers.AnotherChildEntity child)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestChildClass2);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "child", child);
            TestChildClass2Override(callInfo, child);
            return callInfo;
        }

        [NonAction]
        partial void TestComplexModelOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, T4MVCHostMvcApp.Controllers.ComplexModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult TestComplexModel(T4MVCHostMvcApp.Controllers.ComplexModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestComplexModel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            TestComplexModelOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void TestComplexModelWithEnumerableOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, T4MVCHostMvcApp.Controllers.ComplexModelWithEnumerable model);

        [NonAction]
        public override System.Web.Mvc.ActionResult TestComplexModelWithEnumerable(T4MVCHostMvcApp.Controllers.ComplexModelWithEnumerable model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TestComplexModelWithEnumerable);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            TestComplexModelWithEnumerableOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void ParameterlessActionOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ParameterlessAction()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ParameterlessAction);
            ParameterlessActionOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
