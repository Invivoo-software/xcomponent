﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using XComponent.Engine.Processing;
using XComponent.Common.Processing;
using XComponent.Engine.Processing.Domain;
using XComponent.Common.ApiContext;
using XComponent.Communication;

namespace XComponent.Referential.Common
{
    public class InternalCommunication : IInternalCommunication
    {
        private const string ComponentName = "Referential";

		private IAgentManager _agentManager;
        private Dictionary<int, EngineAgent> _engineAgentsById = new Dictionary<int, EngineAgent>();
        private Dictionary<int, List<EngineAgent>> _engineAgentsByStateMachine = new Dictionary<int, List<EngineAgent>>();

        public InternalCommunication(IAgentManager agentManager)
        {
            _agentManager = agentManager;
        }
		
        public void Init(string configFile)
        {
			foreach( var engineAgent in _agentManager.FilterEngineAgentForInternalAPI(1667656897))
			{
				_engineAgentsById.Add(engineAgent.Id, engineAgent);
				
				foreach( var detail in Agent.getAgentDetails(engineAgent))
				{
					if (detail.Key.Equals(1667656897))
					{
						foreach( var stateMachineCode in detail.Value )
						{
							if(!_engineAgentsByStateMachine.ContainsKey(stateMachineCode))
							{
								_engineAgentsByStateMachine.Add(stateMachineCode, new List<EngineAgent>());
							}

							_engineAgentsByStateMachine[stateMachineCode].Add(engineAgent);
						}
					}
				}
			}
        }

		public void Send(Context context, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), IncomingEventType.Transition, HeaderFactory.Create(context, 6, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Referential, evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), IncomingEventType.Transition, HeaderFactory.Create(6, (int)stateMachineEnum, 1667656897, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Referential.UserObject.Instrument evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.Instrument(), IncomingEventType.Transition, HeaderFactory.Create(context, 9, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Referential.UserObject.Instrument evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Referential, evt != null ? evt : new XComponent.Referential.UserObject.Instrument(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Referential.UserObject.Instrument evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.Instrument(), IncomingEventType.Transition, HeaderFactory.Create(9, (int)stateMachineEnum, 1667656897, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.GetSnapshot(), IncomingEventType.Transition, HeaderFactory.Create(context, 8, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Referential, evt != null ? evt : new XComponent.Referential.UserObject.GetSnapshot(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.GetSnapshot(), IncomingEventType.Transition, HeaderFactory.Create(8, (int)stateMachineEnum, 1667656897, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		private void PostOnStateMachine(IncomingEvent incomingEvent, StdEnum stateMachineEnum)
		{
			foreach(var engineAgent in GetEngineAgents(stateMachineEnum))
			{
				Agent.Post(engineAgent, incomingEvent);
			}
		}

		private IEnumerable<EngineAgent> GetEngineAgents(StdEnum stateMachineEnum)
        {
			switch(stateMachineEnum)
			{
				case StdEnum.Referential :
					return _engineAgentsByStateMachine[1667656897];
			}

            return new List<EngineAgent>();
        }
    }
}
