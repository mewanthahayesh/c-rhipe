﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rhipecode.businessrules.Resource {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ValidationMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("rhipecode.businessrules.Resource.ValidationMessages", typeof(ValidationMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  Equilateral Triangle is not valid.
        /// </summary>
        public static string ExceptionInvalidEquilateralTriangle {
            get {
                return ResourceManager.GetString("ExceptionInvalidEquilateralTriangle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  Isosceles Triangle is not valid.
        /// </summary>
        public static string ExceptionInvalidIsoscelesTriangle {
            get {
                return ResourceManager.GetString("ExceptionInvalidIsoscelesTriangle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  ScaleneEngine Triangle is not valid.
        /// </summary>
        public static string ExceptionInvalidScaleneEngineTriangle {
            get {
                return ResourceManager.GetString("ExceptionInvalidScaleneEngineTriangle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  Required record not found.
        /// </summary>
        public static string ExceptionRecordNotFoundTriangle {
            get {
                return ResourceManager.GetString("ExceptionRecordNotFoundTriangle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request string is empty or null.
        /// </summary>
        public static string ExceptionRequestStringEmpty {
            get {
                return ResourceManager.GetString("ExceptionRequestStringEmpty", resourceCulture);
            }
        }
    }
}
