// -----------------------------------------------------------------------------------------
// <copyright file="TestBase.cs" company="Microsoft">
//    Copyright 2013 Microsoft Corporation
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// -----------------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Storage
{
    using Microsoft.WindowsAzure.Storage.Auth;
    using System.Xml.Linq;
	using NUnit.Framework;

	[TestFixture]
    public partial class TestBase
    {
		private const string TestConfigurationsXml=@"
			<TestConfigurations>
			<TargetTestTenant>ProductionTenant</TargetTestTenant>
			<TenantConfigurations>
			  <TenantConfiguration>
			    <TenantName>DevStore</TenantName>
			    <TenantType>DevStore</TenantType>
			    <AccountName>devstoreaccount1</AccountName>
			    <AccountKey>Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==</AccountKey>
			    <BlobServiceEndpoint>http://127.0.0.1:10000/devstoreaccount1</BlobServiceEndpoint>
			    <QueueServiceEndpoint>http://127.0.0.1:10001/devstoreaccount1</QueueServiceEndpoint>
			    <TableServiceEndpoint>http://127.0.0.1:10002/devstoreaccount1</TableServiceEndpoint>
			  </TenantConfiguration>
			  <TenantConfiguration>
			    <TenantName>ProductionTenant</TenantName>
			    <TenantType>Cloud</TenantType>
			    <AccountName>expensemonkey</AccountName>
			    <AccountKey>yhxWrqdk0XaT3Dx6LnCkQr5VAk3O5ITgXzO4F6MA8mB21NtLZVARY6q172+iBJz2RJjJMNKO24gwfxR7636i6w==</AccountKey>
			    <BlobServiceEndpoint>http://expensemonkey.blob.core.windows.net</BlobServiceEndpoint>
			    <QueueServiceEndpoint>http://expensemonkey.queue.core.windows.net</QueueServiceEndpoint>
			    <TableServiceEndpoint>http://expensemonkey.table.core.windows.net</TableServiceEndpoint>
			    <FileServiceEndpoint>http://expensemonkey.file.core.windows.net</FileServiceEndpoint>
			    <BlobServiceSecondaryEndpoint>http://expensemonkey-secondary.blob.core.windows.net</BlobServiceSecondaryEndpoint>
			    <QueueServiceSecondaryEndpoint>http://expensemonkey-secondary.queue.core.windows.net</QueueServiceSecondaryEndpoint>
			    <TableServiceSecondaryEndpoint>http://expensemonkey-secondary.table.core.windows.net</TableServiceSecondaryEndpoint>
			  </TenantConfiguration>
			</TenantConfigurations>
			</TestConfigurations>";

        static TestBase()
        {
			XElement element = XElement.Parse(TestConfigurationsXml);
            TestConfigurations configurations = TestConfigurations.ReadFromXml(element);
            TestBase.Initialize(configurations);
        }
    }
}
