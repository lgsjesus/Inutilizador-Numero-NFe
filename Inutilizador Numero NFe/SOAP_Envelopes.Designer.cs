﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inutilizador_Numero_NFe {
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
    internal class SOAP_Envelopes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SOAP_Envelopes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Inutilizador_Numero_NFe.SOAP_Envelopes", typeof(SOAP_Envelopes).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;&lt;inutNFe versao=&quot;3.10&quot; xmlns=&quot;http://www.portalfiscal.inf.br/nfe&quot;&gt;&lt;/inutNFe&gt;.
        /// </summary>
        internal static string NFE_Inutirilizacao {
            get {
                return ResourceManager.GetString("NFE_Inutirilizacao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;&lt;soap:Envelope xmlns:soap=&quot;http://www.w3.org/2003/05/soap-envelope&quot; xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;&lt;soap:Header&gt;&lt;nfeCabecMsg xmlns=&quot;http://www.portalfiscal.inf.br/nfe/wsdl/NfeInutilizacao2&quot;&gt;&lt;cUF&gt;43&lt;/cUF&gt;&lt;versaoDados&gt;3.10&lt;/versaoDados&gt;&lt;/nfeCabecMsg&gt;&lt;/soap:Header&gt;&lt;soap:Body&gt;&lt;nfeDadosMsg xmlns=&quot;http://www.portalfiscal.inf.br/nfe/wsdl/NfeInutilizacao2&quot;&gt;&lt;/nfeDadosMsg&gt;&lt;/soap:Body&gt;&lt;/soap:Envelope&gt;.
        /// </summary>
        internal static string SOAP_Inut_Numeracao_v2_00 {
            get {
                return ResourceManager.GetString("SOAP_Inut_Numeracao_v2_00", resourceCulture);
            }
        }
    }
}
