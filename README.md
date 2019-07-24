Runt the app:

```sh
 dotnet run --project aspnet3/
```

Make a request to `http://localhost:5000/`

```
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HLOG3BFKK5BS", Request id "0HLOG3BFKK5BS:00000001": An unhandled exception was thrown by the application.
System.TypeLoadException: Could not load type 'Microsoft.AspNetCore.Http.Internal.BufferingHelper' from assembly 'Microsoft.AspNetCore.Http, Version=3.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'.
   at Class1.<>c.<<EnableRewind>b__0_0>d.MoveNext()
   at System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[TStateMachine](TStateMachine& stateMachine)
   at Class1.<>c.<EnableRewind>b__0_0(HttpContext context, Func`1 next)
   at Microsoft.AspNetCore.Builder.UseExtensions.<>c__DisplayClass0_1.<Use>b__1(HttpContext context)
   at Microsoft.AspNetCore.HostFiltering.HostFilteringMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Hosting.HostingApplication.ProcessRequestAsync(Context context)
   at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)

```