﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using O2.Interfaces.O2Core;
using O2.DotNetWrappers.Windows;
using O2.DotNetWrappers.Xsd;
using O2.DotNetWrappers.O2Misc;
using System.Windows.Forms;
using O2.Kernel;
using System.IO;

//namespace O2.Platform.BCL.O2_DotNetWrappers
namespace O2.DotNetWrappers
{
    internal class DI
    {
        static DI()
        {
            log                         = PublicDI.log;
            config                      = PublicDI.config;
            reflection                  = new O2FormsReflectionASCX();
			sourceCodeMappingFileName = "SourceCodeMappingsFile.xml";			// must be set before the call to getSourceCodeMappings();
            sourceCodeMappings          = SourceCodeMappingsUtils.getSourceCodeMappings();
            dFilesLines                 = new Dictionary<string, List<string>>();
            PathToGac                   = Path.Combine(Environment.GetEnvironmentVariable("windir") ?? "", "Assembly");//\\GAC_MSIL");                        
            
        }
        public static IO2Log log                 { get; set; }  
        public static IO2Config config           { get; set; }
        public static IReflectionASCX reflection { get; set; }
        public static Form windowsFormMainO2Form { get; set; }

        
        // local global variables
        public static SourceCodeMappings sourceCodeMappings;
        public static string sourceCodeMappingFileName;        
        public static Dictionary<String, List<String>> dFilesLines;
        public static string PathToGac { get; set; }
    }
}
