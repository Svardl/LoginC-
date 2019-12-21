using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MessageObj;

namespace JsonObjectTest {
    class MainJson {
        static void InARow() {
            Dictionary<string, int> arow = new Dictionary<string, int>();

            JObject o1 = JObject.Parse(File.ReadAllText("D:\\AllianceDivision\\Big-search\\messages\\inbox\\AllianceDivision_5Hy8r-YQIw\\message_1.json"));
            List<Message> msg = JsonConvert.DeserializeObject<List<Message>>(o1["messages"].ToString());
            string eyes = "\u00f0\u009f\u0091\u0080";

            string prevSender = msg[0].SenderName;
            int count = 0;
            foreach (Message m in msg) {
                string currSender = m.SenderName;
                if (!arow.ContainsKey(currSender)) {
                    arow.Add(currSender, 0);
                }
                if (currSender.Equals(prevSender) && (m.Content==null || !m.Content.Equals(eyes))) {
                    count++;
                    if (count > 19) {
                        Console.WriteLine("hre");
                    }
                }
                else {
                    arow[prevSender] = arow[prevSender] < count ? count : arow[prevSender];
                    count = 1;
                }
                prevSender = currSender;
                
            }
            foreach (var name in arow.Keys) {
                Console.WriteLine(name +": " + arow[name]);
            }
        }
    }
}
