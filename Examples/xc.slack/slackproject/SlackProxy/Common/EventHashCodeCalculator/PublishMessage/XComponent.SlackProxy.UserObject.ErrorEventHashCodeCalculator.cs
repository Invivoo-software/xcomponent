﻿using System;
using System.Collections.Generic;
using XComponent.Common.Helper;
using XComponent.Engine.Execution.HashCode;
using XComponent.Logger.Loggers;

namespace XComponent.SlackProxy.Common.EventHashCodeCalculator.PublishMessage
{
    public class ErrorEventHashCodeCalculator : IEventHashCodeCalculator
    {
		private XComponentLogger _logger = new XComponentLogger();

        public IEnumerable<int> Calculate(object rawEvent)
        {
			var typedEvent = rawEvent as XComponent.SlackProxy.UserObject.Error;
			if(typedEvent == null)
			{
				_logger.Error(string.Format("{0}EventHashCodeCalculator should be called with event {1} instead of {2}. This may be due to a generation problem.", "Error", "XComponent.SlackProxy.UserObject.Error", rawEvent != null ? rawEvent.GetType().ToString() : string.Empty));
				yield break;
			}

            yield return 0;
        }
    }
}