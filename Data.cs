﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Phone_freesharp
{
    class Data
    {
        public static String[] logo =
        {
            "██████╗ ██╗  ██╗ ██████╗ ███╗   ██╗███████╗",
            "██╔══██╗██║  ██║██╔═══██╗████╗  ██║██╔════╝",
            "██████╔╝███████║██║   ██║██╔██╗ ██║█████╗  ",
            "██╔═══╝ ██╔══██║██║   ██║██║╚██╗██║██╔══╝  ",
            "██║     ██║  ██║╚██████╔╝██║ ╚████║███████╗",
            "╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝"
        };

        public static String[] options =
        {
            "[1] Clear Files ",
            "[2] Optimize MC ",
            "[3] Debloat PC  ",
            "[4] CFG Firewall"
        };

        public static String[] telementarytasks =
        {
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\Application Experience\\Microsoft Compatibility Appraiser\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\Application Experience\\ProgramDataUpdater\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\Autochk\\Proxy\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\Customer Experience Improvement Program\\Consolidator\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\Customer Experience Improvement Program\\KernelCeipTask\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\Customer Experience Improvement Program\\UsbCeip\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\DiskDiagnostic\\Microsoft-Windows-DiskDiagnosticDataCollector\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\PI\\Sqm-Tasks\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\Power Efficiency Diagnostics\\AnalyzeSystem\"",
            "schtasks /delete /F /TN \"\\Microsoft\\Windows\\Windows Error Reporting\\QueueReporting\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\application experience\\Microsoft compatibility appraiser\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\application experience\\aitagent\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\application experience\\programdataupdater\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\autochk\\proxy\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\customer experience improvement program\\consolidator\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\customer experience improvement program\\kernelceiptask\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\customer experience improvement program\\usbceip\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\diskdiagnostic\\Microsoft-Windows-diskdiagnosticdatacollector\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\maintenance\\winsat\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\activateWindowssearch\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\configureinternettimeservice\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\dispatchrecoverytasks\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\ehdrminit\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\installplayready\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\mcupdate\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\mediacenterrecoverytask\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\objectstorerecoverytask\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\ocuractivate\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\ocurdiscovery\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\pbdadiscovery\">nul 2>&1",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\pbdadiscoveryw1\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\pbdadiscoveryw2\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\pvrrecoverytask\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\pvrscheduletask\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\registersearch\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\reindexsearchroot\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\sqlliterecoverytask\"",
            "schtasks /delete /f /tn \"\\Microsoft\\Windows\\media center\\updaterecordpath\""
        };

        public static String[] badupdates = {
            "REM KB 2902907 (https://support.microsoft.com/en-us/kb/2902907)",
            "start /wait \"\" wusa /uninstall /kb:2902907 /norestart /quiet",
            "REM KB 2922324 (https://support.microsoft.com/en-us/kb/2922324)",
            "start /wait \"\" wusa /uninstall /kb:2922324 /norestart /quiet",
            "REM KB 2952664 (https://support.microsoft.com/en-us/kb/2952664)",
            "start /wait \"\" wusa /uninstall /kb:2952664 /norestart /quiet",
            "REM KB 2976978 (https://support.microsoft.com/en-us/kb/2976978)",
            "start /wait \"\" wusa /uninstall /kb:2976978 /norestart /quiet",
            "REM KB 2977759 (https://support.microsoft.com/en-us/kb/2977759)",
            "start /wait \"\" wusa /uninstall /kb:2977759 /norestart /quiet",
            "REM KB 2990214 (https://support.microsoft.com/en-us/kb/2990214)",
            "start /wait \"\" wusa /uninstall /kb:2990214 /norestart /quiet",
            "REM KB 3012973 (https://support.microsoft.com/en-us/kb/3012973)",
            "start /wait \"\" wusa /uninstall /kb:3012973 /norestart /quiet",
            "REM KB 3014460 (https://support.microsoft.com/en-us/kb/3014460)",
            "start /wait \"\" wusa /uninstall /kb:3014460 /norestart /quiet",
            "REM KB 3015249 (https://support.microsoft.com/en-us/kb/3015249)",
            "start /wait \"\" wusa /uninstall /kb:3015249 /norestart /quiet",
            "REM KB 3021917 (https://support.microsoft.com/en-us/kb/3021917)",
            "start /wait \"\" wusa /uninstall /kb:3021917 /norestart /quiet",
            "REM KB 3022345 (https://support.microsoft.com/en-us/kb/3022345)",
            "start /wait \"\" wusa /uninstall /kb:3022345 /norestart /quiet",
            "REM KB 3035583 (https://support.microsoft.com/en-us/kb/3035583)",
            "start /wait \"\" wusa /uninstall /kb:3035583 /norestart /quiet",
            "REM KB 3044374 (https://support.microsoft.com/en-us/kb/3044374)",
            "start /wait \"\" wusa /uninstall /kb:3044374 /norestart /quiet",
            "REM KB 3050265 (https://support.microsoft.com/en-us/kb/3050265)",
            "start /wait \"\" wusa /uninstall /kb:3050265 /norestart /quiet",
            "REM KB 3050267 (https://support.microsoft.com/en-us/kb/3050267)",
            "start /wait \"\" wusa /uninstall /kb:3050267 /norestart /quiet",
            "REM KB 3065987 (https://support.microsoft.com/en-us/kb/3065987)",
            "start /wait \"\" wusa /uninstall /kb:3065987 /norestart /quiet",
            "REM KB 3068708 (https://support.microsoft.com/en-us/kb/3068708)",
            "start /wait \"\" wusa /uninstall /kb:3068708 /norestart /quiet",
            "REM KB 3075249 (https://support.microsoft.com/en-us/kb/3075249)",
            "start /wait \"\" wusa /uninstall /kb:3075249 /norestart /quiet",
            "REM KB 3075851 (https://support.microsoft.com/en-us/kb/3075851)",
            "start /wait \"\" wusa /uninstall /kb:3075851 /norestart /quiet",
            "REM KB 3075853 (https://support.microsoft.com/en-us/kb/3075853)",
            "start /wait \"\" wusa /uninstall /kb:3075853 /norestart /quiet",
            "REM KB 3080149 (https://support.microsoft.com/en-us/kb/3080149)",
            "start /wait \"\" wusa /uninstall /kb:3080149 /norestart /quiet",
            "REM Additional KB entries removed by Microsoft; originally associated with telemetry",
            "start /wait \"\" wusa /uninstall /kb:2976987 /norestart /quiet",
            "start /wait \"\" wusa /uninstall /kb:3068707 /norestart /quiet"
        };

        public static String[] firewallconfig = {
            "NETSH advfirewall set allprofiles state on",
            "NETSH advfirewall firewall add rule name=\"telemetry_www.trust.office365.com\" dir=out action=block remoteip=64.4.6.100 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_www.moskisvet.com.c.footprint.net\" dir=out action=block remoteip=8.253.37.126 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_www.moskisvet.com.c.footprint.net\" dir=out action=block remoteip=198.78.208.254 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_www.cisco.com\" dir=out action=block remoteip=198.135.3.118 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_wusonprem.ipv6.microsoft.com.akadns.net\" dir=out action=block remoteip=157.56.106.189 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_wns.windows.com\" dir=out action=block remoteip=40.77.229.0-40.77.229.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_wes.df.telemetry.microsoft.com\" dir=out action=block remoteip=65.52.100.93 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_wdcpeurope.microsoft.akadns.net\" dir=out action=block remoteip=137.117.235.16 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_watson.telemetry.microsoft.com\" dir=out action=block remoteip=40.77.228.92 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_watson.ppe.telemetry.microsoft.com\" dir=out action=block remoteip=65.52.100.11 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_watson.microsoft.com.nsatc.net\" dir=out action=block remoteip=65.52.108.154 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_watson.live.com\" dir=out action=block remoteip=207.46.223.94 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_vortex-db5.metron.live.com.nsatc.net\" dir=out action=block remoteip=191.232.139.5 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_vd.vidfuture.com\" dir=out action=block remoteip=66.225.197.197 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_v4ncsi.msedge.net\" dir=out action=block remoteip=13.107.4.52 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_v20-asimov-win.vortex.data.microsoft.com.akadns.net\" dir=out action=block remoteip=64.4.54.254 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_v10-win.vortex.data.microsoft.com.akadns.net\" dir=out action=block remoteip=111.221.29.254 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_us.vortex-win.data.microsoft.com\" dir=out action=block remoteip=40.90.136.33 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_urs.microsoft.com.nsatc.net\" dir=out action=block remoteip=157.55.233.125,192.232.139.180 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_trouter-neu-a.cloudapp.net\" dir=out action=block remoteip=13.69.188.18 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_trouter-easia-a.dc.trouter.io\" dir=out action=block remoteip=13.75.106.0 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_telemetry.microsoft.com\" dir=out action=block remoteip=65.52.100.9 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_telemetry.appex.search.prod.ms.akadns.net\" dir=out action=block remoteip=168.61.24.141 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_telemetry.appex.bing.net\" dir=out action=block remoteip=65.52.161.64,168.63.108.233 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_telecommand.telemetry.microsoft.com\" dir=out action=block remoteip=65.55.252.92 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_tapeytapey.com\" dir=out action=block remoteip=2.21.246.26 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_t.urs.microsoft.com.nsatc.net\" dir=out action=block remoteip=64.4.54.167,65.55.44.85 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_t.urs.microsoft.com\" dir=out action=block remoteip=131.253.40.37 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_survey.watson.microsoft.com\" dir=out action=block remoteip=207.68.166.254 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_statsfe2-df.ws.microsoft.com.nsatc.net\" dir=out action=block remoteip=134.170.115.60 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_statsfe2.ws.microsoft.com.nsatc.net\" dir=out action=block remoteip=131.253.14.153 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_statsfe2.ws.microsoft.com\" dir=out action=block remoteip=207.46.114.61 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_statsfe2.update.microsoft.com.akadns.net\" dir=out action=block remoteip=65.52.108.153 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_stats.update.microsoft.com.nsatc.net\" dir=out action=block remoteip=64.4.54.22 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_static.sl-reverse.com\" dir=out action=block remoteip=169.54.179.156 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ssw.live.com.nsatc.net\" dir=out action=block remoteip=207.46.7.252 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ssw.live.com\" dir=out action=block remoteip=207.46.101.29 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_sqm.msn.com\" dir=out action=block remoteip=65.55.252.93 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_sqm.df.telemetry.microsoft.com\" dir=out action=block remoteip=65.52.100.94 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_sonybank.net\" dir=out action=block remoteip=2.21.246.24 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_settings-win-ppe.data.microsoft.com\" dir=out action=block remoteip=40.77.226.248 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_settings-sandbox.data.microsoft.com\" dir=out action=block remoteip=111.221.29.177 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_settings-sandbox.data.glbdns2.microsoft.com\" dir=out action=block remoteip=191.232.140.76 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_services.wes.df.telemetry.microsoft.com\" dir=out action=block remoteip=65.52.100.92 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_service.xbox.com\" dir=out action=block remoteip=157.55.129.21 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_secure-ams.adnxs.com\" dir=out action=block remoteip=37.252.163.244,37.252.163.106 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_secure.flashtalking.com\" dir=out action=block remoteip=95.101.244.134 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_schemas.microsoft.akadns.net\" dir=out action=block remoteip=65.54.226.187 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_sact.atdmt.com\" dir=out action=block remoteip=94.245.121.177 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_s0.2mdn.net\" dir=out action=block remoteip=172.217.21.166 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_s.outlook.com\" dir=out action=block remoteip=134.170.3.199 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_rmads.msn.com\" dir=out action=block remoteip=157.56.23.91 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_reports.wes.df.telemetry.microsoft.com\" dir=out action=block remoteip=65.52.100.91 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_redir.metaservices.microsoft.com\" dir=out action=block remoteip=194.44.4.200,194.44.4.208,2.21.246.42,2.21.246.58 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_realgames.cn\" dir=out action=block remoteip=65.55.57.27 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_pipe.skype.com\" dir=out action=block remoteip=40.115.1.44 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_perthnow.com.au\" dir=out action=block remoteip=2.21.246.8 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_osiprod-weu-snow-000.cloudapp.net\" dir=out action=block remoteip=23.97.178.173 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_oca.watson.data.microsoft.com.akadns.net\" dir=out action=block remoteip=64.4.54.153 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_oca.telemetry.microsoft.com.nsatc.net\" dir=out action=block remoteip=65.55.252.63 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_nt-c.ns.nsatc.net\" dir=out action=block remoteip=8.254.119.155 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_nt-b.ns.nsatc.net\" dir=out action=block remoteip=8.254.92.155 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ns3.msft.net\" dir=out action=block remoteip=192.221.113.53 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ns3.a-msedge.net\" dir=out action=block remoteip=131.253.21.1 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ns2.a-msedge.net\" dir=out action=block remoteip=204.79.197.2 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ns1.gslb.com\" dir=out action=block remoteip=8.19.31.10 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ns1.a-msedge.net\" dir=out action=block remoteip=204.79.197.1 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_nl-1.ns.nsatc.net\" dir=out action=block remoteip=4.23.39.155 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_nexus.officeapps.live.com\" dir=out action=block remoteip=40.76.8.142,23.101.14.229,207.46.153.155 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_next-services.windows.akadns.net\" dir=out action=block remoteip=134.170.30.202 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_new_wns.windows.com\" dir=out action=block remoteip=131.253.21.0-131.253.47.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_msnbot-65-55-108-23.search.msn.com\" dir=out action=block remoteip=65.55.108.23 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_msnbot-64-4-54-18.search.msn.com\" dir=out action=block remoteip=64.4.54.18 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_msnbot-207-46-194-46.search.msn.com\" dir=out action=block remoteip=207.46.194.46 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_msnbot-207-46-194-33.search.msn.com\" dir=out action=block remoteip=207.46.194.33 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_msnbot-207-46-194-29.search.msn.com\" dir=out action=block remoteip=207.46.194.29 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_msnbot-207-46-194-25.search.msn.com\" dir=out action=block remoteip=207.46.194.25 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_msnbot-207-46-194-14.search.msn.com\" dir=out action=block remoteip=207.46.194.14 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_msedge.net\" dir=out action=block remoteip=204.79.19.197 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ms1-ib.adnxs.com\" dir=out action=block remoteip=37.252.163.88 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_modern.watson.data.microsoft.com.akadns.net\" dir=out action=block remoteip=65.55.252.43,65.52.108.29,65.55.252.202 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_mm.bing.net\" dir=out action=block remoteip=204.79.197.200 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft22.com\" dir=out action=block remoteip=52.178.178.16 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft21.com\" dir=out action=block remoteip=65.55.64.54 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft20.com\" dir=out action=block remoteip=40.80.145.27 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft17.com\" dir=out action=block remoteip=40.80.145.78 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft16.com\" dir=out action=block remoteip=23.99.116.116 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft15.com\" dir=out action=block remoteip=77.67.29.176 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft14.com\" dir=out action=block remoteip=65.55.223.0-65.55.223.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft13.com\" dir=out action=block remoteip=65.39.117.230 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft12.com\" dir=out action=block remoteip=64.4.23.0-64.4.23.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft11.com\" dir=out action=block remoteip=23.223.20.82 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft10.com\" dir=out action=block remoteip=213.199.179.0-213.199.179.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft09.com\" dir=out action=block remoteip=2.22.61.66 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft08.com\" dir=out action=block remoteip=195.138.255.0-195.138.255.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft07.com\" dir=out action=block remoteip=157.55.56.0-157.55.56.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft06.com\" dir=out action=block remoteip=157.55.52.0-157.55.52.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft05.com\" dir=out action=block remoteip=157.55.236.0-157.55.236.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft04.com\" dir=out action=block remoteip=157.55.235.0-157.55.235.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft03.com\" dir=out action=block remoteip=157.55.130.0-157.55.130.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft02.com\" dir=out action=block remoteip=111.221.64.0-111.221.127.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft01.com\" dir=out action=block remoteip=11.221.29.253 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_microsoft.com\" dir=out action=block remoteip=104.96.147.3 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_mediaroomsds.microsoft.com\" dir=out action=block remoteip=134.170.185.70 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_media.blinkbox.com.c.footprint.net\" dir=out action=block remoteip=206.33.58.254 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_m.adnxs.com\" dir=out action=block remoteip=37.252.170.141 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_legacy.watson.data.microsoft.com.akadns.net\" dir=out action=block remoteip=65.55.252.71 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_inside.microsoftmse.com\" dir=out action=block remoteip=65.55.39.10 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_iact.atdmt.com\" dir=out action=block remoteip=94.245.121.178 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_i4.services.social.microsoft.com\" dir=out action=block remoteip=104.79.134.225 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_i1.services.social.microsoft.com\" dir=out action=block remoteip=23.74.190.252,104.82.22.249 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_hp-comm.ca.msn.com\" dir=out action=block remoteip=40.127.139.224 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_helloaddress.com\" dir=out action=block remoteip=2.21.246.10 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_globalns2.appnexus.net\" dir=out action=block remoteip=8.19.31.11 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_geo-prod.dodsp.mp.microsoft.com.nsatc.net\" dir=out action=block remoteip=191.232.139.212 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_geo-prod.do.dsp.mp.microsoft.com\" dir=out action=block remoteip=40.77.226.217-40.77.226.224 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_geo.settings.data.microsoft.com.akadns.net\" dir=out action=block remoteip=64.4.0.0-64.4.63.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_float.2655.bm-impbus.prod.ams1.adnexus.net\" dir=out action=block remoteip=37.252.163.215 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_float.2113.bm-impbus.prod.ams1.adnexus.net\" dir=out action=block remoteip=37.252.163.3 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_float.1334.bm-impbus.prod.fra1.adnexus.net\" dir=out action=block remoteip=37.252.170.82 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_float.1332.bm-impbus.prod.fra1.adnexus.net\" dir=out action=block remoteip=37.252.170.81 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_float.1143.bm-impbus.prod.fra1.adnexus.net\" dir=out action=block remoteip=37.252.170.1 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_flex.msn.com\" dir=out action=block remoteip=207.46.194.8 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_fesweb1.ch1d.binginternal.com\" dir=out action=block remoteip=131.253.14.76 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_fe3.delivery.dsp.mp.microsoft.com.nsatc.net\" dir=out action=block remoteip=64.4.54.18 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_fd-rad-msn-com.a-0004.a-msedge.net\" dir=out action=block remoteip=204.79.197.206 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_fashiontamils.com\" dir=out action=block remoteip=69.64.34.185 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_exch-eu.atdmt.com.nsatc.net\" dir=out action=block remoteip=94.245.121.179,94.245.121.176 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_evoke-windowsservices-tas.msedge.net\" dir=out action=block remoteip=13.107.5.88 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_eu.vortex-win.data.microsoft.com\" dir=out action=block remoteip=191.232.139.254 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_es-1.ns.nsatc.net\" dir=out action=block remoteip=8.254.34.155 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_edge-atlas-shv-01-cdg2.facebook.com\" dir=out action=block remoteip=179.60.192.10 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_e8218.ce.akamaiedge.net\" dir=out action=block remoteip=23.57.107.27 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_e6845.ce.akamaiedge.net\" dir=out action=block remoteip=23.57.101.163 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_dub109-afx.ms.a-0009.a-msedge.net\" dir=out action=block remoteip=204.79.197.211 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_dps.msn.com\" dir=out action=block remoteip=131.253.14.121 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_dmd.metaservices.microsoft.com.akadns.net\" dir=out action=block remoteip=52.160.91.170 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_dmd.metaservices.microsoft.com.akadns.net\" dir=out action=block remoteip=40.112.210.171 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_dmd.metaservices.microsoft.com\" dir=out action=block remoteip=40.87.63.92,40.80.145.78,40.80.145.38,40.80.145.27,40.112.213.22 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_diagnostics.support.microsoft.com\" dir=out action=block remoteip=134.170.52.151 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_diagnostics.support.microsoft.akadns.net\" dir=out action=block remoteip=157.56.121.89 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_df.telemetry.microsoft.com\" dir=out action=block remoteip=65.52.100.7 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_descargas.diximedia.es.c.footprint.net\" dir=out action=block remoteip=185.13.160.61 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_deploy.static.akamaitechnologies.com\" dir=out action=block remoteip=23.218.212.69 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_deploy.akamaitechnologies.com\" dir=out action=block remoteip=95.100.38.95 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_db5.wns.notify.windows.com.akadns.net\" dir=out action=block remoteip=40.77.226.246,40.77.226.247 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_db5.vortex.data.microsoft.com.akadns.net\" dir=out action=block remoteip=40.77.226.250 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_db5.settings.data.microsoft.com.akadns.net\" dir=out action=block remoteip=40.77.226.249,191.232.139.253 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_db5.displaycatalog.md.mp.microsoft.com.akadns.net\" dir=out action=block remoteip=40.77.229.125 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_db3wns2011111.wns.windows.com\" dir=out action=block remoteip=157.56.124.87 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_dart.l.doubleclick.net\" dir=out action=block remoteip=173.194.113.219,173.194.113.220,173.194.113.219,216.58.209.166,172.217.20.134 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_cy2.settings.data.microsoft.com.akadns.net\" dir=out action=block remoteip=64.4.54.253,13.78.188.147 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_cs697.wac.thetacdn.net\" dir=out action=block remoteip=192.229.233.249 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_cs479.wac.edgecastcdn.net\" dir=out action=block remoteip=68.232.35.139 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_corpext.msitadfs.glbdns2.microsoft.com\" dir=out action=block remoteip=131.107.113.238 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_compatexchange.cloudapp.net\" dir=out action=block remoteip=23.99.10.11 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_colonialtoolset.com\" dir=out action=block remoteip=208.84.0.53 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_col130-afx.ms.a-0008.a-msedge.net\" dir=out action=block remoteip=204.79.197.210 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_co4.telecommand.telemetry.microsoft.com.akadns.net\" dir=out action=block remoteip=65.55.252.190 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_cn.msn.fr\" dir=out action=block remoteip=23.102.21.4 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_choice.microsoft.com.nsatc.net\" dir=out action=block remoteip=65.55.128.81,157.56.91.77 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_chinamobileltd.com\" dir=out action=block remoteip=211.137.82.38 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_cdn.energetichabits.com\" dir=out action=block remoteip=93.184.220.20 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_cdn.deezer.com.c.footprint.net\" dir=out action=block remoteip=8.254.209.254 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_cannon-construction.co.uk\" dir=out action=block remoteip=93.184.220.29 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_candycrushsoda.king.com\" dir=out action=block remoteip=185.48.81.162 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_c.nine.com.au\" dir=out action=block remoteip=207.46.194.10 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_c.microsoft.akadns.net\" dir=out action=block remoteip=134.170.188.139 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_bsnl.eyeblaster.akadns.net\" dir=out action=block remoteip=82.199.80.141 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_bots.teams.skype.com\" dir=out action=block remoteip=13.107.3.128 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_bn2.vortex.data.microsoft.com.akadns.net\" dir=out action=block remoteip=65.55.44.109 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_blu173-mail-live-com.a-0006.a-msedge.net\" dir=out action=block remoteip=204.79.197.208 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_beta.t.urs.microsoft.com\" dir=out action=block remoteip=157.56.74.250 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_bay175-mail-live-com.a-0007.a-msedge.net\" dir=out action=block remoteip=204.79.197.209 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_b.ns.nsatc.net\" dir=out action=block remoteip=198.78.208.155 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_auth.nym2.appnexus.net\" dir=out action=block remoteip=68.67.155.138 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_auth.lax1.appnexus.net\" dir=out action=block remoteip=68.67.133.169 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_auth.ams1.appnexus.net\" dir=out action=block remoteip=37.252.164.5 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_assets2.parliament.uk.c.footprint.net\" dir=out action=block remoteip=192.221.106.126 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_assets.dishonline.com.c.footprint.net\" dir=out action=block remoteip=207.123.56.252 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_asimov-sandbox.vortex.data.microsoft.com.akadns.net\" dir=out action=block remoteip=64.4.54.32 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_array204-prod.dodsp.mp.microsoft.com.nsatc.net\" dir=out action=block remoteip=65.52.0.0-65.52.255.255 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_apnic.net\" dir=out action=block remoteip=221.232.247.2,222.216.3.213 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_a-msedge.net\" dir=out action=block remoteip=204.79.197.204 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ams1-ib.adnxs.com\" dir=out action=block remoteip=37.252.163.207,37.252.162.228,37.252.162.216 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ampudc.udc0.glbdns2.microsoft.com\" dir=out action=block remoteip=137.116.81.24 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_akadns.info\" dir=out action=block remoteip=157.56.96.54 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ads.msn.com\" dir=out action=block remoteip=157.56.91.82,157.56.23.91,104.82.14.146,207.123.56.252,185.13.160.61,8.254.209.254,65.55.128.80,8.12.207.125 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_adnxs.com\" dir=out action=block remoteip=37.252.170.80,37.252.170.142,37.252.170.140,37.252.169.43 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_ad.doubleclick.net\" dir=out action=block remoteip=172.217.20.230 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_acyfdr.explicit.bing.net\" dir=out action=block remoteip=204.79.197.201 enable=yes",
            "NETSH advfirewall firewall add rule name=\"telemetry_a.msft.net\" dir=out action=block remoteip=208.76.45.53 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-69\" dir=in action=block protocol=tcp localport=69 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-135\" dir=in action=block protocol=tcp localport=135 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-137\" dir=in action=block protocol=tcp localport=137 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-138\" dir=in action=block protocol=tcp localport=138 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-139\" dir=in action=block protocol=tcp localport=139 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-445\" dir=in action=block protocol=tcp localport=445 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-1025\" dir=in action=block protocol=tcp localport=1025 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-4444\" dir=in action=block protocol=tcp localport=4444 enable=yes",
            "NETSH advfirewall firewall add rule name=\"Block_TCP-5000\" dir=in action=block protocol=tcp localport=5000 enable=yes",
        };

        public static String optifineOptions =
            "ofFogType:3\r\n" +
            "ofFogStart:0.2\r\n" +
            "ofMipmapType:3\r\n" +
            "ofOcclusionFancy:false\r\n" +
            "ofSmoothFps:false\r\n" +
            "ofSmoothWorld:false\r\n" +
            "ofAoLevel:0.0\r\n" +
            "ofClouds:3\r\n" +
            "ofCloudsHeight:0.0\r\n" +
            "ofTrees:1\r\n" +
            "ofDroppedItems:1\r\n" +
            "ofRain:3\r\n" +
            "ofAnimatedWater:2\r\n" +
            "ofAnimatedLava:2\r\n" +
            "ofAnimatedFire:false\r\n" +
            "ofAnimatedPortal:false\r\n" +
            "ofAnimatedRedstone:false\r\n" +
            "ofAnimatedExplosion:false\r\n" +
            "ofAnimatedFlame:false\r\n" +
            "ofAnimatedSmoke:false\r\n" +
            "ofVoidParticles:false\r\n" +
            "ofWaterParticles:false\r\n" +
            "ofPortalParticles:false\r\n" +
            "ofPotionParticles:false\r\n" +
            "ofFireworkParticles:false\r\n" +
            "ofDrippingWaterLava:false\r\n" +
            "ofAnimatedTerrain:false\r\n" +
            "ofAnimatedTextures:false\r\n" +
            "ofRainSplash:false\r\n" +
            "ofLagometer:false\r\n" +
            "ofShowFps:false\r\n" +
            "ofAutoSaveTicks:28800\r\n" +
            "ofBetterGrass:3\r\n" +
            "ofConnectedTextures:3\r\n" +
            "ofWeather:false\r\n" +
            "ofSky:false\r\n" +
            "ofStars:true\r\n" +
            "ofSunMoon:false\r\n" +
            "ofVignette:1\r\n" +
            "ofChunkUpdates:1\r\n" +
            "ofChunkUpdatesDynamic:false\r\n" +
            "ofTime:1\r\n" +
            "ofClearWater:false\r\n" +
            "ofAaLevel:0\r\n" +
            "ofAfLevel:1\r\n" +
            "ofProfiler:false\r\n" +
            "ofBetterSnow:false\r\n" +
            "ofSwampColors:false\r\n" +
            "ofRandomEntities:false\r\n" +
            "ofSmoothBiomes:false\r\n" +
            "ofCustomFonts:false\r\n" +
            "ofCustomColors:false\r\n" +
            "ofCustomItems:false\r\n" +
            "ofCustomSky:false\r\n" +
            "ofShowCapes:true\r\n" +
            "ofNaturalTextures:false\r\n" +
            "ofEmissiveTextures:false\r\n" +
            "ofLazyChunkLoading:false\r\n" +
            "ofRenderRegions:false\r\n" +
            "ofSmartAnimations:false\r\n" +
            "ofDynamicFov:true\r\n" +
            "ofAlternateBlocks:false\r\n" +
            "ofDynamicLights:3\r\n" +
            "ofScreenshotSize:1\r\n" +
            "ofCustomEntityModels:false\r\n" +
            "ofCustomGuis:false\r\n" +
            "ofShowGlErrors:true\r\n" +
            "ofFullscreenMode:1280x720\r\n" +
            "ofFastMath:false\r\n" +
            "ofFastRender:true\r\n" +
            "ofTranslucentBlocks:1\r\n" +
            "key_of.key.zoom:46\r\n";

        public static String mcoptions =
            "invertYMouse:false" +
            "mouseSensitivity:0.52112675\r\n" +
            "fov:0.0\r\n" +
            "gamma:0.0\r\n" +
            "saturation:0.0\r\n" +
            "renderDistance:4\r\n" +
            "guiScale:2\r\n" +
            "particles:1\r\n" +
            "bobView:true\r\n" +
            "anaglyph3d:false\r\n" +
            "maxFps:260\r\n" +
            "fboEnable:true\r\n" +
            "difficulty:1\r\n" +
            "fancyGraphics:false\r\n" +
            "ao:0\r\n" +
            "renderClouds:false\r\n" +
            "resourcePacks:[]\r\n" +
            "incompatibleResourcePacks:[]\r\n" +
            "lastServer:\r\n" +
            "lang:en_US\r\n" +
            "chatVisibility:0\r\n" +
            "chatColors:true\r\n" +
            "chatLinks:true\r\n" +
            "chatLinksPrompt:true\r\n" +
            "chatOpacity:1.0\r\n" +
            "snooperEnabled:true\r\n" +
            "fullscreen:false\r\n" +
            "enableVsync:false\r\n" +
            "useVbo:true\r\n" +
            "hideServerAddress:false\r\n" +
            "advancedItemTooltips:false\r\n" +
            "pauseOnLostFocus:true\r\n" +
            "touchscreen:false\r\n" +
            "overrideWidth:0\r\n" +
            "overrideHeight:0\r\n" +
            "heldItemTooltips:false\r\n" +
            "chatHeightFocused:0.45070422\r\n" +
            "chatHeightUnfocused:0.5\r\n" +
            "chatScale:0.7253521\r\n" +
            "chatWidth:0.5915493\r\n" +
            "showInventoryAchievementHint:false\r\n" +
            "mipmapLevels:4\r\n" +
            "streamBytesPerPixel:0.5\r\n" +
            "streamMicVolume:1.0\r\n" +
            "streamSystemVolume:1.0\r\n" +
            "streamKbps:0.5412844\r\n" +
            "streamFps:0.31690142\r\n" +
            "streamCompression:1\r\n" +
            "streamSendMetadata:true\r\n" +
            "streamPreferredServer:\r\n" +
            "streamChatEnabled:0\r\n" +
            "streamChatUserFilter:0\r\n" +
            "streamMicToggleBehavior:0\r\n" +
            "forceUnicodeFont:false\r\n" +
            "allowBlockAlternatives:false\r\n" +
            "reducedDebugInfo:false\r\n" +
            "useNativeTransport:true\r\n" +
            "entityShadows:false\r\n" +
            "realmsNotifications:true\r\n" +
            "key_key.attack:-100\r\n" +
            "key_key.use:-99\r\n" +
            "key_key.forward:17\r\n" +
            "key_key.left:30\r\n" +
            "key_key.back:31\r\n" +
            "key_key.right:32\r\n" +
            "key_key.jump:57\r\n" +
            "key_key.sneak:42\r\n" +
            "key_key.sprint:29\r\n" +
            "key_key.drop:16\r\n" +
            "key_key.inventory:18\r\n" +
            "key_key.chat:20\r\n" +
            "key_key.playerlist:15\r\n" +
            "key_key.pickItem:-98\r\n" +
            "key_key.command:53\r\n" +
            "key_key.screenshot:60\r\n" +
            "key_key.togglePerspective:63\r\n" +
            "key_key.smoothCamera:0\r\n" +
            "key_key.streamStartStop:64\r\n" +
            "key_key.streamPauseUnpause:65\r\n" +
            "key_key.streamCommercial:0\r\n" +
            "key_key.streamToggleMic:0\r\n" +
            "key_key.fullscreen:87\r\n" +
            "key_key.spectatorOutlines:0\r\n" +
            "key_key.hotbar.1:2\r\n" +
            "key_key.hotbar.2:3\r\n" +
            "key_key.hotbar.3:4\r\n" +
            "key_key.hotbar.4:5\r\n" +
            "key_key.hotbar.5:6\r\n" +
            "key_key.hotbar.6:7\r\n" +
            "key_key.hotbar.7:8\r\n" +
            "key_key.hotbar.8:9\r\n" +
            "key_key.hotbar.9:10\r\n" +
            "key_of.key.zoom:46\r\n" +
            "key_Create Waypoint:49\r\n" +
            "key_Freelook:56\r\n" +
            "key_Mod Menu:54\r\n" +
            "key_Waypoint Menu:50\r\n" +
            "key_Emote Wheel:48\r\n" +
            "soundCategory_master:0.21523179\r\n" +
            "soundCategory_music:0.0\r\n" +
            "soundCategory_record:0.0\r\n" +
            "soundCategory_weather:0.0\r\n" +
            "soundCategory_block:0.0\r\n" +
            "soundCategory_hostile:0.0\r\n" +
            "soundCategory_neutral:0.0\r\n" +
            "soundCategory_player:0.18309858\r\n" +
            "soundCategory_ambient:0.0\r\n" +
            "modelPart_cape:true\r\n" +
            "modelPart_jacket:true\r\n" +
            "modelPart_left_sleeve:true\r\n" +
            "modelPart_right_sleeve:true\r\n" +
            "modelPart_left_pants_leg:true\r\n" +
            "modelPart_right_pants_leg:true\r\n" +
            "modelPart_hat:true\r\n";
    }
}
