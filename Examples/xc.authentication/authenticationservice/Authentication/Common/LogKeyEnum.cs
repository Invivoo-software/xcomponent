﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Logger.Managers;
using XComponent.Common.Logger;
using System.Collections.Generic;

namespace XComponent.Authentication.Common
{
    public enum LogKeyEnum
    {
    }

    public static class Loggers
    {
        readonly private static Dictionary<LogKeyEnum, IComponentLogger> _loggerByLogKeyEnum = new Dictionary<LogKeyEnum, IComponentLogger>();

        static Loggers()
        {
        }

        public static IComponentLogger GetLogger(LogKeyEnum loggerName)
        {
            return _loggerByLogKeyEnum[loggerName];
        }
    }
}