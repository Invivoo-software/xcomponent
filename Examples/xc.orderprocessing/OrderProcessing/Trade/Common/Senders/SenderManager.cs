﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Trade.Common;

namespace XComponent.Trade.Common.Senders
{
    public class SenderManager
    {
		private static ProcessOrderCreationOrderCreationOnUpTradeProcessorSender _processOrderCreationOrderCreationOnUpTradeProcessorSender;
		private static ExecuteTradeTradeExecutionOnUpTradeProcessorSender _executeTradeTradeExecutionOnUpTradeProcessorSender;
		private static ProcessOrderExecutionOrderExecutionOnUpTradeProcessorSender _processOrderExecutionOrderExecutionOnUpTradeProcessorSender;
		private static ExecuteTradeExecutionOnExecutedTradeSender _executeTradeExecutionOnExecutedTradeSender;
		private static CreateTradeTradeOnWaitingForExecutionTradeSender _createTradeTradeOnWaitingForExecutionTradeSender;

        public static ProcessOrderCreationOrderCreationOnUpTradeProcessorSender ProcessOrderCreationOrderCreationOnUpTradeProcessorSender
        {
            get
            {
                return _processOrderCreationOrderCreationOnUpTradeProcessorSender ??
                       (_processOrderCreationOrderCreationOnUpTradeProcessorSender = new ProcessOrderCreationOrderCreationOnUpTradeProcessorSender());
            }
        }

        public static ExecuteTradeTradeExecutionOnUpTradeProcessorSender ExecuteTradeTradeExecutionOnUpTradeProcessorSender
        {
            get
            {
                return _executeTradeTradeExecutionOnUpTradeProcessorSender ??
                       (_executeTradeTradeExecutionOnUpTradeProcessorSender = new ExecuteTradeTradeExecutionOnUpTradeProcessorSender());
            }
        }

        public static ProcessOrderExecutionOrderExecutionOnUpTradeProcessorSender ProcessOrderExecutionOrderExecutionOnUpTradeProcessorSender
        {
            get
            {
                return _processOrderExecutionOrderExecutionOnUpTradeProcessorSender ??
                       (_processOrderExecutionOrderExecutionOnUpTradeProcessorSender = new ProcessOrderExecutionOrderExecutionOnUpTradeProcessorSender());
            }
        }

        public static ExecuteTradeExecutionOnExecutedTradeSender ExecuteTradeExecutionOnExecutedTradeSender
        {
            get
            {
                return _executeTradeExecutionOnExecutedTradeSender ??
                       (_executeTradeExecutionOnExecutedTradeSender = new ExecuteTradeExecutionOnExecutedTradeSender());
            }
        }

        public static CreateTradeTradeOnWaitingForExecutionTradeSender CreateTradeTradeOnWaitingForExecutionTradeSender
        {
            get
            {
                return _createTradeTradeOnWaitingForExecutionTradeSender ??
                       (_createTradeTradeOnWaitingForExecutionTradeSender = new CreateTradeTradeOnWaitingForExecutionTradeSender());
            }
        }

    }
}