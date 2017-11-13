﻿////------------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated by XCTools.
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------
using System;
using XComponent.ChatManager.Common;
using XComponent.ChatManager.Common.Senders;
using XComponent.Runtime.Shared.TriggeredMethods;
using XComponent.Runtime.Shared.Manager;
using XComponent.Common.Logger;
using XComponent.Common.Logger.Logger;
using XComponent.Functions.Core;

namespace XComponent.ChatManager.TriggeredMethod
{
    public partial class TriggeredMethodContext : ICustomTriggeredMethodContext
    {
        private static ILogger _logger =  new XComponentLogger();
        
        private static ICustomTriggeredMethodContext instance = new TriggeredMethodContext();
        
        static TriggeredMethodContext()
        {
        }
        
        private TriggeredMethodContext()
        {
        }
        
        public static ICustomTriggeredMethodContext Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }

		public FunctionsManager ChatroomFunctionManager { get; set; }
		public FunctionsManager PublishedMessageFunctionManager { get; set; }
 
        private ComponentManager componentManager;
        
        public IComponentManager ComponentManager
        {
            get
            {
                return componentManager;
            }
        }
        
        public IComponentLogger GetLogger(LogKeyEnum loggerName)
        {
				return  Loggers.GetLogger(loggerName);
        }
        
        public void Init(ComponentManager componentMgrInput)
        {
				componentManager = componentMgrInput;
				var restEndpoint = string.IsNullOrEmpty(ComponentManager.FunctionsManagerConfiguration.RestEndpoint) 
					? FunctionsFactory.DefaultUrl 
					: new Uri(ComponentManager.FunctionsManagerConfiguration.RestEndpoint);
				_logger.Info(string.Format("Endpoint address : {0}", restEndpoint));
				_logger.Info(string.Format("Endpoint swagger address : {0}/swagger/ui/index", restEndpoint));

				Environment.SetEnvironmentVariable("OWIN_SERVER", "Microsoft.Owin.Host.HttpListener.OwinServerFactory, XComponent.Core");
				ChatroomFunctionManager = FunctionsFactory.CreateFunctionsManager(ComponentHelper.COMPONENT_NAME, "Chatroom", restEndpoint);
				PublishedMessageFunctionManager = FunctionsFactory.CreateFunctionsManager(ComponentHelper.COMPONENT_NAME, "PublishedMessage", restEndpoint);

				OnComponentInitialized();
        }
        
        public string GetParameterValue(KeyValueParametersEnum keyValueParameter)
        {
				if (componentManager.KeyValueParameters.IsKeyExists(keyValueParameter.ToString())) {
				return componentManager.KeyValueParameters.GetValue(keyValueParameter.ToString()); }
				return null;
        }
    }
    
    public partial interface ICustomTriggeredMethodContext : ITriggeredMethodContext
    {
        
        string GetParameterValue(KeyValueParametersEnum keyValueParameter);
        
        IComponentLogger GetLogger(LogKeyEnum loggerName);
        
        IComponentManager ComponentManager
        {
            get;
        }

		FunctionsManager ChatroomFunctionManager { get; }
		FunctionsManager PublishedMessageFunctionManager { get; }
	}
}