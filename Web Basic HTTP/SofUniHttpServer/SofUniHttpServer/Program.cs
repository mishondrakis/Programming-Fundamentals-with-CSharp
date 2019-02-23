﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SofUniHttpServer
{
   public static class Program
    {
        public static void Main(string[] args)
        {
            IHttpServer server = new HttpServer();

            server.Start();
        }
    }

    public interface IHttpServer
    {
        void Start();

        void Stop();
    }

    public class HttpServer : IHttpServer
    {
        private bool IsWorking; 

        private TcpListener tcpListener;

        public HttpServer()
        {
            this.tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
        }

        public void Start()
        {
            this.IsWorking = true;
            this.tcpListener.Start();

            while (this.IsWorking)
            {
                var client  =   this.tcpListener.AcceptTcpClient();
                var buffer = new byte[10000];
                var stream =  client.GetStream();
                var readLength =  stream.Read(buffer,0,buffer.Length);
                var requestTex = Encoding.UTF8.GetString(buffer, 0, readLength);
                Console.WriteLine(new string ('=',60));
                Console.WriteLine(requestTex);
                
            }
        }

        public void Stop()
        {
            this.IsWorking = false;
        }
    }


}
