using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQReiverCoreAPI
{
    //public static class AppConstant
    //{

    //    public static string UrlApi = "http://localhost:54571";
    //}
    public class FileJson
    {
        public string JsonString { get; set; }
    }
    public static class RabbitMQSetting
    {
        public static string hostName = "35.247.178.47";
        public static string username = "admin";
        public static string password = "indocyber";
        public static string exchangeName = "LOS.E.Direct.Leads";
        public static string queueName = "LOS.Q.Leads";
        public static string routingKey = "Leads";
        public static string message = "Test Leads";

        //public static string exchangeName = "LOS.E.Direct.Leads";
        //public static string queueName = "LOS.Q.Leads";
        //public static string routingKey = "Leads";
        //public static string username = "admin";
        //public static string password = "indocyber";

        //public static string username = "guest";
        //public static string password = "guest";
    }
}
