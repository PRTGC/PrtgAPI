﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgAPI.Tests.UnitTests.InfrastructureTests.Support;
using PrtgAPI.Tests.UnitTests.Support.TestItems;

namespace PrtgAPI.Tests.UnitTests.Support.TestResponses
{
    class TakeUnfilteredLogsForceStreamScenario : TakeScenario
    {
        protected override IWebResponse GetResponse(string address, Content content)
        {
            switch (requestNum)
            {
                case 1:
                    Assert.AreEqual(TestHelpers.RequestLogCount, address);
                    return GetTotalLogsResponse();

                case 2:
                    Assert.AreEqual(TestHelpers.RequestLog("count=2&start=1", UrlFlag.Columns), address);
                    return new MessageResponse(new MessageItem(), new MessageItem(), new MessageItem());

                default:
                    throw UnknownRequest(address);
            }
        }
    }
}