﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Informedica.GenUnits.lib")>]
[<assembly: AssemblyProductAttribute("GenUnits")>]
[<assembly: AssemblyCompanyAttribute("halcwb")>]
[<assembly: AssemblyDescriptionAttribute("Basic units of measure library enabling calculating with values that have units")>]
[<assembly: AssemblyVersionAttribute("0.3.0")>]
[<assembly: AssemblyFileVersionAttribute("0.3.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.0"
    let [<Literal>] InformationalVersion = "0.3.0"
