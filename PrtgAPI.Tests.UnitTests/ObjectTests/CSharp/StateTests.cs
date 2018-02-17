﻿using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgAPI.Tests.UnitTests.ObjectTests.TestResponses;

namespace PrtgAPI.Tests.UnitTests.ObjectTests
{
    [TestClass]
    public class StateTests : BaseTest
    {
        [TestMethod]
        public void AcknowledgeSensor_CanExecute() =>
            Execute(c => c.AcknowledgeSensor(1001, 30, "Acknowledging sensor"), "api/acknowledgealarm.htm?id=1001&ackmsg=Acknowledging+sensor&duration=30");

        [TestMethod]
        public async Task AcknowledgeSensor_CanExecuteAsync() =>
            await ExecuteAsync(async c => await c.AcknowledgeSensorAsync(1001, 30, "Acknowledging sensor"), "api/acknowledgealarm.htm?id=1001&ackmsg=Acknowledging+sensor&duration=30");

        [TestMethod]
        public void PauseObject_CanExecute() =>
            Execute(c => c.PauseObject(1001, 30, "Pausing sensor"), "api/pauseobjectfor.htm?id=1001&duration=30&pausemsg=Pausing+sensor");

        [TestMethod]
        public async Task PauseObject_CanExecute_CanExecuteAsync() =>
            await ExecuteAsync(async c => await c.PauseObjectAsync(1001, 30, "Pausing sensor"), "api/pauseobjectfor.htm?id=1001&duration=30&pausemsg=Pausing+sensor");

        [TestMethod]
        public void SimulateError_CanExecute() =>
            Execute(c => c.SimulateError(1001), "api/simulate.htm?id=1001&action=1");

        [TestMethod]
        public async Task SimulateError_CanExecuteAsync() =>
            await ExecuteAsync(async c => await c.SimulateErrorAsync(1001), "api/simulate.htm?id=1001&action=1");

        [TestMethod]
        public void Resume_CanExecute() =>
            Execute(c => c.ResumeObject(1001), "api/pause.htm?id=1001&action=1");

        [TestMethod]
        public async Task Resume_CanExecuteAsync() =>
            await ExecuteAsync(async c => await c.ResumeObjectAsync(1001), "api/pause.htm?id=1001&action=1");
    }
}
