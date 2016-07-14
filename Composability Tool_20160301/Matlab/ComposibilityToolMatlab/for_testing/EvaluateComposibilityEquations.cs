/*
* MATLAB Compiler: 6.2 (R2016a)
* Date: Tue Jul 12 04:22:22 2016
* Arguments: "-B" "macro_default" "-W"
* "dotnet:ComposibilityToolMatlab,EvaluateComposibilityEquations,0.0,private" "-T"
* "link:lib" "-d" "C:\Users\Zara\Documents\Visual Studio 2015\Projects\Composability
* Tool_20160301\Composability Tool_20160301\Composability
* Tool_20160301\Matlab\ComposibilityToolMatlab\for_testing" "-v"
* "class{EvaluateComposibilityEquations:C:\Users\Zara\Documents\Visual Studio
* 2015\Projects\Composability Tool_20160301\Composability Tool_20160301\Composability
* Tool_20160301\Matlab\evaluateComposibilityEquations.m}"
* "class{EvaluateSustainabilityMetrics:C:\Users\Zara\Documents\Visual Studio
* 2015\Projects\Composability Tool_20160301\Composability Tool_20160301\Composability
* Tool_20160301\Matlab\Sustainability_Evaluation_Criteria.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace ComposibilityToolMatlab
{

  /// <summary>
  /// The EvaluateComposibilityEquations class provides a CLS compliant, MWArray
  /// interface to the MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Zara\Documents\Visual Studio 2015\Projects\Composability
  /// Tool_20160301\Composability Tool_20160301\Composability
  /// Tool_20160301\Matlab\evaluateComposibilityEquations.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class EvaluateComposibilityEquations : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static EvaluateComposibilityEquations()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "ComposibilityToolMatlab.ctf";

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
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the EvaluateComposibilityEquations class.
    /// </summary>
    public EvaluateComposibilityEquations()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~EvaluateComposibilityEquations()
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
    /// Provides a single output, 0-input MWArrayinterface to the
    /// evaluateComposibilityEquations MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray evaluateComposibilityEquations()
    {
      return mcr.EvaluateFunction("evaluateComposibilityEquations", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the
    /// evaluateComposibilityEquations MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="expr">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray evaluateComposibilityEquations(MWArray expr)
    {
      return mcr.EvaluateFunction("evaluateComposibilityEquations", expr);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the
    /// evaluateComposibilityEquations MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] evaluateComposibilityEquations(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluateComposibilityEquations", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the
    /// evaluateComposibilityEquations MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="expr">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] evaluateComposibilityEquations(int numArgsOut, MWArray expr)
    {
      return mcr.EvaluateFunction(numArgsOut, "evaluateComposibilityEquations", expr);
    }


    /// <summary>
    /// Provides an interface for the evaluateComposibilityEquations function in which
    /// the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void evaluateComposibilityEquations(int numArgsOut, ref MWArray[] argsOut, 
                                     MWArray[] argsIn)
    {
      mcr.EvaluateFunction("evaluateComposibilityEquations", numArgsOut, ref argsOut, 
                                     argsIn);
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

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}