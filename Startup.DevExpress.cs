//------------------------------------------------------------------------------
// Generated by the DevExpress.Blazor package.
// To prevent this operation, add the DxExtendStartupHost property to the project and set this property to False.
//
// AweBlazor.csproj:
//
// <Project Sdk="Microsoft.NET.Sdk.Web">
//  <PropertyGroup>
//    <TargetFramework>netcoreapp3.1</TargetFramework>
//    <DxExtendStartupHost>False</DxExtendStartupHost>
//  </PropertyGroup>
//------------------------------------------------------------------------------
using System;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(AweBlazor.DevExpressHostingStartup))]

namespace AweBlazor {
    public partial class DevExpressHostingStartup : IHostingStartup {
        void IHostingStartup.Configure(IWebHostBuilder builder) {
            builder.ConfigureServices((serviceCollection) => {
                serviceCollection.AddDevExpressBlazor();
            });
        }
    }
}