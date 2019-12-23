using MessageObj;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonObjectTest {
    class LongestMessage {
        private static void Main(string[] args) {
        
            JObject o1 = JObject.Parse(File.ReadAllText("C:\\Users\\nisv\\Documents\\ChatguiResources\\facebook-Niclas01\\messages\\inbox\\AllianceDivision_5Hy8r-YQIw\\message_1.json"));
            //JObject o1 = JObject.Parse(File.ReadAllText("D:\\AllianceDivision\\Big-search\\messages\\inbox\\AllianceDivision_5Hy8r-YQIw\\message_1.json"));
            List <Message> msg = JsonConvert.DeserializeObject<List<Message>>(o1["messages"].ToString());

            int maxLength = 0;
            Message maxMsg = null;

            foreach(var m in msg) {
                if (m.Content!=null && m.Content.Length > maxLength) {
                    maxLength = m.Content.Length;
                    maxMsg = m;
                }

            }

            Console.WriteLine(maxMsg.Content.Length);
        }
    }
}
