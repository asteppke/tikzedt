﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TikzEdt.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("pdflatex")]
        public string Path_pdflatex {
            get {
                return ((string)(this["Path_pdflatex"]));
            }
            set {
                this["Path_pdflatex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Path_externalviewer {
            get {
                return ((string)(this["Path_externalviewer"]));
            }
            set {
                this["Path_externalviewer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        public double Window_Width {
            get {
                return ((double)(this["Window_Width"]));
            }
            set {
                this["Window_Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public double Window_Height {
            get {
                return ((double)(this["Window_Height"]));
            }
            set {
                this["Window_Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Editor_WordWrap {
            get {
                return ((bool)(this["Editor_WordWrap"]));
            }
            set {
                this["Editor_WordWrap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Editor_ShowLineNumbers {
            get {
                return ((bool)(this["Editor_ShowLineNumbers"]));
            }
            set {
                this["Editor_ShowLineNumbers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public double BB_Margin {
            get {
                return ((double)(this["BB_Margin"]));
            }
            set {
                this["BB_Margin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\documentclass[tight]{article}\r\n\\usepackage{tikz,amsmath, amssymb,bm,color}\r\n\\use" +
            "package[margin=0cm,nohead]{geometry}\r\n\\usepackage[active,tightpage]{preview}\r\n\r\n" +
            "\\begin{document}\r\n\\PreviewEnvironment{tikzpicture}\r\n")]
        public string Tex_Preamble {
            get {
                return ((string)(this["Tex_Preamble"]));
            }
            set {
                this["Tex_Preamble"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\end{document}")]
        public string Tex_Postamble {
            get {
                return ((string)(this["Tex_Postamble"]));
            }
            set {
                this["Tex_Postamble"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowTools {
            get {
                return ((bool)(this["TLB_ShowTools"]));
            }
            set {
                this["TLB_ShowTools"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowFiles {
            get {
                return ((bool)(this["TLB_ShowFiles"]));
            }
            set {
                this["TLB_ShowFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowBB {
            get {
                return ((bool)(this["TLB_ShowBB"]));
            }
            set {
                this["TLB_ShowBB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TLB_ShowZoom {
            get {
                return ((bool)(this["TLB_ShowZoom"]));
            }
            set {
                this["TLB_ShowZoom"] = value;
            }
        }
    }
}