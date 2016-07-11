using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace spintel_utility
{
    class IPaddressTools
    {
        static public string LongToIPAddress(uint IPAddr)
        {
            return new System.Net.IPAddress(IPAddr).ToString();
        }
        static public uint reverseBytesArray(uint ip)
        {
            byte[] bytes = BitConverter.GetBytes(ip);
            bytes = bytes.Reverse().ToArray();
            return (uint)BitConverter.ToInt32(bytes, 0);
        }

        string incrementIPaddress(String ipIn, int offset)
        {
            IPAddress Realip = IPAddress.Parse("61.69.101.118");
            byte[] byteIP = Realip.GetAddressBytes();
            var byteIP3 = byteIP[3] + 1;
            uint ip = (uint)byteIP[3] << 24;
            ip += (uint)byteIP[2] << 16;
            ip += (uint)byteIP[1] << 8;
            ip += (uint)byteIP[0];
            ip = reverseBytesArray(ip);
            ip = ip + 1;
            ip = reverseBytesArray(ip);
            return (LongToIPAddress(ip));

        }

      
    }

}

