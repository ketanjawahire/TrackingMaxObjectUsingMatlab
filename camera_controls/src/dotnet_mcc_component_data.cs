//
// MATLAB Compiler: 4.9 (R2008b)
// Date: Sun Apr 08 00:30:30 2012
// Arguments: "-B" "macro_default" "-W"
// "dotnet:camera_controls,Camera_controls,0.0,private" "-d" "C:\Documents and
// Settings\Administrator\My Documents\MATLAB\my code\final code for tracking max object
// from live video\camera_controls\src" "-T" "link:lib" "-v"
// "class{Camera_controls:C:\Documents and Settings\Administrator\My Documents\MATLAB\my
// code\final code for tracking max object from live video\stop_camera.m,C:\Documents and
// Settings\Administrator\My Documents\MATLAB\my code\final code for tracking max object
// from live video\preview_cam.m,C:\Documents and Settings\Administrator\My
// Documents\MATLAB\my code\final code for tracking max object from live
// video\start_camera.m}" 
//


using System;

namespace MathWorks.MATLAB.NET.ComponentData
{
  /// <summary>
  /// The MCR Component State
  /// </summary>
  public class MCRComponentState
  {
      /// <summary>
      /// The .NET Builder component name
      /// </summary>
      public static string MCC_camera_controls_name_data= "camera_controls";

      /// <summary>
      /// The component root data
      /// </summary>
      public static string MCC_camera_controls_root_data= "";

      /// <summary>
      /// The public encryption key for the .NET Builder component
      /// </summary>
      public static byte[] MCC_camera_controls_public_data=
                              {(byte)'3', (byte)'0', (byte)'8', (byte)'1',
                               (byte)'9', (byte)'D', (byte)'3', (byte)'0',
                               (byte)'0', (byte)'D', (byte)'0', (byte)'6',
                               (byte)'0', (byte)'9', (byte)'2', (byte)'A',
                               (byte)'8', (byte)'6', (byte)'4', (byte)'8',
                               (byte)'8', (byte)'6', (byte)'F', (byte)'7',
                               (byte)'0', (byte)'D', (byte)'0', (byte)'1',
                               (byte)'0', (byte)'1', (byte)'0', (byte)'1',
                               (byte)'0', (byte)'5', (byte)'0', (byte)'0',
                               (byte)'0', (byte)'3', (byte)'8', (byte)'1',
                               (byte)'8', (byte)'B', (byte)'0', (byte)'0',
                               (byte)'3', (byte)'0', (byte)'8', (byte)'1',
                               (byte)'8', (byte)'7', (byte)'0', (byte)'2',
                               (byte)'8', (byte)'1', (byte)'8', (byte)'1',
                               (byte)'0', (byte)'0', (byte)'C', (byte)'4',
                               (byte)'9', (byte)'C', (byte)'A', (byte)'C',
                               (byte)'3', (byte)'4', (byte)'E', (byte)'D',
                               (byte)'1', (byte)'3', (byte)'A', (byte)'5',
                               (byte)'2', (byte)'0', (byte)'6', (byte)'5',
                               (byte)'8', (byte)'F', (byte)'6', (byte)'F',
                               (byte)'8', (byte)'E', (byte)'0', (byte)'1',
                               (byte)'3', (byte)'8', (byte)'C', (byte)'4',
                               (byte)'3', (byte)'1', (byte)'5', (byte)'B',
                               (byte)'4', (byte)'3', (byte)'1', (byte)'5',
                               (byte)'2', (byte)'7', (byte)'7', (byte)'E',
                               (byte)'D', (byte)'3', (byte)'F', (byte)'7',
                               (byte)'D', (byte)'A', (byte)'E', (byte)'5',
                               (byte)'3', (byte)'0', (byte)'9', (byte)'9',
                               (byte)'D', (byte)'B', (byte)'0', (byte)'8',
                               (byte)'E', (byte)'E', (byte)'5', (byte)'8',
                               (byte)'9', (byte)'F', (byte)'8', (byte)'0',
                               (byte)'4', (byte)'D', (byte)'4', (byte)'B',
                               (byte)'9', (byte)'8', (byte)'1', (byte)'3',
                               (byte)'2', (byte)'6', (byte)'A', (byte)'5',
                               (byte)'2', (byte)'C', (byte)'C', (byte)'E',
                               (byte)'4', (byte)'3', (byte)'8', (byte)'2',
                               (byte)'E', (byte)'9', (byte)'F', (byte)'2',
                               (byte)'B', (byte)'4', (byte)'D', (byte)'0',
                               (byte)'8', (byte)'5', (byte)'E', (byte)'B',
                               (byte)'9', (byte)'5', (byte)'0', (byte)'C',
                               (byte)'7', (byte)'A', (byte)'B', (byte)'1',
                               (byte)'2', (byte)'E', (byte)'D', (byte)'E',
                               (byte)'2', (byte)'D', (byte)'4', (byte)'1',
                               (byte)'2', (byte)'9', (byte)'7', (byte)'8',
                               (byte)'2', (byte)'0', (byte)'E', (byte)'6',
                               (byte)'3', (byte)'7', (byte)'7', (byte)'A',
                               (byte)'5', (byte)'F', (byte)'E', (byte)'B',
                               (byte)'5', (byte)'6', (byte)'8', (byte)'9',
                               (byte)'D', (byte)'4', (byte)'E', (byte)'6',
                               (byte)'0', (byte)'3', (byte)'2', (byte)'F',
                               (byte)'6', (byte)'0', (byte)'C', (byte)'4',
                               (byte)'3', (byte)'0', (byte)'7', (byte)'4',
                               (byte)'A', (byte)'0', (byte)'4', (byte)'C',
                               (byte)'2', (byte)'6', (byte)'A', (byte)'B',
                               (byte)'7', (byte)'2', (byte)'F', (byte)'5',
                               (byte)'4', (byte)'B', (byte)'5', (byte)'1',
                               (byte)'B', (byte)'B', (byte)'4', (byte)'6',
                               (byte)'0', (byte)'5', (byte)'7', (byte)'8',
                               (byte)'7', (byte)'8', (byte)'5', (byte)'B',
                               (byte)'1', (byte)'9', (byte)'9', (byte)'0',
                               (byte)'1', (byte)'4', (byte)'3', (byte)'1',
                               (byte)'4', (byte)'A', (byte)'6', (byte)'5',
                               (byte)'F', (byte)'0', (byte)'9', (byte)'0',
                               (byte)'B', (byte)'6', (byte)'1', (byte)'F',
                               (byte)'C', (byte)'2', (byte)'0', (byte)'1',
                               (byte)'6', (byte)'9', (byte)'4', (byte)'5',
                               (byte)'3', (byte)'B', (byte)'5', (byte)'8',
                               (byte)'F', (byte)'C', (byte)'8', (byte)'B',
                               (byte)'A', (byte)'4', (byte)'3', (byte)'E',
                               (byte)'6', (byte)'7', (byte)'7', (byte)'6',
                               (byte)'E', (byte)'B', (byte)'7', (byte)'E',
                               (byte)'C', (byte)'D', (byte)'3', (byte)'1',
                               (byte)'7', (byte)'8', (byte)'B', (byte)'5',
                               (byte)'6', (byte)'A', (byte)'B', (byte)'0',
                               (byte)'F', (byte)'A', (byte)'0', (byte)'6',
                               (byte)'D', (byte)'D', (byte)'6', (byte)'4',
                               (byte)'9', (byte)'6', (byte)'7', (byte)'C',
                               (byte)'B', (byte)'1', (byte)'4', (byte)'9',
                               (byte)'E', (byte)'5', (byte)'0', (byte)'2',
                               (byte)'0', (byte)'1', (byte)'1', (byte)'1'};

