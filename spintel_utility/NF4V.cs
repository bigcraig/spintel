using SimpleBrowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CraigTelnet;

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
            if(match.Success)
            return match.Groups[1].Value;

            // NF10WV doesnt have braces around serial number value, will attempt polymorphism through using return on match
            _pattern = @"\>(\d{12})\<";
            match = Regex.Match(html, _pattern);
            if (match.Success)
                return match.Groups[1].Value;
            return("fail");



        }
        string getModemMACTelnet()
        {
            //currently assume telnet is active which is the case with NF10W(V)
            TelnetConnection tc = new TelnetConnection("192.168.20.1", 23);

            //login with user "root",password "rootpassword", using a timeout of 100ms, and show server output
            string s = tc.Login("admin", "admin", 100);
            Console.Write(s);

            // server output should end with "$" or ">", otherwise the connection failed
            string prompt = s.TrimEnd();
            prompt = s.Substring(prompt.Length - 1, 1);
            if (prompt != "$" && prompt != ">")
                throw new Exception("Connection failed");

            tc.WriteLine("macaddr");
            string output = tc.Read();
            string[] result = output.Split(new string[] { "\n", "\r\n" },
             StringSplitOptions.RemoveEmptyEntries);
            string macAddress = result[1];
            // close telnet session
            tc.WriteLine("exit");
            


            return (macAddress);
        }
        void saveModemDefaults(Browser modem,string port)
        {
            string modemURL = "http://192.168.20.1:" + port;
            modem.Navigate(modemURL + "/configdefaultlogin.html");
            modem.Navigate(modemURL + "/configdefault.cgi?thirdConfigMode=3&cdUser=root&cdPwd=netcommdefault");
            modem.Navigate(modemURL + "/configdefault.cgi?thirdConfigMode=1");


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
       
        public  Browser initialiseModem()
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
                return NF4Vmodem;
            }

            //    Console.Write("get url");
            //    modem.BasicAuthenticationLogin("Broadband Router","admin","admin");
            NF4Vmodem.BasicAuthenticationLogin("192.168.20.1", "admin", "admin");
            return NF4Vmodem;
        }


        public void nf4Vsetup()
        {
           // getModemMACTelnet();
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
            configureVoip(NF4Vmodem,"sip.iboss.com.au","sip.iboss.com.au","09802390000610","F2P66PB3");
          //  configureServices(NF4Vmodem);
         //   saveModemDefaults(NF4Vmodem,"51003");
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
        void configureServices(Browser modem)
        {

            var modemURL = "http://192.168.20.1/backupsettings.html";
            modem.Navigate(modemURL);
            modemURL = "http://192.168.20.1/password.html";
            modem.Navigate(modemURL);
            modemURL = "http://192.168.20.1/scsrvcntr.html";
            modem.Navigate(modemURL);
            modemURL = "http://192.168.20.1/scsrvcntr.cmd?servicelist=HTTP=1,1,51003;TELNET=1,0,23;SSH=1,0,22;FTP=1,0,21;TFTP=1,0,69;ICMP=1,1,0;SNMP=1,0,161;SAMBA=1,0,445;";
            modem.Navigate(modemURL);


        }
        public void configureVoip(Browser modem,string sipDomain, string sipProxy, string login, string password)
        {  
            var modemURL = "http://192.168.20.1/voicesip_basic.html";
            //var sipDomain = "sip.iboss.com.au";
            //var sipProxy = sipDomain;
            modem.Navigate(modemURL);
            string sessionKey = getSessionID(modem.CurrentHtml);
            modemURL = "http://192.168.20.1/voicesipapply.cmd?currentview=basic&ifName=Any_WAN&localeName=AUS&proxyAddr0="
                +sipProxy +"&proxyPort0=5060&obProxyAddr0=" 
                + sipProxy +
                "&obProxyPort0=5060&regAddr0=" + sipDomain +"&regPort0=5060&domainName0=" +sipDomain +
                "&proxyAddr20=0.0.0.0&proxyPort20=5060&obProxyAddr20=0.0.0.0&obProxyPort20=5060&regAddr20=0.0.0.0&regPort20=5060&siplocalport0=5060&authName0_0="
                + login + "&password0_0=" + password +"&cidName0_0="
                + login +"&cidNumber0_0=" 
                + login +"&lineEnabled0_0=on&polarityreverseEnable0_0=off&codecList0_0=G711U,20,2,1:G711A,20,3,1:G729,20,1,1:G723_63,30,4,1:G726_24,20,5,1:G726_32,20,6,1:G726_16,20,7,1:G726_40,20,8,1:G722,20,9,1&authName0_1=&password0_1=&cidName0_1=&cidNumber0_1=&lineEnabled0_1=on&polarityreverseEnable0_1=off&codecList0_1=G711U,20,1,1:G711A,20,2,1:G729,20,3,1:G723_63,30,4,1:G726_24,20,5,1:G726_32,20,6,1:G726_16,20,7,1:G726_40,20,8,1:G722,20,9,1&sessionKey=" + sessionKey;
            modem.Navigate(modemURL);
            modemURL = "http://192.168.20.1/voicesip_advanced.html";
            modem.Navigate(modemURL);
            sessionKey = getSessionID(modem.CurrentHtml);
            modemURL = "http://192.168.20.1/voicesipapply.cmd?voicesipapply.cmd?currentview=advanced&sessExpireTime0=1800&minSessExpireTime0=90&enLocalFeature0=0&MaliciousFeatureEnable0=0&vadEnable0=off&vadShowMode0=0&t38Enable0=off&vtpvbdEnable0=off&t38RedundancyEnable0=on&vtpRTCPEnable0=off&EchoCancellation0=on&vtpvbdRedundancyEnable0=off&uripounddata0=off&CwCidEnable0=on&fskMode0=BELL&callIdMsgType0=MDMF&callIdDelayTime0=600&transport0=UDP&regExpTmr0=3600&tosByteRtp0=46&tosByteSip0=46&dtmfRelay0=InBand&Rel100Resp0=1&EthPriorityMark0=-1&RTPPayload0=125&faxNegoMode0=Auto_switch&vbdCodec0=G711_A&vtpv152vbdEnable0=off&dialPlan0=000%7C%5B*%23%5DX%5B0-9*%5D.%23%7C**XX%7C*%23X%5B0-9*%5D.%23%7C%23*x%5B0-9*%5D.%23%7C00%5B1-9%5Dxx.t%7C014XXXXXXX%7C016XXXXXX%7C0192X%7C0198XXXXXX%7C0%5B23478%5DXXXXXXXX%7C0500XXXXXX%7C11XX%7C123X%7C124XX%7C1251XX%7C1252XXX%7C1255X%7C1258XXX%7C1271X%7C130XXXXXXX%7C1802XXX%7C189XX%7C1%5B8-9%5DXXXXXXXX%7C%5B2-9%5DXXXXXXX%7C13%5B1-9%5DXXX&callwait0_0=on&fwdAll0_0=on&fwdBusy0_0=on&fwdNoAns0_0=on&mwi0_0=off&anonBlock0_0=on&anonCall0_0=on&anonCallMode0_0=display&doNotDisturb0_0=on&fwduNum0_0=&fwdbNum0_0=&fwdnNum0_0=&OptionsTime0_0=0&callReturnEnable0_0=on&calltransfer0_0=on&callconference0_0=on&speedDial0_0=off&speedDialMap0_0=00=;01=;02=;03=;04=;05=;06=;07=;08=;09=;&callwait0_1=on&fwdAll0_1=on&fwdBusy0_1=on&fwdNoAns0_1=on&mwi0_1=off&anonBlock0_1=on&anonCall0_1=on&anonCallMode0_1=display&doNotDisturb0_1=on&fwduNum0_1=&fwdbNum0_1=&fwdnNum0_1=&OptionsTime0_1=0&callReturnEnable0_1=on&calltransfer0_1=on&callconference0_1=on&speedDial0_1=off&speedDialMap0_1=00=;01=;02=;03=;04=;05=;06=;07=;08=;09=;&pstnPrefix=9&sessionKey=" + sessionKey;
            modem.Navigate(modemURL);



        }
    }
}

