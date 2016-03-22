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
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ButtonDetachVolume = new System.Windows.Forms.Button();
            this.ButtonListSecurityGroups = new System.Windows.Forms.Button();
            this.ButtonCreateSecurityGroup = new System.Windows.Forms.Button();
            this.TextBoxVMId = new System.Windows.Forms.TextBox();
            this.TextBoxVolId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonDeleteVolume = new System.Windows.Forms.Button();
            this.ButtonListVolumes = new System.Windows.Forms.Button();
            this.ButtonListVirtualMachines = new System.Windows.Forms.Button();
            this.ButtonAttachVolume = new System.Windows.Forms.Button();
            this.ButtonListAsyncJobs = new System.Windows.Forms.Button();
            this.ButtonQueryAsyncJob = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxAsyncJob = new System.Windows.Forms.TextBox();
            this.ButtonListDiskOfferings = new System.Windows.Forms.Button();
            this.ButtonCreateVolume = new System.Windows.Forms.Button();
            this.ButtonListZones = new System.Windows.Forms.Button();
            this.ButtonForceStopVM = new System.Windows.Forms.Button();
            this.ButtonCleanStopVM = new System.Windows.Forms.Button();
            this.ButtonStartVM = new System.Windows.Forms.Button();
            this.ButtonListNetworks = new System.Windows.Forms.Button();
            this.ButtonListServiceOfferings = new System.Windows.Forms.Button();
            this.ButtonListNetworkOfferings = new System.Windows.Forms.Button();
            this.ButtonListTemplates = new System.Windows.Forms.Button();
            this.ButtonClearLog = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxTemplateId = new System.Windows.Forms.TextBox();
            this.TextBoxZoneId = new System.Windows.Forms.TextBox();
            this.TextBoxSubnet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxServiceOffering = new System.Windows.Forms.TextBox();
            this.ButtonDeployVM = new System.Windows.Forms.Button();
            this.checkBoxDeployStopped = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServiceUrl = new System.Windows.Forms.TextBox();
            this.ApiKey = new System.Windows.Forms.TextBox();
            this.SecretKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loggingText = new System.Windows.Forms.RichTextBox();
            this.ButtonListDomains = new System.Windows.Forms.Button();
            this.ButtonCreateDomain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ButtonCreateDomain);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListDomains);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonDetachVolume);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListSecurityGroups);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonCreateSecurityGroup);
            this.splitContainer1.Panel1.Controls.Add(this.TextBoxVMId);
            this.splitContainer1.Panel1.Controls.Add(this.TextBoxVolId);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonDeleteVolume);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListVolumes);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListVirtualMachines);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonAttachVolume);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListAsyncJobs);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonQueryAsyncJob);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.TextBoxAsyncJob);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListDiskOfferings);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonCreateVolume);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListZones);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonForceStopVM);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonCleanStopVM);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonStartVM);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListNetworks);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListServiceOfferings);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListNetworkOfferings);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonListTemplates);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonClearLog);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 360;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.loggingText);
            this.splitContainer1.Size = new System.Drawing.Size(1091, 647);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 23;
            // 
            // ButtonDetachVolume
            // 
            this.ButtonDetachVolume.Location = new System.Drawing.Point(496, 87);
            this.ButtonDetachVolume.Name = "ButtonDetachVolume";
            this.ButtonDetachVolume.Size = new System.Drawing.Size(119, 23);
            this.ButtonDetachVolume.TabIndex = 48;
            this.ButtonDetachVolume.Text = "Detach Volume";
            this.ButtonDetachVolume.UseVisualStyleBackColor = true;
            this.ButtonDetachVolume.Click += new System.EventHandler(this.ButtonDetachVolume_Click);
            // 
            // ButtonListSecurityGroups
            // 
            this.ButtonListSecurityGroups.Location = new System.Drawing.Point(803, 177);
            this.ButtonListSecurityGroups.Name = "ButtonListSecurityGroups";
            this.ButtonListSecurityGroups.Size = new System.Drawing.Size(119, 23);
            this.ButtonListSecurityGroups.TabIndex = 47;
            this.ButtonListSecurityGroups.Text = "List Security Groups";
            this.ButtonListSecurityGroups.UseVisualStyleBackColor = true;
            this.ButtonListSecurityGroups.Click += new System.EventHandler(this.ButtonListSecurityGroups_Click);
            // 
            // ButtonCreateSecurityGroup
            // 
            this.ButtonCreateSecurityGroup.Location = new System.Drawing.Point(492, 277);
            this.ButtonCreateSecurityGroup.Name = "ButtonCreateSecurityGroup";
            this.ButtonCreateSecurityGroup.Size = new System.Drawing.Size(119, 23);
            this.ButtonCreateSecurityGroup.TabIndex = 46;
            this.ButtonCreateSecurityGroup.Text = "Create Security Group";
            this.ButtonCreateSecurityGroup.UseVisualStyleBackColor = true;
            this.ButtonCreateSecurityGroup.Click += new System.EventHandler(this.ButtonCreateSecurityGroup_Click);
            // 
            // TextBoxVMId
            // 
            this.TextBoxVMId.Location = new System.Drawing.Point(672, 221);
            this.TextBoxVMId.Name = "TextBoxVMId";
            this.TextBoxVMId.Size = new System.Drawing.Size(114, 20);
            this.TextBoxVMId.TabIndex = 44;
            // 
            // TextBoxVolId
            // 
            this.TextBoxVolId.Location = new System.Drawing.Point(672, 57);
            this.TextBoxVolId.Name = "TextBoxVolId";
            this.TextBoxVolId.Size = new System.Drawing.Size(114, 20);
            this.TextBoxVolId.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(617, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "VM Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Vol Id";
            // 
            // ButtonDeleteVolume
            // 
            this.ButtonDeleteVolume.Location = new System.Drawing.Point(496, 117);
            this.ButtonDeleteVolume.Name = "ButtonDeleteVolume";
            this.ButtonDeleteVolume.Size = new System.Drawing.Size(119, 23);
            this.ButtonDeleteVolume.TabIndex = 41;
            this.ButtonDeleteVolume.Text = "Delete Volume";
            this.ButtonDeleteVolume.UseVisualStyleBackColor = true;
            this.ButtonDeleteVolume.Click += new System.EventHandler(this.ButtonDeleteVolume_Click);
            // 
            // ButtonListVolumes
            // 
            this.ButtonListVolumes.Location = new System.Drawing.Point(803, 297);
            this.ButtonListVolumes.Name = "ButtonListVolumes";
            this.ButtonListVolumes.Size = new System.Drawing.Size(119, 23);
            this.ButtonListVolumes.TabIndex = 40;
            this.ButtonListVolumes.Text = "List Volumes";
            this.ButtonListVolumes.UseVisualStyleBackColor = true;
            this.ButtonListVolumes.Click += new System.EventHandler(this.ButtonListVolumes_Click);
            // 
            // ButtonListVirtualMachines
            // 
            this.ButtonListVirtualMachines.Location = new System.Drawing.Point(803, 267);
            this.ButtonListVirtualMachines.Name = "ButtonListVirtualMachines";
            this.ButtonListVirtualMachines.Size = new System.Drawing.Size(119, 23);
            this.ButtonListVirtualMachines.TabIndex = 39;
            this.ButtonListVirtualMachines.Text = "List Virtual Machines";
            this.ButtonListVirtualMachines.UseVisualStyleBackColor = true;
            this.ButtonListVirtualMachines.Click += new System.EventHandler(this.ButtonListVirtualMachines_Click);
            // 
            // ButtonAttachVolume
            // 
            this.ButtonAttachVolume.Location = new System.Drawing.Point(496, 58);
            this.ButtonAttachVolume.Name = "ButtonAttachVolume";
            this.ButtonAttachVolume.Size = new System.Drawing.Size(119, 23);
            this.ButtonAttachVolume.TabIndex = 38;
            this.ButtonAttachVolume.Text = "Attach Volume";
            this.ButtonAttachVolume.UseVisualStyleBackColor = true;
            this.ButtonAttachVolume.Click += new System.EventHandler(this.ButtonAttachVolume_Click);
            // 
            // ButtonListAsyncJobs
            // 
            this.ButtonListAsyncJobs.Location = new System.Drawing.Point(803, 27);
            this.ButtonListAsyncJobs.Name = "ButtonListAsyncJobs";
            this.ButtonListAsyncJobs.Size = new System.Drawing.Size(119, 23);
            this.ButtonListAsyncJobs.TabIndex = 37;
            this.ButtonListAsyncJobs.Text = "List Async Jobs";
            this.ButtonListAsyncJobs.UseVisualStyleBackColor = true;
            this.ButtonListAsyncJobs.Click += new System.EventHandler(this.ButtonListAsyncJobs_Click);
            // 
            // ButtonQueryAsyncJob
            // 
            this.ButtonQueryAsyncJob.Location = new System.Drawing.Point(803, 57);
            this.ButtonQueryAsyncJob.Name = "ButtonQueryAsyncJob";
            this.ButtonQueryAsyncJob.Size = new System.Drawing.Size(119, 23);
            this.ButtonQueryAsyncJob.TabIndex = 36;
            this.ButtonQueryAsyncJob.Text = "Query Async Job";
            this.ButtonQueryAsyncJob.UseVisualStyleBackColor = true;
            this.ButtonQueryAsyncJob.Click += new System.EventHandler(this.ButtonQueryAsyncJob_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Job Id";
            // 
            // TextBoxAsyncJob
            // 
            this.TextBoxAsyncJob.Location = new System.Drawing.Point(672, 30);
            this.TextBoxAsyncJob.Name = "TextBoxAsyncJob";
            this.TextBoxAsyncJob.Size = new System.Drawing.Size(114, 20);
            this.TextBoxAsyncJob.TabIndex = 34;
            // 
            // ButtonListDiskOfferings
            // 
            this.ButtonListDiskOfferings.Location = new System.Drawing.Point(803, 87);
            this.ButtonListDiskOfferings.Name = "ButtonListDiskOfferings";
            this.ButtonListDiskOfferings.Size = new System.Drawing.Size(119, 23);
            this.ButtonListDiskOfferings.TabIndex = 33;
            this.ButtonListDiskOfferings.Text = "List DiskOfferings";
            this.ButtonListDiskOfferings.UseVisualStyleBackColor = true;
            this.ButtonListDiskOfferings.Click += new System.EventHandler(this.ButtonListDiskOfferings_Click);
            // 
            // ButtonCreateVolume
            // 
            this.ButtonCreateVolume.Location = new System.Drawing.Point(496, 27);
            this.ButtonCreateVolume.Name = "ButtonCreateVolume";
            this.ButtonCreateVolume.Size = new System.Drawing.Size(119, 23);
            this.ButtonCreateVolume.TabIndex = 32;
            this.ButtonCreateVolume.Text = "Create Volume";
            this.ButtonCreateVolume.UseVisualStyleBackColor = true;
            this.ButtonCreateVolume.Click += new System.EventHandler(this.ButtonCreateVolume_Click);
            // 
            // ButtonListZones
            // 
            this.ButtonListZones.Location = new System.Drawing.Point(803, 327);
            this.ButtonListZones.Name = "ButtonListZones";
            this.ButtonListZones.Size = new System.Drawing.Size(119, 23);
            this.ButtonListZones.TabIndex = 25;
            this.ButtonListZones.Text = "List Zones";
            this.ButtonListZones.UseVisualStyleBackColor = true;
            this.ButtonListZones.Click += new System.EventHandler(this.ButtonListZones_Click);
            // 
            // ButtonForceStopVM
            // 
            this.ButtonForceStopVM.Location = new System.Drawing.Point(492, 249);
            this.ButtonForceStopVM.Name = "ButtonForceStopVM";
            this.ButtonForceStopVM.Size = new System.Drawing.Size(119, 23);
            this.ButtonForceStopVM.TabIndex = 26;
            this.ButtonForceStopVM.Text = "Force Stop VM";
            this.ButtonForceStopVM.UseVisualStyleBackColor = true;
            this.ButtonForceStopVM.Click += new System.EventHandler(this.ButtonForceStopVM_Click);
            // 
            // ButtonCleanStopVM
            // 
            this.ButtonCleanStopVM.Location = new System.Drawing.Point(492, 221);
            this.ButtonCleanStopVM.Name = "ButtonCleanStopVM";
            this.ButtonCleanStopVM.Size = new System.Drawing.Size(119, 23);
            this.ButtonCleanStopVM.TabIndex = 24;
            this.ButtonCleanStopVM.Text = "Clean Stop VM";
            this.ButtonCleanStopVM.UseVisualStyleBackColor = true;
            this.ButtonCleanStopVM.Click += new System.EventHandler(this.ButtonCleanStopVM_Click);
            // 
            // ButtonStartVM
            // 
            this.ButtonStartVM.Location = new System.Drawing.Point(492, 193);
            this.ButtonStartVM.Name = "ButtonStartVM";
            this.ButtonStartVM.Size = new System.Drawing.Size(119, 23);
            this.ButtonStartVM.TabIndex = 27;
            this.ButtonStartVM.Text = "Start Virtual Machine";
            this.ButtonStartVM.UseVisualStyleBackColor = true;
            this.ButtonStartVM.Click += new System.EventHandler(this.ButtonStartVM_Click);
            // 
            // ButtonListNetworks
            // 
            this.ButtonListNetworks.Location = new System.Drawing.Point(803, 117);
            this.ButtonListNetworks.Name = "ButtonListNetworks";
            this.ButtonListNetworks.Size = new System.Drawing.Size(119, 23);
            this.ButtonListNetworks.TabIndex = 30;
            this.ButtonListNetworks.Text = "List Networks";
            this.ButtonListNetworks.UseVisualStyleBackColor = true;
            this.ButtonListNetworks.Click += new System.EventHandler(this.ButtonListNetworks_Click);
            // 
            // ButtonListServiceOfferings
            // 
            this.ButtonListServiceOfferings.Location = new System.Drawing.Point(803, 207);
            this.ButtonListServiceOfferings.Name = "ButtonListServiceOfferings";
            this.ButtonListServiceOfferings.Size = new System.Drawing.Size(119, 23);
            this.ButtonListServiceOfferings.TabIndex = 31;
            this.ButtonListServiceOfferings.Text = "ListServiceOfferings";
            this.ButtonListServiceOfferings.UseVisualStyleBackColor = true;
            this.ButtonListServiceOfferings.Click += new System.EventHandler(this.ButtonListServiceOfferings_Click);
            // 
            // ButtonListNetworkOfferings
            // 
            this.ButtonListNetworkOfferings.Location = new System.Drawing.Point(803, 147);
            this.ButtonListNetworkOfferings.Name = "ButtonListNetworkOfferings";
            this.ButtonListNetworkOfferings.Size = new System.Drawing.Size(119, 23);
            this.ButtonListNetworkOfferings.TabIndex = 28;
            this.ButtonListNetworkOfferings.Text = "List Network Offerings";
            this.ButtonListNetworkOfferings.UseVisualStyleBackColor = true;
            this.ButtonListNetworkOfferings.Click += new System.EventHandler(this.ButtonListNetworkOfferings_Click);
            // 
            // ButtonListTemplates
            // 
            this.ButtonListTemplates.Location = new System.Drawing.Point(803, 237);
            this.ButtonListTemplates.Name = "ButtonListTemplates";
            this.ButtonListTemplates.Size = new System.Drawing.Size(119, 23);
            this.ButtonListTemplates.TabIndex = 29;
            this.ButtonListTemplates.Text = "List Templates";
            this.ButtonListTemplates.UseVisualStyleBackColor = true;
            this.ButtonListTemplates.Click += new System.EventHandler(this.ButtonListTemplates_Click);
            // 
            // ButtonClearLog
            // 
            this.ButtonClearLog.Location = new System.Drawing.Point(9, 327);
            this.ButtonClearLog.Name = "ButtonClearLog";
            this.ButtonClearLog.Size = new System.Drawing.Size(119, 23);
            this.ButtonClearLog.TabIndex = 21;
            this.ButtonClearLog.Text = "Clear Log";
            this.ButtonClearLog.UseVisualStyleBackColor = true;
            this.ButtonClearLog.Click += new System.EventHandler(this.ButtonClearLog_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.45953F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.54047F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxTemplateId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxZoneId, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxSubnet, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxServiceOffering, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.ButtonDeployVM, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxDeployStopped, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 129);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 143);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "TemplateId";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ZoneId";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Network";
            // 
            // TextBoxTemplateId
            // 
            this.TextBoxTemplateId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTemplateId.Location = new System.Drawing.Point(111, 3);
            this.TextBoxTemplateId.Name = "TextBoxTemplateId";
            this.TextBoxTemplateId.Size = new System.Drawing.Size(269, 20);
            this.TextBoxTemplateId.TabIndex = 3;
            // 
            // TextBoxZoneId
            // 
            this.TextBoxZoneId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxZoneId.Location = new System.Drawing.Point(111, 29);
            this.TextBoxZoneId.Name = "TextBoxZoneId";
            this.TextBoxZoneId.Size = new System.Drawing.Size(269, 20);
            this.TextBoxZoneId.TabIndex = 3;
            // 
            // TextBoxSubnet
            // 
            this.TextBoxSubnet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSubnet.Location = new System.Drawing.Point(111, 55);
            this.TextBoxSubnet.Name = "TextBoxSubnet";
            this.TextBoxSubnet.Size = new System.Drawing.Size(269, 20);
            this.TextBoxSubnet.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "ServiceOffering";
            // 
            // TextBoxServiceOffering
            // 
            this.TextBoxServiceOffering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxServiceOffering.Location = new System.Drawing.Point(111, 82);
            this.TextBoxServiceOffering.Name = "TextBoxServiceOffering";
            this.TextBoxServiceOffering.Size = new System.Drawing.Size(269, 20);
            this.TextBoxServiceOffering.TabIndex = 3;
            // 
            // ButtonDeployVM
            // 
            this.ButtonDeployVM.Location = new System.Drawing.Point(111, 109);
            this.ButtonDeployVM.Name = "ButtonDeployVM";
            this.ButtonDeployVM.Size = new System.Drawing.Size(119, 23);
            this.ButtonDeployVM.TabIndex = 15;
            this.ButtonDeployVM.Text = "deployVirtualMachine";
            this.ButtonDeployVM.UseVisualStyleBackColor = true;
            this.ButtonDeployVM.Click += new System.EventHandler(this.ButtonDeployVM_Click);
            // 
            // checkBoxDeployStopped
            // 
            this.checkBoxDeployStopped.AutoSize = true;
            this.checkBoxDeployStopped.Location = new System.Drawing.Point(3, 109);
            this.checkBoxDeployStopped.Name = "checkBoxDeployStopped";
            this.checkBoxDeployStopped.Size = new System.Drawing.Size(99, 17);
            this.checkBoxDeployStopped.TabIndex = 48;
            this.checkBoxDeployStopped.Text = "DeployStopped";
            this.checkBoxDeployStopped.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.70588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.29412F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ServiceUrl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ApiKey, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SecretKey, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 82);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service URL";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Secret Key";
            // 
            // ServiceUrl
            // 
            this.ServiceUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceUrl.Location = new System.Drawing.Point(78, 3);
            this.ServiceUrl.Name = "ServiceUrl";
            this.ServiceUrl.Size = new System.Drawing.Size(302, 20);
            this.ServiceUrl.TabIndex = 3;
            // 
            // ApiKey
            // 
            this.ApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiKey.Location = new System.Drawing.Point(78, 30);
            this.ApiKey.Name = "ApiKey";
            this.ApiKey.Size = new System.Drawing.Size(302, 20);
            this.ApiKey.TabIndex = 3;
            // 
            // SecretKey
            // 
            this.SecretKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SecretKey.Location = new System.Drawing.Point(78, 58);
            this.SecretKey.Name = "SecretKey";
            this.SecretKey.Size = new System.Drawing.Size(302, 20);
            this.SecretKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "API Key";
            // 
            // loggingText
            // 
            this.loggingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loggingText.Location = new System.Drawing.Point(0, 0);
            this.loggingText.Name = "loggingText";
            this.loggingText.Size = new System.Drawing.Size(1091, 247);
            this.loggingText.TabIndex = 23;
            this.loggingText.Text = "";
            // 
            // ButtonListDomains
            // 
            this.ButtonListDomains.Location = new System.Drawing.Point(803, 356);
            this.ButtonListDomains.Name = "ButtonListDomains";
            this.ButtonListDomains.Size = new System.Drawing.Size(119, 23);
            this.ButtonListDomains.TabIndex = 49;
            this.ButtonListDomains.Text = "List Domains";
            this.ButtonListDomains.UseVisualStyleBackColor = true;
            this.ButtonListDomains.Click += new System.EventHandler(this.ButtonListDomains_Click);
            // 
            // ButtonCreateDomain
            // 
            this.ButtonCreateDomain.Location = new System.Drawing.Point(928, 356);
            this.ButtonCreateDomain.Name = "ButtonCreateDomain";
            this.ButtonCreateDomain.Size = new System.Drawing.Size(119, 23);
            this.ButtonCreateDomain.TabIndex = 50;
            this.ButtonCreateDomain.Text = "Create Domain";
            this.ButtonCreateDomain.UseVisualStyleBackColor = true;
            this.ButtonCreateDomain.Click += new System.EventHandler(this.ButtonCreateDomain_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 647);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindow";
            this.Text = "CloudStack SDK Test";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox loggingText;
        private System.Windows.Forms.Button ButtonListSecurityGroups;
        private System.Windows.Forms.Button ButtonCreateSecurityGroup;
        private System.Windows.Forms.TextBox TextBoxVMId;
        private System.Windows.Forms.TextBox TextBoxVolId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonDeleteVolume;
        private System.Windows.Forms.Button ButtonListVolumes;
        private System.Windows.Forms.Button ButtonListVirtualMachines;
        private System.Windows.Forms.Button ButtonAttachVolume;
        private System.Windows.Forms.Button ButtonListAsyncJobs;
        private System.Windows.Forms.Button ButtonQueryAsyncJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxAsyncJob;
        private System.Windows.Forms.Button ButtonListDiskOfferings;
        private System.Windows.Forms.Button ButtonCreateVolume;
        private System.Windows.Forms.Button ButtonListZones;
        private System.Windows.Forms.Button ButtonForceStopVM;
        private System.Windows.Forms.Button ButtonCleanStopVM;
        private System.Windows.Forms.Button ButtonStartVM;
        private System.Windows.Forms.Button ButtonListNetworks;
        private System.Windows.Forms.Button ButtonListServiceOfferings;
        private System.Windows.Forms.Button ButtonListNetworkOfferings;
        private System.Windows.Forms.Button ButtonListTemplates;
        private System.Windows.Forms.Button ButtonClearLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxTemplateId;
        private System.Windows.Forms.TextBox TextBoxZoneId;
        private System.Windows.Forms.TextBox TextBoxSubnet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxServiceOffering;
        private System.Windows.Forms.Button ButtonDeployVM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServiceUrl;
        private System.Windows.Forms.TextBox ApiKey;
        private System.Windows.Forms.TextBox SecretKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDeployStopped;
        private System.Windows.Forms.Button ButtonDetachVolume;
		private System.Windows.Forms.Button ButtonListDomains;
        private System.Windows.Forms.Button ButtonCreateDomain;
    }
}

