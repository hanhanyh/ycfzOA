using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
namespace UI
{
    public  class GGClient
    {
        public Thread mWorkThread;
        public Socket mClientSocket;
        public delegate void  RecvHandler(string data);//接收数据委托
        public event RecvHandler eventRecvd;//接收数据事件
       
        //public delegate void connedHandler();//连接成功委托
        //public event connedHandler eventConned;//连接成功事件
        public GGClient()
        {
            start();//开始连接
        }
        //发送数据（发送数据的函数在主线程 不影响子线程的阻塞）
        public void sendData(string data)
        {
          //  string sendStr = "send to server : hello,ni hao";
            byte[] sendBytes = Encoding.UTF8.GetBytes(data);//为了支持中文这里编码和 接收的时候解码 都要使用UTF8而并不是ASCII
            mClientSocket.Send(sendBytes);
        }
        //接收数据的循环   （子线程阻塞）
        public void loop()
        {
            while (true)
            {
                string recStr = "";
                byte[] recBytes = new byte[4096];
                int bytes = mClientSocket.Receive(recBytes, recBytes.Length, 0);
                recStr += Encoding.UTF8.GetString(recBytes, 0, bytes);
                if (eventRecvd != null)//发送接收事件
                {
                    eventRecvd(recStr);
                }
            }
           
           // Console.WriteLine(recStr);
        }
        //开启
        public void start()
        {
            int port = 1997;
            string host = "119.29.11.92";//服务器端ip地址

            IPAddress ip = IPAddress.Parse(host);
            IPEndPoint ipe = new IPEndPoint(ip, port);

            mClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
              
                mClientSocket.Connect(ipe);
                this.mWorkThread = new Thread(new ThreadStart(loop));
                
                this.mWorkThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);//连接服务器失败异常
            }
           
            //if (eventConned != null)
            //{
            //    eventConned();//调用事件处理函数
            //}
           
            ////send message
            //string sendStr = "send to server : hello,ni hao";
            //byte[] sendBytes = Encoding.ASCII.GetBytes(sendStr);
            //clientSocket.Send(sendBytes);

            //receive message
            //string recStr = "";
            //byte[] recBytes = new byte[4096];
            //int bytes = clientSocket.Receive(recBytes, recBytes.Length, 0);
            //recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
            //Console.WriteLine(recStr);

            //clientSocket.Close();
        }
    }
}
