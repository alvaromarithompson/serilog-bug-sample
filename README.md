# serilog-bug-sample
This repository illustrates the problem of using AutofacSerilogIntegration in ASP.NET Core 2.1 and injecting the ILogger to controllers.

The `{SourceContext}` property in the OutputTemplate is blank when making calls to the ILogger from within a Controller, but works ok if injected into an arbitrary utility class.

    2018-10-27 08:56:17.919 INF [] - This is a log line from a controller.
    2018-10-27 08:56:17.927 INF [SerilogSample.Test] - This is a log line from a class.

To test, do a GET request in a browser to api/test, e.g. https://localhost:44315/api/test