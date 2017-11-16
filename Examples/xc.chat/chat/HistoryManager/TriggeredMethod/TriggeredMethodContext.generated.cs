﻿////------------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated by XCTools.
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------
using System;
using XComponent.HistoryManager.Common;
using XComponent.HistoryManager.Common.Senders;
using XComponent.Runtime.Shared.TriggeredMethods;
using XComponent.Runtime.Shared.Manager;
using XComponent.Common.Logger;
using XComponent.Common.Logger.Logger;

namespace XComponent.HistoryManager.TriggeredMethod
{
    public partial class TriggeredMethodContext : ICustomTriggeredMethodContext
    {
        enum DefaultLogger
        {
            HistoryManagerDefaultLogger
        }

        private IComponentLogger _defaultLogger = XComponent.Common.Logger.Managers.ComponentLoggerManager<DefaultLogger>.GetComponentLogger(DefaultLogger.HistoryManagerDefaultLogger, ComponentHelper.COMPONENT_NAME);

        
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

		public IComponentLogger GetDefaultLogger()
		{
				return  _defaultLogger;
		}
 
 
        public void Init(ComponentManager componentMgrInput)
        {
				_defaultLogger.Enable();
				componentManager = componentMgrInput;

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

        IComponentLogger GetDefaultLogger();

        IComponentManager ComponentManager
        {
            get;
        }

	}
}