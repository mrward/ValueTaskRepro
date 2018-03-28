# ValueTaskRepro
Reproduction for the following ValueTask error:

>/Users/bramin/Projects/ValueTaskRepro/iOS/Path_iOS.cs(26,26): Error CS0012: The type 'ValueTask<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Threading.Tasks.Extensions, Version=4.1.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'. (CS0012) (ValueTaskRepro.iOS)

## Steps to Reproduce
1. Install the current Visual Studio Mac Beta Channel release, as of 0340 28 March 2018 (Environment Information below)
2. Open ValueTaskRepro.sln in Visual Studio Mac (Beta Channel)
3. Build ValueTaskRepro.iOS or ValueTaskRepro.Droid

## Available Workaround
1. Install the current Visual Studio Mac Stable Channel release, as of 0340 28 March 2018 
2. Open ValueTaskRepro.sln in Visual Studio Mac (Stable Channel)
3. Install [System.Threading.Tasks.Extensions NuGet Package](https://www.nuget.org/packages/System.Threading.Tasks.Extensions/) into the ValueTaskRepro.iOS project
4. Install [System.Threading.Tasks.Extensions NuGet Package](https://www.nuget.org/packages/System.Threading.Tasks.Extensions/) into the ValueTaskRepro.Droid project
5. Build ValueTaskRepro.iOS or ValueTaskRepro.Droid

## Environment

=== Visual Studio Enterprise 2017 for Mac (Preview) ===

Version 7.5 Preview (7.5 build 933)
Installation UUID: 97f93b74-bd84-4161-86fb-e8c474d1a273
Runtime:
-	Mono 5.10.0.179 (2017-12/dac60775616) (64-bit)
-	GTK+ 2.24.23 (Raleigh theme)
-	Xamarin.Mac 4.4.0.36 (master / 0c7c49a6)

-	Package version: 510000179

=== NuGet ===

Version: 4.3.1.4445

=== .NET Core ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	2.0.6
	2.0.5
SDK: /usr/local/share/dotnet/sdk/2.1.101/Sdks
SDK Versions:
	2.1.101
	2.1.4
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/5.10.0/lib/mono/msbuild/15.0/bin/Sdks

=== Xamarin.Profiler ===

Version: 1.6.2
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Apple Developer Tools ===

Xcode 9.2 (13772)
Build 9C40b

=== Xamarin.Mac ===

Version: 4.4.0.31 (Visual Studio Enterprise)

=== Xamarin.iOS ===

Version: 11.10.0.32 (Visual Studio Enterprise)
Hash: 4d8c4e32
Branch: d15-7
Build date: 2018-03-07 18:39:46-0500

=== Xamarin.Android ===

Version: 8.3.0.5 (Visual Studio Enterprise)
Android SDK: /Users/bramin/Library/Android/sdk
	Supported Android versions:
		7.1 (API level 25)
		8.0 (API level 26)
		8.1 (API level 27)

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 27.0.1
SDK Build Tools Version: 26.0.2

Java SDK: /usr
java version "1.8.0_131"
Java(TM) SE Runtime Environment (build 1.8.0_131-b11)
Java HotSpot(TM) 64-Bit Server VM (build 25.131-b11, mixed mode)

Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Xamarin Inspector ===

Version: 1.4.0
Hash: b3f92f9
Branch: master
Build date: Fri, 19 Jan 2018 22:00:34 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 705000933
Git revision: ace1e107c88477db1abe5e807809650f064112c4
Build date: 2018-03-19 17:42:41-04
Xamarin addins: a01263bdbba2589b1f6e42ef085bd31f6e3bfcf4
Build lane: monodevelop-lion-d15-7

=== Operating System ===

Mac OS X 10.13.3
Darwin 17.4.0 Darwin Kernel Version 17.4.0
    Sun Dec 17 09:19:54 PST 2017
    root:xnu-4570.41.2~1/RELEASE_X86_64 x86_64

=== Enabled user installed addins ===

MFractor 3.04.14
AddinMaker 1.4.2
NuGet Package Management Extensions 0.12.6
Template Creator 0.2
WakaTime 3.0.2
Redth's Addins 1.0.9
Internet of Things (IoT) development (Preview) 7.1

