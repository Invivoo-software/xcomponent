﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;
using XComponent.SlackProxy.Common;

namespace XComponent.SlackProxy.Common.Senders
{
    public interface ISendMessageSendMessageOnPublishingPublishMessageSenderInterface
    {
		void Success(Context context);

		void Error(Context context);


		void Success(Context context, XComponent.SlackProxy.UserObject.Success transitionEvent, string privateTopic = null);

		void Error(Context context, XComponent.SlackProxy.UserObject.Error transitionEvent, string privateTopic = null);


		void SendEvent(XComponent.SlackProxy.UserObject.Success evt);

		void SendEvent(StdEnum stdEnum, XComponent.SlackProxy.UserObject.Success evt);

		void SendEvent(XComponent.SlackProxy.UserObject.Error evt);

		void SendEvent(StdEnum stdEnum, XComponent.SlackProxy.UserObject.Error evt);

    }

}