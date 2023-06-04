using Microsoft.AspNetCore.ResponseCompression;
using System.IO.Compression;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddResponseCompression(opts =>
{
    opts.EnableForHttps = true;
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
    {
        "application/octet-stream"
    }).ToArray();
    opts.Providers.Add<BrotliCompressionProvider>();
    opts.Providers.Add<GzipCompressionProvider>();
})
    .Configure<BrotliCompressionProviderOptions>(opt => opt.Level = CompressionLevel.Fastest)
    .Configure<GzipCompressionProviderOptions>(opt => opt.Level = CompressionLevel.Fastest);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
if (app.Environment.IsProduction() || true)
{
    app.UseResponseCompression();
}
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapFallbackToFile("index.html");

app.Run();
