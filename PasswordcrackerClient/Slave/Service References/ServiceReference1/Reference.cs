﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Slave.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.CalculatorWSSoap")]
    public interface CalculatorWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoWork", ReplyAction="*")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoWork", ReplyAction="*")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Slave.ServiceReference1.HelloWorldResponse HelloWorld(Slave.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Slave.ServiceReference1.HelloWorldResponse> HelloWorldAsync(Slave.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        double Divide(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DivideAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        int Multiply(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/subtraction", ReplyAction="*")]
        int subtraction(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/subtraction", ReplyAction="*")]
        System.Threading.Tasks.Task<int> subtractionAsync(int a, int b);
        
        // CODEGEN: Generating message contract since element name MyListaResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyLista", ReplyAction="*")]
        Slave.ServiceReference1.MyListaResponse MyLista(Slave.ServiceReference1.MyListaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyLista", ReplyAction="*")]
        System.Threading.Tasks.Task<Slave.ServiceReference1.MyListaResponse> MyListaAsync(Slave.ServiceReference1.MyListaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Slave.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Slave.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Slave.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Slave.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MyListaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MyLista", Namespace="http://tempuri.org/", Order=0)]
        public Slave.ServiceReference1.MyListaRequestBody Body;
        
        public MyListaRequest() {
        }
        
        public MyListaRequest(Slave.ServiceReference1.MyListaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MyListaRequestBody {
        
        public MyListaRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MyListaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MyListaResponse", Namespace="http://tempuri.org/", Order=0)]
        public Slave.ServiceReference1.MyListaResponseBody Body;
        
        public MyListaResponse() {
        }
        
        public MyListaResponse(Slave.ServiceReference1.MyListaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MyListaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Slave.ServiceReference1.ArrayOfString MyListaResult;
        
        public MyListaResponseBody() {
        }
        
        public MyListaResponseBody(Slave.ServiceReference1.ArrayOfString MyListaResult) {
            this.MyListaResult = MyListaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorWSSoapChannel : Slave.ServiceReference1.CalculatorWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorWSSoapClient : System.ServiceModel.ClientBase<Slave.ServiceReference1.CalculatorWSSoap>, Slave.ServiceReference1.CalculatorWSSoap {
        
        public CalculatorWSSoapClient() {
        }
        
        public CalculatorWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Slave.ServiceReference1.HelloWorldResponse Slave.ServiceReference1.CalculatorWSSoap.HelloWorld(Slave.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Slave.ServiceReference1.HelloWorldRequest inValue = new Slave.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Slave.ServiceReference1.HelloWorldRequestBody();
            Slave.ServiceReference1.HelloWorldResponse retVal = ((Slave.ServiceReference1.CalculatorWSSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Slave.ServiceReference1.HelloWorldResponse> Slave.ServiceReference1.CalculatorWSSoap.HelloWorldAsync(Slave.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Slave.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            Slave.ServiceReference1.HelloWorldRequest inValue = new Slave.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Slave.ServiceReference1.HelloWorldRequestBody();
            return ((Slave.ServiceReference1.CalculatorWSSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public double Divide(double a, double b) {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double a, double b) {
            return base.Channel.DivideAsync(a, b);
        }
        
        public int Multiply(int a, int b) {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b) {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public int subtraction(int a, int b) {
            return base.Channel.subtraction(a, b);
        }
        
        public System.Threading.Tasks.Task<int> subtractionAsync(int a, int b) {
            return base.Channel.subtractionAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Slave.ServiceReference1.MyListaResponse Slave.ServiceReference1.CalculatorWSSoap.MyLista(Slave.ServiceReference1.MyListaRequest request) {
            return base.Channel.MyLista(request);
        }
        
        public Slave.ServiceReference1.ArrayOfString MyLista() {
            Slave.ServiceReference1.MyListaRequest inValue = new Slave.ServiceReference1.MyListaRequest();
            inValue.Body = new Slave.ServiceReference1.MyListaRequestBody();
            Slave.ServiceReference1.MyListaResponse retVal = ((Slave.ServiceReference1.CalculatorWSSoap)(this)).MyLista(inValue);
            return retVal.Body.MyListaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Slave.ServiceReference1.MyListaResponse> Slave.ServiceReference1.CalculatorWSSoap.MyListaAsync(Slave.ServiceReference1.MyListaRequest request) {
            return base.Channel.MyListaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Slave.ServiceReference1.MyListaResponse> MyListaAsync() {
            Slave.ServiceReference1.MyListaRequest inValue = new Slave.ServiceReference1.MyListaRequest();
            inValue.Body = new Slave.ServiceReference1.MyListaRequestBody();
            return ((Slave.ServiceReference1.CalculatorWSSoap)(this)).MyListaAsync(inValue);
        }
    }
}
