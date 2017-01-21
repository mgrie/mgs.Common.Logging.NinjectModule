# mgs.Common.Logging.NinjectModule
A small <code class="syntax brush-csharp">NinjectModule</code> for <code class="syntax brush-csharp">Common.Logging.ILog</code>

## Usage

Add the NinjectModule to your Kernel:

<pre class="syntax brush-csharp">
kernel.Load("*.dll");
</pre>

or

<pre class="syntax brush-csharp">
kernel.Load(new Common.Logging.Ninject.NinjectModule());
</pre>
