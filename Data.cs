using System;
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
