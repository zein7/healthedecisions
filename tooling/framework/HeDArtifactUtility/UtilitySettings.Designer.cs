﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeDArtifactUtility {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class UtilitySettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static UtilitySettings defaultInstance = ((UtilitySettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UtilitySettings())));
        
        public static UtilitySettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Maps")]
        public string MapLocation {
            get {
                return ((string)(this["MapLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schema\\knowledgeartifact\\knowledgedocument.xsd;Schema\\vmr\\vmr.xsd")]
        public string SchemaLocation {
            get {
                return ((string)(this["SchemaLocation"]));
            }
        }
    }
}
