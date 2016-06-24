using SimpleBrowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace spintel_utility
{
    public class NF4V
    {
            public string SSID;
              string configureModem;
              public string wPassword;

       
        static string getSessionID(string html)
        {      // static since we dont need to instance another program class to run it

            string _pattern = @"var sessionKey='([^']+)';";
            Match match = Regex.Match(html, _pattern);
            if(match.Success)
            return match.Groups[1].Value;
            _pattern = @"sessionKey=(.+)';";
            match = Regex.Match(html, _pattern);
            
            return match.Groups[1].Value;
        }

        string getModemSerialNumber(String html)
        {
           
            string _pattern = @"\{(\d{12})\}";
            Match match = Regex.Match(html, _pattern);
            return match.Groups[1].Value;
            

         

        }
        string getModemModel(string html)
        {
            string modemtype = "default";
            string _pattern = @"NF4V";
            Match match = Regex.Match(html, _pattern);
            if (match.Success)
            {
                modemtype = "NF4V";

            }

            return (modemtype);
        }

        bool checkDSLError(string html)
        {      // static since we dont need to instance another program class to run it

            string _pattern = "DSL Interface Configuration Error";
            Match match = Regex.Match(html, _pattern);

            if (match.Success)
                configureModem = "Configuration Failed , please check modem has been reset";

            return match.Success;

        }

        static string ACSConfigString(string sessionKey)
        /* string Tr69cAcsPwd,
         string tr69cConnReqUser,
         string tr69cConnReqPwd,
         string tr69cConnReqPort,
         string tr69cAcsUrl,
         string informInterval) */
        {
            string _acspost;
            _acspost = "tr69cfg.cgi?tr69cEnable=1&tr69cInformEnable=1&tr69cInformInterval=86400&tr69cAcsURL=http://acs.syd.spintel.net.au:8080/openacs/acs&tr69cAcsUser=spintelacs&tr69cAcsPwd=Ac3leX20&tr69cConnReqUser=spintelacs&tr69cConnReqPwd=Ac3leX20&tr69cConnReqPort=30005&tr69cNoneConnReqAuth=0&tr69cDebugEnable=0&tr69cBoundIfName=Any_WAN&sessionKey=";
            _acspost = _acspost + sessionKey;
            // Console.Write(_acspost);
            return (_acspost);
        }



        public void nf4Vsetup()
        {

            var NF4Vmodem = new Browser();
            Browser.RefererModes ModemBrowserMode;
            // add referrer for NF4V"
            ModemBrowserMode = Browser.RefererModes.OriginWhenCrossOrigin;
            // add referrer for NF4V"


            NF4Vmodem.RefererMode = ModemBrowserMode;
            var modemURL = "http://192.168.20.1/";

            int timeOut = 3000;
            NF4Vmodem.Navigate(modemURL, timeOut);

            if (NF4Vmodem.RequestData().ResponseCode != 401)
            {

                configureModem = "modem is not online, please connect,wait and click again";
                return;
            }

            //    Console.Write("get url");
            //    modem.BasicAuthenticationLogin("Broadband Router","admin","admin");
            NF4Vmodem.BasicAuthenticationLogin("192.168.20.1", "admin", "admin");

            modemURL = "http://192.168.20.1";

            NF4Vmodem.Navigate(modemURL);

            //determine serial number

            modemURL = "http://192.168.20.1/info.html";
            NF4Vmodem.Navigate(modemURL);
            string serialNumber = getModemSerialNumber(NF4Vmodem.CurrentHtml);
            string username = serialNumber + "-spintelacs";

            // setup adsl
            modemURL = "http://192.168.20.1/qinetsetup.html ";
            NF4Vmodem.Navigate(modemURL);
            string sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/qadslwanmode.cgi?wanType=1&enblOnDemand=0&pppTimeOut=0&enblv4=1&useStaticIpAddress=0&pppIpExtension=0&enblFirewall=1&enblNat=1&enblIgmp=1&enblPppDebug=0&maxMtu=1492&keepalive=0&enblv6=0&pppAuthErrorRetry=0&pppAuthMethod=0&sessionKey=";
            modemURL = modemURL + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);

            modemURL = "http://192.168.20.1/qadslppp.cgi?ntwkPrtcl=0&keepalive=1&keepalivetime=5&alivemaxfail=30&sessionKey=";
            modemURL = modemURL + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/qsetup.cmd?pppUserName="
            + username + "&pppPassword=" +
            "spin2000&atmVpi=8&atmVci=35&portId=0&linkType=EoA&connMode=1&encapMode=0&atmServiceCategory=UBR&atmPeakCellRate=0&atmSustainedCellRate=0&atmMaxBurstSize=0&atmMinCellRate=-1&enblQos=1&grpPrec=8&grpAlg=WRR&grpWght=1&alg=WRR&wght=1&prec=8&sessionKey=";
            modemURL = modemURL + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            modemURL = "http://192.168.20.1/qinetsetup.html ";
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/qvdslwanmode.cgi?wanType=2&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/qvdslppp.cgi?ntwkPrtcl=0&enblOnDemand=0&pppTimeOut=0&enblv4=1&useStaticIpAddress=0&pppIpExtension=0&enblFirewall=1&enblNat=1&enblIgmp=1&keepalive=1&keepalivetime=5&alivemaxfail=30&enVlanMux=0&vlanMuxId=-1&vlanMuxPr=-1&enblPppDebug=0&maxMtu=1492&keepalive=0&enblv6=0&pppAuthErrorRetry=0&pppAuthMethod=0&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/qsetup.cmd?pppUserName="+ username+"&pppPassword=spin200&portId=0&ptmPriorityNorm=1&ptmPriorityHigh=1&connMode=1&burstsize=3000&enblQos=1&grpPrec=8&grpAlg=WRR&grpWght=1&prec=8&alg=WRR&wght=1&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            modemURL = "http://192.168.20.1/qinetsetup.html";
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/qethwanmode.cgi?wanType=3&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/qethppp.cgi?enblEnetWan=0&ntwkPrtcl=12&enblIpVer=0&enblOnDemand=0&pppTimeOut=0&enblv4=1&useStaticIpAddress=0&pppIpExtension=0&enblFirewall=1&enblNat=1&enblIgmp=1&keepalive=1&keepalivetime=5&alivemaxfail=30&enVlanMux=0&vlanMuxId=-1&vlanMuxPr=-1&enblPppDebug=0&maxMtu=1492&pppAuthErrorRetry=0&pppAuthMethod=0&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/qsetup.cmd?pppUserName="+ username+"&pppPassword=spin2000&ifname=eth4&portId=0&ptmPriorityNorm=1&ptmPriorityHigh=1&connMode=1&burstsize=3000&enblQos=1&grpPrec=8&grpAlg=WRR&grpWght=1&prec=8&alg=WRR&wght=1&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            configureACS(NF4Vmodem);
            // add inbound firewall table and rules
            modemURL = "http://192.168.20.1/firewall.cmd?action=view";
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/firewall.cmd?action=add&objtype=firewall&Name=inbound&interface=&Type=In&defaultAction=Permit&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/firewall.cmd?action=add&objtype=rule&firwallid=1&enabled=1&IPVersion=4&Protocol=TCP&RuleAction=Permit&RejectType=Null&IcmpType=Null&origIPAddress=202.172.107.0&origMask=255.255.255.0&origStartPort=&origEndPort=&destIPAddress=&destMask=&destStartPort=51003&destEndPort=51003&packetLenMix=&packetLenMax=&dscp=-1&tcpFlag=&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            sessionKey = getSessionID(NF4Vmodem.CurrentHtml);
            modemURL = "http://192.168.20.1/firewall.cmd?action=add&objtype=rule&firwallid=1&enabled=1&IPVersion=4&Protocol=TCP&RuleAction=Drop&RejectType=Null&IcmpType=Null&origIPAddress=&origMask=&origStartPort=&origEndPort=&destIPAddress=&destMask=&destStartPort=51003&destEndPort=51003&packetLenMix=&packetLenMax=&dscp=-1&tcpFlag=&sessionKey=" + sessionKey;
            NF4Vmodem.Navigate(modemURL);
            NF4Vmodem.Close();


        }


        void configureACS(Browser modem)
        {
            configureModem = "Configuring ACS";
            var modemURL = "http://192.168.20.1/tr69cfg.html";
            int timeOut = 3000;
            if (!modem.Navigate(modemURL, timeOut))
            {
                configureModem = "modem is not connected, please connect and click again";
                return;
            }

            var html = modem.CurrentHtml;
            string sessionKey = getSessionID(html);

            var getstringACS = ACSConfigString(sessionKey);
            modemURL = "http://192.168.20.1/";
            modemURL = modemURL + getstringACS;
            modem.Navigate(modemURL);
        }
    }
}

