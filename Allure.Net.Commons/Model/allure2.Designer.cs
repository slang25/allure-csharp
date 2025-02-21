// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//    <NameSpace>Allure.Net.Commons</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net45</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><ClassesInSeparateFilesDir></ClassesInSeparateFilesDir><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><IndentChar>Indent2Space</IndentChar><NewLineAttr>False</NewLineAttr><OmitXML>False</OmitXML><Encoder>UTF8</Encoder><Serializer>JSonSerializer</Serializer><sspNullable>True</sspNullable><sspString>True</sspString><sspCollection>True</sspCollection><sspComplexType>True</sspComplexType><sspSimpleType>True</sspSimpleType><sspEnumType>True</sspEnumType><XmlSerializerEvent>False</XmlSerializerEvent><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Allure.Net.Commons
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.Collections.Generic;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TestRunResult
    {

        #region Private fields
        private string _uuid;

        private string _name;
        #endregion

        public string uuid
        {
            get
            {
                return this._uuid;
            }
            set
            {
                this._uuid = value;
            }
        }

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TestResultContainer
    {

        #region Private fields
        private string _uuid;

        private string _name;

        private List<string> _children;

        private string _description;

        private string _descriptionHtml;

        private List<FixtureResult> _befores;

        private List<FixtureResult> _afters;

        private List<Link> _links;

        private long _start;

        private long _stop;
        #endregion

        public TestResultContainer()
        {
            this._links = new List<Link>();
            this._afters = new List<FixtureResult>();
            this._befores = new List<FixtureResult>();
            this._children = new List<string>();
        }

        public string uuid
        {
            get
            {
                return this._uuid;
            }
            set
            {
                this._uuid = value;
            }
        }

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public List<string> children
        {
            get
            {
                return this._children;
            }
            set
            {
                this._children = value;
            }
        }

        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public string descriptionHtml
        {
            get
            {
                return this._descriptionHtml;
            }
            set
            {
                this._descriptionHtml = value;
            }
        }

        public List<FixtureResult> befores
        {
            get
            {
                return this._befores;
            }
            set
            {
                this._befores = value;
            }
        }

        public List<FixtureResult> afters
        {
            get
            {
                return this._afters;
            }
            set
            {
                this._afters = value;
            }
        }

        public List<Link> links
        {
            get
            {
                return this._links;
            }
            set
            {
                this._links = value;
            }
        }

        public long start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }

        public long stop
        {
            get
            {
                return this._stop;
            }
            set
            {
                this._stop = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class FixtureResult : ExecutableItem
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public abstract partial class ExecutableItem
    {

        #region Private fields
        private string _name;

        private Status _status;

        private StatusDetails _statusDetails;

        private Stage _stage;

        private string _description;

        private string _descriptionHtml;

        private List<StepResult> _steps;

        private List<Attachment> _attachments;

        private List<Parameter> _parameters;

        private long _start;

        private long _stop;
        #endregion

        public ExecutableItem()
        {
            this._parameters = new List<Parameter>();
            this._attachments = new List<Attachment>();
            this._steps = new List<StepResult>();
            this._statusDetails = new StatusDetails();
        }

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public Status status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }

        public StatusDetails statusDetails
        {
            get
            {
                return this._statusDetails;
            }
            set
            {
                this._statusDetails = value;
            }
        }

        public Stage stage
        {
            get
            {
                return this._stage;
            }
            set
            {
                this._stage = value;
            }
        }

        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public string descriptionHtml
        {
            get
            {
                return this._descriptionHtml;
            }
            set
            {
                this._descriptionHtml = value;
            }
        }

        public List<StepResult> steps
        {
            get
            {
                return this._steps;
            }
            set
            {
                this._steps = value;
            }
        }

        public List<Attachment> attachments
        {
            get
            {
                return this._attachments;
            }
            set
            {
                this._attachments = value;
            }
        }

        public List<Parameter> parameters
        {
            get
            {
                return this._parameters;
            }
            set
            {
                this._parameters = value;
            }
        }

        public long start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }

        public long stop
        {
            get
            {
                return this._stop;
            }
            set
            {
                this._stop = value;
            }
        }
    }

    public enum Status
    {
        none,
        /// <remarks/>
        failed,

        /// <remarks/>
        broken,

        /// <remarks/>
        passed,

        /// <remarks/>
        skipped,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class StatusDetails
    {

        #region Private fields
        private bool _known;

        private bool _muted;

        private bool _flaky;

        private string _message;

        private string _trace;
        #endregion

        public bool known
        {
            get
            {
                return this._known;
            }
            set
            {
                this._known = value;
            }
        }

        public bool muted
        {
            get
            {
                return this._muted;
            }
            set
            {
                this._muted = value;
            }
        }

        public bool flaky
        {
            get
            {
                return this._flaky;
            }
            set
            {
                this._flaky = value;
            }
        }

        public string message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
            }
        }

        public string trace
        {
            get
            {
                return this._trace;
            }
            set
            {
                this._trace = value;
            }
        }
    }

    public enum Stage
    {

        /// <remarks/>
        scheduled,

        /// <remarks/>
        running,

        /// <remarks/>
        finished,

        /// <remarks/>
        pending,

        /// <remarks/>
        interrupted,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class StepResult : ExecutableItem
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Attachment
    {

        #region Private fields
        private string _name;

        private string _source;

        private string _type;
        #endregion

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }

        public string type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Parameter
    {

        #region Private fields
        private string _name;

        private string _value;
        #endregion

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TestResult : ExecutableItem
    {

        #region Private fields
        private string _uuid;

        private string _historyId;

        private string _testCaseId;

        private string _rerunOf;

        private string _fullName;

        private List<Label> _labels;

        private List<Link> _links;
        #endregion

        public TestResult()
        {
            this._links = new List<Link>();
            this._labels = new List<Label>();
        }

        public string uuid
        {
            get
            {
                return this._uuid;
            }
            set
            {
                this._uuid = value;
            }
        }

        public string historyId
        {
            get
            {
                return this._historyId;
            }
            set
            {
                this._historyId = value;
            }
        }

        public string testCaseId
        {
            get
            {
                return this._testCaseId;
            }
            set
            {
                this._testCaseId = value;
            }
        }

        public string rerunOf
        {
            get
            {
                return this._rerunOf;
            }
            set
            {
                this._rerunOf = value;
            }
        }

        public string fullName
        {
            get
            {
                return this._fullName;
            }
            set
            {
                this._fullName = value;
            }
        }

        public List<Label> labels
        {
            get
            {
                return this._labels;
            }
            set
            {
                this._labels = value;
            }
        }

        public List<Link> links
        {
            get
            {
                return this._links;
            }
            set
            {
                this._links = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Label
    {

        #region Private fields
        private string _name;

        private string _value;
        #endregion

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Link
    {

        #region Private fields
        private string _name;

        private string _url;

        private string _type;
        #endregion

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = value;
            }
        }

        public string type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}
#pragma warning restore