      /// <summary>
      /// The session encryption key for the .NET Builder component
      /// </summary>
      public static byte[] MCC_camera_controls_session_data=
                              {(byte)'0', (byte)'2', (byte)'7', (byte)'3',
                               (byte)'3', (byte)'6', (byte)'5', (byte)'7',
                               (byte)'8', (byte)'5', (byte)'F', (byte)'C',
                               (byte)'F', (byte)'D', (byte)'4', (byte)'B',
                               (byte)'0', (byte)'3', (byte)'7', (byte)'4',
                               (byte)'3', (byte)'0', (byte)'A', (byte)'8',
                               (byte)'E', (byte)'E', (byte)'3', (byte)'A',
                               (byte)'C', (byte)'D', (byte)'3', (byte)'B',
                               (byte)'7', (byte)'0', (byte)'1', (byte)'E',
                               (byte)'D', (byte)'D', (byte)'F', (byte)'6',
                               (byte)'B', (byte)'D', (byte)'3', (byte)'E',
                               (byte)'5', (byte)'E', (byte)'D', (byte)'7',
                               (byte)'A', (byte)'C', (byte)'3', (byte)'5',
                               (byte)'E', (byte)'B', (byte)'7', (byte)'6',
                               (byte)'6', (byte)'9', (byte)'2', (byte)'4',
                               (byte)'A', (byte)'2', (byte)'E', (byte)'2',
                               (byte)'9', (byte)'7', (byte)'A', (byte)'4',
                               (byte)'5', (byte)'E', (byte)'A', (byte)'5',
                               (byte)'C', (byte)'8', (byte)'0', (byte)'7',
                               (byte)'1', (byte)'9', (byte)'0', (byte)'6',
                               (byte)'7', (byte)'E', (byte)'F', (byte)'8',
                               (byte)'0', (byte)'9', (byte)'1', (byte)'0',
                               (byte)'6', (byte)'4', (byte)'8', (byte)'B',
                               (byte)'1', (byte)'F', (byte)'2', (byte)'F',
                               (byte)'8', (byte)'B', (byte)'7', (byte)'B',
                               (byte)'0', (byte)'2', (byte)'E', (byte)'A',
                               (byte)'F', (byte)'6', (byte)'5', (byte)'D',
                               (byte)'C', (byte)'E', (byte)'C', (byte)'F',
                               (byte)'C', (byte)'E', (byte)'6', (byte)'F',
                               (byte)'F', (byte)'4', (byte)'1', (byte)'3',
                               (byte)'1', (byte)'3', (byte)'E', (byte)'6',
                               (byte)'3', (byte)'A', (byte)'5', (byte)'7',
                               (byte)'4', (byte)'6', (byte)'A', (byte)'7',
                               (byte)'9', (byte)'8', (byte)'5', (byte)'9',
                               (byte)'1', (byte)'8', (byte)'9', (byte)'3',
                               (byte)'2', (byte)'2', (byte)'0', (byte)'7',
                               (byte)'7', (byte)'C', (byte)'C', (byte)'9',
                               (byte)'1', (byte)'F', (byte)'D', (byte)'C',
                               (byte)'2', (byte)'8', (byte)'D', (byte)'9',
                               (byte)'0', (byte)'7', (byte)'7', (byte)'C',
                               (byte)'3', (byte)'0', (byte)'7', (byte)'6',
                               (byte)'A', (byte)'3', (byte)'4', (byte)'C',
                               (byte)'A', (byte)'D', (byte)'8', (byte)'1',
                               (byte)'8', (byte)'7', (byte)'7', (byte)'2',
                               (byte)'3', (byte)'2', (byte)'6', (byte)'F',
                               (byte)'3', (byte)'A', (byte)'6', (byte)'A',
                               (byte)'D', (byte)'2', (byte)'0', (byte)'9',
                               (byte)'6', (byte)'4', (byte)'F', (byte)'A',
                               (byte)'4', (byte)'C', (byte)'9', (byte)'B',
                               (byte)'B', (byte)'0', (byte)'C', (byte)'9',
                               (byte)'2', (byte)'0', (byte)'0', (byte)'A',
                               (byte)'F', (byte)'B', (byte)'A', (byte)'1',
                               (byte)'2', (byte)'B', (byte)'A', (byte)'1',
                               (byte)'4', (byte)'2', (byte)'9', (byte)'D',
                               (byte)'E', (byte)'8', (byte)'1', (byte)'6',
                               (byte)'B', (byte)'A', (byte)'2', (byte)'9',
                               (byte)'C', (byte)'5', (byte)'5', (byte)'8',
                               (byte)'F', (byte)'7', (byte)'8', (byte)'C',
                               (byte)'B', (byte)'D', (byte)'5', (byte)'6',
                               (byte)'1', (byte)'1', (byte)'F', (byte)'0',
                               (byte)'E', (byte)'6', (byte)'1', (byte)'C',
                               (byte)'E', (byte)'0', (byte)'9', (byte)'3',
                               (byte)'6', (byte)'8', (byte)'B', (byte)'7',
                               (byte)'4', (byte)'E', (byte)'7', (byte)'5'};

