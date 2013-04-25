//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                                
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace Terrarium.Services.Watson {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WatsonServiceSoap", Namespace="http://tempuri.org/")]
    public class WatsonService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public WatsonService() {
            this.Url = "http://lhsdkter2/Terrarium/watson/watson.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ReportError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ReportError(System.Data.DataSet data) {
            this.Invoke("ReportError", new object[] {
                        data});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReportError(System.Data.DataSet data, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReportError", new object[] {
                        data}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndReportError(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
}
