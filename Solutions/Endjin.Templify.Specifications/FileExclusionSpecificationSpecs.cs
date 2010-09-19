#region License

//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Endjin.Templify.Domain.Domain.Packager.Tokeniser;
using Endjin.Templify.Specifications;

using Machine.Specifications;

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

#endregion

namespace Endjin.Templify.Specifications
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Endjin.Templify.Domain.Domain.Packager.Specifications;

    using Machine.Specifications;
    using Machine.Specifications.AutoMocking.Rhino;

    #endregion

    public abstract class specification_for_file_exclusion_specification
    {
        protected static List<string> file_list;

        private Establish context = () =>
            {
                file_list = new List<string>
                    {
                        @"C:\__NAME__\.git\hooks\applypatch-msg.sample",
                        @"C:\__NAME__\.git\hooks\post-commit.sample",
                        @"C:\__NAME__\.git\hooks\commit-msg.sample",
                        @"C:\__NAME__\.git\hooks\post-receive.sample",
                        @"C:\__NAME__\.git\hooks\post-update.sample",
                        @"C:\__NAME__\.git\hooks\pre-applypatch.sample",
                        @"C:\__NAME__\.git\hooks\pre-commit.sample",
                        @"C:\__NAME__\.git\hooks\pre-rebase.sample",
                        @"C:\__NAME__\.git\hooks\prepare-commit-msg.sample",
                        @"C:\__NAME__\.git\hooks\update.sample",
                        @"C:\__NAME__\.git\info\exclude",
                        @"C:\__NAME__\.git\info\refs",
                        @"C:\__NAME__\.git\logs\HEAD",
                        @"C:\__NAME__\.git\logs\refs\heads\master",
                        @"C:\__NAME__\.git\logs\refs\remotes\origin\master",
                        @"C:\__NAME__\.git\objects\1c\142b2e5715da01f39e6be8f6909e76265a0c8b",
                        @"C:\__NAME__\.git\objects\4b\825dc642cb6eb9a060e54bf8d69288fbee4904",
                        @"C:\__NAME__\.git\objects\60\fb067a460c56a01b4ff319ea68f618f3811fc6",
                        @"C:\__NAME__\.git\objects\66\2d36d70adc611e68e8565971050e1683bbe596",
                        @"C:\__NAME__\.git\objects\7a\3f324467c39b7428d964a53518c0c03b614695",
                        @"C:\__NAME__\.git\objects\info\packs",
                        @"C:\__NAME__\.git\refs\heads\master",
                        @"C:\__NAME__\.git\refs\remotes\origin\master",
                        @"C:\__NAME__\Build\Build.proj",
                        @"C:\__NAME__\Build\FullBuild.cmd",
                        @"C:\__NAME__\Build\ImportData.cmd",
                        @"C:\__NAME__\Build\Package.cmd",
                        @"C:\__NAME__\Build\ReleaseBuild.cmd",
                        @"C:\__NAME__\Build\ReleaseBuild_Dont_Increment_Version.cmd",
                        @"C:\__NAME__\Build\RunFirst.cmd",
                        @"C:\__NAME__\Build\RunSpecs.cmd",
                        @"C:\__NAME__\Build\SharpArch.Build.csproj",
                        @"C:\__NAME__\Build\Properties\Build.properties",
                        @"C:\__NAME__\Build\Properties\Common.properties",
                        @"C:\__NAME__\Build\Properties\CPUArchitecture.properties",
                        @"C:\__NAME__\Build\Properties\Global.Imports",
                        @"C:\__NAME__\Build\Signing\WhoCanHelpMe.snk",
                        @"C:\__NAME__\Build\Targets\BuildSolutions.target",
                        @"C:\__NAME__\Build\Tasks\MSBuild.Community.tasks",
                        @"C:\__NAME__\Build\Targets\BuildSuccess.target",
                        @"C:\__NAME__\Build\Targets\CleanSolution.target",
                        @"C:\__NAME__\Build\Tasks\MSBuild.Community.Tasks.dll",
                        @"C:\__NAME__\Build\Tasks\MSBuild.Extended.tasks",
                        @"C:\__NAME__\Build\Targets\CreateDrops.target",
                        @"C:\__NAME__\Build\Targets\Package.target",
                        @"C:\__NAME__\Build\Targets\RunSpecs.target",
                        @"C:\__NAME__\Build\Targets\SyncWithSourceControl.target",
                        @"C:\__NAME__\Build\Targets\Template.target",
                        @"C:\__NAME__\Build\Tasks\MSBuild.Extended.Tasks.dll",
                        @"C:\__NAME__\Build\Targets\VersionNumberGenerate.target",
                        @"C:\__NAME__\Build\Targets\VersionNumberGetLast.target",
                        @"C:\__NAME__\Build\Targets\VersionNumberIncrement.target",
                        @"C:\__NAME__\Build\Tasks\ICSharpCode.SharpZipLib.dll",
                        @"C:\__NAME__\Build\Tasks\Microsoft.Sdc.Common.tasks",
                        @"C:\__NAME__\Build\Tasks\Microsoft.Sdc.Tasks.dll",
                        @"C:\__NAME__\Build\Versioning\VersionNumber.exe",
                        @"C:\__NAME__\Build\Versioning\VersionNumber.exe.config",
                        @"C:\__NAME__\Data\Mongo.DB.Import\ReadMe.txt",
                        @"C:\__NAME__\ReferencedAssemblies\AutoMapper\AutoMapper.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Castle\Castle.Core.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Castle\Castle.DynamicProxy2.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Castle\Castle.MicroKernel.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Castle\Castle.Services.Transaction.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Castle\Castle.Services.Logging.Log4netIntegration.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Castle\Castle.Windsor.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Castle\CommonServiceLocator.WindsorAdapter.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\CommandLine.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\InstallResharperRunner.4.1.bat",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\InstallResharperRunner.4.5.bat",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\InstallResharperRunner.5.0.bat",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\InstallTDNetRunner.bat",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.AutoMocking.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.ConsoleRunner.exe",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.GallioAdapter.3.1.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.Mvc.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.Reporting.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.SeleniumSupport.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.Reporting.Templates.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.ReSharperRunner.4.1.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.TDNetRunner.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.ReSharperRunner.4.5.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\mspec.exe",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Machine.Specifications.ReSharperRunner.5.0.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Newtonsoft.Json.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\Spark.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\TestDriven.Framework.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Machine.Specifications\ThoughtWorks.Selenium.Core.dll",
                        @"C:\__NAME__\ReferencedAssemblies\NoRM\Norm.dll",
                        @"C:\__NAME__\ReferencedAssemblies\NoRM\Norm.dll.old",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenBastard.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenBastard.Hosting.Iis7.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenBastard.TestRunner.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenRasta.Codecs.SharpView.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenRasta.Codecs.Spark.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenRasta.Codecs.WebForms.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenRasta.DI.Windsor.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenRasta.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenRasta.Hosting.AspNet.dll",
                        @"C:\__NAME__\ReferencedAssemblies\OpenRasta\OpenRasta.Testing.dll",
                        @"C:\__NAME__\ReferencedAssemblies\RhinoMocks\Rhino.Mocks.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Spark\Spark.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Spark\Spark.Web.Mvc.dll",
                        @"C:\__NAME__\ReferencedAssemblies\Spark\Spark.Web.Mvc.Pdf.dll",
                        @"C:\__NAME__\Solutions\come-work-for-us.sln",
                        @"C:\__NAME__\Solutions\__NAME__.Domain\__NAME__.Domain.csproj",
                        @"C:\__NAME__\Solutions\__NAME__.Domain\Properties\AssemblyInfo.cs",
                        @"C:\__NAME__\Solutions\__NAME__.Infrastructure\__NAME__.Infrastructure.csproj",
                        @"C:\__NAME__\Solutions\__NAME__.Infrastructure\Properties\AssemblyInfo.cs",
                        @"C:\__NAME__\Solutions\__NAME__.Specifications\__NAME__.Specifications.csproj",
                        @"C:\__NAME__\Solutions\__NAME__.Specifications\Properties\AssemblyInfo.cs",
                        @"C:\__NAME__\Solutions\__NAME__.Tasks\__NAME__.Tasks.csproj",
                        @"C:\__NAME__\Solutions\__NAME__.Tasks\Properties\AssemblyInfo.cs",
                        @"C:\__NAME__\Solutions\__NAME__.WebCore\__NAME__.WebCore.csproj",
                        @"C:\__NAME__\Solutions\__NAME__.WebCore\Handlers\HomeHandler.cs",
                        @"C:\__NAME__\Solutions\__NAME__.WebCore\Properties\AssemblyInfo.cs",
                        @"C:\__NAME__\Solutions\__NAME__.WebCore\Resources\HomeResource.cs",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\__NAME__.WebView.csproj",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Configuration.cs",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Web.config",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Web.Debug.config",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Web.Release.config",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Content\Scripts\raphael.js",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Content\Styles\site.css",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Properties\AssemblyInfo.cs",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Views\Home.spark",
                        @"C:\__NAME__\Solutions\__NAME__.WebView\Views\Layouts\Application.spark",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongo.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongod.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongodump.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongorestore.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongoexport.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongofiles.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongoimport.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongos.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongofiles.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\mongostat.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongoimport.exe",
                        @"C:\__NAME__\Tools\MongoDB\x64\start-mongo-(the-client).cmd",
                        @"C:\__NAME__\Tools\MongoDB\x64\start-mongod-(the-server).cmd",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongo.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongorestore.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongos.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongod.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongostat.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongodump.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\start-mongo-(the-client).cmd",
                        @"C:\__NAME__\Tools\MongoDB\x86\mongoexport.exe",
                        @"C:\__NAME__\Tools\MongoDB\x86\start-mongod-(the-server).cmd",
                    };
            };
    } ;

    [Subject(typeof(FileExclusionSpecification))]
    public class when_the_file_exclusion_specification_is_given_a_list_of_items_to_exclude : specification_for_file_exclusion_specification
    {
        static FileExclusionSpecification subject;
        static IEnumerable<string> result;

        Establish context = () =>
            {
                subject = new FileExclusionSpecification();
            };

        Because of = () => result = subject.SatisfyingElementsFrom(file_list.AsQueryable());

        It should_return_no_files = () => result.Count().ShouldEqual(0);
    }
}