      /// <summary>
      /// The MATLAB path for the .NET Builder component
      /// </summary>
      public static string[] MCC_camera_controls_matlabpath_data= {"camera_contr/",
                                                                   "$TOOLBOXDEPLOYDIR/",
                                                                   "$TOOLBOXMATLABDIR/general/",
                                                                   "$TOOLBOXMATLABDIR/ops/",
                                                                   "$TOOLBOXMATLABDIR/lang/",
                                                                   "$TOOLBOXMATLABDIR/elmat/",
                                                                   "$TOOLBOXMATLABDIR/randfun/",
                                                                   "$TOOLBOXMATLABDIR/elfun/",
                                                                   "$TOOLBOXMATLABDIR/specfun/",
                                                                   "$TOOLBOXMATLABDIR/matfun/",
                                                                   "$TOOLBOXMATLABDIR/datafun/",
                                                                   "$TOOLBOXMATLABDIR/polyfun/",
                                                                   "$TOOLBOXMATLABDIR/funfun/",
                                                                   "$TOOLBOXMATLABDIR/sparfun/",
                                                                   "$TOOLBOXMATLABDIR/scribe/",
                                                                   "$TOOLBOXMATLABDIR/graph2d/",
                                                                   "$TOOLBOXMATLABDIR/graph3d/",
                                                                   "$TOOLBOXMATLABDIR/specgraph/",
                                                                   "$TOOLBOXMATLABDIR/graphics/",
                                                                   "$TOOLBOXMATLABDIR/uitools/",
                                                                   "$TOOLBOXMATLABDIR/strfun/",
                                                                   "$TOOLBOXMATLABDIR/imagesci/",
                                                                   "$TOOLBOXMATLABDIR/iofun/",
                                                                   "$TOOLBOXMATLABDIR/audiovideo/",
                                                                   "$TOOLBOXMATLABDIR/timefun/",
                                                                   "$TOOLBOXMATLABDIR/datatypes/",
                                                                   "$TOOLBOXMATLABDIR/verctrl/",
                                                                   "$TOOLBOXMATLABDIR/codetools/",
                                                                   "$TOOLBOXMATLABDIR/helptools/",
                                                                   "$TOOLBOXMATLABDIR/winfun/",
                                                                   "$TOOLBOXMATLABDIR/demos/",
                                                                   "$TOOLBOXMATLABDIR/timeseries/",
                                                                   "$TOOLBOXMATLABDIR/hds/",
                                                                   "$TOOLBOXMATLABDIR/guide/",
                                                                   "$TOOLBOXMATLABDIR/plottools/",
                                                                   "toolbox/local/",
                                                                   "toolbox/shared/controllib/",
                                                                   "toolbox/shared/dastudio/",
                                                                   "$TOOLBOXMATLABDIR/datamanager/",
                                                                   "toolbox/rtw/targets/common/tgtcommon/",
                                                                   "toolbox/compiler/",
                                                                   "toolbox/control/control/",
                                                                   "toolbox/control/ctrlguis/",
                                                                   "toolbox/control/ctrlobsolete/",
                                                                   "toolbox/control/ctrlutil/",
                                                                   "toolbox/shared/slcontrollib/",
                                                                   "toolbox/finance/finance/",
                                                                   "toolbox/ident/ident/",
                                                                   "toolbox/ident/nlident/",
                                                                   "toolbox/ident/idobsolete/",
                                                                   "toolbox/ident/idutils/",
                                                                   "toolbox/images/colorspaces/",
                                                                   "toolbox/images/images/",
                                                                   "toolbox/images/imuitools/",
                                                                   "toolbox/images/iptformats/",
                                                                   "toolbox/images/iptutils/",
                                                                   "toolbox/shared/imageslib/",
                                                                   "toolbox/shared/spcuilib/",
                                                                   "toolbox/imaq/imaq/",
                                                                   "toolbox/shared/imaqlib/",
                                                                   "toolbox/rtw/targets/mpc555dk/mpc555dk/",
                                                                   "toolbox/rtw/targets/mpc555dk/rt/blockset/mfiles/",
                                                                   "toolbox/signal/signal/",
                                                                   "toolbox/signal/sigtools/"};
      /// <summary>
      /// The MATLAB path count
      /// </summary>
      public static int MCC_camera_controls_matlabpath_data_count= 64;

