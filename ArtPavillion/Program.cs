using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.FileProviders;
using System;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
var environment = builder.Environment;

services.AddRazorPages();

if (environment.IsDevelopment()) configuration.AddUserSecrets<Program>();

services.AddHttpClient();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
