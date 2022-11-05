// See https://aka.ms/new-console-template for more information

#if TstVar
Console.WriteLine("TST_VAR Exists!");
#endif

#if GoVar
Console.WriteLine("GoVar Exists!");
#endif

var txtVarVal = Environment.GetEnvironmentVariable("TST_VAR");
if (!string.IsNullOrEmpty(txtVarVal))
{
    Console.WriteLine("TST_VAR has value!");
}

#if PathVar
Console.WriteLine("PathVar Exists!");
#endif
