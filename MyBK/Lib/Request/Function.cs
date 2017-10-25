using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBK.Lib.Request {
    class Function {
        public static String getValue(String str) {
            String[] list = str.Split(new char[] { ' ' });
            for (int i = 0; i < list.Length; i++)
                if (list[i].IndexOf("value") >= 0) {
                    String[] temp = list[i].Split(new char[] { '=' });
                    if (temp[1].EndsWith(">"))
                        return temp[1].Substring(1, temp[1].Length - 3);
                    else
                        return temp[1].Substring(1, temp[1].Length - 2);
                }
            return null;
        }
    }
}
