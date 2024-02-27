Azure Function : A single, individual function with a specific trigger and associated logic.	
Azure Function App : A collection or container that can host multiple functions within the same environment. it provides an execution context in Azure where our functions run. Functions in one function app can be mamnaged, deployed and scaled together.

**Triggers:**  Event sources that initiate the execution of functions. Examples include HTTP requests, timers, blob changes, and queue messages.

HTTP Triggers:
How They Work: Respond to HTTP requests.
When to Use: Build web APIs, handle HTTP-based events.

Timer Triggers:
How They Work: Execute on a schedule.
When to Use: Run periodic tasks, scheduled jobs.

Blob Triggers:
How They Work: Triggered by changes in Azure Storage blobs.
When to Use: Process files or data in Azure Storage.

**Bindings:** Bindings in Azure Functions connect functions to external resources for input and output.

Facilitation:
Input Bindings: Bring data into functions (e.g., Azure Storage, Service Bus).
Output Bindings: Send data out of functions (e.g., update databases, send messages).

**Types of Bindings:**

Input Bindings:
Example: Azure Blob Storage input binding.
Use Cases: Retrieve data for processing.

Output Bindings:
Example: Azure Queue Storage output binding.
Use Cases: Update external systems, persist results.

Trigger Bindings:
Example: HTTP Trigger binding.
Use Cases: Define events triggering function execution.


**Example Folder Structure:** 

			MyFunctionApp
			|-- .gitignore
			|-- host.json
			|-- local.settings.json
			|-- MyFirstFunction
			|   |-- function.json
			|   |-- run.csx
			|-- MySecondFunction
			|   |-- function.json
			|   |-- ...
			|-- SharedCode
			|   |-- mySharedModule.cs
			|-- bin
			|   |-- (compiled binaries and dependencies)
			|-- obj
			|   |-- (object files, intermediate build files)
			|-- extensions.csproj
			|-- MyFunctionApp.sln


___
NOTES : 

**function.json** is created for compiled languages but for scripting language you must provide it (function.json is created when we build or puiblish)
Every function has only one trigger.

**FUNCTIONS_WORKER_RUNTIME** environment variable in Azure Functions specifies the language or runtime that your function app uses to execute functions. (Runtime stack sets it e.g dotnet core)
**FUNTIONS_EXTENSION_VERSION** is an environment variable that specifies the version of the Azure Functions runtime that your function app is using. (default setting is version 2.x)

Best way to **migrate** is to create a new function app and port existing version function code to the new app.

