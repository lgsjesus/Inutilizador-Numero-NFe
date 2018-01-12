﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inutilizador_Numero_NFe
{
    public class leiauteInutNFe_v3_00
    {

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignedInfoTypeCanonicalizationMethod
        {

            private string algorithmField;

            public SignedInfoTypeCanonicalizationMethod()
            {
                this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
            public string Algorithm
            {
                get
                {
                    return this.algorithmField;
                }
                set
                {
                    this.algorithmField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class X509DataType
        {

            private byte[] x509CertificateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
            public byte[] X509Certificate
            {
                get
                {
                    return this.x509CertificateField;
                }
                set
                {
                    this.x509CertificateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class KeyInfoType
        {

            private X509DataType x509DataField;

            private string idField;

            /// <remarks/>
            public X509DataType X509Data
            {
                get
                {
                    return this.x509DataField;
                }
                set
                {
                    this.x509DataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignatureValueType
        {

            private string idField;

            private byte[] valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
            public byte[] Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }
        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public enum TTransformURI
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
            httpwwww3org200009xmldsigenvelopedsignature,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
            httpwwww3orgTR2001RECxmlc14n20010315,
        }
        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class TransformType
        {

            private string[] xPathField;

            private TTransformURI algorithmField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("XPath")]
            public string[] XPath
            {
                get
                {
                    return this.xPathField;
                }
                set
                {
                    this.xPathField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public TTransformURI Algorithm
            {
                get
                {
                    return this.algorithmField;
                }
                set
                {
                    this.algorithmField = value;
                }
            }
        }


        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class ReferenceType
        {

            private TransformType[] transformsField;

            private ReferenceTypeDigestMethod digestMethodField;

            private byte[] digestValueField;

            private string idField;

            private string uRIField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
            public TransformType[] Transforms
            {
                get
                {
                    return this.transformsField;
                }
                set
                {
                    this.transformsField = value;
                }
            }

            /// <remarks/>
            public ReferenceTypeDigestMethod DigestMethod
            {
                get
                {
                    return this.digestMethodField;
                }
                set
                {
                    this.digestMethodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
            public byte[] DigestValue
            {
                get
                {
                    return this.digestValueField;
                }
                set
                {
                    this.digestValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
            public string URI
            {
                get
                {
                    return this.uRIField;
                }
                set
                {
                    this.uRIField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class ReferenceTypeDigestMethod
        {

            private string algorithmField;

            public ReferenceTypeDigestMethod()
            {
                this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
            public string Algorithm
            {
                get
                {
                    return this.algorithmField;
                }
                set
                {
                    this.algorithmField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public partial class SignedInfoTypeSignatureMethod
        {

            private string algorithmField;

            public SignedInfoTypeSignatureMethod()
            {
                this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
            public string Algorithm
            {
                get
                {
                    return this.algorithmField;
                }
                set
                {
                    this.algorithmField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
        [System.Xml.Serialization.XmlRootAttribute("inutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
        public partial class TInutNFe
        {

            private TInutNFeInfInut infInutField;


            private string versaoField;

            /// <remarks/>
            public TInutNFeInfInut infInut
            {
                get
                {
                    return this.infInutField;
                }
                set
                {
                    this.infInutField = value;
                }
            }


            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
            public string versao
            {
                get
                {
                    return this.versaoField;
                }
                set
                {
                    this.versaoField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public partial class TInutNFeInfInut
        {

            private TAmb tpAmbField;

            private TInutNFeInfInutXServ xServField;

            private TCodUfIBGE cUFField;

            private string anoField;

            private string cNPJField;

            private TMod modField;

            private string serieField;

            private string nNFIniField;

            private string nNFFinField;

            private string xJustField;

            private string idField;

            /// <remarks/>
            public TAmb tpAmb
            {
                get
                {
                    return this.tpAmbField;
                }
                set
                {
                    this.tpAmbField = value;
                }
            }

            /// <remarks/>
            public TInutNFeInfInutXServ xServ
            {
                get
                {
                    return this.xServField;
                }
                set
                {
                    this.xServField = value;
                }
            }

            /// <remarks/>
            public TCodUfIBGE cUF
            {
                get
                {
                    return this.cUFField;
                }
                set
                {
                    this.cUFField = value;
                }
            }

            /// <remarks/>
            public string ano
            {
                get
                {
                    return this.anoField;
                }
                set
                {
                    this.anoField = value;
                }
            }

            /// <remarks/>
            public string CNPJ
            {
                get
                {
                    return this.cNPJField;
                }
                set
                {
                    this.cNPJField = value;
                }
            }

            /// <remarks/>
            public TMod mod
            {
                get
                {
                    return this.modField;
                }
                set
                {
                    this.modField = value;
                }
            }

            /// <remarks/>
            public string serie
            {
                get
                {
                    return this.serieField;
                }
                set
                {
                    this.serieField = value;
                }
            }

            /// <remarks/>
            public string nNFIni
            {
                get
                {
                    return this.nNFIniField;
                }
                set
                {
                    this.nNFIniField = value;
                }
            }

            /// <remarks/>
            public string nNFFin
            {
                get
                {
                    return this.nNFFinField;
                }
                set
                {
                    this.nNFFinField = value;
                }
            }

            /// <remarks/>
            public string xJust
            {
                get
                {
                    return this.xJustField;
                }
                set
                {
                    this.xJustField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public enum TAmb
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1")]
            Item1,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2")]
            Item2,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public enum TInutNFeInfInutXServ
        {

            /// <remarks/>
            INUTILIZAR,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public enum TCodUfIBGE
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("11")]
            Item11,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("12")]
            Item12,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("13")]
            Item13,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("14")]
            Item14,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("15")]
            Item15,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("16")]
            Item16,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("17")]
            Item17,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("21")]
            Item21,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("22")]
            Item22,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("23")]
            Item23,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("24")]
            Item24,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("25")]
            Item25,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("26")]
            Item26,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("27")]
            Item27,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("28")]
            Item28,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("29")]
            Item29,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("31")]
            Item31,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("32")]
            Item32,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("33")]
            Item33,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("35")]
            Item35,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("41")]
            Item41,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("42")]
            Item42,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("43")]
            Item43,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("50")]
            Item50,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("51")]
            Item51,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("52")]
            Item52,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("53")]
            Item53,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public enum TMod
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("55")]
            Item55,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("65")]
            Item65,
        }
    }
}