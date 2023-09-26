using SilkroadSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSROManager
{
    class PScriptParser
    {
        public static async Task Parse(string[] scriptLines)
        {
            Packet packet = null;
            for (int x = 0; x < scriptLines.Length; x++)
            {
                string line = scriptLines[x].Trim();

                // skip comments
                if (line.StartsWith("//"))
                {
                    Console.WriteLine("Trace: entered comment condition.");
                    continue;
                }

                // Parse Packet
                else if (line.StartsWith("packet") || line.StartsWith("Packet"))
                {
                    string[] values = StringExtensions.GetSubstringByString("(", ")", line).Split(',').Select(i => i.Trim()).ToArray();
                    // new Packet
                    if (values.Length == 3)
                    {
                        if(values[0].ToString().Length == 4 && (values[1].ToLower() == "true" || values[1].ToLower() == "false") && (values[2].ToLower() == "true" || values[2].ToLower() == "false"))
                        {
                            bool encrypted = values[1].ToLower() == "true" ? true : false;
                            bool massive = values[2].ToLower() == "true" ? true : false;
                            packet = new Packet(Convert.ToUInt16(values[0], 16), encrypted, massive);
                            Console.WriteLine("Trace: entered packet condition.");
                        }
                        else
                        {
                            new alert("Packet opcode must be 4 hex digits and other parameter must be (Encrypted, Massice) true or false.", 0);
                            return;
                        }
                    }
                    else
                    {
                        new alert("Packet is missing some parameters.", 0);
                    }
                }

                // hexbytes
                else if (line.StartsWith("hexbytes") || line.StartsWith("Hexbytes"))
                {
                    if (packet == null)
                    {
                        new alert("Hexbytes cannot be used without a declared packet.", 0);
                        return;
                    }

                    string bytes = StringExtensions.GetSubstringByString("(", ")", line);
                    packet.m_writer.Write(StringExtensions.StringToByteArray(bytes.Replace(" ", "")));

                    Console.WriteLine("Trace: entered hex bytes condition." + bytes);
                }

                // Params
                else if (line.StartsWith("param") || line.StartsWith("Param"))
                {
                    if (packet == null)
                    {
                        new alert("Param cannot be used without a declared packet.", 0);
                        return;
                    }

                    string[] values = StringExtensions.GetSubstringByString("(", ")", line).Split(',').Select(i => i.Trim()).ToArray();
                    if (values.Length == 2)
                    {
                        // int8
                        if (values[0] == "int8")
                            packet.WriteByte(byte.Parse(values[1]));
                        // int16
                        else if (values[0] == "int16")
                            packet.WriteShort(short.Parse(values[1]));
                        // int32
                        else if (values[0] == "int32")
                            packet.WriteInt(int.Parse(values[1]));
                        // int64
                        else if (values[0] == "int64")
                            packet.WriteLong(long.Parse(values[1]));
                        // uint8
                        if (values[0] == "uint8")
                            packet.WriteByte(byte.Parse(values[1]));
                        // uint16
                        else if (values[0] == "uint16")
                            packet.WriteUShort(ushort.Parse(values[1]));
                        // uint32
                        else if (values[0] == "uint32")
                            packet.WriteUInt(uint.Parse(values[1]));
                        // uint64
                        else if (values[0] == "uint64")
                            packet.WriteULong(ulong.Parse(values[1]));
                        // ascii
                        else if (values[0] == "ascii")
                            packet.WriteAscii(values[1]);
                        // uincode
                        else if (values[0] == "unicode")
                            packet.WriteUnicode(values[1]);

                        Console.WriteLine("Trace: entered param condition.");
                    }
                }

                // send
                else if (line.StartsWith("send") || line.StartsWith("Send"))
                {
                    if (packet == null)
                    {
                        new alert("Sand cannot be used without a declared packet.", 0);
                        return;
                    }

                    string direction = StringExtensions.GetSubstringByString("(", ")", line);
                    if (direction.ToLower() == "server")
                        Common.SRClient.SendToServer(packet);
                    else if (direction.ToLower() == "client")
                        Common.SRClient.SendToClient(packet);

                    Console.WriteLine("Trace: entered send condition.");
                }

                // Delay
                else if (line.StartsWith("delay") || line.StartsWith("Delay"))
                {
                    string delay = StringExtensions.GetSubstringByString("(", ")", line);
                    await Task.Delay(int.Parse(delay));

                    Console.WriteLine("Trace: entered delay condition.");
                }
            }
        }
    }
}
