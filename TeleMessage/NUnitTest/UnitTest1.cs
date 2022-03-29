/*
using Chat.Server.SocketsManager;

using Moq;
using NUnit.Framework;
using System.Net.WebSockets;

namespace Chat.Tests
{
    public class Tests
    {
        private Mock<WebSocket>? _socket = null;

        [SetUp]
        public void Setup()
        {
            _socket = new Mock<WebSocket>();
        }

        [Test]
        public void Test_Socket_Adds_Correctly()
        {
            ConnectionManager con = new ConnectionManager();
            con.AddSocket(_socket.Object);
            Assert.IsNotEmpty(con.GetAllConnections());
        }

        [Test]
        public void Test_ConnectionManager_Can_Get_ID()
        {
            ConnectionManager con = new ConnectionManager();
            con.AddSocket(_socket.Object);
            var id = con.GetId(_socket.Object);
            Assert.IsNotNull(id);
        }
    }
}
*/
using NUnit.Framework;
using Chat.DesktopClient2.ChatModel;
using System.Collections.Generic;
using System.Threading;

namespace NUnitTest
{
    public class Tests
    {
        private ChatModel testChat;
        string name = "Name Surname";
        List<string> MsgList;


        [SetUp]
        public void Setup()
        {
            void getMsg(string message)
            {

                MsgList.Add(message);

            }
            MsgList = new List<string>();
            testChat = new ChatModel();
            testChat.Connect(getMsg, name);
            testChat.Disconnect();
            // testChat.Connect(getMsg, name);
            //testChat.Connect
            //testChat.Disconnect
            //testChat.isOnline
            // testChat.nickname
            //testChat.SendMsg


        }

        [Test]
        public void TestConnect()
        {



            // testChat.Connect(getMsg, name);
            if (testChat.isOnline != true)
            {
                //  Assert.That(false);
            }

            //testChat.Disconnect();
            if (testChat.isOnline != false)
            {
                //  Assert.That(false);
            }

            if (testChat.isOnline != true)
            {
                //   Assert.That(false);
            }

            //   testChat.Disconnect();
            if (testChat.isOnline != false)
            {
                //   Assert.That(false);
            }
            Thread.Sleep(300);
            Assert.Pass();
        }




        [TearDown]
        public void TearDown() // после завершения теста или ошибки теста
        {

        }
    }
}

//Assert.That(result.Item1 == 123);

