This is a tutorial on how to create your first project using ASP.NET vNext. This new version of ASP.NET is vastly different compared to previous versions and it may be frustrating in getting started. 

I'm using Visual Studio 2015 RC on a Windows OS.

Start by creating a new project and call it something like "vNext Tutorial". Select C# as programming language and "ASP.NET Web Application" as project template. In the next dialog there should be the option to select a more specific template both for ASP.NET 4.5 and ASP.NET 5. Under ASP.NET 5 there are 3 different templates.

1. Empty
2. Web API
3. Web Site

Pick "Empty" to create a minimal project. From here we will start adding to our project according to the MVC pattern.

Take a look in the Visual Studio Solution Explorer, it should similar to this. We are using the DNX execution environment and the Core framework with cross-platform support and can be deployed without the full .NET installation.

<Insert Struture1.png here>

Start the project and you should see "Hello World" being written to your browser. If you take a closer look at the Startup.cs file you see its a string being written to the browser.

Next we will add a Controller and View. Add a folder called "Controllers" to the project and add a MVC Controller Class to the folder. The Microsoft.AspNet.Mvc namespace will be missing and the build will fail. Since we are not using assemblies and the full .NET framework we cant add a reference as usual with the Reference Manager window.

First create a view by adding a folder called "Views" and another folder called "Home" to the "Views" folder. Add a new Item and name it "Index.cshtml" to the new folder. 

Now lets setup up routing so that the View is loaded by default by the controller. We'll do this in the Startup class with two small changes. First we need to add MVC to the service container with a single line:

    services.AddMvc();

Finally routing is configured in the Configure method like this:

    app.UseMvc(routes =>
            {
                routes.MapRoute("Index", null, new { controller = "Home", action = "Index" });
            });

To fix the build error a dependency to Asp.Mvc is added to the project.json file. 
 
    "dependencies": {
        "Microsoft.AspNet.Server.IIS": "1.0.0-beta4",
        "Microsoft.AspNet.Server.WebListener": "1.0.0-beta4",
        "Microsoft.AspNet.Mvc": "6.0.0-beta4"
     }  

The above C# syntax only seem to work for MVC 6 so any of the MVC 5 version will not work but it should be a minor fix if you want to use the non-beta version 5 instead.

Now run the project and your default browser should open the view. The view will be empty but with the basic scaffolding for MVC using the lastest version of ASP.NET completed we can add more stuff in the next step of the tutorial.





