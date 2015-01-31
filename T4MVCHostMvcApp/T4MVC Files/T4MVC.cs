﻿// <auto-generated />
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

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly breakClass s_break = new breakClass();
    public static breakClass @break { get { return s_break; } }
    static readonly FeatureFolderAreaClass s_FeatureFolderArea = new FeatureFolderAreaClass();
    public static FeatureFolderAreaClass FeatureFolderArea { get { return s_FeatureFolderArea; } }
    static readonly HomeClass s_Home = new HomeClass();
    public static HomeClass HomeArea { get { return s_Home; } }
    public static T4MVCHostMvcApp.Controllers.HomeController Home = new T4MVCHostMvcApp.Controllers.T4MVC_HomeController();
    public static T4MVCHostMvcApp.Controllers.ModelUnbinderController ModelUnbinder = new T4MVCHostMvcApp.Controllers.T4MVC_ModelUnbinderController();
    public static T4MVCHostMvcApp.Controllers.SomeAsyncController SomeAsync = new T4MVCHostMvcApp.Controllers.T4MVC_SomeAsyncController();
    public static T4MVCHostMvcApp.Controllers.T4CtrlController T4Ctrl = new T4MVCHostMvcApp.Controllers.T4MVC_T4CtrlController();
    public static T4MVCHostMvcApp.Controllers.TestAttributeYesName1Controller TestAttributeYesName1 = new T4MVCHostMvcApp.Controllers.T4MVC_TestAttributeYesName1Controller();
    public static T4MVCHostMvcApp.Controllers.TestAttributeYesControllerName3 TestAttributeYesName3 = new T4MVCHostMvcApp.Controllers.T4MVC_TestAttributeYesControllerName3();
    public static T4MVCHostMvcApp.Controllers.TestAttributeYesProcessed1Controller TestAttributeYesProcessed1 = new T4MVCHostMvcApp.Controllers.T4MVC_TestAttributeYesProcessed1Controller();
    public static T4MVCHostMvcApp.Controllers.TestAttributeYesProcessed2Controller TestAttributeYesProcessed2 = new T4MVCHostMvcApp.Controllers.T4MVC_TestAttributeYesProcessed2Controller();
    public static T4MVCHostMvcApp.Controllers.TestAttributeYesAbstract2Controller TestAttributeYesAbstract2 = new T4MVCHostMvcApp.Controllers.T4MVC_TestAttributeYesAbstract2Controller();
    public static T4MVCHostMvcApp.Controllers.TestAttributeYesDerivedController TestAttributeYesDerived = new T4MVCHostMvcApp.Controllers.T4MVC_TestAttributeYesDerivedController();
    public static T4MVC.NoControllerMatchingFolderController NoMatchingFolder = new T4MVC.NoControllerMatchingFolderController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
    public static T4MVCHostMvcApp.Features.Contact.ContactController Contact = new T4MVCHostMvcApp.Features.Contact.T4MVC_ContactController();
    public static T4MVCHostMvcApp.Features.Pictures.PicturesController Pictures = new T4MVCHostMvcApp.Features.Pictures.T4MVC_PicturesController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class breakClass
    {
        public readonly string Name = "break";
        public T4MVCHostMvcApp.Areas.Break.Controllers.PostController Post = new T4MVCHostMvcApp.Areas.Break.Controllers.T4MVC_PostController();
        public T4MVC.@break.SharedController Shared = new T4MVC.@break.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class FeatureFolderAreaClass
    {
        public readonly string Name = "FeatureFolderArea";
        public T4MVCHostMvcApp.Areas.FeatureFolderArea.FeatureFoo.FeatureFooController FeatureFoo = new T4MVCHostMvcApp.Areas.FeatureFolderArea.FeatureFoo.T4MVC_FeatureFooController();
        public T4MVC.FeatureFolderArea.SharedViewsController SharedViews = new T4MVC.FeatureFolderArea.SharedViewsController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class HomeClass
    {
        public readonly string Name = "Home";
        public T4MVCHostMvcApp.Areas.Home.Controllers.HomeController Home = new T4MVCHostMvcApp.Areas.Home.Controllers.T4MVC_HomeController();
        public T4MVC.Home.SharedController Shared = new T4MVC.Home.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ViewResult : System.Web.Mvc.ViewResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ViewResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_JsonResult : System.Web.Mvc.JsonResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_FileContentResult : System.Web.Mvc.FileContentResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_FileContentResult(string area, string controller, string action, string protocol = null): base(new byte[0], " ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_FileStreamResult : System.Web.Mvc.FileStreamResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_FileStreamResult(string area, string controller, string action, string protocol = null): base(default(System.IO.Stream), " ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_FileResult : System.Web.Mvc.FileResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_FileResult(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    protected override void WriteFile(System.Web.HttpResponseBase response) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_T4MVCHostMvcApp_Misc_MyCustomResult : T4MVCHostMvcApp.Misc.MyCustomResult, IT4MVCActionResult
{
    public T4MVC_T4MVCHostMvcApp_Misc_MyCustomResult(string area, string controller, string action, string protocol = null): base(" ", default(int), default(T4MVCHostMvcApp.Misc.Animal))
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_String : T4MVCHostMvcApp.Controllers.SomeGenericResult<System.String>, IT4MVCActionResult
{
    public T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_String(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_Int32 : T4MVCHostMvcApp.Controllers.SomeGenericResult<System.Int32>, IT4MVCActionResult
{
    public T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_Int32(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_Collections_Generic_List_System_Tuple_System_String_System_String_System_Int32 : T4MVCHostMvcApp.Controllers.SomeGenericResult<System.Collections.Generic.List<System.Tuple<System.String,System.String,System.Int32>>>, IT4MVCActionResult
{
    public T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_Collections_Generic_List_System_Tuple_System_String_System_String_System_Int32(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ViewResultBase : System.Web.Mvc.ViewResultBase, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ViewResultBase(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    protected override System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext context) { return default(System.Web.Mvc.ViewEngineResult);  }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string jquery_1_3_2_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.3.2-vsdoc.min.js") ? Url("jquery-1.3.2-vsdoc.min.js") : Url("jquery-1.3.2-vsdoc.js");
        public static readonly string jquery_1_3_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.3.2.min.js") ? Url("jquery-1.3.2.min.js") : Url("jquery-1.3.2.js");
        public static readonly string jquery_1_3_2_min_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.3.2.min-vsdoc.min.js") ? Url("jquery-1.3.2.min-vsdoc.min.js") : Url("jquery-1.3.2.min-vsdoc.js");
        public static readonly string jquery_1_3_2_min_js = Url("jquery-1.3.2.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min-vsdoc.min.js") ? Url("jquery.validate.min-vsdoc.min.js") : Url("jquery.validate.min-vsdoc.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string MicrosoftAjax_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftAjax.debug.min.js") ? Url("MicrosoftAjax.debug.min.js") : Url("MicrosoftAjax.debug.js");
        public static readonly string MicrosoftAjax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftAjax.min.js") ? Url("MicrosoftAjax.min.js") : Url("MicrosoftAjax.js");
        public static readonly string MicrosoftMvcAjax_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcAjax.debug.min.js") ? Url("MicrosoftMvcAjax.debug.min.js") : Url("MicrosoftMvcAjax.debug.js");
        public static readonly string MicrosoftMvcAjax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcAjax.min.js") ? Url("MicrosoftMvcAjax.min.js") : Url("MicrosoftMvcAjax.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _7_My_Text_File_Space_txt = Url("7 My.Text-File Space.txt");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class @default {
            private const string URLPATH = "~/Content/default";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Zzz_txt = Url("Zzz.txt");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Empty_Folder {
            private const string URLPATH = "~/Content/Empty Folder";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        }
    
        public static readonly string Hello_World_txt = Url("Hello World.txt");
        public static readonly string Hello_World_txt_ = Url("Hello$World.txt");
        public static readonly string Hello_World_txt__ = Url("Hello+World.txt");
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
             
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class SomeRandomName {
            private const string URLPATH = "~/Content/SomeRandomName";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class SomeRandomName_ {
                private const string URLPATH = "~/Content/SomeRandomName/SomeRandomName";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Hello_World_txt = Url("Hello World.txt");
                public static readonly string Hello_World_txt_ = Url("Hello$World.txt");
                public static readonly string Hello_World_txt__ = Url("Hello+World.txt");
                public static readonly string SomeRandomName_txt = Url("SomeRandomName.txt");
            }
        
        }
    
        public static readonly string StyleSheet_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/StyleSheet.min.css") ? Url("StyleSheet.min.css") : Url("StyleSheet.css");
             
        public static readonly string StyleSheet_min_css = Url("StyleSheet.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Sub_Content_folder_test {
            private const string URLPATH = "~/Content/Sub Content-folder.test";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string SomeT4_tt = Url("SomeT4.tt");
            public static readonly string SomeT41_txt = Url("SomeT41.txt");
            public static readonly string SomeT4_txt = Url("SomeT4.txt");
        }
    
    }


    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class ContentStatic {
        private const string URLPATH = "~/ContentStatic";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class TextFiles {
            private const string URLPATH = "~/ContentStatic/TextFiles";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string readme_txt = Url("readme.txt");
        }
    
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Views {
        private const string URLPATH = "~/Views";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Home {
            private const string URLPATH = "~/Views/Home";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string _7_Some_Home_View_Hello_txt = Url("7 Some Home.View-Hello.txt");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class App_LocalResources {
                private const string URLPATH = "~/Views/Home/App_LocalResources";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Qqq_txt = Url("Qqq.txt");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class @default {
                private const string URLPATH = "~/Views/Home/default";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class DisplayTemplates {
                private const string URLPATH = "~/Views/Home/DisplayTemplates";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class EditorTemplates {
                private const string URLPATH = "~/Views/Home/EditorTemplates";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
            public static readonly string Qqq_txt = Url("Qqq.txt");
            public static readonly string QqQ_txt2 = Url("QqQ.txt2");
            public static readonly string Qqq_txt3 = Url("Qqq.txt3");
            public static readonly string SomeLinkedFile_txt = Url("SomeLinkedFile.txt");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class SomeName {
                private const string URLPATH = "~/Views/Home/SomeName";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class SomeName_ {
                    private const string URLPATH = "~/Views/Home/SomeName/SomeName";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string SomeName_txt = Url("SomeName.txt");
                }
            
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Sub_Home {
                private const string URLPATH = "~/Views/Home/Sub Home";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Nested_Sub {
                    private const string URLPATH = "~/Views/Home/Sub Home/Nested-Sub";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string _99_Super_Nested_View_txt = Url("99 Super~Nested-View.txt");
                }
            
                public static readonly string Qqq_txt = Url("Qqq.txt");
                public static readonly string string_txt = Url("string.txt");
                public static readonly string T4View_tt = Url("T4View.tt");
            }
        
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class NoControllerMatchingFolder {
            private const string URLPATH = "~/Views/NoControllerMatchingFolder";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Abcd_txt = Url("Abcd.txt");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Shared {
            private const string URLPATH = "~/Views/Shared";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Hello_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Hello.min.js") ? Url("Hello.min.js") : Url("Hello.js");
            public static readonly string Site_Master = Url("Site.Master");
        }
    
        public static readonly string Web_config = Url("Web.config");
    }


    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Features {
        private const string URLPATH = "~/Features";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Contact {
            private const string URLPATH = "~/Features/Contact";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Index_txt = Url("Index.txt");
        }
    
    }

    public static partial class Features {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Pictures {
            private const string URLPATH = "~/Features/Pictures";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Detail_txt = Url("Detail.txt");
            public static readonly string Index_txt = Url("Index.txt");
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Areas {
        private const string URLPATH = "~/Areas";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class @break {
            private const string URLPATH = "~/Areas/break";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Views {
                private const string URLPATH = "~/Areas/break/Views";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Shared {
                    private const string URLPATH = "~/Areas/break/Views/Shared";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string SharedAreaView_txt = Url("SharedAreaView.txt");
                }
            
                public static readonly string Web_config = Url("Web.config");
            }
        
        }
    }

    public static partial class Areas {
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class FeatureFolderArea {
            private const string URLPATH = "~/Areas/FeatureFolderArea";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class FeatureFoo {
                private const string URLPATH = "~/Areas/FeatureFolderArea/FeatureFoo";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Foobar_txt = Url("Foobar.txt");
                public static readonly string Index_txt = Url("Index.txt");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class FeatureFolderArea {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class SharedViews {
                private const string URLPATH = "~/Areas/FeatureFolderArea/SharedViews";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string SharedView_txt = Url("SharedView.txt");
            }
        
        }
    }

    public static partial class Areas {
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Home {
            private const string URLPATH = "~/Areas/Home";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Views {
                private const string URLPATH = "~/Areas/Home/Views";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Home {
                    private const string URLPATH = "~/Areas/Home/Views/Home";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                    public static class EditorTemplates {
                        private const string URLPATH = "~/Areas/Home/Views/Home/EditorTemplates";
                        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    }
                
                    public static readonly string SomeHomeView_txt = Url("SomeHomeView.txt");
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Shared {
                    private const string URLPATH = "~/Areas/Home/Views/Shared";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                public static readonly string Web_config = Url("Web.config");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class Home {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Content {
                private const string URLPATH = "~/Areas/Home/Content";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Home_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Home.min.css") ? Url("Home.min.css") : Url("Home.css");
                     
            }
        
        }
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108


