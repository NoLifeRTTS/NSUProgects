using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace События
{
    class Message
    {
        public void TextRecord()
        {
            using (StreamWriter sw = new StreamWriter(@"file.txt", true, System.Text.Encoding.Default))
            {
                sw.Write("назад ");
            }
        }
    }
}
