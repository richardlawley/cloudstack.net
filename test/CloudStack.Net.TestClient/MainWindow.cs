// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

namespace CloudStack.Net.TestClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Linq;

    /// <summary>
    /// GUI window for testing.
    /// </summary>
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Restore test settings.
            ApiKey.Text = Properties.Settings.Default.User;
            SecretKey.Text = Properties.Settings.Default.Password;
            ServiceUrl.Text = Properties.Settings.Default.URL;
            this.TextBoxTemplateId.Text = Properties.Settings.Default.TemplateId;
            this.TextBoxSubnet.Text = Properties.Settings.Default.SubnetId;
            this.TextBoxZoneId.Text = Properties.Settings.Default.ZoneId;
            this.TextBoxServiceOffering.Text = Properties.Settings.Default.ServiceOfferingId;
            this.checkBoxDeployStopped.Checked = Properties.Settings.Default.DeployStopped;

            ApiKey.Leave += (s, e) => SettingsChanged(s, e);
            SecretKey.Leave += (s, e) => SettingsChanged(s, e);
            ServiceUrl.Leave += (s, e) => SettingsChanged(s, e);
            TextBoxTemplateId.Leave += (s, e) => SettingsChanged(s, e);
            TextBoxSubnet.Leave += (s, e) => SettingsChanged(s, e);
            TextBoxZoneId.Leave += (s, e) => SettingsChanged(s, e);
            TextBoxServiceOffering.Leave += (s, e) => SettingsChanged(s, e);
            checkBoxDeployStopped.Leave += (s, e) => SettingsChanged(s, e);
        }

        private void SettingsChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.User = ApiKey.Text;
            Properties.Settings.Default.Password = SecretKey.Text;
            Properties.Settings.Default.URL = ServiceUrl.Text;
            Properties.Settings.Default.TemplateId = this.TextBoxTemplateId.Text;
            Properties.Settings.Default.SubnetId = this.TextBoxSubnet.Text;
            Properties.Settings.Default.ZoneId = this.TextBoxZoneId.Text;
            Properties.Settings.Default.ServiceOfferingId = this.TextBoxServiceOffering.Text;
            Properties.Settings.Default.DeployStopped = this.checkBoxDeployStopped.Checked;
            Properties.Settings.Default.Save();
        }

        private void WriteToLogBox(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => WriteToLogBox(message)));
            }
            else
            {
                try
                {
                    loggingText.AppendText(DateTime.Now + " : " + message + "\r\n");
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("InvokeRequired bug!!!");
                    System.Diagnostics.Debug.WriteLine(message);
                }
            }
        }

        private void ClearLogBox()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => ClearLogBox()));
            }
            else
            {
                try
                {
                    loggingText.Clear();
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("InvokeRequired bug!!!");
                }
            }
        }

        private void ButtonDeployVM_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Tests tests = new Tests(this.WriteToLogBox);
            tests.DeployVirtualMachine();
        }

        private void ButtonListServiceOfferings_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListServiceOfferings();
        }

        private void ButtonClearLog_Click(object sender, EventArgs e)
        {
            this.ClearLogBox();
        }

        private void ButtonStartVM_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.StartVirtualMachine(this.TextBoxVMId.Text);
        }

        private void ButtonCleanStopVM_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.StopVirtualMachine(this.TextBoxVMId.Text, false);
        }

        private void ButtonForceStopVM_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.StopVirtualMachine(this.TextBoxVMId.Text, true);
        }

        private void ButtonListNetworkOfferings_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListNetworkOfferings();
        }

        private void ButtonCreateSecurityGroup_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            string securityGroupName = "TestSecurityGroup";
            tests.CreateSecurityGroup(securityGroupName);
            tests.AuthorizeSecurityGroupIngress(securityGroupName);
        }

        private void ButtonListSecurityGroups_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListSecurityGroups();
        }

        private void ButtonListVirtualMachines_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListVirtualMachines();
        }

        private void ButtonCreateVolume_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            string volumeId = tests.CreateVolume();
            TextBoxVolId.Text = volumeId;
        }

        private void ButtonAttachVolume_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.AttachVolume(TextBoxVolId.Text, TextBoxVMId.Text);
        }

        private void ButtonDetachVolume_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.DetachVolume(TextBoxVolId.Text, TextBoxVMId.Text);
        }

        private void ButtonDeleteVolume_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.DeleteVolume(TextBoxVolId.Text);
        }

        private void ButtonListTemplates_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListTemplates("executable");
        }

        private void ButtonListAsyncJobs_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListAsyncJobs();
        }

        private void ButtonQueryAsyncJob_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.QueryAsyncJobResult(this.TextBoxAsyncJob.Text);
        }

        private void ButtonListDiskOfferings_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListDiskOfferings();
        }

        private void ButtonListNetworks_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListNetworks();
        }

        private void ButtonListVolumes_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListVolumes();
        }

        private void ButtonListZones_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests(this.WriteToLogBox);
            tests.ListZones();
        }  
    }
}
