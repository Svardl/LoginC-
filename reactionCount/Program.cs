using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace reactionCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            String path = "D:\\AllianceDivision\\message_1.json";
            JObject o1 = JObject.Parse(File.ReadAllText(path));
            Dictionary<string, List<string>[]> react = new Dictionary<string, List<string>[]>();

            foreach (var message in o1["messages"]) {
                if (message["reactions"] != null) {
                    if (!react.ContainsKey(message["sender_name"].ToString())) {
                        react.Add(message["sender_name"].ToString(), new List<String>[] { new List<string>(), new List<string>() });
                    }
                    foreach (var reaction in message["reactions"]) {
                        String reauth = reaction["actor"].ToString();
                        if (!react.ContainsKey(reauth)) {
                            react.Add(reauth, new List<String>[] { new List<string>(), new List<string>() });
                        }
                        react[reauth][1].Add(@reaction["reaction"].ToString());
                        react[message["sender_name"].ToString()][0].Add(@reaction["reaction"].ToString());
                    }
                }
            }

            foreach (String name in react.Keys) {

                Console.WriteLine(name + " has reacted on messages " + react[name][1].Count + " times and other people have reacted to their messages " + react[name][0].Count + " times");
                Console.WriteLine();
            }

            string chosen = null;
            while (chosen == null) {
                Console.WriteLine("Whose reaction do you want to investigate?");
                string who = Console.ReadLine().ToLower();


                foreach (string name in react.Keys) {
                    if (name.ToLower().Contains(who)) {
                        chosen = name;
                        break;
                    }
                }
            }
            Dictionary<string, int> emojiNum = new Dictionary<string, int>();
           
            foreach (string @emoji in react[chosen][0]) {
                string emojiText = emojiConversion(emoji);
                if (!emojiNum.ContainsKey(emojiText)){
                    emojiNum.Add(emojiText, 1);
                }
                else {
                    emojiNum[emojiText]++;
                }
            }
            Console.WriteLine("Other people's reactions to their messages: ");
            Console.WriteLine();
            foreach (String emojis in emojiNum.Keys) {
                Console.WriteLine(emojis + " " + emojiNum[emojis] + " times");
                Console.WriteLine();
            }

        }
        public static string emojiConversion(string emoji){
           
            switch (emoji) {
                case "\u00f0\u009f\u0098\u008d":
                    return "Heart eyes emoji";
                    
                case "\u00f0\u009f\u0098\u00ae":
                    return "Shocked emoji";
                    
                case "\u00f0\u009f\u0098\u0086":
                    return "Grinning Squinting Face";
                   
                case "\u00f0\u009f\u0098\u00a2":
                    return "Crying Face";
                   
                case "\u00f0\u009f\u0091\u0080":
                    return "Eyes";
                   
                case "\u00f0\u009f\u0098\u00a0":
                    return "Angry Face";
                    
                case "\u00f0\u009f\u0091\u008d":
                    return "Thumbs Up";
                  
                case "\u00f0\u009f\u0091\u008e":
                    return "Thumbs Down";
                    
                default:
                    return "Missing";
                    
            }


        }
    }
}
