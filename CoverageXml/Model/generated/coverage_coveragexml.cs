﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace CoverageXml.Model {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CoverageDSPriv {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Module", typeof(CoverageDSPrivModule), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SourceFileNames", typeof(CoverageDSPrivSourceFileNames), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CoverageDSPrivModule {
        
        private string moduleNameField;
        
        private uint imageSizeField;
        
        private uint imageLinkTimeField;
        
        private uint linesCoveredField;
        
        private bool linesCoveredFieldSpecified;
        
        private uint linesPartiallyCoveredField;
        
        private bool linesPartiallyCoveredFieldSpecified;
        
        private uint linesNotCoveredField;
        
        private bool linesNotCoveredFieldSpecified;
        
        private uint blocksCoveredField;
        
        private bool blocksCoveredFieldSpecified;
        
        private uint blocksNotCoveredField;
        
        private bool blocksNotCoveredFieldSpecified;
        
        private CoverageDSPrivModuleNamespaceTable[] namespaceTableField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ModuleName {
            get {
                return this.moduleNameField;
            }
            set {
                this.moduleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint ImageSize {
            get {
                return this.imageSizeField;
            }
            set {
                this.imageSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint ImageLinkTime {
            get {
                return this.imageLinkTimeField;
            }
            set {
                this.imageLinkTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesCovered {
            get {
                return this.linesCoveredField;
            }
            set {
                this.linesCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesCoveredSpecified {
            get {
                return this.linesCoveredFieldSpecified;
            }
            set {
                this.linesCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesPartiallyCovered {
            get {
                return this.linesPartiallyCoveredField;
            }
            set {
                this.linesPartiallyCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesPartiallyCoveredSpecified {
            get {
                return this.linesPartiallyCoveredFieldSpecified;
            }
            set {
                this.linesPartiallyCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesNotCovered {
            get {
                return this.linesNotCoveredField;
            }
            set {
                this.linesNotCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesNotCoveredSpecified {
            get {
                return this.linesNotCoveredFieldSpecified;
            }
            set {
                this.linesNotCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint BlocksCovered {
            get {
                return this.blocksCoveredField;
            }
            set {
                this.blocksCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlocksCoveredSpecified {
            get {
                return this.blocksCoveredFieldSpecified;
            }
            set {
                this.blocksCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint BlocksNotCovered {
            get {
                return this.blocksNotCoveredField;
            }
            set {
                this.blocksNotCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlocksNotCoveredSpecified {
            get {
                return this.blocksNotCoveredFieldSpecified;
            }
            set {
                this.blocksNotCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NamespaceTable", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CoverageDSPrivModuleNamespaceTable[] NamespaceTable {
            get {
                return this.namespaceTableField;
            }
            set {
                this.namespaceTableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CoverageDSPrivModuleNamespaceTable {
        
        private uint blocksCoveredField;
        
        private bool blocksCoveredFieldSpecified;
        
        private uint blocksNotCoveredField;
        
        private bool blocksNotCoveredFieldSpecified;
        
        private uint linesCoveredField;
        
        private bool linesCoveredFieldSpecified;
        
        private uint linesNotCoveredField;
        
        private bool linesNotCoveredFieldSpecified;
        
        private uint linesPartiallyCoveredField;
        
        private bool linesPartiallyCoveredFieldSpecified;
        
        private string moduleNameField;
        
        private string namespaceKeyNameField;
        
        private string namespaceNameField;
        
        private CoverageDSPrivModuleNamespaceTableClass[] classField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint BlocksCovered {
            get {
                return this.blocksCoveredField;
            }
            set {
                this.blocksCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlocksCoveredSpecified {
            get {
                return this.blocksCoveredFieldSpecified;
            }
            set {
                this.blocksCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint BlocksNotCovered {
            get {
                return this.blocksNotCoveredField;
            }
            set {
                this.blocksNotCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlocksNotCoveredSpecified {
            get {
                return this.blocksNotCoveredFieldSpecified;
            }
            set {
                this.blocksNotCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesCovered {
            get {
                return this.linesCoveredField;
            }
            set {
                this.linesCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesCoveredSpecified {
            get {
                return this.linesCoveredFieldSpecified;
            }
            set {
                this.linesCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesNotCovered {
            get {
                return this.linesNotCoveredField;
            }
            set {
                this.linesNotCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesNotCoveredSpecified {
            get {
                return this.linesNotCoveredFieldSpecified;
            }
            set {
                this.linesNotCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesPartiallyCovered {
            get {
                return this.linesPartiallyCoveredField;
            }
            set {
                this.linesPartiallyCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesPartiallyCoveredSpecified {
            get {
                return this.linesPartiallyCoveredFieldSpecified;
            }
            set {
                this.linesPartiallyCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ModuleName {
            get {
                return this.moduleNameField;
            }
            set {
                this.moduleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NamespaceKeyName {
            get {
                return this.namespaceKeyNameField;
            }
            set {
                this.namespaceKeyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NamespaceName {
            get {
                return this.namespaceNameField;
            }
            set {
                this.namespaceNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Class", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CoverageDSPrivModuleNamespaceTableClass[] Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CoverageDSPrivModuleNamespaceTableClass {
        
        private string classKeyNameField;
        
        private string classNameField;
        
        private uint linesCoveredField;
        
        private bool linesCoveredFieldSpecified;
        
        private uint linesNotCoveredField;
        
        private bool linesNotCoveredFieldSpecified;
        
        private uint linesPartiallyCoveredField;
        
        private bool linesPartiallyCoveredFieldSpecified;
        
        private uint blocksCoveredField;
        
        private bool blocksCoveredFieldSpecified;
        
        private uint blocksNotCoveredField;
        
        private bool blocksNotCoveredFieldSpecified;
        
        private string namespaceKeyNameField;
        
        private CoverageDSPrivModuleNamespaceTableClassMethod[] methodField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ClassKeyName {
            get {
                return this.classKeyNameField;
            }
            set {
                this.classKeyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ClassName {
            get {
                return this.classNameField;
            }
            set {
                this.classNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesCovered {
            get {
                return this.linesCoveredField;
            }
            set {
                this.linesCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesCoveredSpecified {
            get {
                return this.linesCoveredFieldSpecified;
            }
            set {
                this.linesCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesNotCovered {
            get {
                return this.linesNotCoveredField;
            }
            set {
                this.linesNotCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesNotCoveredSpecified {
            get {
                return this.linesNotCoveredFieldSpecified;
            }
            set {
                this.linesNotCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesPartiallyCovered {
            get {
                return this.linesPartiallyCoveredField;
            }
            set {
                this.linesPartiallyCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesPartiallyCoveredSpecified {
            get {
                return this.linesPartiallyCoveredFieldSpecified;
            }
            set {
                this.linesPartiallyCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint BlocksCovered {
            get {
                return this.blocksCoveredField;
            }
            set {
                this.blocksCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlocksCoveredSpecified {
            get {
                return this.blocksCoveredFieldSpecified;
            }
            set {
                this.blocksCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint BlocksNotCovered {
            get {
                return this.blocksNotCoveredField;
            }
            set {
                this.blocksNotCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlocksNotCoveredSpecified {
            get {
                return this.blocksNotCoveredFieldSpecified;
            }
            set {
                this.blocksNotCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NamespaceKeyName {
            get {
                return this.namespaceKeyNameField;
            }
            set {
                this.namespaceKeyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Method", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CoverageDSPrivModuleNamespaceTableClassMethod[] Method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CoverageDSPrivModuleNamespaceTableClassMethod {
        
        private string methodKeyNameField;
        
        private string methodNameField;
        
        private string methodFullNameField;
        
        private uint linesCoveredField;
        
        private bool linesCoveredFieldSpecified;
        
        private uint linesPartiallyCoveredField;
        
        private bool linesPartiallyCoveredFieldSpecified;
        
        private uint linesNotCoveredField;
        
        private bool linesNotCoveredFieldSpecified;
        
        private uint blocksCoveredField;
        
        private bool blocksCoveredFieldSpecified;
        
        private uint blocksNotCoveredField;
        
        private bool blocksNotCoveredFieldSpecified;
        
        private CoverageDSPrivModuleNamespaceTableClassMethodLines[] linesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MethodKeyName {
            get {
                return this.methodKeyNameField;
            }
            set {
                this.methodKeyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MethodName {
            get {
                return this.methodNameField;
            }
            set {
                this.methodNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MethodFullName {
            get {
                return this.methodFullNameField;
            }
            set {
                this.methodFullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesCovered {
            get {
                return this.linesCoveredField;
            }
            set {
                this.linesCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesCoveredSpecified {
            get {
                return this.linesCoveredFieldSpecified;
            }
            set {
                this.linesCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesPartiallyCovered {
            get {
                return this.linesPartiallyCoveredField;
            }
            set {
                this.linesPartiallyCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesPartiallyCoveredSpecified {
            get {
                return this.linesPartiallyCoveredFieldSpecified;
            }
            set {
                this.linesPartiallyCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LinesNotCovered {
            get {
                return this.linesNotCoveredField;
            }
            set {
                this.linesNotCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinesNotCoveredSpecified {
            get {
                return this.linesNotCoveredFieldSpecified;
            }
            set {
                this.linesNotCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint BlocksCovered {
            get {
                return this.blocksCoveredField;
            }
            set {
                this.blocksCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlocksCoveredSpecified {
            get {
                return this.blocksCoveredFieldSpecified;
            }
            set {
                this.blocksCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint BlocksNotCovered {
            get {
                return this.blocksNotCoveredField;
            }
            set {
                this.blocksNotCoveredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlocksNotCoveredSpecified {
            get {
                return this.blocksNotCoveredFieldSpecified;
            }
            set {
                this.blocksNotCoveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lines", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CoverageDSPrivModuleNamespaceTableClassMethodLines[] Lines {
            get {
                return this.linesField;
            }
            set {
                this.linesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CoverageDSPrivModuleNamespaceTableClassMethodLines {
        
        private uint lnStartField;
        
        private uint colStartField;
        
        private uint lnEndField;
        
        private uint colEndField;
        
        private uint coverageField;
        
        private uint sourceFileIDField;
        
        private uint lineIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LnStart {
            get {
                return this.lnStartField;
            }
            set {
                this.lnStartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint ColStart {
            get {
                return this.colStartField;
            }
            set {
                this.colStartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LnEnd {
            get {
                return this.lnEndField;
            }
            set {
                this.lnEndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint ColEnd {
            get {
                return this.colEndField;
            }
            set {
                this.colEndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint Coverage {
            get {
                return this.coverageField;
            }
            set {
                this.coverageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint SourceFileID {
            get {
                return this.sourceFileIDField;
            }
            set {
                this.sourceFileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint LineID {
            get {
                return this.lineIDField;
            }
            set {
                this.lineIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CoverageDSPrivSourceFileNames {
        
        private uint sourceFileIDField;
        
        private string sourceFileNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint SourceFileID {
            get {
                return this.sourceFileIDField;
            }
            set {
                this.sourceFileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SourceFileName {
            get {
                return this.sourceFileNameField;
            }
            set {
                this.sourceFileNameField = value;
            }
        }
    }
}
