//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace XComponent.Authentication.Common
{
    using System;
    using XComponent.Common.ApiContext;
    using Microsoft.FSharp.Collections;
    using Microsoft.FSharp.Core;
    
    
    public interface IInternalAPI
    {
		void Initialize(Context context);
			
		void InitializationSuccess(Context context);
			
		void InitializationError(Context context);
			
		void CheckLogin(Context context);
			
		void CreateHeartBeat(Context context);
			
		void LoginSuccess(Context context);
			
		void LoginError(Context context);
			
		void NotifyUp(Context context);
			
		
		
		void Initialize(Context context, XComponent.Common.Event.DefaultEvent transitionEvent);
			
		void InitializationSuccess(Context context, XComponent.Authentication.UserObject.InitializationSuccess transitionEvent);
			
		void InitializationError(Context context, XComponent.Authentication.UserObject.InitializationError transitionEvent);
			
		void CheckLogin(Context context, XComponent.Authentication.UserObject.CheckLogin transitionEvent);
			
		void CreateHeartBeat(Context context, XComponent.Authentication.UserObject.CreateHeartBeat transitionEvent);
			
		void LoginSuccess(Context context, XComponent.Authentication.UserObject.LoginSuccess transitionEvent);
			
		void LoginError(Context context, XComponent.Authentication.UserObject.LoginError transitionEvent);
			
		void NotifyUp(Context context, XComponent.Common.Event.DefaultEvent transitionEvent);
			
		
		
		void SendEvent(XComponent.Authentication.UserObject.InitializationSuccess evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.InitializationSuccess evt);
			
		void SendEvent(XComponent.Authentication.UserObject.InitializationError evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.InitializationError evt);
			
		void SendEvent(XComponent.Authentication.UserObject.CheckLogin evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.CheckLogin evt);
			
		void SendEvent(XComponent.Authentication.UserObject.CreateHeartBeat evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.CreateHeartBeat evt);
			
		void SendEvent(XComponent.Authentication.UserObject.LoginSuccess evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.LoginSuccess evt);
			
		void SendEvent(XComponent.Authentication.UserObject.LoginError evt);
			
			void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.LoginError evt);
			
		
    }
}