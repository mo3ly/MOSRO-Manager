using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSROManager
{
    class Utility
    {
        public static string HexDump(byte[] buffer)
        {
            return HexDump(buffer, 0, buffer.Length);
        }

        public static string HexDump(byte[] buffer, int offset, int count)
        {
            const int bytesPerLine = 16;
            StringBuilder output = new StringBuilder();
            StringBuilder ascii_output = new StringBuilder();
            int length = count;
            if (length % bytesPerLine != 0)
            {
                length += bytesPerLine - length % bytesPerLine;
            }
            for (int x = 0; x <= length; ++x)
            {
                if (x % bytesPerLine == 0)
                {
                    if (x > 0)
                    {
                        output.AppendFormat("  {0}{1}", ascii_output.ToString(), Environment.NewLine);
                        ascii_output.Clear();
                    }
                    if (x != length)
                    {
                        output.AppendFormat("{0:d10}   ", x);
                    }
                }
                if (x < count)
                {
                    output.AppendFormat("{0:X2} ", buffer[offset + x]);
                    char ch = (char)buffer[offset + x];
                    if (!char.IsControl(ch))
                    {
                        ascii_output.AppendFormat("{0}", ch);
                    }
                    else
                    {
                        ascii_output.Append(".");
                    }
                }
                else
                {
                    output.Append("   ");
                    ascii_output.Append(".");
                }
            }
            return output.ToString();
        }
        //public static string HexDump(byte[] buffer, int offset, int size)
        //{
        //    StringBuilder output = new StringBuilder();

        //    int[] fields = new int[16];
        //    int index = 0, cur = 0;
        //    int length = size;

        //    if (length == 0 || length % 16 != 0)
        //        length += 16 - (length % 16);

        //    for (int x = 0; x < length; ++x)
        //    {

        //        fields[index++] = cur < size ? buffer[x] : 0;
        //        ++cur;
        //        if (index == 16)
        //        {
        //            for (int y = 0; y < 16; ++y)
        //            {
        //                if (cur - 16 + y < size)
        //                {
        //                    //ss << std::hex << std::setfill('0') << std::setw(2) << fields[y] << " ";
        //                    output.AppendFormat("{0:X2} ", fields[y]); 
        //                }
        //                else
        //                {
        //                    output.Append("   ");
        //                }
        //            }

        //            output.Append("   ");

        //            for (int y = 0; y < 16; ++y)
        //            {
        //                if (cur - 16 + y < size)
        //                {
        //                    char ch = (char)fields[y];
        //                    if (!char.IsControl(ch))
        //                        output.AppendFormat("{0}", ch);
        //                    else
        //                        output.Append(".");
        //                }
        //                else
        //                {
        //                    output.Append(".");
        //                }
        //            }
        //            output.AppendLine();
        //            index = 0;
        //        }
        //    }
        //    Console.WriteLine(output.ToString());
        //    return output.ToString();
        //}
    }
}
