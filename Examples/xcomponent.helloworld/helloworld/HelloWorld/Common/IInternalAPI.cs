//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace XComponent.HelloWorld.Common
{
    using System;
    using XComponent.Common.ApiContext;
    using Microsoft.FSharp.Collections;
    using Microsoft.FSharp.Core;
    
    
    public interface IInternalAPI
    {
		void SayHello(Context context);
			
		
		
		void SayHello(Context context, XComponent.HelloWorld.UserObject.SayHello transitionEvent);
			
		
		
		void SendEvent(XComponent.HelloWorld.UserObject.SayHello evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.HelloWorld.UserObject.SayHello evt);
			
		
    }
}