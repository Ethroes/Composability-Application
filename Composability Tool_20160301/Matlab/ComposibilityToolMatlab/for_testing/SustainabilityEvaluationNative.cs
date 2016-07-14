/*
* MATLAB Compiler: 6.2 (R2016a)
* Date: Tue Jul 12 03:14:55 2016
* Arguments: "-B" "macro_default" "-W"
* "dotnet:ComposibilityToolMatlab,SustainabilityEvaluation,0.0,private" "-T" "link:lib"
* "-d" "C:\Users\Zara\Documents\Visual Studio 2015\Projects\Composability
* Tool_20160301\Composability Tool_20160301\Composability
* Tool_20160301\Matlab\ComposibilityToolMatlab\for_testing" "-v"
* "class{SustainabilityEvaluation:C:\Users\Zara\Documents\Visual Studio
* 2015\Projects\Composability Tool_20160301\Composability Tool_20160301\Composability
* Tool_20160301\Matlab\Sustainability_Evaluation_Criteria.m}"
* "class{EvaluateComposibilityEquations:C:\Users\Zara\Documents\Visual Studio
* 2015\Projects\Composability Tool_20160301\Composability Tool_20160301\Composability
* Tool_20160301\Matlab\evaluateComposibilityEquations.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace ComposibilityToolMatlabNative
{

  /// <summary>
  /// The SustainabilityEvaluation class provides a CLS compliant, Object (native)
  /// interface to the MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Zara\Documents\Visual Studio 2015\Projects\Composability
  /// Tool_20160301\Composability Tool_20160301\Composability
  /// Tool_20160301\Matlab\Sustainability_Evaluation_Criteria.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class SustainabilityEvaluation : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static SustainabilityEvaluation()
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
    /// Constructs a new instance of the SustainabilityEvaluation class.
    /// </summary>
    public SustainabilityEvaluation()
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
    ~SustainabilityEvaluation()
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
    /// Provides a single output, 0-input Objectinterface to the
    /// Sustainability_Evaluation_Criteria MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function accepts the results of the process and linking model
    /// parametric equations and then inputs them to determine the final
    /// sustainability scores
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Sustainability_Evaluation_Criteria()
    {
      return mcr.EvaluateFunction("Sustainability_Evaluation_Criteria", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the
    /// Sustainability_Evaluation_Criteria MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function accepts the results of the process and linking model
    /// parametric equations and then inputs them to determine the final
    /// sustainability scores
    /// </remarks>
    /// <param name="inputVars">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Sustainability_Evaluation_Criteria(Object inputVars)
    {
      return mcr.EvaluateFunction("Sustainability_Evaluation_Criteria", inputVars);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the
    /// Sustainability_Evaluation_Criteria MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function accepts the results of the process and linking model
    /// parametric equations and then inputs them to determine the final
    /// sustainability scores
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Sustainability_Evaluation_Criteria(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Sustainability_Evaluation_Criteria", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the
    /// Sustainability_Evaluation_Criteria MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function accepts the results of the process and linking model
    /// parametric equations and then inputs them to determine the final
    /// sustainability scores
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inputVars">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Sustainability_Evaluation_Criteria(int numArgsOut, Object inputVars)
    {
      return mcr.EvaluateFunction(numArgsOut, "Sustainability_Evaluation_Criteria", inputVars);
    }


    /// <summary>
    /// Provides an interface for the Sustainability_Evaluation_Criteria function in
    /// which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This function accepts the results of the process and linking model
    /// parametric equations and then inputs them to determine the final
    /// sustainability scores
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("Sustainability_Evaluation_Criteria", 1, 7, 0)]
    protected void Sustainability_Evaluation_Criteria(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("Sustainability_Evaluation_Criteria", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
