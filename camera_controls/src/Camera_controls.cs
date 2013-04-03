/*
* MATLAB Compiler: 4.9 (R2008b)
* Date: Sun Apr 08 00:30:30 2012
* Arguments: "-B" "macro_default" "-W"
* "dotnet:camera_controls,Camera_controls,0.0,private" "-d" "C:\Documents and
* Settings\Administrator\My Documents\MATLAB\my code\final code for tracking max object
* from live video\camera_controls\src" "-T" "link:lib" "-v"
* "class{Camera_controls:C:\Documents and Settings\Administrator\My Documents\MATLAB\my
* code\final code for tracking max object from live video\stop_camera.m,C:\Documents and
* Settings\Administrator\My Documents\MATLAB\my code\final code for tracking max object
* from live video\preview_cam.m,C:\Documents and Settings\Administrator\My
* Documents\MATLAB\my code\final code for tracking max object from live
* video\start_camera.m}" 
*/

using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.ComponentData;
#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace camera_controls
{
  /// <summary>
  /// The Camera_controls class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\Documents and Settings\Administrator\My Documents\MATLAB\my code\final code for
  /// tracking max object from live video\stop_camera.m
  /// <newpara></newpara>
  /// C:\Documents and Settings\Administrator\My Documents\MATLAB\my code\final code for
  /// tracking max object from live video\preview_cam.m
  /// <newpara></newpara>
  /// C:\Documents and Settings\Administrator\My Documents\MATLAB\my code\final code for
  /// tracking max object from live video\start_camera.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Camera_controls : IDisposable
  {
      #region Constructors

      /// <summary internal= "true">
      /// The static constructor instantiates and initializes the MATLAB Component
      /// Runtime instance.
      /// </summary>
      static Camera_controls()
      {
          if (MWArray.MCRAppInitialized)
          {
              Assembly assembly= Assembly.GetExecutingAssembly();

              string ctfFilePath= assembly.Location;

              int lastDelimeter= ctfFilePath.LastIndexOf(@"\");

              ctfFilePath= ctfFilePath.Remove(lastDelimeter, (ctfFilePath.Length - lastDelimeter));

              string ctfFileName = MCRComponentState.MCC_camera_controls_name_data + ".ctf";

              Stream embeddedCtfStream = null;

              String[] resourceStrings = assembly.GetManifestResourceNames();

              foreach (String name in resourceStrings)
                {
                  if (name.Contains(ctfFileName))
                    {
                      embeddedCtfStream = assembly.GetManifestResourceStream(name);
                      break;
                    }
                }
              mcr= new MWMCR(MCRComponentState.MCC_camera_controls_name_data,
                             MCRComponentState.MCC_camera_controls_root_data,
                             MCRComponentState.MCC_camera_controls_public_data,
                             MCRComponentState.MCC_camera_controls_session_data,
                             MCRComponentState.MCC_camera_controls_matlabpath_data,
                             MCRComponentState.MCC_camera_controls_classpath_data,
                             MCRComponentState.MCC_camera_controls_libpath_data,
                             MCRComponentState.MCC_camera_controls_mcr_application_options,
                             MCRComponentState.MCC_camera_controls_mcr_runtime_options,
                             MCRComponentState.MCC_camera_controls_mcr_pref_dir,
                             MCRComponentState.MCC_camera_controls_set_warning_state,
                             ctfFilePath, embeddedCtfStream, true);
          }
          else
          {
              throw new ApplicationException("MWArray assembly could not be initialized");
          }
      }


      /// <summary>
      /// Constructs a new instance of the Camera_controls class.
      /// </summary>
      public Camera_controls()
      {
      }


      #endregion Constructors

      #region Finalize

      /// <summary internal= "true">
      /// Class destructor called by the CLR garbage collector.
      /// </summary>
      ~Camera_controls()
      {
          Dispose(false);
      }


      /// <summary>
      /// Frees the native resources associated with this object
      /// </summary>
      public void Dispose()
      {
          Dispose(true);

          GC.SuppressFinalize(this);
      }


      /// <summary internal= "true">
      /// Internal dispose function
      /// </summary>
      protected virtual void Dispose(bool disposing)
      {
          if (!disposed)
          {
              disposed= true;

              if (disposing)
              {
                  // Free managed resources;
              }

              // Free native resources
          }
      }


      #endregion Finalize

      #region Methods

      /// <summary>
      /// Provides a void output, 0-input MWArray interface to the stop_camera
      /// M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      ///
      public void stop_camera()
      {
          mcr.EvaluateFunction(0, "stop_camera", new MWArray[]{});
      }


      /// <summary>
      /// Provides the standard 0-input MWArray interface to the stop_camera M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public MWArray[] stop_camera(int numArgsOut)
      {
          return mcr.EvaluateFunction(numArgsOut,
                                      "stop_camera", new MWArray[]{});
      }


      /// <summary>
      /// Provides a void output, 0-input MWArray interface to the preview_cam
      /// M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      ///
      public void preview_cam()
      {
          mcr.EvaluateFunction(0, "preview_cam", new MWArray[]{});
      }


      /// <summary>
      /// Provides the standard 0-input MWArray interface to the preview_cam M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public MWArray[] preview_cam(int numArgsOut)
      {
          return mcr.EvaluateFunction(numArgsOut,
                                      "preview_cam", new MWArray[]{});
      }


      /// <summary>
      /// Provides a void output, 0-input MWArray interface to the start_camera
      /// M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      ///
      public void start_camera()
      {
          mcr.EvaluateFunction(0, "start_camera", new MWArray[]{});
      }


      /// <summary>
      /// Provides the standard 0-input MWArray interface to the start_camera M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public MWArray[] start_camera(int numArgsOut)
      {
          return mcr.EvaluateFunction(numArgsOut,
                                      "start_camera", new MWArray[]{});
      }


      /// <summary>
      /// This method will cause a MATLAB figure window to behave as a modal dialog box.
      /// The method will not return until all the figure windows associated with this
      /// component have been closed.
      /// </summary>
      /// <remarks>
      /// An application should only call this method when required to keep the
      /// MATLAB figure window from disappearing.  Other techniques, such as calling
      /// Console.ReadLine() from the application should be considered where
      /// possible.</remarks>
      ///
      public void WaitForFiguresToDie()
      {
          mcr.WaitForFiguresToDie();
      }


      
      #endregion Methods

      #region Class Members

      private static MWMCR mcr= null;

      private bool disposed= false;

      #endregion Class Members
  }
}
