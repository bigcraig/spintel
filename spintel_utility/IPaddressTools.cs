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

        public string decrementIPaddress(String ipIn, uint offset)
        {
            IPAddress iPAddressOut;
            if (!IPAddress.TryParse(ipIn,out iPAddressOut))
                return ("IPAddress address invalid");
            IPAddress Realip = IPAddress.Parse(ipIn);
            byte[] byteIP = Realip.GetAddressBytes();
           
            uint ip = (uint)byteIP[3] << 24;
            ip += (uint)byteIP[2] << 16;
            ip += (uint)byteIP[1] << 8;
            ip += (uint)byteIP[0];
            ip = reverseBytesArray(ip);
            ip = ip - offset;
            ip = reverseBytesArray(ip);
            return (LongToIPAddress(ip));

        }

      
    }

}

