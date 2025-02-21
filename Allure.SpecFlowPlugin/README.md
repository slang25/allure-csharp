## SpecFlow Adapter  [![](http://img.shields.io/nuget/vpre/Allure.SpecFlow.svg?style=flat)](https://www.nuget.org/packages/Allure.SpecFlow)

Currently supports [SpecFlow](http://specflow.org/) v2.1 - 3.9.*

See [Allure report](https://allure-secondary.z23.web.core.windows.net/)
generated from https://github.com/allure-framework/allure-csharp/tree/main/Allure.Features

Please use corresponding NuGet package version.

### Installation

Install  [Allure.SpecFlow](https://www.nuget.org/packages/Allure.SpecFlow)
nuget package according to your Specflow version.

#### For users of Mac with Apple silicon

If you're developing on a Mac machine with Apple silicon, make sure you have
Rosetta installed. Follow this article for the instructions:
https://support.apple.com/en-us/HT211861

You may also install Rosetta via the CLI:

```shell
/usr/sbin/softwareupdate --install-rosetta --agree-to-license
```

### Configuration

For Specflow 3 please add or update the following section in your specflow.json:

```json      
{
  "stepAssemblies": [
    { "assembly": "Allure.SpecFlowPlugin" }
  ]
}
```

The plugin uses allureConfig.json extended with custom sections that are
described below.

#### Custom host name

In case if you want to customize host name which is displayed in Allure Timeline
section, please configure `allure.title` property in json configuraion file.

```json
{
    "allure": {
        "title": "My title"
    }
}
```

#### If you use NUnit

The default value for allure.directory in allureConfig.json is "allure-results".
The default working directory in NUnit 3.* depends on what runner you use.

If you don't want to place allure results into NUnit default working folder
please either set absolute path in allure.config or set working directory for
NUnit in your test setup, e.g.:

``` csharp
[OneTimeSetUp]
public void Init()
{
   Environment.CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
}
```

### Usage

Just run your SpecFlow scenarios and find the `allure-results` folder ready to
generate Allure report.

### Features

#### Grouping

You can structure your scenarios in 3 Allure hierarchies using feature and
scenario tags.
Please read [report structure](https://docs.qameta.io/allure/latest/#_report_structure)
Allure documentation section for additional details. Hierarchies consist of
the following levels:

**Suites**
* Parent Suite
* * Suite
* * * Sub Suite

**Behaviors**
* Epic
* * Feature
* * * Story

**Packages**
* Package
* * Class
* * * Method

The plugin uses `allure:grouping` configuration section to parse tags with the
regular expression. If the expression contains the group, it will be used as
hierarchy level name otherwise entire match will be used. E.g:

`^mytag.*` : any tags starting with `@mytag` will be used for grouping.

`^type:(ui|api)` : `@ui` or `@api` tags from regex pattern will be used for
grouping.

Check this [config example](https://github.com/allure-framework/allure-csharp/blob/main/Tests.SpecRun/allureConfig.json)
as a starting point.

#### Links
You can add links to your scenarios using tags. Tag and link patterns can be
configured in `allureConfig.json`

``` json
{
  "allure": {
    "links": [
      "https://myissuetracker.org/{issue}",
      "https://mytestmanagementsystem.org?test={tms}"
    ]
  },
  "specflow": {
    "links": {
      "link": "^link:(.+)",
      "issue": "^\\d+",
      "tms": "^tms:(\\d+)"
    }
  }
}
```

The following scenario

``` cucumber
@123456 @tms:42 @link:http://example.org 
Scenario: I do like click on links in Allure report 
```

will have three links in Allure report:
[123456](https://myissuetracker.org/123456),
[42](https://mytestmanagementsystem.org?test=tms-42) and http://example.org.

Links generated dynamically during the tests can be added in code via
AllureLifecycle. The next example adds the [Example link](http://example.com)
link at runtime:

``` c#
AllureLifecycle.Instance.UpdateTestCase(tc =>
{
    tc.links.Add(new Link()
    {
        name = "Example link",
        url = "http://example.com"
    });
});
```

#### Severity
You can add Severity for your scenarios using tags. It can be configured in
`allureConfig.json`:

``` json
 "labels": {
      "severity": "^(normal|blocker|critical|minor|trivial)"
    },
```

The following scenario

``` cucumber
@critical
Scenario: ....
```

sets the current scenario's severity in Allure report as Blocker.

#### Label

You can add allure labels for your scenarios using tags. It can be configured
in `allureConfig.json`:

``` json
 "labels": {
      "label": "^label:([\\w]+):(.+)"
    },
```

The following scenario

``` cucumber
@label:layer:e2e: @label:allure_id:123
Scenario: ....
```

sets the current scenario's layer as e2e and Id as 123 in Allure report

#### Tables conversion

Table arguments in SpecFlow steps can be converted either to step
csv-attacments or step parameters in the Allure report. The conversion is
configurable in `specflow:stepArguments` config section.

With `specflow:stepArguments:convertToParameters` set to `true` the following
table arguments will be represented as parameters:

* one row tables
* two column tables with the headers matching both
  `specflow:stepArguments:paramNameRegex` and
  `specflow:stepArguments:paramValueRegex` regular expressions.

<table>
<th>SpecFlow</th>
<th>Allure</th>
<tr>
<td>

![](https://github.com/allure-framework/allure-csharp/blob/main/img/wiki-step-all.PNG)

</td>
<td>

![](https://github.com/allure-framework/allure-csharp/blob/main/img/allure-step-all.PNG)

</td>
</tr>
</table>

#### Attachments

You can add attachments to an Allure report from your step bindings:

```csharp
using Allure.Net.Commons;
...
AllureLifecycle.Instance.AddAttachment(path, "Attachment Title");
// or
AllureLifecycle.Instance.AddAttachment("Attachment Title", "application/txt", "path");
// where "application/txt" - type of your attachment
```

### Known issues

#### Selective run might not work

Under rare circumstances selective run feature might not work.
Issue [#369] contains some additional details.

If you are affected by this, you may try to switch to the `Debug` configuration
as a workaround until we come up with a solution.
