# mgs.Common.Logging.NinjectModule
A small <code class="syntax brush-csharp">NinjectModule</code> for <code class="syntax brush-csharp">Common.Logging.ILog</code>

## Usage
### Add the NinjectModule to your Kernel

<pre class="syntax brush-csharp">
kernel.Load("*.dll");
</pre>

or

<pre class="syntax brush-csharp">
kernel.Load(new Common.Logging.Ninject.NinjectModule());
</pre>

### Inject a Logger

Property Injection

<pre class="syntax brush-csharp">
[Inject]
public Common.Logging.ILog CommonLogger { get; set; }
</pre>

MVC Base Controller

<pre class="syntax brush-csharp">
using System.Web.Mvc;
using Common.Logging;
using Ninject;

namespace YourWebApplication.Controllers
{
    public class BaseController : Controller
    {
        [Inject]
        public ILog CommonLogger { get; set; }
    }
}
</pre>

### Logger Name

Until you are using the Property Injection, the Logger Name equals to the Class Name of your Instance. If you use <code class="syntax brush-csharp">IKernel.Get&lt;ILog&gt;</code>, the Logger Name belongs to <code class="syntax brush-csharp">Settings.Default.DefaultLoggerName</code>