      /// <summary>
      /// The class path for the .NET Builder component
      /// </summary>
      public static string[] MCC_camera_controls_classpath_data= {"java/jar/toolbox/control.jar",
                                                                  "java/jar/toolbox/images.jar"};

      /// <summary>
      /// The class path count
      /// </summary>
      public static int MCC_camera_controls_classpath_data_count= 2;

      /// <summary>
      /// The lib path for the .NET Builder component
      /// </summary>
      public static string[] MCC_camera_controls_libpath_data= {"bin/win32/"};

      /// <summary>
      /// The lib path count
      /// </summary>
      public static int MCC_camera_controls_libpath_data_count= 1;

      /// <summary>
      /// The MCR application options
      /// </summary>
      public static string[] MCC_camera_controls_mcr_application_options= {"\0"};

      /// <summary>
      /// The MCR application options count
      /// </summary>
      public static int MCC_camera_controls_mcr_application_option_count= 0;

      /// <summary>
      /// The MCR runtime options
      /// </summary>
      public static string[] MCC_camera_controls_mcr_runtime_options= {"\0"};

      /// <summary>
      /// The MCR runtime options count
      /// </summary>
      public static int MCC_camera_controls_mcr_runtime_option_count= 0;

      /// <summary>
      /// The component preferences directory
      /// </summary>
      public static string MCC_camera_controls_mcr_pref_dir= "camera_contr_497CB9442BAF9069298B5906E6EE641C";

      /// <summary>
      /// Runtime warning states
      /// </summary>
      public static string[] MCC_camera_controls_set_warning_state= {"off:MATLAB:dispatcher:nameConflict"};
      /// <summary>
      /// Runtime warning state count
      /// </summary>
      public static int MCC_camera_controls_set_warning_state_count= 0;
  }
}
